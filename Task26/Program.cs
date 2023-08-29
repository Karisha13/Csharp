// программа на вход принимает число и выдаёт количество цифр в числе
System.Console.WriteLine("Введи число");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Quantity(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}
System.Console.WriteLine(Quantity(userNumber));