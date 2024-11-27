using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace triangle_form
{
    internal class Triangle
    {
        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double ac = 0;
        public double bc = 0;
        public double cc = 0;
        public double height;
        public string type;

        public Triangle(double A, double B, double C, double Height)
        {
            a = A;
            b = B;
            c = C;          

            height = Height;
        }
        public Triangle(double Ac, double Bc, double Cc, double Height, bool byCorners)
        {
            ac = Ac;
            bc = Bc;
            cc = Cc;

            height = Height;
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
        public string outputAc()
        {
            return Convert.ToString(ac);
        }

        public string outputBc()
        {
            return Convert.ToString(bc);
        }

        public string outputCc()
        {
            return Convert.ToString(cc);
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
            semiP = Perimeter() / 2;
            return semiP;
        }


        public double Surface()
        {
            double s = 0;
            if (ExistTriangle)
            {
                double semiP = SemiPerimeter();
                s = Math.Sqrt((semiP * (semiP - a) * (semiP - b) * (semiP - c)));
                
            }
            return s;
        }


        public double GetHeight(double baseLength)
        {
            double s = Surface();
            double Height = 0;
            Height = (2 * s) / baseLength;
            height = Height;
            return Height;
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
        public double GetSetAc
        {
            get
            { return ac; }
            set { ac = value; }
        }
        public double GetSetBc
        {
            get { return bc; }
            set { bc = value; }
        }
        public double GetSetCc
        {
            get { return cc; }
            set { cc = value; }
        }
        public double GetSetHeight
        {
            get { return height; }
            set { height = value; }
        }
        public bool ExistTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool ExistTriangleCorner
        {
            get
            {
                if (ac + bc + cc == 180)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void SaveToXML()
        {
            string filePath = @"..\..\Triangles.xml";
            XDocument doc = XDocument.Load(filePath);
            XElement newTriangle = new XElement("triangle",
                new XElement("sideA", a),
                new XElement("sideB", b),
                new XElement("sideC", c),
                new XElement("angleA", ac),
                new XElement("angleB", bc),
                new XElement("angleC", cc),
                new XElement("height", height),
                new XElement("type", type)
                );
            doc.Root.Add(newTriangle);
            doc.Save(filePath);
        }

        public string TriangleTypeBySides
        {
            get
            {
                if (ExistTriangle)
                    if (a == b && b == c)
                    {
                        type = "võrdkülgne";
                        return "võrdkülgne";
                        
                    }
                    else if (a == b || a == c || b == c)
                    {
                        type = "võrdhaarne";
                        return "võrdhaarne";
                    }
                    else
                    {
                        type = "erikülgne";
                        return "erikülgne";
                    }
                else
                {
                    type = "tundmatu tüüp";
                    return "tundmatu tüüp";
                }
            }
               


        }
        public string TriangleTypeByCorners
        {
            get
            {
                if (ExistTriangleCorner)
                    if (ac == bc && bc == cc)
                    {
                        type = "võrdkülgne";
                        return "võrdkülgne";
                    }
                    else if (ac == 90 && bc == cc || bc == 90 && ac == cc || cc == 90 && ac == bc)
                    {
                        type = "võrdhaarne ristkülikujuline";
                        return "võrdhaarne ristkülikujuline";
                    }
                    else if (ac == 90 || bc == 90 || cc == 90)
                    {
                        type = "ristkülikujuline";
                        return "ristkülikujuline";
                    }
                    else if (ac == bc || ac == cc || bc == cc)
                    {
                        type = "võrdhaarne";
                        return "võrdhaarne";
                    }
                   
                    else
                    {
                        type = "erikülgne";
                        return "erikülgne";
                    }
                else
                {
                    type = "tundmatu tüüp";
                    return "tundmatu tüüp";
                }
            }



        }


    } 
    
}
