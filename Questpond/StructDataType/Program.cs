using System;

namespace StructDataType
{
    // struct is composite value data type
    struct Coordinates
    {
        public int x, y, z;
        public void MoveBy10()
        {
            x = x + 10;
            y = y + 10;
            z = z + 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates xyz = new Coordinates();
            xyz.x = 10;
            xyz.y = 10;
            xyz.z = 10;
            Coordinates x1y1z1 = new Coordinates();
            // value is copied
            x1y1z1 = xyz;
            xyz.MoveBy10();
            Console.WriteLine(xyz.x);
            Console.WriteLine(xyz.y);
            Console.WriteLine(xyz.z);

            Console.WriteLine(x1y1z1.x);
            Console.WriteLine(x1y1z1.y);
            Console.WriteLine(x1y1z1.z);
        }
    }
}
