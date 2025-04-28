using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DataTypes");
            Console.WriteLine(typeof(sbyte));
            Console.WriteLine(sizeof(byte));
            Console.WriteLine($"Byte:  {byte.MinValue} ... {byte.MaxValue}");
            Console.WriteLine($"SByte:{sbyte.MinValue}... {sbyte.MaxValue}");
        }
    }
}
