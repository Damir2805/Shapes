using System;
using System.Runtime.InteropServices;

namespace Shapes
{
    class Program
    {
        public static void Main()
        {
            //Спрашиваем пользователя, какую фигуру будем считать
            Console.WriteLine("Площадь какой фигуры будем считать?");
            Console.WriteLine("1. Треугольник");
            Console.WriteLine("2. Круг");

            string num = Console.ReadLine();

            if(num == "1") 
            {
                //создаем экземпляр класса Triangle и присваиваем ему имя instance
                Triangle instance = new Triangle();

                //вызываем метод ввода данных
                instance.GetData();

                //вызываем метод Dims
                instance.Dims();
            }
            else
            {
                //создаем экземпляр класса Circle и присваиваем ему имя instance
                Circle instance = new Circle();

                //вызываем метод ввода данных
                instance.GetData();

                //вызываем метод Dims
                instance.Dims();
            }                       
        }
    }
}
