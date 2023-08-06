
//Выводит чётные числа от 1 до N
Console.WriteLine("Введи число");

int number1 = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number1; i = i+2)
{
    Console.Write(i+" ");
}
