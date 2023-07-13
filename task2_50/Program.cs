//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

        Console.WriteLine("Введите позицию элемента для поиска (в формате 'i,j')");
        string input = Console.ReadLine();
        string[] position = input.Split(',');
        int i = int.Parse(position[0]);
        int j = int.Parse(position[1]);

        if (i >= 0 && i < array.GetLength(0) && j >= 0 && j < array.GetLength(1))
        {
            int element = array[i, j];
            Console.WriteLine($"Значение элемента [{i}][{j}]: {element}");
        }
        else
        {
            Console.WriteLine("Указанная позиция элемента вне диапазона массива.");
        }
    }
}