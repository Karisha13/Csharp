/*программа создаёт копию заданного одномерного массива с помощью поэлементного копирование*/

int[] array = {1, 9, 3, 4, 5};

int[] CopyArray(int[] array)
{
    int[] arrayL = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayL[i] = array[i];
    }
    return arrayL;
}

int[] userArray = CopyArray(array);

void PrintArray(int[] arrayToPrint)
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
PrintArray(userArray);