using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Привет Мир!!!");
            Console.Title = "Introduction to .NET";
            Console.Title = "Введение в платформу .NET";

            //Console.WindowWidth = 80;
            //Console.WindowHeight = 16;
            Console.SetWindowSize(80, 16);

            //Console.CursorTop = 8;
            //Console.CursorLeft = 16;
            Console.SetCursorPosition(16, 8);


            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Position");
            Console.ResetColor();
            //Console.Clear();
        }
    }
}
