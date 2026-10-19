using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class Container<T>
    {

        #region answer Q2
        private T? item;

        public void Add(T value)
        {
            item = value;
        }

        public T Get()
        {
            return item!;
        }
        #endregion

    }
}
