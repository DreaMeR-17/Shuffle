using System;
using System.Linq;

namespace Shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[10];

            values = GetValueForArrayElement(values);
            ShowArrayElements(values);

            Console.WriteLine();

            values = Shuffle(values);
            ShowArrayElements(values);
        }

        static int[] GetValueForArrayElement(int[] values)
        {
            int startValue = 0;

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = startValue++;
            }

            return values;
        }

        static void ShowArrayElements(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }
        }

        static int[] Shuffle(int[] values)
        {
            Random random = new Random();

            int arrayLenght = values.Count();

            while (arrayLenght > 1)
            {
                arrayLenght--;

                int randomIndex = random.Next(arrayLenght);
                int temp = values[randomIndex];
                values[randomIndex] = values[arrayLenght];
                values[arrayLenght] = temp;
            }

            return values;
        }
    }
}
