/* Задача 44: 
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
string Fibonacci(int num)
{
    int f1 = 0;
    int f2 = 1;
    int f3 = 0;
    string res = $"{f1} ";
    if (num == 1) return res;
    else
    {
        res = res + $"{f2} ";
        for (int i = 3; i <= num; i++)
        {
            f3 = f1 + f2;
            res = res + $"{f3} ";
            f1 = f2;
            f2 = f3;
        }
    }
    return res;
}
int num = InputNum("Введи N: ");
string res = Fibonacci(num);
Console.WriteLine(res);