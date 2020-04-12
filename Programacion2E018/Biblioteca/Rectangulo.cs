using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float? area;
        private float? perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = new Punto(vertice1.GetX(), vertice1.GetY());
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice3 = new Punto(vertice3.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.area = null;
            this.perimetro = null;
        }

        public float Area()
        {
            if(this.area is null)
            {
                float baseRectangulo;
                float alturaRectangulo;

                baseRectangulo = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                alturaRectangulo = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());

                this.area = baseRectangulo * alturaRectangulo;
            }
            return (float)this.area;
        }

        public float Perimetro()
        {
            if (this.perimetro is null)
            {
                float baseRectangulo;
                float alturaRectangulo;

                baseRectangulo = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                alturaRectangulo = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());

                this.perimetro = (baseRectangulo + alturaRectangulo) * 2;
            }
            return (float)this.perimetro;

        }

        override public string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Vertice 1: ({0}, {1})\n"
                , this.vertice1.GetX(), this.vertice1.GetY());
            str.AppendFormat("Vertice 2: ({0}, {1})\n"
                , this.vertice2.GetX(), this.vertice2.GetY());
            str.AppendFormat("Vertice 3: ({0}, {1})\n"
                , this.vertice3.GetX(), this.vertice3.GetY());
            str.AppendFormat("Vertice 4: ({0}, {1})\n"
                , this.vertice4.GetX(), this.vertice4.GetY());

            return str.ToString();
        }
    }
}
