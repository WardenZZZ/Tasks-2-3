using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresApp
{
    class FiguresApp
    {
        static void Main(string[] args)
        {
            Random RandomValue = new Random();
            double Value1;
            double Value2;
            double Value3;
            double Result;

            Console.WriteLine("Добро пожаловать! Выберите тип вычисления (1/3):");
            Console.WriteLine("1: Вычисление площади всех добавленных фигур");
            Console.WriteLine("2: Вычисление площади случайной неизвестной фигуры.");
            Console.WriteLine("3: Вычисление площади с выбором фигуры и значений.");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();


            if (choice == 1) //Вывод площадей всех добавленных фигур с заранее установленными значениями
            {
                Value1 = 10;
                Console.WriteLine("Вычисление площади круга с радиусом: " + Value1);
                Result = FiguresLibrary.FiguresLibrary.Circle(Value1);
                Console.WriteLine("Площадь круга равна: " + Result);
                Console.WriteLine();


                Value1 = 7;
                Value2 = 8;
                Value3 = 11;
                Console.WriteLine("Вычисление площади треугольника со сторонами: " + Value1 + ", " + Value2 + " и " + Value3 + ".");
                Result = FiguresLibrary.FiguresLibrary.Triangle(Value1, Value2, Value3);
                Console.WriteLine("Площадь треугольника равна: " + Result);
                if ((Value1 * Value1 + Value2 * Value2 == Value3 * Value3) || (Value1 * Value1 + Value3 * Value3 == Value2 * Value2) || (Value3 * Value3 + Value2 * Value2 == Value1 * Value1))
                {
                    Console.WriteLine("Треугольник также является прямоугольным");
                }
                else
                {
                    Console.WriteLine("Треугольник не является прямоугольным.");
                }
                Console.WriteLine();


                Value1 = 6;
                Value2 = 8;
                Console.WriteLine("Вычисление площади прямугольника со сторонами: " + Value1 + " и " + Value2);
                Result = FiguresLibrary.FiguresLibrary.Rectangle(Value1, Value2);
                Console.WriteLine("Площадь прямоугольника равна: " + Result);
                Console.WriteLine();

                Value1 = 4;
                Console.WriteLine("Вычисление площади квадрата со стороной " + Value1);
                Result = FiguresLibrary.FiguresLibrary.Square(Value1);
                Console.WriteLine("Площадь квадрата Равна: " + Result);
                Console.WriteLine();

                Console.ReadKey();


            }
            else if (choice == 2) //Вывод площади случайной фигуры со случайными значениями
            {

                switch (RandomValue.Next(1, 4)) //При выборе первого варианта 
                {

                    case 1:
                        Console.WriteLine("Вычисляю площадь круга.");
                        Value1 = RandomValue.Next(1, 10);
                        Result = FiguresLibrary.FiguresLibrary.Circle(Value1);
                        Console.WriteLine("Площадь круга с радиусом " + Value1);
                        Console.Write("Равен: " + Result);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Вычисляю площадь треугольника.");
                        Value1 = RandomValue.Next(6, 10);
                        Value2 = RandomValue.Next(5, 10);
                        Value3 = RandomValue.Next(3, 10);
                        Result = FiguresLibrary.FiguresLibrary.Triangle(Value1, Value2, Value3);
                        Console.WriteLine("Площадь треугольника со сторонами " + Value1 + ", " + Value2 + " и " + Value3);
                        Console.WriteLine("Равен: " + Result);
                        if ((Value1 * Value1 + Value2 * Value2 == Value3 * Value3) || (Value1 * Value1 + Value3 * Value3 == Value2 * Value2) || (Value3 * Value3 + Value2 * Value2 == Value1 * Value1))
                        {
                            Console.WriteLine("Треугольник также является прямоугольным");
                        }
                        else
                        {
                            Console.WriteLine("Треугольник не является прямоугольным.");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Вычисляю площадь прямугольника.");
                        Value1 = RandomValue.Next(1, 10);
                        Value2 = RandomValue.Next(1, 10);
                        Result = FiguresLibrary.FiguresLibrary.Rectangle(Value1, Value2);
                        Console.WriteLine("Площадь прямоугольника со сторонами " + Value1 + " и " + Value2);
                        Console.WriteLine("Равна: " + Result);
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Вычисляю площадь квадрата.");
                        Value1 = RandomValue.Next(1, 10);
                        Result = FiguresLibrary.FiguresLibrary.Square(Value1);
                        Console.WriteLine("Площадь квадрата со стороной " + Value1);
                        Console.WriteLine("Равен: " + Result);
                        Console.ReadKey();
                        break;
                }
            }
            else if (choice == 3) //Вывод площади выбранной фигуры с заданными значениями
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("1: Круг.");
                Console.WriteLine("2: Треугольник.");
                Console.WriteLine("3: Прямоугольник.");
                Console.WriteLine("4: Квадрат.");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.Write("Выбран круг. Введите радиус: ");
                        Value1 = Convert.ToInt32(Console.ReadLine());
                        Result = FiguresLibrary.FiguresLibrary.Circle(Value1);
                        Console.WriteLine("Площадь круга с радиусом " + Value1);
                        Console.Write("Равен: " + Result);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Выбран треугольник. Введите стороны: ");
                        Value1 = Convert.ToInt32(Console.ReadLine());
                        Value2 = Convert.ToInt32(Console.ReadLine());
                        Value3 = Convert.ToInt32(Console.ReadLine());
                        Result = FiguresLibrary.FiguresLibrary.Triangle(Value1, Value2, Value3);
                        Console.WriteLine("Площадь треугольника со сторонами " + Value1 + ", " + Value2 + " и " + Value3);
                        Console.WriteLine("Равен: " + Result);
                        if ((Value1 * Value1 + Value2 * Value2 == Value3 * Value3) || (Value1 * Value1 + Value3 * Value3 == Value2 * Value2) || (Value3 * Value3 + Value2 * Value2 == Value1 * Value1))
                        {
                            Console.WriteLine("Треугольник также является прямоугольным");
                        }
                        else
                        {
                            Console.WriteLine("Треугольник не является прямоугольным.");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Выбран прямоугольник. Введите стороны: ");
                        Value1 = Convert.ToInt32(Console.ReadLine());
                        Value2 = Convert.ToInt32(Console.ReadLine());
                        Result = FiguresLibrary.FiguresLibrary.Rectangle(Value1, Value2);
                        Console.WriteLine("Площадь прямоугольника со сторонами " + Value1 + " и " + Value2);
                        Console.WriteLine("Равна: " + Result);
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Write("Выбран квадрат. Введите сторону: ");
                        Value1 = Convert.ToInt32(Console.ReadLine());
                        Result = FiguresLibrary.FiguresLibrary.Square(Value1);
                        Console.WriteLine("Площадь квадрата со стороной " + Value1);
                        Console.WriteLine("Равен: " + Result);
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Введено неверное значение!");
                        Console.ReadKey();
                        break;
                }

            }
            else
            {
                Console.WriteLine("Введёно неверное число.");
                Console.ReadKey();
                Environment.Exit(0);
            }
                    
        }
    }
}
