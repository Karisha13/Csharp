/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

double[,] GetRandom2DArray(int rowNumber, int colNumber, int min, int max)//создаёт двумерный массив
{
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = Math.Round((new Random().NextDouble() * (max - min) + min), 1);
        }
    }
    return result;
}
 
 void Print2DArray(double[,] arrayToPrint)//выводит индекс (с16-35)
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
double[,] randomArray = GetRandom2DArray(5, 5, -10, 10);
Print2DArray(randomArray);
