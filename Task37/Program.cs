/*найти произведение пар чисел в массиве, 
парой считаем первый и последний элемент, второй и предпоследний и тд.
результат запизать в новом массиве
*/ 
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

int[] ProdPar (int[] array)
{
    int[] array1 = new int[(array.Length) / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
       array1[i] = array[i] * array[array.Length-i-1]; 
    }
    return array1;
}

System.Console.WriteLine("Введи размер массива, минимальное и максимальное значение");
int arrayL = Convert.ToInt32(Console.ReadLine());//длина массива
int min = Convert.ToInt32(Console.ReadLine());//минимальное значение
int max = Convert.ToInt32(Console.ReadLine());//максимальное значение

int[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProdPar(userArray);
PrintArray(newArray);
