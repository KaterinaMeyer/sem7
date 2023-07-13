//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

class Program
{
    static void Main()
    {
        int[,] array = new int[4, 3];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Введите значение элемента [{i}][{j}]:");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        while (true)
        {
            Console.WriteLine("Введите позицию элемента для поиска (в формате 'i,j') ");
            string input = Console.ReadLine();

            string[] position = input.Split(',');
            int i = int.Parse(position[0]);
            int j = int.Parse(position[1]);

            if (i >= 0 && i < 4 && j >= 0 && j < 3)
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
}