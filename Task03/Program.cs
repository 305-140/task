// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер дня недели:");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if (numberWeek == 1) 
{
    Console.WriteLine("Понедельник");
}
else if (numberWeek == 2) 
{
    Console.WriteLine("Вторник");
}
else if (numberWeek == 3) 
{
   Console.WriteLine("Среда");
}
else if (numberWeek == 4) 
{
    Console.WriteLine("Четверг");
}
else if (numberWeek == 5) 
{
   Console.WriteLine("Пятница");
}
else if (numberWeek == 6) 
{
    Console.WriteLine("Суббота");
}
else if (numberWeek == 7) 
{
    Console.WriteLine("Воскресенье");
}
else  
{
    Console.WriteLine("Такого дня не существует!");
}
