 //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является
 // ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введи число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8 && number > 5)
{
    Console.WriteLine("Да");
}

if (number < 6 && number > 0)
{
    Console.WriteLine("Нет");
}

if (number < 1 && number > 7)
{
    Console.WriteLine("Такого дня нет");
}
