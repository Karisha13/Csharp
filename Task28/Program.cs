/* программа на вход принимает число х и выдаёт производное от 1 до х*/
System.Console.WriteLine("Введи число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int ProductOfNumber(int number)
{
    int product = 1;
    while (number != 0)
    {
        product *= number;
        number--;
    }
    return product;
}
System.Console.WriteLine(ProductOfNumber(userNumber));