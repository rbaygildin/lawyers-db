using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CHW_2_Yarnykh_Roman_V13
{
    public partial class MainWindow : Form
    {
        private List<Lawyer> lawyers_;
        private string path_;
        public MainWindow()
        {
            InitializeComponent();
            lawyers_ = new List<Lawyer>();
            datagridLawyersList.AutoSize = true;
            datagridLawyersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void menubuttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "CSV файлы (*.csv)|*.csv" };
                if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                path_ = openFileDialog.FileName;
                LawyerModel.Instance.InitDB(path_);
                buttonShow.Enabled = true;
                buttonFilter.Enabled = true;
                buttonSort.Enabled = true;
                datagridLawyersList.Rows.Clear();
            }
            catch(IOException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка при открытии файла!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка при обработки файла!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(IndexOutOfRangeException exception){
                MessageBox.Show(exception.Message, "Ошибка при обработки файла!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int line_number;
            lawyers_ = LawyerModel.Instance.ReadDB(Int32.TryParse(textboxLineNumber.Text, out line_number) ? (int?)line_number : null).ToList();
            datagridLawyersList.DataSource = new BindingSource() {DataSource = lawyers_};
            datagridLawyersList.AutoResizeColumns();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            datagridLawyersList.DataSource = new BindingSource() {DataSource = (lawyers_ = lawyers_.Where(lawyer => !String.IsNullOrEmpty(comboboxFilterKey.SelectedIndex == 0 ? lawyer.Suspension : lawyer.Resumption)).ToList())};
            datagridLawyersList.AutoResizeColumns();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (!checkboxFirstNameSortKey.Checked && !checkboxLastNameSortKey.Checked)
                return;
            datagridLawyersList.DataSource = new BindingSource()
            {
                DataSource = (lawyers_ = lawyers_.OrderBy<Lawyer, string>(lawyer => {
                    if (checkboxFirstNameSortKey.Checked && !checkboxLastNameSortKey.Checked)
                        return lawyer.FirstName;
                    else if (checkboxLastNameSortKey.Checked && !checkboxFirstNameSortKey.Checked)
                        return lawyer.LastName;
                    return lawyer.LastName + " " + lawyer.FirstName;

                }).ToList())
            };
            datagridLawyersList.AutoResizeColumns();
        }

        private void menubuttonSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                string path_;
                SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV файлы (*.csv)|*.csv", OverwritePrompt = false};
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path_ = saveFileDialog.FileName;
                    LawyerModel.Instance.WriteDBToFile(lawyers_, path_, FileSavingOptions.Rewrite);
                }
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void menubuttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                LawyerModel.Instance.WriteDBToFile(lawyers_, null, FileSavingOptions.Rewrite);
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void menubuttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("©\"Реестр адвокатов\" - программа для чтения, обработки и сохранения данных об адвокатах.\nРазработка: студент 101ПИ ФКН НИУ ВШЭ Ярных Роман."));
        }
    }
}
