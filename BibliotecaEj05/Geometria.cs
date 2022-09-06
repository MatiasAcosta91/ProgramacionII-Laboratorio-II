using System;

namespace BibliotecaEj05
{
    public class Geometria
    {
        public class Punto
        {
            private int x;
            private int y;
            public Punto(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int GetX ()
            {
                return this.x;
            }
            public int GetY()
            {
                return this.y;
            }


        }

        public class Rectangulo
        {
            private float area;
            private float perimetro;
            Punto vertice1;
            Punto vertice2;
            Punto vertice3;
            Punto vertice4;

            public Rectangulo(Punto verticeUno, Punto verticeTres)
            {
                this.vertice1 = verticeUno;
                this.vertice3 = verticeTres;
                Punto puntoDos = new Punto(vertice1.GetX(), vertice3.GetY());
                Punto puntoCuatro = new Punto(vertice3.GetX(), vertice1.GetY());
                this.vertice2 = puntoDos;
                this.vertice4 = puntoCuatro;
            }

            public float GetArea()
            {
                return this.Area();
            }
            public float GetPerimetro()
            {    
                return this.Perimetro();
            }
            public float Area ()
            {
                int distanciaX = Math.Abs(vertice4.GetX() - vertice1.GetX());
                int distanciaY = Math.Abs(vertice2.GetY() - vertice1.GetY());

                return distanciaX * distanciaY;

            }
            public float Perimetro()
            {
                int distanciaX = Math.Abs(vertice4.GetX() - vertice1.GetX());
                int distanciaY = Math.Abs(vertice2.GetY() - vertice1.GetY());

                return (distanciaX + distanciaY) / 2;
            }




        }

       
    }
}
