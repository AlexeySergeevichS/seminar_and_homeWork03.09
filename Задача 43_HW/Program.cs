/* Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
double InputNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

void Koord(double k1, double b1, double k2, double b2)
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых({x};{y})");
    }
    else if (b1 != b2) Console.WriteLine("Прямые не пересекаются");
    else Console.WriteLine("Прямые совпадают");
}

double b1 = InputNum("Введи b1: ");
double k1 = InputNum("Введи k1: ");
double b2 = InputNum("Введи b2: ");
double k2 = InputNum("Введи k2: ");
Koord(k1, b1, k2, b2);