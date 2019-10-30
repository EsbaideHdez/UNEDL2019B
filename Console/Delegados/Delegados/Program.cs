using System;
public delegate int Numeros(int n1, int n2, int n3, int n4, int n5);

namespace Delegados
{
    class Program
    {
        static int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0;
        static int suma = 0, promedio = 0, mayor = 0;

        public static int ObtenerSuma(int n1, int n2, int n3, int n4, int n5)
        {
            suma = n1 + n2 + n3 + n4 + n5;
            return suma;
        }

        public static int ObtenerPomedio(int n1, int n2, int n3, int n4, int n5)
        {
            promedio =((n1 + n2 + n3 + n4 + n5 )/ 5);
            return promedio;
        }

        public static int ObtenerMayor(int n1, int n2, int n3, int n4 , int n5)
        {
            if(n1>n2 && n1>n3 && n1>n4 && n1 > n5)
            {
                mayor = n1;
            }
            else if(n2>n1 && n2>n3 && n2>n4 && n2 > n5)
            {
                mayor = n2;
            }
            else if(n3>n1 && n3>n2 && n3>n4 && n3 > n5)
            {
                mayor = n3;
            }
            else if(n4>n1 && n4>n2 && n4>n3  && n4 > n5)
            {
                mayor = n5;
            }
            else if(n5>n1 && n5>n2 && n5>n3 && n5 > n4)
            {
                mayor = n5;
            }
            return mayor;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero");
            n5 = int.Parse(Console.ReadLine());

            Numeros N1 = new Numeros(ObtenerSuma);
            Numeros N2 = new Numeros(ObtenerPomedio);
            Numeros N3 = new Numeros(ObtenerMayor);
            N1 (n1, n2, n3, n4, n5);
            N2 (n1, n2, n3, n4, n5);
            N3 (n1, n2, n3, n4, n5);

            Console.WriteLine("La suma de los 5 numero es : {0}", suma);
            Console.WriteLine("El promedio de los 5 numero es : {0}", promedio);
            Console.WriteLine("El mayor de los 5 numero es : {0}", mayor);
            Console.ReadKey();

        }
        
    }
}
