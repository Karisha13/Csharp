// программа переворачивает массив

Console.Clear();

int[] userArray = FillArray(6, 0, 11);

int[] FillArray(int arrayLenght1, int start, int end)//создаёт массив
{
    int[] array = new int[arrayLenght1];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int [] arrayForPrint)//заполняет массив рандомными числами
{
    System.Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
      System.Console.Write(arrayForPrint[i]);
      if (i < arrayForPrint.Length - 1)
      {
        System.Console.Write(", ");
      }  
    }
    System.Console.Write("]");
}

int[] TurnArray(int[] arrayForTurn)//разворачивает массив
{
    int temp = 0;
    for (int i = 0; i < arrayForTurn.Length / 2; i++)
    {
        temp = arrayForTurn[i];
        arrayForTurn[i] = arrayForTurn[arrayForTurn.Length - 1 - i];//arrayForTurn[arrayForTurn.Length - 1    последний элемент массива
        arrayForTurn[arrayForTurn.Length - 1 - i] = temp;
    }
    return arrayForTurn;
}

Console.ForegroundColor=ConsoleColor.Blue;//меняет цвет
PrintArray(userArray);
int[] turnArray = TurnArray(userArray);
Console.ForegroundColor=ConsoleColor.Green;//меняет цвет
PrintArray(turnArray);
Console.ForegroundColor=ConsoleColor.White;