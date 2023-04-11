﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ПУШКА\nВведите координаты пушки\nx = ");
            int x0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите начальную скорость снаряда\nV = ");
            int V0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите угол вылета снаряда из пушки в градусах\na = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите момент времени, в котором вы хотите узнать координаты снаряда\nt = ");
            int t = Convert.ToInt32(Console.ReadLine());
            double Vx0 = V0 * Math.Cos((a * Math.PI) / 180);
            double Vy0 = V0 * Math.Sin((a * Math.PI) / 180);
            double x = x0 + Vx0 * t;
            double y = y0 + Vy0 * t - (9.81 * Math.Pow(t, 2)) / 2;
            if (y >= 0)
                Console.WriteLine($"x = {x}\ny = {y}");
            else
            {

            }
        }
    }
}
