using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle
    {
        // Создаем поля класса Triangle
        public double r; // радиус круга       
        
        //Создаем метод запроса данных и присвоения их полям класса
        public void GetData()
        {
            Console.WriteLine("введите радиус");
            r = Convert.ToDouble(Console.ReadLine());
        }

        // Создаем метод вычисления площади круга
        public void Dims()
        {
            double area = r * r * 3.14;
            Console.WriteLine("Площадь круга равна " + area);
        }
    }
}
