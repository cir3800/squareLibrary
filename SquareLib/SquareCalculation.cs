using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public class SquareCalculation
    {
        /// <summary>
        /// Вычисляет площадь круга, прямоугольника или треугольника по заданным сторонам. Автоматически определяет тип фигуры.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double Square(double radius) // круг
        {
            double result = Math.PI * Math.Pow(radius, 2);
            result = Math.Round(result, 6);
            return result;
        }

        /// <summary>
        /// Вычисляет площадь круга, прямоугольника или треугольника по заданным сторонам. Автоматически определяет тип фигуры.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double Square(double height, double width) // прямоугольник
        {
            double result = height * width;
            result = Math.Round(result, 6);
            return result;
        }

        /// <summary>
        /// Вычисляет площадь круга, прямоугольника или треугольника по заданным сторонам. Автоматически определяет тип фигуры.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double Square(double first, double second, double third) // треугольник
        {
            double p = (first + second + third) / 2.0;
            double result = Math.Sqrt(p * (p - first) * (p - second) * (p - third));
            result = Math.Round(result, 6);
            return result;
        }
        /// <summary>
        /// Выполняет проверку треугольника на наличие прямого угла
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public bool CheckTypeTriangle(double first, double second, double third)
        {
            bool result = false;
            List<double> list = new List<double>(3);
            list.Add(first);
            list.Add(second);
            list.Add(third);
            list.Sort();
            double eps = 0.001;
            if (Math.Abs(Math.Pow(list[0], 2) + Math.Pow(list[1], 2) - Math.Pow(list[2], 2)) < eps)
                result = true;
            return result;
        }
    }
}
