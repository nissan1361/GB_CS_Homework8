// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя
// индексы каждого элемента

const int DIMX = 2; //размерность массива по строкам
const int DIMY = 2; //размерность массива по столбцам
const int DIMZ = 2; //размерность массива в глубину
const int MAXV = 100;
 
int[,,] matrix = generate3DArray(DIMX, DIMY, DIMZ);
 
Console.WriteLine("Массив");
Display3DArray(matrix);

static int[,,] generate3DArray(int dimX, int dimY, int dimZ)
{
    int[,,] resultArray = new int[dimX, dimY, dimZ];
    int[] usedValues = new int[dimX * dimY * dimZ];
    Array.Fill(usedValues, -1); //заполняем заведомо недостижимыми значениями
    int iterationIndex = 0;
    Random random = new Random();
    for (int i = 0; i < dimX; i++)
    for (int j = 0; j < dimY; j++)
    for (int k = 0; k < dimZ; k++) 
    {
        int pretenderValue = random.Next(MAXV);
        if (Array.IndexOf(usedValues, pretenderValue) == -1)
        {
            usedValues[iterationIndex++] = pretenderValue;
            resultArray[i, j, k] = pretenderValue;
        }
    }
    return resultArray;
}
 
static void Display3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
    for (int k = 0; k < arr.GetLength(2); k++)
    { 
        Console.WriteLine($" {arr[i, j, k]:d} ({i:d},{j:d},{k:d}) ");
    }
}