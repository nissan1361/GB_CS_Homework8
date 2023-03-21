// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива. Например,
// задан массив
Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());

int[,] array = CreateArray(rows, cols);

Console.WriteLine("Не отсортированный массив: ");
PrintArray(array);

int[,] sortedArray = SortArray(array);

Console.WriteLine("Отсортированный массив: ");
PrintArray(sortedArray);

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
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "    ");
        }
        Console.WriteLine("");
    }
}

static int[,] SortArray(int[,] arr)
{
    int[] arrayString = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrayString[j] = arr[i, j];
        }
        Array.Sort(arrayString, (x, y) => y.CompareTo(x));
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = arrayString[j];
        }
    }

    return arr;
}

