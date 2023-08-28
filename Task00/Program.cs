/* Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number; 
Console.WriteLine(result); */

int number1 = Convert.ToInt32(Console.ReadLine());
int digit = 0;
//digit = number1 % 10;
//System.Console.WriteLine(digit);
 



  digit = number1 % 10;
    number1 = number1 / 10;
    number2 = number2 * 10;
    number2 = number2 + digit;
}
/* 
int number1 = Convert.ToInt32(Console.ReadLine());
number1 = number1 / 10;
System.Console.WriteLine(number1); */