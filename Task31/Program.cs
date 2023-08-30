// программа выводит массив из 12 случайных чисел от -9 до 9, 
//и выводит сумму их отрицательных и положительнвх чисел 
//(первое число - размер массиваб второе - начало массиваб третье - конец массива)
Console.Clear();
int[] GetRandomArray(int arrayLenght1, int start, int end)
{
    int[] array = new int[arrayLenght1];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int [] arrayToPrint)
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

void GetSum(int[] array)
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sumP = sumP + array[i];
        }
        else
        {
            sumN = sumN + array[i];
        }
    }
    System.Console.WriteLine($"Сумма положительных = {sumP}, сумма отрицательных =  {sumN}");
}
System.Console.WriteLine("Введи число");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(arrayL, min , max);
PrintArray(userArray);
System.Console.WriteLine();
//PrintArray(GetRandomArray(arrayL , min, max));
GetSum(userArray);