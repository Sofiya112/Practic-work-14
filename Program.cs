using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Size()
        {
            Console.Write("размер: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0) 
            {
                Console.WriteLine("Ошибка");
                
            }
            return size;
        }
        static int[] Input(int size)
        {
            int[] omas = new int[size];
            Console.WriteLine("Заполнить одномерный массив");
            for(int i=0;i<size;i++)
            {
                Console.Write($"omas[{i}]");
                omas[i] = Convert.ToInt32(Console.Read());                                                                                                                                                                                                 
            }
            return omas;
        }
        static void Output(int[] array)
        {
            Console.WriteLine("Вывести одномерный массив");
            for(int i=0;i<array.Length;i++)
            {
                Console.Write($"omas[{i}]={array[i]}");
            }
        }


        static void Main(string[] args)
        {
            int size = Size();
            int[]omas= Input(size);
            Output(omas);
            Console.Read();

        }
    }
}
