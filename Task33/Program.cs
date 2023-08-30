/*программа определяет присутствует ли заданное число в массиве*/
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

System.Console.WriteLine("Введи размер массива, минимальное и максимальное значение, число, которое нужно найти");
int arrayL = Convert.ToInt32(Console.ReadLine());//длина массива
int min = Convert.ToInt32(Console.ReadLine());//минимальное значение
int max = Convert.ToInt32(Console.ReadLine());//максимальное значение
int number = Convert.ToInt32(Console.ReadLine());//цифра которую нужно найти

int[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);

bool FindUserNumber(int[] array, int number)
{
    bool number1 = false;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i] == number)
        {
            number1 = true;
        }
    }
    return number1;
}

FindUserNumber(userArray, number);
System.Console.WriteLine();
bool number1 = FindUserNumber(userArray, number);
System.Console.WriteLine(number1);