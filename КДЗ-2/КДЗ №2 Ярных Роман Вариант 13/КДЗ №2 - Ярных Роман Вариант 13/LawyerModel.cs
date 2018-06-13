using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Reflection;

namespace CHW_2_Yarnykh_Roman_V13
{
    enum FileSavingOptions { Rewrite, AddToEnd}
    class LawyerModel : Singleton<LawyerModel>
    {
        private string header_;
        private string path_;
        private List<Lawyer> lawyer_list_;
        private const int COLUMNS_LEN = 18;
        private LawyerModel() { }
        /// <summary>
        /// Инициализация БД
        /// </summary>
        /// <param name="path"></param>
        public void InitDB(string path)
        {
            if (!File.Exists(path))
                throw new IOException(String.Format("Файл {0} не найден", path));
            path_ = path;
            lawyer_list_ = new List<Lawyer>();
        }
        /// <summary>
        /// Чтение полей БД
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        
        public IEnumerable<Lawyer> ReadDB(int? n)
        {
            string[] lines = File.ReadAllLines(path_);
            header_ = lines[0];
            int k = 0;
            string line = "";
            int len = 0;
            bool context_ = false;
            for (int i = 1; i < lines.Length && k < n; i++)
			{
                lines[i].Trim('\n', ' ');
                Array.ForEach(lines[i].ToArray(), x =>
                {
                    context_ ^= x == '\"';
                    if (!context_ && x == ',')
                        len++;
                });
                line += lines[i];
                if (len == COLUMNS_LEN)
                {
                    len = 0;
                    yield return TryParse(line);
                    line = "";
                    k++;
                }
			}
        }
        /// <summary>
        /// Запись данных БД в файл
        /// </summary>
        /// <param name="lawyers"></param>
        /// <param name="path"></param>
        public void WriteDBToFile(IEnumerable<Lawyer> lawyers, string path, FileSavingOptions options)
        {
            using (FileStream fileStream = new FileStream(path ?? path_, options == FileSavingOptions.Rewrite ? FileMode.Create : FileMode.Append))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine(header_);
                    foreach (var lawyer in lawyers)
                    {
                        string line = "";
                        int k = 0;
                        foreach (PropertyInfo property in typeof(Lawyer).GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(x => x.PropertyType == typeof(string)))
                        {
                            string property_value = (string)property.GetValue(lawyer, null);
                            if (property_value.Contains(',') || property_value.Contains('"'))
                                line += String.Format("\"{0}\"", property_value);
                            else line += property_value;
                            if (++k < COLUMNS_LEN)
                                line += ",";
                        }
                        streamWriter.WriteLine(line);
                    }
                }
            }
        }
        private Lawyer TryParse(string line)
        {
            //if (line.Count(x => x == ',') != column_len)
              //  throw new ArgumentException("Файл поврежден! Строка с данными не соответствует формату!");
            Lawyer lawyer = new Lawyer();
            string[] columns_ = line.Split(',');
            lawyer.RegistryNumber = columns_[0];
            lawyer.LastName = columns_[1];
            lawyer.FirstName = columns_[2];
            lawyer.Patronym = columns_[3];
            lawyer.Requisite = new Requisite() { Assignment = columns_[4], AssignmentEntry = columns_[5], Suspension = columns_[6], SuspensionEntry = columns_[7], 
            Resumption = columns_[8], ResumptionEntry = columns_[9], CancelSuspension = columns_[10], CancelSuspensionEntry = columns_[11], ClearRecords = columns_[12],
            ClearRecordsEntry = columns_[13], Description = columns_[14], DescriptionEntry = columns_[15]
            };
            lawyer.Status = columns_[16];
            lawyer.Org = columns_[17];
            lawyer.Cab = columns_[18];
            return lawyer;
        }
    }
}
