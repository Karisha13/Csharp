//программа принимает на вход число х и выдаёт сумму чисел от 1 до х
/* System.Console.WriteLine("Введи число");
int userNumber = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for(int i = 1; i <= userNumber; i++)
{
    sum += i;
}
System.Console.WriteLine(sum);
 */

System.Console.WriteLine("Введи число");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SumOfNumber(int number)
{
    int sum = 0;
    for(int i = 1; i <= userNumber; i++)
    {
    sum += i;
    }

    return sum;
}
System.Console.WriteLine($"Сумма цифр в до {userNumber} равна {SumOfNumber(userNumber)}");