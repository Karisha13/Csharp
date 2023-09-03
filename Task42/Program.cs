/*программа переобразовывает десетичное число в двоичное  3 = 11, 2 = 10, 45 = */

System.Console.Write("Введи число ");
int a = Convert.ToInt32(Console.ReadLine());

string Delenie(int a)
{
    string result = string.Empty;
    int temp = 0;
    for (int i = a; i > 0; i /= 2)
    {
        temp = i % 2;
        result = temp + result;
    }
    return result;
}

string b = Delenie(a);
System.Console.WriteLine(b);