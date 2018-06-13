using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
using System.IO;

namespace CSVliteDB
{
    public class Lawyer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronym { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
    internal abstract class Singleton<T> where T : class
    {
        private Singleton() { }
        private class SingletonFactory<S> where S : class
        {
            private static readonly S instance_ = (S)typeof(S).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], new ParameterModifier[0]).Invoke(new object[0]);
            public static S GetInstance()
            {
                return instance_;
            }
            public static T Instance
            {
                get { return SingletonFactory<T>.GetInstance(); }
            }
        }
    }
    public class LawyerDB : Singleton<LawyerDB>, INotifyPropertyChanged
    {
        private string db_path_;
        public void OpenDB(string path)
        {
            if (!File.Exists(path))
                throw new IOException(String.Format("Файл {0} не найден", path));
            db_path_ = path;
        }
        private List<Lawyer> TryParseFile()
        {
            List<Lawyer> lawyers_ = new List<Lawyer>();
            return lawyers_;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
