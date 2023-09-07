/* Задача 42:
 Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string DecToBinar(int num)
{
    string res = "";
    while (num != 0)
    {
        res = $"{num % 2}" + res;
        num /= 2;
    }
    return res;
}
int num = InputNum("Введи целое число: ");
string res = DecToBinar(num);
Console.WriteLine($"{num} = {res}");