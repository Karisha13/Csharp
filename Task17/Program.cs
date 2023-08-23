// найти в какой четверти координаты
Console.WriteLine("Введи Х и Y вашей точки: ");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());
if(userX > 0 && userY > 0)
{
    Console.WriteLine($"Точка [{userX}:{userY}] находится в I Четверти");
}
else if(userX < 0 && userY > 0)
{
    Console.WriteLine($"Точка [{userX}:{userY}] находится в II Четверти");
}
else if(userX < 0 && userY < 0)
{
    Console.WriteLine($"Точка [{userX}:{userY}] находится в III Четверти");
}
else if(userX > 0 && userY < 0)
{
    Console.WriteLine($"Точка [{userX}:{userY}] находится в IV Четверти");
}