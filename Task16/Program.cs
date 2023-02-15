// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите а b");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (Kvadrat(numberA,numberB)) Console.WriteLine(numberA +" "+ numberB +" -> да"); 
else Console.WriteLine(numberA +" "+ numberB+" -> нет"); 

bool Kvadrat(int num1, int num2)
{
    if ((num1 == num2*num2)||(num2 == num1*num1)) return true;
    else return false;
}