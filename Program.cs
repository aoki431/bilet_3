using System;

class Program
{
    static void Main()
    {
int x, y;
Console.Write("Введите значение x: ");
x = Convert.ToInt32(Console.ReadLine());
y = 5 * x + 20;
Console.WriteLine("Значение выражения y *= 5*x + 20 равно: \n" +y*2);
    }
}