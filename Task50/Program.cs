/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] Get2DArray(int rowNumber, int colNumber, int min, int max)//создаёт двумерный массив
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
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

void GetArrayElement(int[,] array, int row, int col)
{
    int rowSize = array.GetLength(0);
    int colSize = array.GetLength(1);
    if (row <= rowSize && col <= colSize) System.Console.WriteLine($"Значение элемента в [{row}] строке и [{col}] столбце => {array[row, col]}");
    else Console.WriteLine("Такого числа в массиве нет");
}

System.Console.Write("Укажите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] arr = Get2DArray(rows,cols, 1, 10);
Print2DArray(arr);

System.Console.Write("Укажите строку: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите столбец: ");
int col = Convert.ToInt32(Console.ReadLine());

GetArrayElement(arr, row, col);
