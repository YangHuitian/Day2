using System;

namespace ConsoleApplication2
{
    class Program1
    {
        public static void Main()
        {
            System.Console.WriteLine(111);//111
            System.Console.WriteLine(222);//222

            System.Console.Write(333);
            System.Console.WriteLine(444);//333444

            System.Console.WriteLine(555 + 666 + 777);//1998

            System.Console.WriteLine("555" + "666" + "777");//555666777

            System.Console.WriteLine("c");//c

            int a = 5;
            Console.WriteLine(a);//5

            Console.WriteLine("The duck says \"GaGa\"");//The duck says "GaGa"

            Console.WriteLine(" \"\"\" ");///"""

            Console.WriteLine("*\n**\n***");
            //*
            //**
            //***

            Console.WriteLine("Name \t Age");
            Console.WriteLine("John \t 21");
            Console.WriteLine("Jannie \t 22");
            Console.WriteLine("Jay \t 38");

            int b = 10;
            Console.WriteLine(a + " * " + b + " = " + (a * b));
            //5 * 10 = 50, remember a&b are declared before

            int c = 2;
            Console.WriteLine(a + " ^ " + c + " = " + (a ^ c));
            //5 ^ 2 = 25, remember a&b are declared before

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b );//5 + 10 = 15


            double d = 71.5678;
            Console.WriteLine("He weighs {0:0.000} kg", d);//He weighs 71.568 kg
            double e = 12343456.789;
            Console.WriteLine("${0:#.##}", e);//12343456.79
        }
    }
}
