// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов
Console.Clear();


Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());

int[,] array = CreateArray(rows, cols);

PrintArray(array);

int minSum = SearchMinSumm(array);
Console.WriteLine("Номер строки с наименьшей суммой элементов:");
Console.WriteLine(minSum);

static int[,] CreateArray(int rows, int cols)
{
    int[,] arr = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }

    return arr;
}

static void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Строка {i + 1} -> ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "    ");
        }
        Console.WriteLine("");
    }
}

static int SearchMinSumm(int[,] arr)
{
    int minSumm = -1;
    int rowMin = 0;
    int summStr = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        summStr = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summStr += arr[i, j];
        }

        if (i == 0)
        {
            minSumm = summStr;
        }

        if (summStr < minSumm)
        {
            rowMin = i;
            minSumm = summStr;
        }
    }

    return rowMin + 1;
}
