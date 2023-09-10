/*поменять строки и столбцы (только если массив квадратный) */

int[,] GetRandom2DArray(int rowNumber, int min, int max)//создаёт двумерный массив
{
    int[,] result = new int[rowNumber, rowNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < rowNumber; j++)
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

int [,] ChangeStringsAndColumns(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
          temp = matrix[i, j];
          matrix[i, j] = matrix[j, i];
          matrix[j, i] = temp;  
        }
    }
    return matrix;
}

int[,] userMatrix = GetRandom2DArray(5, 0, 10);
Print2DArray(userMatrix);
Print2DArray(ChangeStringsAndColumns(userMatrix));