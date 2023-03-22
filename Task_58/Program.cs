// Задача 58. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц
Console.Clear();
const int ROWS = 3;
const int COLS = 2;
const int MAXVALUE = 10; //Максимальное значение в ячейке матрицы
 
int[,] matrixA = CreateMatrix(ROWS, COLS);
int[,] matrixB = CreateMatrix(COLS, ROWS);
int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
 
Console.WriteLine("Матрица А");
PrintMatrix(matrixA);
Console.WriteLine("Матрица Б");
PrintMatrix(matrixB);
Console.WriteLine("Результируюящая матрица");
PrintMatrix(matrixC);

 
static int[,] CreateMatrix(int rows, int cols)
{
    int[,] resultMatrix = new int[rows, cols];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++) resultMatrix[i, j] = random.Next(MAXVALUE);
    return resultMatrix;
}
 
static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j=0;j<matrix.GetLength(1); j++)
            Console.Write($" {matrix[i, j]:d2} ");
        Console.WriteLine();
    }
}
 
static int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)
            resultMatrix[i,j] += matrixA[i, k] * matrixB[k,j];
    }
    return resultMatrix;
}