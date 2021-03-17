﻿using System;
using AbstractE.Entites;
using System.Collections.Generic;
using AbstractE.Entites.Enums;
using System.Globalization;

namespace AbstractE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.WriteLine("Recangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red) :");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                } else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }                
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
