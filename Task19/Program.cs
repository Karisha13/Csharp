/* Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
System.Console.WriteLine("Введи пятизначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int num = number1;
if(number1 < 10000 && number1 > 99999)
{
    System.Console.WriteLine("Число не пятизначное.");
}
int digit = 0;
int number2 = 0;
while (num > 0)
{
    digit = num % 10;
    number2 = number2 * 10 + digit;
    num = num / 10;
}

/* System.Console.WriteLine(number2); */
if (number1 == number2)
{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}



