using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS
{
    class Punto2D : Punto
    {
        private double y;
        public double Y
        {
            get 
            { 
                return y; 
            }
            set 
            { 
                y = value; 
            }
        }
        
        public Punto2D() : base()
        {
            //x = 0;
            y = 0;
        }
        public Punto2D(double x, double y) : base(x)
        {
            this.y = y;
        }
        public override string ToString()
        {
            return base.ToString() + "Y=" + y;
        }
    }
}
