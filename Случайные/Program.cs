// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
//Также если убрать if и else выводить предпоследнюю цифру любого числа
Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=100 && number <1000) 
{
     int result1 = (number / 10);
     int result2 = (result1%10);
     Console.WriteLine(result2);
} 
else
{
     Console.WriteLine("Число не трёхзначное");
}




// выводит последнюю цифру любого числа
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result1 = (number / 10);
int result2 = (result1*10);
int result3 = (number - result2);
Console.WriteLine(result3);
