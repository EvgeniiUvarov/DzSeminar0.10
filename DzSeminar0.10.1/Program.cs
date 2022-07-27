//Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.

using System;
using static System.Console;
Clear();

WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] pascalTreugol = new double[n+1, 2*n+1];

FillpascalTreugolcalTriangle(pascalTreugol);

// WriteLine();
// PrintArray(pascalTreugol);

transforPascalTreugol(pascalTreugol);

WriteLine();
PrintArray(pascalTreugol);

void transforPascalTreugol(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

void FillpascalTreugolcalTriangle(double[,] pascalTreugol)
{
  for (int s = 0; s < pascalTreugol.GetLength(0); s++)
  {
    pascalTreugol[s, 0] = 1;
  }
  for (int i = 1; i < pascalTreugol.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascalTreugol[i, j] = pascalTreugol[i - 1, j] + pascalTreugol[i - 1, j - 1];
    }
  }
}

void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Write($"{array[i, j]} ");
      }
      else Write("  ");
    }
    WriteLine();
  }
}

