using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {


            uint arraynum;
            int[] myArray;
            Console.WriteLine("Сколько будет элементов в массиве?");
            arraynum = uint.Parse(Console.ReadLine());
            myArray = new int[arraynum];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + "-й элемент массива: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            // Выводим массив, который дан
            Console.WriteLine("Ваш массив:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();


            // Выводим массив в обатном порядке
            Console.WriteLine("Этот массив в обратном порядке:");
            for (int i = (myArray.Length - 1); i >= 0; i--)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();

            // Считаем четные числа в массиве
            uint positive_count = 0;
            float positive_sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    positive_sum = positive_sum + myArray[i];
                    positive_count++;
                }
            }
            Console.WriteLine("Количество четных чисел в массиве: " + positive_count);
            Console.WriteLine("Сумма четных чисел в массиве: " + positive_sum);

            Console.ReadLine();
        }   
    }
}
