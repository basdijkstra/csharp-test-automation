using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.ObjectOrientedPrinciples
{
    public class Point
    {
        private double XCoordinate;
        private double YCoordinate;

        public Point(double X, double Y)
        {
            XCoordinate = X;
            YCoordinate = Y;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(Math.Pow(XCoordinate, 2) + Math.Pow(YCoordinate, 2));
        }

        public void DoubleDistanceToOrigin()
        {
            XCoordinate *= 2;
            YCoordinate *= 2;
        }
    }
}
