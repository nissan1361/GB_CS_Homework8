// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4

const int ROWS = 4;
const int COLS = 4;
 
int[,] array = GenerateMatrix(ROWS, COLS);
PrintArray(array);

static int FillPerimetr(int[,] array, int itrNo, int startValue)
{
    int upperRow = itrNo;
    int lowerRow = array.GetLength(0)-itrNo-1;
    int leftCol = itrNo;
    int rightCol = array.GetLength(1) - itrNo-1;
 
    for (int i = leftCol; i <= rightCol; i++) 
        array[upperRow, i] = startValue++; //проход по верху 
 
    for (int j = upperRow+1; j <= lowerRow; j++) 
        array[ j, rightCol] = startValue++; //проход по правой стенке
                                            
    for (int j = rightCol-1; j >= leftCol; j--) 
        array[ lowerRow, j] = startValue++; //проход по нижней стенке
 
    for (int j = lowerRow-1; j > upperRow; j--) 
        array[ j, leftCol] = startValue++; //проход по левой стенке
    
    return startValue;
}
 
static int[,] GenerateMatrix(int rows, int cols)
{
    int[,] resultArray = new int[rows, cols];
    int startValue = 0;
    int numbersOfIterations = (int) Math.Ceiling(Math.Min(rows, cols) / 2.0);
 
    for (int counter = 0; counter < numbersOfIterations; counter++)
    {
        startValue = FillPerimetr(resultArray, counter, startValue);
    }
 
    return resultArray;
}
 
static void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($" {arr[i, j]:d2} ");
        Console.WriteLine();
    }
}