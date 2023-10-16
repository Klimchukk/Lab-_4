using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Введiть число M");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть число N");
            int n = int.Parse(Console.ReadLine());
            //Умова що m<=5
            if (m < 1 || m > 5)
            {
                Console.WriteLine("За умовою завдання m повинно бути менше або дорiвнювати 5");
            }
            else
            {
                //Введення рандомних чисел в масив
                int[,] arr = new int[m, n];
                Random r = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {

                        arr[i, j] = r.Next(0, 100);

                    }
                }
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + "\t");


                    }
                    Console.WriteLine();
                }
                //Знаходження найменшого елемента в масиві
                int min = arr[0, 0];
                for (int y = 0; y < arr.GetLength(0); y++)
                {
                    for (int x = 0; x < arr.GetLength(1); x++)
                    {
                        if (min > arr[y, x])
                        {
                            min = arr[y, x];
                        }


                    }
                }



                Console.WriteLine("Мiнiмальне значення");
                Console.WriteLine(min);
                Console.WriteLine("Перероблена матриця по головнiй дiагоналi");
                //Заміна елементів під головною діагоналлю на найменші
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        if (i > j)
                        {
                            Console.Write((arr[i, j] = min) + "\t");

                        }
                        else
                        {
                            Console.Write(arr[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }


            Console.ReadLine();

        }

    }




}
