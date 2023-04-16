using System;

namespace FiguresLibrary //Библиотека фигур
{
    public static class FiguresLibrary
    {
        public static double Circle(double V1) //V1 = ValueOne;
        {
            return (V1 * V1) * Math.PI; //Формула площади круга: произведение константы Пи на квадрат радиуса
        }

        public static double Triangle(double V1, double V2, double V3) //V1 = Value one; V2 = ValueTwo; V3 = ValueThree;
        {
            double P = (V1 + V2 + V3) / 2; //Переменная для определения полупериметра

            double S = Math.Sqrt(P * (P - V1) * (P - V2) * (P - V3));

            return Math.Abs(S); //Вычисление площади треугольника по формуле Герона

        }

        //Добавление новой фигуры - прямуогольника;
        public static double Rectangle(double V1, double V2) //V1 = Value one; V2 = ValueTwo;
        {
            return V1 * V2; //Вычисление площади прямуогольника
        }

        //Добавление новой фигуры - квадрата;
        public static double Square(double V1) //V1 = Value one;
        {
            return V1 * V1; //Вычисление площади квадрата
        }

    }
}
