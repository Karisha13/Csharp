/*пользоваетль вводит числа, а программа показывает сколько из них больше 0*/

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}