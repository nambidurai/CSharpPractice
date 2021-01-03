using System;
using System.Runtime.InteropServices;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // premitive datatype
            // value datatype
            // value datatype stored in stack - first in last out
            int i = 10;
            // value is copied
            int j = i;
            j = 30;
            Console.WriteLine("i = " + i + " j = " + j);

            // custom data type
            // referance data type
            // rederance data type pointer is stored in stack and data is stored in heap
            MyDataType obj1 = new MyDataType();
            MyDataType obj2 = new MyDataType();
            obj1.str = "Car";
            // address is copied
            obj2 = obj1;
            obj1.str = "MyCar";
            Console.WriteLine("object1 str = " + obj1.str);
            Console.WriteLine("object2 str = " + obj2.str);
        }

        public static IntPtr Get(object a)
        {
            GCHandle handle = GCHandle.Alloc(a,GCHandleType.Weak);
            try
            {
                IntPtr pointer = GCHandle.ToIntPtr(handle);
                return pointer;
            }
            finally
            {
                handle.Free();
            }
        }
    }

    class MyDataType
    {
        public string str = "custom datatype";
    }

}
