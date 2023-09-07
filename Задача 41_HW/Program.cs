/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void CountPos(int m)
{
    int count = 0;
    for (int i = 1; i <= m; i++)
    {
        Console.Write($"Введи число {i}: ");
        if (int.Parse(Console.ReadLine()!) > 0) count++;
    }
    System.Console.WriteLine($"Числел больше 0: {count}");
}

int m = InputNum("Введи число M: ");
CountPos(m);
