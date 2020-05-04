using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Shapes
{
    public class Triangle
    {
        // Создаем поля класса Triangle
        public double a; // Длина стороны а
        public double b; // Длина стороны b
        public double c; // Длина стороны c

        //Создаем метод запроса данных и присвоения их полям класса
        public void GetData()
        {
            Console.WriteLine("введите длину стороны a");
            a = Convert.ToDouble(Console.ReadLine());          

            Console.WriteLine("введите длину стороны b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите длину стороны c");
            c = Convert.ToDouble(Console.ReadLine());
        }
               
        // Создаем метод вычисления площади по трем сторонам
        public void Dims()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Площадь треугольника равна " + area);
        }
    }    
}
