/*не используя рекурсию вывести первые N чисел фибоначчи.
 если N = 5 -> 0 1 1 2 3, N = 3 -> 0 1 1.
*/ 
System.Console.Write("Введи число ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int [a];

void Fibonacci(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    System.Console.Write($"[{array[0]} {array[1] + " "}");
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("]");
}

Fibonacci(array);