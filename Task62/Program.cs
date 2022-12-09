// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] array = FillMatrixSpiral(4, 4);
PrintMatrix(array);


int[,] FillMatrixSpiral(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    int i = 0;
    int j = 0;
    int count = 0;
    while (j < matrix.GetLength(1))
    {
        matrix[i, j] = j + 1;
        j++;
        count = j;
    }
    j = matrix.GetLength(0) - 1;
    i++;
    count++;
    while (i < matrix.GetLength(0))
    {
        matrix[i, j] = count;
        count++;
        i++;
    }
    i--;
    j--;

    while (j >= 0)
    {
        matrix[i, j] = count;
        count++;
        j--;
    }
    j++;
    i--;
    while (i >= 1)
    {
        matrix[i, j] = count;
        count++;
        i--;
    }
    i++;
    j++;
    while (j < matrix.GetLength(0) - 1)
    {
        matrix[i, j] = count;
        count++;
        j++;
    }
    i++;
    j--;
    while (i < matrix.GetLength(0) - 1)
    {
        matrix[i, j] = count;
        count++;
        i++;
    }
    i--;
    j--;
    while (j < matrix.GetLength(0) - 2)
    {
        matrix[i, j] = count;
        count++;
        j++;
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
