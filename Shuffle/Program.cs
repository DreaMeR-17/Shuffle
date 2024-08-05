using System;
using System.Linq;

namespace Shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[10];

            GetValueForArrayElement(values);
            ShowArrayElements(values);

            Console.WriteLine();

            Shuffle(values);
            ShowArrayElements(values);
        }

        static void GetValueForArrayElement(int[] values)
        {
            int startValue = 0;

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = startValue++;
            }
        }

        static void ShowArrayElements(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }
        }

        static void Shuffle(int[] values)
        {
            Random random = new Random();

            int arrayLenght = values.Count();

            for (int i = 0; arrayLenght > 0; i++)
            {
                arrayLenght--;

                int randomIndex = random.Next(arrayLenght);
                int temp = values[randomIndex];
                values[randomIndex] = values[arrayLenght];
                values[arrayLenght] = temp;
            }
        }
    }
}
