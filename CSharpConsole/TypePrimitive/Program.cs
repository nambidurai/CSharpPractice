using System;

namespace TypePrimitive
{
    class Program
    {
        static void Main(string[] args)
        {
             // natural or whole numbers - postive numbers including 0 used for counting, eg. 23
            uint natualNumber = 23;
            // negative numbers or integers including 0, eg. -23
            int integerNumber = -23;
            // real numbers or single precision floating point numbers, eg. 3.9
            float realNumber = 2.3F;
            // real numbers or double precision floating point numbers, eg. 3.9
            double anotherRealNumber = 2.3;

            // the three variables below stores 2 million
            // _ used for code readability
            // decimal - base 10 system (0 to 9)
            int decimalNotation = 2_000_000;
            // binary - base 2 system (0 and 1), prefix with 0b
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            // hexadecimal - base 16 system (0 to 9 and A to F), prefix with 0x
            int hexadecimalNotation =0x_001E_8480;
            Console.WriteLine(decimalNotation==binaryNotation);
            Console.WriteLine(decimalNotation==hexadecimalNotation);

            Console.WriteLine("size of integer " + sizeof(int));
            // double is 8 bit but stores bigger number than 16 bit decimal
            Console.WriteLine("size of double " + sizeof(double));
            Console.WriteLine("size of decimal " + sizeof(decimal));

            //comparing double types - double are not gaurranteed to be accurate
             double doubleA = 0.1;
             double doubleB = 0.2;

             if (doubleA + doubleB == 0.3)
             {
                 Console.WriteLine($"{doubleA} + {doubleB} equals 0.3");
             } 
             else 
             {
                 Console.WriteLine($"{doubleA} + {doubleB} dose not equals 0.3");
             }

            //comparing decimal types - double are not gaurranteed to be accurate
             decimal decimalA = 0.1M;
             decimal decimalB = 0.2M;

             if (decimalA + decimalB == 0.3M)
             {
                 Console.WriteLine($"{decimalA} + {decimalB} equals 0.3");
             } 
             else 
             {
                 Console.WriteLine($"{decimalA} + {decimalB} dose not equals 0.3");
             }
        }
    }
}
