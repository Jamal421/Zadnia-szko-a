﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Number 1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Number 2 : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            while (n1 != n2)
            {
                if (n1 > n2)
                    n1 -= n2;
                else
                    n2 -= n1;
            }
            Console.WriteLine("greatest common divisor is " + n1);
            Console.ReadKey();
        }
    }
}
