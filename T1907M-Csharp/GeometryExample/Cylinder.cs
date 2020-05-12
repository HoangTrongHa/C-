using System;
using System.Security.Cryptography.X509Certificates;

namespace buoi2.GeometryExample
{
    public delegate double Number(double radius,double height);

    public class Cylinder
    {

        public static double BaseArea(double radius, double height)
        {
            return radius * radius * Math.PI;
        }

        public static double LateralArea(double radius, double height)
        {
            return 2 * Math.PI * radius * height;
        }

        public static double TotalArea(double radius, double height)
        {
            return 2 * Math.PI * radius * (height + radius);
            ;
        }

        public static double Volume(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }

        public static Number Result(int Choose)
        {
            switch (Choose)
            {
                case 1: return BaseArea;
                case 2: return LateralArea;
                case 3: return TotalArea;
                case 4: return Volume;

                default: return null;
            }
        }
    }
}