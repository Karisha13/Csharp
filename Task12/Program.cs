Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 % number2 == 0)
{
    Console.WriteLine($"Число {number1} кратно {number2}");
}
else
{
    int number3 = number1 % number2;
    Console.WriteLine($"Остаток равен {number3}");
}