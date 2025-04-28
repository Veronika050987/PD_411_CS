using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAndStringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите Ваше имя:");
            string firs_name = "Michael";   //Console.ReadLine();

            //Console.Write("Введите Вашу фамилию:");
            string last_name = "Stanne";    //Console.ReadLine();

            //Console.Write("Ваш возраст: ");
            int age = 32;   //Convert.ToInt32(Console.ReadLine());

            //Console.Write(firs_name);
            //Console.Write(last_name);
            //Console.Write(age);

            Console.WriteLine(firs_name + " " + last_name + " " + age);   //конкатенация строк
            Console.WriteLine(string.Format("{0} {1} {2}", firs_name, last_name, age)); //Форматирование строк
            Console.WriteLine($"{firs_name} {last_name} {age}");    //Интерполяция строк

            Console.WriteLine();    //cout << endl;
        }
    }
}
