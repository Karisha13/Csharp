﻿/*программа принимает 3 числа и проверяет может ли 
существовать треугольник с сторонами такой длины.
*/ 
Console.Write("Введи длины сторон: ");

int[] FillUserArray()//сами создаём элементы массива
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

bool TriangleExistance(int[] array)
{

    if(array[0] + array[1] > array[2]
    && array[0] + array[2] > array[1]
    && array[1] + array[2] > array[0])
    {
        return true;
    }
    else
    {
        return false;
    }
    
}
int[] userArray = FillUserArray();
bool result = TriangleExistance(userArray);
System.Console.Write(result);