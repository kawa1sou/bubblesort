using System;

namespace u16kk
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Console.WriteLine("Input seven numbers: ");
            for (int e = 0; e < array.Length; e++)
            {
                Console.Write("{0} number: ", e + 1);
                array[e] = Int32.Parse(Console.ReadLine());
            }
            for (int t = 0; t < array.Length; t++)
            {
                Console.Write(array[t] + " ");
            }

            int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int k = 0; k < array.Length - 1; k++)
                    {
                        if (array[k] > array[k + 1])
                        {
                            temp = array[k];
                            array[k] = array[k + 1];
                            array[k + 1] = temp;
                        }
                    }
                    Console.WriteLine();
                    for (int t = 0; t < array.Length; t++)
                    {
                        Console.Write(array[t] + " ");
                    }
                }
                Console.WriteLine();
                Console.Write("Final result:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.ReadKey();
            }
        }
    }