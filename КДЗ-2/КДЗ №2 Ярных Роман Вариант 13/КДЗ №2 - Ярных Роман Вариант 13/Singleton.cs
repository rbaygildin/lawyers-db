using System;
using System.Reflection;

namespace CHW_2_Yarnykh_Roman_V13
{
    /// <summary>
    /// Базовый класс, предоставляющий своим потомкам поведение объекта-одиночки
    /// </summary>
    /// <typeparam name="T"></typeparam>
    abstract class Singleton<T> where T : class
    {
        private class SingletonFactory<S> where S : class
        {
            private static readonly S instance_ = (S)typeof(S).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], new ParameterModifier[0]).Invoke(new object[0]);
            public static S GetInstance()
            {
                return instance_;
            }
        }
        protected Singleton() { }
        public static T Instance
        {
            get { return SingletonFactory<T>.GetInstance(); }
        }
    }
}
