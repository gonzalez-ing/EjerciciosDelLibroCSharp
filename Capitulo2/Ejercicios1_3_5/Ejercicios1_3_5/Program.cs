﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1_3_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a, r;
            Console.WriteLine("Dijite la cantidad en dolares: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dijite el precio del cambio: ");
            a = double.Parse(Console.ReadLine());
            r = n * a;
            Console.WriteLine("El resultados en euro es : " + r);
            Console.ReadLine();
        }
    }
}
