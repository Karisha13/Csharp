// Напишите программу, которая выводит случайное трёхзначное число и 
//удаляет вторую цифру этого числа.


int randomNumber = new Random().Next(100, 1000);
int numberOne = (randomNumber / 100) *10;
int numberTwo = randomNumber % 10;
int Result = numberOne + numberTwo;
Console.WriteLine (randomNumber);
Console.WriteLine ($" Число {randomNumber}  Результат {Result}");