Console.WriteLine("Введи три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    Console.WriteLine("Максимальное: " + number1);
}

else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine("Максимальное: " + number2);
}

else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine("Максимальное: " + number3);
}