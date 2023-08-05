Console.WriteLine("Введи число");
int usernumber = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;


if (usernumber % (number1 * number2) == 0)
{
    Console.WriteLine($"Число {usernumber} кратно {number1} и {number2}");
}
else
{
    Console.WriteLine($"Число {usernumber} не кратно {number1} и {number2}");
}