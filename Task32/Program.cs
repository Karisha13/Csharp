/*программа заменяет положительные элементы массива на отрицательные и наоборот*/
Console.Clear();

int[] GetRandomArray(int arrayLenght1, int start, int end)//создаёт массив
{
    int[] array = new int[arrayLenght1];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int [] arrayToPrint)//заполняет массив рандомными числами
{
    System.Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
      System.Console.Write(arrayToPrint[i]);
      if (i < arrayToPrint.Length - 1)
      {
        System.Console.Write(", ");
      }  
    }
    System.Console.Write("]");
}


System.Console.WriteLine("Введи число");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(arrayL, min , max);
PrintArray(userArray);

int[] ChangeSignArray(int[] array)//меняет знак на противоположный
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
System.Console.WriteLine();
PrintArray(ChangeSignArray(userArray));