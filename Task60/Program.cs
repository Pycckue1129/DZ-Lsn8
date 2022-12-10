// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = FillMatrix(2, 2, 2);
PrintMatrix(array);
ArrayCheck(array);
System.Console.WriteLine();
PrintMatrix(array);

void ArrayCheck(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                for (int i1 = 0; i1 < array.GetLength(0); i1++)
                {
                    for (int j1 = 0; j1 < array.GetLength(1); j1++)
                    {
                        for (int k1 = 0; k1 < array.GetLength(2); k1++)
                        {
                            if(array[i, j, k] == array[i1, j1, k1])
                            {
                                if(i == i1 && j == j1 && k == k1)
                                {

                                }
                                else
                                {
                                array[i, j, k] = new Random().Next(10, 20);
                                ArrayCheck(array);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

int[,,] FillMatrix(int rows, int colums, int dept)
{
    int[,,] matrix = new int[rows, colums, dept];
    Random rnd = new Random();
    // int step = 10;
    // int step2 = 20;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int num = rnd.Next(10, 20);
                matrix[i, j, k] = num;
                // step += 10;
                // step2 += 10;
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
    }
}
