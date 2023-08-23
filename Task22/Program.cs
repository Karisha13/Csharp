// Программа на вход принимает число (N) и выдаёт таблицу квадратов чисел от 1 до N
System.Console.WriteLine("Введи число");
int numberN = Convert.ToInt32(Console.ReadLine());
double result = 0;
if(numberN < 0)
{
    numberN = numberN * (-1);
}
for (int i = 1; i <= numberN; i++)
{
    result = Math.Pow(i,2);
    System.Console.WriteLine(result);
}