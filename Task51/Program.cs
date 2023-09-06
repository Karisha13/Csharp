﻿/**Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д.*/

int[,] Get2DArray(int cols, int rows, int min, int max)//создаёт двумерный массив
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max);//выводит рандомные числа
        }
    }
    return array;
}

void Print2DArray(int[,] arrayToPrint)//выводит индекс (с16-35)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        System.Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int SumDiagonalArray(int[,] array)
{
    int result = 0;
    int cols = array.GetLength(0);
    int rows= array.GetLength(1);
    int size = cols;
    if(cols > rows) size = rows;
    for (int i = 0; i < size; i++)
    {
        result = result + array[i,i];
    }
    return result;
}

int[,] arr = Get2DArray(5, 10, 0, 10);
Print2DArray(arr);
System.Console.WriteLine(SumDiagonalArray(arr));