using System;

class Program
{
    static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 1000);
        }
        return array;
    }

    static void Main(string[] args)
    {
        int[] randomArray = GenerateRandomArray(100);
        Console.WriteLine(string.Join(" ", randomArray));

        Console.WriteLine("Podaj wartość do znalezienia:");
        int target = Convert.ToInt32(Console.ReadLine());

        int index = LinearSearch(randomArray, target);
        if (index != -1)
        {
            Console.WriteLine($"Liczba {target} znajduje się na pozycji {index}.");
        }
        else
        {
            Console.WriteLine($"Liczba {target} nie znajduje się w tablicy.");
        }
    }
}
