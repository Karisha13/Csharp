//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
/* System.Console.WriteLine("Введи координаты X1 и Y1, X2 и Y2");
int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());  
double S = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(S); */

System.Console.WriteLine("Введи координаты X1 и Y1, X2 и Y2");
int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());  
double S = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
Console.WriteLine(S);