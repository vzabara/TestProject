using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{

    public static class TestProject
    {
        /// <summary>
        /// Calculates square of circle by it's radius.
        /// </summary>
        /// <param name="r">Circle's radius.</param>
        /// <returns>Square of circle.</returns>
        public static double GetCircleSquare(double r)
        {
            return (new Circle(r)).GetSquare();
        }

        /// <summary>
        /// Calculates square of triangle by it's sides.
        /// </summary>
        /// <param name="a">Side of thiangle.</param>
        /// <param name="b">Side of thiangle.</param>
        /// <param name="c">Side of thiangle.</param>
        /// <returns>Square of triangle.</returns>
        public static double GetTriangleSquare(double a, double b, double c)
        {
            return (new Triangle(a, b, c)).GetSquare();
        }

        /// <summary>
        /// Calculates square of some shape.
        /// </summary>
        /// <param name="shape">a shape</param>
        /// <returns>Square of a shape</returns>
        public static double GetShapeSquare(IShape shape)
        {
            return shape.GetSquare();
        }

        /// <summary>
        /// Checks if triangle is right.
        /// </summary>
        /// <param name="a">Side of thiangle.</param>
        /// <param name="b">Side of thiangle.</param>
        /// <param name="c">Side of thiangle.</param>
        /// <returns></returns>
        public static bool IsRightTriangle(double a, double b, double c)
        {
            return (new Triangle(a, b, c)).IsRightTriangle();
        }
    }

    public interface IShape
    {
        double GetSquare();
    }

    public class Circle: IShape
    {
        double r;
        public Circle (double r)
        {
            if (r <= 0)
                throw new Exception("Incorrect radius.");
            this.r = r;
        }
        public double GetSquare()
        {
            return Math.PI * r * r;
        }
    }

    public class Triangle: IShape
    {
        double a;
        double b;
        double c;

        public Triangle(double a, double b, double c)
        {
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                throw new Exception("Incorrect sides.");
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRightTriangle()
        {
            return ((a * a + b * b) == c * c || (a * a + c * c) == b * b || (b * b + c * c) == a * a);
        }
    }
}
