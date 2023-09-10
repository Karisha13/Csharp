/*программа принимает двумерный массив и меняет местами первую и последнюю строку*/

int[,] Get2DArray(int rows, int cols, int min, int max)//создаёт двумерный массив
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
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] ResultArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int temp = 0;
    for (int i = 0; i < cols; i++)
    {
        temp = array[0, i];
        array[0, i] = array[rows-1, i];
        array[rows-1, i] = temp;
    }
    return array;
}

int[,] arr = Get2DArray(4, 4, 0, 10);
Print2DArray(arr);
System.Console.WriteLine();
int[,] arr2 = ResultArray(arr);
Print2DArray(arr2);