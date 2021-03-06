﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace libtest
{
    public class data
    {
       
        public static void vsquare(double a = 0, double b = -1, double c = -1)
        {
            figure polygon;

            if (a == 0)
            {
                polygon = new circle(a);
            }
            else
            {
                if (b != -1)
                {
                    if (c != -1)
                    {
                        polygon = new triangle(a, b, c);
                        
                    }
                    else
                    {
                        polygon = new triangle(a, b, b);
                        
                    }
                }
                else
                {
                     polygon = new circle(a);
                   
                }

            }
            polygon.Square();

        }
    }
     public class figure
    {
        

        public virtual void Square()
        { }

    }

     public class triangle : figure 
    {
        public double a, b, c;
        public triangle(double a1, double b1, double c1) { a = a1; b = b1; c = c1; }


        public override void Square()
        {
            
            double s = 0;
            double p = (a + b + c) / 2;
            s = p * (p - a) * (p - b) * (p - c);
            s = Math.Sqrt(s);
            Console.WriteLine("Square = {0} ", s);
            

        }

    }
    public class circle : figure
    {
        public double a;
        public circle(double a1) { a = a1; }


        public override void Square()
        {
          
            double s = a*a*3.14;

            Console.WriteLine("Square = {0} ", s);
            

        }

    }


}
