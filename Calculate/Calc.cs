using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class Calc
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }
        public double Minus(double x, double y )
        {
            return x - y;
        }
        public double Mult(double x, double y)
        {
            return x * y;
        }
        public double dev(double x, double y)
        {
            return x / y;
        }
        
        public double sin(double a)
        { return Math.Sin(a); }
        public double cos(double a)
        { return Math.Cos(a); }
        public double tg(double a)
        { return Math.Tan(a); }
        public double log(double a)
        { return Math.Log(a); }

        public double X2(double a)
        { return Math.Pow(a, 2); }

        public double Xkoren2(double a)
        { return Math.Pow(a, 0.5); }

        public double fakt(double a)
        {
            double temp = 1;
            for (int i = 1; i <= a; i++)
            {
                temp *= i;
            }
            return temp; }
    }
}
