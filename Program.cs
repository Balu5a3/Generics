using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyGeneric<T>
    {
        public T[] list;

        public MyGeneric(int size)
        {
            list = new T[size];
        }

        public T getItem(int index)
        {
            return list[index];
        }

        public void setItem(int index, T value)
        {
            list[index] = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> IntBalu = new MyGeneric<int>(5);
            IntBalu.setItem(4, 1);
            int a = IntBalu.getItem(4);
            MyGeneric<string> StringBalu = new MyGeneric<string>(5);
        }
    }
}
