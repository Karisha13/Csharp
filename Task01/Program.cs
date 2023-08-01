Console.WriteLine("Введи два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("является");
}
else
{
    Console.WriteLine("не является");
}