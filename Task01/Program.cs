Console.WriteLine("Введите числа а и б:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.WriteLine("=> ДА");
}
else
{
    Console.WriteLine("=> НЕТ");
} 