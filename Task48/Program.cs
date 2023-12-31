﻿/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
Aₘₙ = m+n. Выведите полученный массив на экран*/
int[,] Get2DArray(int m, int n)//создаёт двумерный массив
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j; //выводит числа по порядку
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
int[,] arr = Get2DArray(5, 5);
Print2DArray(arr);