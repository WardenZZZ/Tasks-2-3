using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresUnitTest
{
    [TestClass]
    public class FiguresUnitTest
    {
        [TestMethod]
        public void CircleSquareTest() //Юнит тест вычисления площади круга по радиусу
        {
            double SquareRadius = 3;
            double Anticipatedresult = 28.274333882308138; //Ожидаемое значение площади круга при радиусе равном 3

            double CircleSquareResult = FiguresLibrary.FiguresLibrary.Circle(SquareRadius); //Вызов библиотеки

            Assert.AreEqual(CircleSquareResult, Anticipatedresult); //Сравнение ожидаемого и полученного значения
        }

        [TestMethod]
        public void TriangleSquareTest() //Юнит тест вычисления площади треугольника по трём сторонам
        {
            double TriangleFirstSide = 3;
            double TriangleSecondSide = 5;
            double TriangleThirdSide = 6;

            double Anticipatedresult = 7.483314773547883; //Ожидаемое значение площади треугольника по трём сторонам

            double TriangleSquareResult = FiguresLibrary.FiguresLibrary.Triangle(TriangleFirstSide, TriangleSecondSide, TriangleThirdSide); //Вызов библиотеки

            Assert.AreEqual(TriangleSquareResult, Anticipatedresult); //Сравнение ожидаемого и полученного значения
        }

        [TestMethod]
        public void TriangleSquareZeroValueTest() //Юнит тест вычисления площади треугольника по трём сторонам
        {
            double TriangleFirstSide = 1;
            double TriangleSecondSide = 2;
            double TriangleThirdSide = 3;

            double Anticipatedresult = 0; //Ожидаемое значение


            double TriangleSquareResult = FiguresLibrary.FiguresLibrary.Triangle(TriangleFirstSide, TriangleSecondSide, TriangleThirdSide); //Вызов библиотеки

            Assert.AreEqual(TriangleSquareResult, Anticipatedresult); //Сравнение ожидаемого и полученного значения

        }

        [TestMethod]
        public void RectangleSquareTest() //Юнит тест вычисления площади треугольника по трём сторонам
        {
            double RectangleFirstSide = 3;
            double RectangleSecondSide = 5;

            double Anticipatedresult = 15; //Ожидаемое значение площади прямоугольника по двум сторонам

            double RectangleSquareResult = FiguresLibrary.FiguresLibrary.Rectangle(RectangleFirstSide, RectangleSecondSide); //Вызов библиотеки

            Assert.AreEqual(RectangleSquareResult, Anticipatedresult); //Сравнение ожидаемого и полученного значения
        }

        [TestMethod]
        public void SquareTest() //Юнит тест вычисления площади квадрата
        {
            double SquareSide = 3;

            double Anticipatedresult = 9; //Ожидаемое значение площади прямоугольника по двум сторонам

            double SquareResult = FiguresLibrary.FiguresLibrary.Square(SquareSide); //Вызов библиотеки

            Assert.AreEqual(SquareResult, Anticipatedresult); //Сравнение ожидаемого и полученного значения
        }
    }

}
