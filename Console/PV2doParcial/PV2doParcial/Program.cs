using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV2doParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack p = new Stack();
            Console.WriteLine("Ingresa los signos parentesis, llaves y  corchtes ");
               string n = Console.ReadLine();
         
            for (int i = 0; i < n.Length; i++)
            {
                if ((n[i] == '(') || (n[i] == '{') || (n[i] == '['))
                {
                    p.Push(n[i]);
                }
                else if (p.Count > 0)
                {
                    switch (n[i])
                    {
                        case ']'://caso ]

                            p.Pop();
                            break;
                        case '}'://caso}

                            p.Pop();
                            break;
                        case ')'://caso )
                            p.Pop();
                            break;
                    }
                }
            }
            if (p.Count == 0)
            {
                Console.WriteLine("LA ECUACION ESTA CORRECTAMENTE EQUILIBRADA");//imprime es correcta
            }
            else
            {
                Console.WriteLine("LA ECUACION NO ECUACION NO ESTA EQUILIBRADA");//imprime no esta equilibrada
            }
        }
    }
}


