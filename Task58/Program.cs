// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20 
// 15 18

int[,] array = FillMatrix(4, 4);
int[,] array2 = FillMatrix(4, 4);
PrintMatrix(array);
System.Console.WriteLine();
PrintMatrix(array2);
System.Console.WriteLine();
PrintMatrix(MultiplyMatrix(array, array2));

int[,] MultiplyMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] multiplyMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < multiplyMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiplyMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    multiplyMatrix[i, j] += matrix[i, k] * matrix2[k, j];
                }
            }
        }
    return multiplyMatrix;
}

int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 6);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
