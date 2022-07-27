//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.


using System;
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");

string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);

int[,] arr = GetArray(m, n);
PrintArray(arr);

WriteLine();

int[,] position = new int[1, 2];
position = MinNumberArray(arr, position);
PrintArray(position);

WriteLine();

int[,] ArrayNew = DeleteLinesCoolArray(arr, position);
PrintArray(ArrayNew);

int[,] MinNumberArray(int[,] arr, int[,] position)
{
    int min = arr[0, 0];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] <= min)
            {
                position[0, 0] = i;
                position[0, 1] = j;
                min = arr[i, j];
            }
        }
    }
    WriteLine($"Мин элемент: {min}");
    return position;
}

int[,] DeleteLinesCoolArray(int[,] arr, int[,] position)
{
    int[,] ArrayNewSize = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int s = 0;
    int z = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (position[0, 0] != i && position[0, 1] != j)
            {
                ArrayNewSize[s, z] = arr[i, j];
                z++;
            }
        }
        z = 0;
        if (position[0, 0] != i)
        {
            s++;
        }
    }
    return ArrayNewSize;
}


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10, 100);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}