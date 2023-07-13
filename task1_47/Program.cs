// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк (m):");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов (n):");
        int n = int.Parse(Console.ReadLine());

        double[,] array = GenerateRandomArray(m, n);

        Console.WriteLine("Сгенерированный двумерный массив:");
        PrintArray(array);
    }

    static double[,] GenerateRandomArray(int m, int n)
    {
        Random random = new Random();
        double[,] array = new double[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double randomNumber = Math.Round(random.NextDouble() * 200 - 100, 1);
                array[i, j] = randomNumber;
            }
        }

        return array;
    }

    static void PrintArray(double[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}