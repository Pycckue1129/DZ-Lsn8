// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = FillMatrix(2, 2, 2);
PrintMatrix(array);

int[,,] FillMatrix(int rows, int colums, int dept)
{
    int[,,] matrix = new int[rows, colums, dept];
    Random rnd = new Random();
    int step = 10;
    int step2 = 20;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                int num = rnd.Next(step, step2);
                matrix[i, j, k] = num;
                step += 10;
                step2 += 10;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[j, k, i]} ({j}, {k}, {i}) ");
            }
            Console.WriteLine();
        }
        // Console.WriteLine();
    }
}
