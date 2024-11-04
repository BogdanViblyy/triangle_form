using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_form
{
    internal class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double height;

        public Triangle(double A, double B, double C, double Height)
        {
            a = A;
            b = B;
            c = C;
            height = Height;
        }
        public Triangle()
        {
        
            a = 3;
            b = 4;
            c = 5;
        }
        public string outputA() 
        {
            return Convert.ToString(a); 
        }

        public string outputB() 
        {
            return Convert.ToString(b); 
        }

        public string outputC() 
        {
            return Convert.ToString(c); 
        }
        public string outputHeight()
        {
            return Convert.ToString(height);
        }

        public double Perimeter() 
        {
            double p = 0;
            p = a + b + c; 
            return p; 
        }
        public double SemiPerimeter()
        {
            double semiP = 0;
            semiP=(a + b + c) / 2;
            return semiP;
        }

        public double Surface() 
        {
            double s = 0;
            double semiP = SemiPerimeter();
            semiP = (a + b + c) / 2;
            s = Math.Sqrt((semiP * (semiP - a) * (semiP - b) * (semiP - c)));
            return s;
        }


        public double GetHeight(double baseLength)
        {
            double s = Surface();
            double height = 0;
            height = (2 * s) / baseLength;
            return height;
        }


        public double GetSetA
        {
            get
            { return a; }
            set { a = value; }
        }
        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }
        public double GetSetC
        {
            get { return c; }
            set { c = value; }
        }
        public double GetSetHeight
        { 
            get { return height; }
            set { height = value; }
        }
       

    }
    
}
