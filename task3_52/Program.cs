//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        double[] columnAverages = new double[cols];

        for (int j = 0; j < cols; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = (double)sum / rows;
        }

        Console.WriteLine("Средние арифметические элементов в каждом столбце:");
        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
        }
    }
}
