/* 
    Data types
        1. Value types - Enum, Struct amd Nullable types 
        2. Reference types - Class, Interface, Arrays and Delegate

    There are several primitive or simple pre-defined data types which are value or reference types
        1. Value types - byte, short, int, long, float, double and decimal 
        2. Reference types - string and object
    
    Value genrally have literal (fixed) values 
 
 */


using System;

namespace TypePrimitive
{
    class Program
    {
        static void Main(string[] args)
        {
            // natural or whole numbers - postive numbers including 0 used for counting, eg. 23
            uint naturalNumber = 23;
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

            // summary
            Console.WriteLine($"{"Alias",-12}{".NET Type",-20}{"Bits",-12}{"Default",-12}{"Max."}");
            // natural numbers, unsigned integers, struct
            Console.WriteLine();
            Console.WriteLine($"{"byte",-12}{typeof(byte),-20}{sizeof(byte)*8,-12}{default(byte),-12}{byte.MaxValue}");
            Console.WriteLine($"{"ushort",-12}{typeof(ushort),-20}{sizeof(ushort)*8,-12}{default (ushort),-12}{ushort.MaxValue:N0}");
            Console.WriteLine($"{"uint",-12}{typeof(uint),-20}{sizeof(uint)*8,-12}{default(uint),-12}{uint.MaxValue:N0}");
            Console.WriteLine($"{"ulong",-12}{typeof(ulong),-20}{sizeof(ulong)*8,-12}{default(ulong),-12}{ulong.MaxValue:N0}");
            // negative numbers, signed integers, struct
            Console.WriteLine("");
            Console.WriteLine($"{"sbyte",-12}{typeof(sbyte),-20}{sizeof(byte)*8,-12}{default(sbyte),-12}{sbyte.MaxValue}");
            Console.WriteLine($"{"short",-12}{typeof(short),-20}{sizeof(ushort)*8,-12}{default(short),-12}{short.MaxValue:N0}");
            Console.WriteLine($"{"int",-12}{typeof(int),-20}{sizeof(uint)*8,-12}{default(int),-12}{int.MaxValue:N0}");
            Console.WriteLine($"{"long",-12}{typeof(long),-20}{sizeof(ulong)*8,-12}{default(long),-12}{long.MaxValue:N0}");
            // IEEE 754-2008 Standard for Floating-Point Arithmetic
            Console.WriteLine("");
            // Binary floating point number single-precision - fast, less accurate, eg: graphic libraries
            Console.WriteLine($"{"float",-12}{typeof(float),-20}{sizeof(float)*8,-12}{default(float),-12}{float.MaxValue:0.0e0}");
            // Binary floating point number double-precision - ok speed & accuracy, eg: engineering calculations where round of errors is acceptable
            Console.WriteLine($"{"double",-12}{typeof(double),-20}{sizeof(double)*8,-12}{default(double),-12}{double.MaxValue:0.0e0}");
            // Decimal floating point number - slow, accurate, eg: finance calculations 
            Console.WriteLine($"{"decimal",-12}{typeof(decimal),-20}{sizeof(decimal)*8,-12}{default(decimal),-12}{decimal.MaxValue:0.0e0}");
            Console.WriteLine("");
            // bool - logic true/false, struct
            Console.WriteLine($"{"bool",-12}{typeof(bool),-20}{sizeof(bool)*8,-12}{default(bool),-12}");
            // char - unicode character, struct
            Console.WriteLine($"{"char",-12}{typeof(char),-20}{sizeof(char)*8,-12}{" ",-12}{Convert.ToString(char.MaxValue,16)}");
            // datetime - represents date and time, struct
            Console.WriteLine($"{"DateTime",-12}{typeof(DateTime),-20}{" ",-12}{default(DateTime),-12:d}{DateTime.MaxValue:d}");
            Console.WriteLine("");
            // string - sequence of unicode characters, class
            Console.WriteLine($"{"string",-12}{typeof(string),-20}{" ",-12}{default(string),-12}{" "}");
            // base type of all other types, class
            Console.WriteLine($"{"object",-12}{typeof(object),-20}{" ",-12}{default(object),-12}{" "}");

        }
    }
}