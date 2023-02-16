using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad2_pr2_c
{
    public class Program
    {
        public abstract class Figura
        {
            private  double _area;
            private double _perimetro;

            public Figura()
            {

            }

            public abstract double GetArea();
            public abstract double GetPerimetro();

            public virtual void MostrarDatos()
            {
                Console.WriteLine("Muestro las Figuras solicitadas");
            }
        }//Fin Figura

        public class Triangulo : Figura
        {
            private double _base;
            private double _altura;
            private double _lado;
            public double base_T { get; set; }
            public double altura_T { get; set; }
            public double lado_T { get; set; }

            public Triangulo(double base_T, double altura_T, double lado_T)
            {
                _base = base_T;
                _altura = altura_T;
                _lado = lado_T;
            }
            public Triangulo()
            {
                _base = 0;
                _altura = 0;
                _lado = 0;
            }
            public override double GetArea()
            {
                return GetArea();
            }
            public override double GetPerimetro()
            {
                return GetPerimetro();
            }

        } //Fin de triangulo

        public class TrianguloEquilatero : Triangulo
        {
            public override double GetArea()
            {
                return ((base_T * altura_T) / 2);
            }
            public override double GetPerimetro()
            {
                return (lado_T + lado_T + lado_T);
            }
            public override void MostrarDatos()
            {
                Console.WriteLine($" Equilatero\n  Area = {GetArea()} cm^2\n   Perimetro = {GetPerimetro()} cm\n");
            }

        }//Fin de TrianguloEquilatero

        public class TrianguloIsoceles : Triangulo
        {
            public override double GetArea()
            {
                return ((base_T * altura_T) / (2));
            }

            public override double GetPerimetro()
            {
                return (((2) * lado_T) + base_T);
            }
            public override void MostrarDatos()
            {
                Console.WriteLine($" Isoceles\n  Area = {GetArea()} cm^2\n   Perimetro = {GetPerimetro()} cm\n");
            }

        }//Fin de TrianguloIsoceles

        public class TrianguloEscaleno : Triangulo
        {
            public override double GetArea()
            {
                return ((base_T  * altura_T) / (2));
            }
            public override double GetPerimetro()
            {
                return (base_T + altura_T + lado_T);
            }
            public override void MostrarDatos()
            {
                Console.WriteLine($" Escaleno\n  Area = {GetArea()} cm^2\n   Perimetro = {GetPerimetro()} cm\n");
            }


        }//Fin de TrianguloEscaleno

        static void Main(string[] args)
        {
            TrianguloEquilatero Equilatero = new TrianguloEquilatero();
            Equilatero.base_T = 3;
            Equilatero.altura_T = 2;
            Equilatero.lado_T = 5;
            Equilatero.MostrarDatos();

            TrianguloIsoceles Isoceles = new TrianguloIsoceles();
            Isoceles.base_T = 1;
            Isoceles.altura_T = 2;
            Isoceles.lado_T = 3;
            Isoceles.MostrarDatos();

            TrianguloEscaleno Escaleno = new TrianguloEscaleno();
            Escaleno.base_T = 4;
            Escaleno.altura_T = 5;
            Escaleno.lado_T = 8;
            Escaleno.MostrarDatos();

            Console.ReadKey();
        }
    }
}
