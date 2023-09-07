/* Задача 40:
 Напишите программу, которая принимает на вход три числа и
  проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон. */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool CheckTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
}

int a = InputNum("Введи длину стороны A:");
int b = InputNum("Введи длину стороны B:");
int c = InputNum("Введи длину стороны C:");
bool res = CheckTriangle(a, b, c);
Console.WriteLine(res?"Да":"Нет");