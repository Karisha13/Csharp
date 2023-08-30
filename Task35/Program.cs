/*задайте массив из 123 случайных чисел. 
Найдите количество элементов массива, значение которых лежит в отрезке 10 99*/
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

int QuantityNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 && array[i] >=10)
        {
            count++;
        }
    }
    return count;
}

System.Console.WriteLine("Введи размер массива, минимальное и максимальное значение");
int arrayL = Convert.ToInt32(Console.ReadLine());//длина массива
int min = Convert.ToInt32(Console.ReadLine());//минимальное значение
int max = Convert.ToInt32(Console.ReadLine());//максимальное значение

int[] userArray = GetRandomArray(arrayL, min , max);
PrintArray(userArray);
int kolvo = QuantityNumber(userArray);
System.Console.WriteLine();
System.Console.WriteLine(kolvo);