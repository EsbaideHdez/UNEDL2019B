using System;

namespace Semestres_Unedl
{
    class Program
    {


        static void Main(string[] args)
        {
            int[][] arr = new int[8][];
            arr[0] = new int[30];
            arr[1] = new int[24];
            arr[2] = new int[20];
            arr[3] = new int[15];
            arr[4] = new int[13];
            arr[5] = new int[13];
            arr[6] = new int[9];
            arr[7] = new int[8];

            System.Console.WriteLine("UNIVERSIDAD ENRIQUE DIAZ DE LEON ");
            System.Console.WriteLine("8 semetres con las calificaciones de cada alumno ");

            

            arr[0] = new int[] { 89, 90, 99, 78, 25, 59, 74, 67, 88, 100, 100, 57, 30, 99, 95, 90, 34, 65, 69, 77, 63, 86, 88, 17, 40, 50, 51, 69, 70, 99 };
            arr[1] = new int[] { 100,95,49,75,78,100,99,94,92,84,69,70,70,87,59,68,88,77,35,56,76,64,89,96};
            arr[2] = new int[] { 89,69,79,47,79,99,79,89,29,59,19,39,56,78,46,67,89,99,100,100};
            arr[3] = new int[] { 67,34,99,69,15,98,99,100,100,100,67,89,94,20,50,};
            arr[4] = new int[] { 99, 69, 15, 98, 99, 100, 100, 100, 67, 89, 94, 20, 50, };
            arr[5] = new int[] { 89, 34, 99, 69, 15, 67, 99, 100, 90, 100, 67, 39, 94 };
            arr[6] = new int[] { 100, 89, 99, 96, 51, 89, 45, 67, 54};
            arr[7] = new int[] {  89, 75, 96, 51, 38, 45, 74, 29 };

            for (int i=0 ; i < arr.Length; i++)
            {
                System.Console.Write("Semestre {0} : ", i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j] , "," ,j == (arr[i].Length - 1) ? "" : " ");

                }

                Console.WriteLine();
            }
            
            System.Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    
}
