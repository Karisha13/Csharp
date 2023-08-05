Console.WriteLine("Введи два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int kvadrat = number1 * number1;
if(number2 == kvadrat)
{
    Console.WriteLine($"Число {number2} является квадратом {number1}");
}
else
{
    Console.WriteLine($"Число {number2} не является квадратом {number1}");
}