/* С помощью ряда Нилаканта (Google в помощь) вычислить значение числа пи. 
Решение должно быть оформлено в функцию. Функция должна принимать точность - 
количество знаков после запятой, сколько указал пользователь. 
Точность расчета не должна сравниваться с уже известным значением числа, 
то есть цикл останавливается не потому, что Вы точно знаете, что в сотых будет ,14. 
Вы этого не знаете. Программа должна сама оценить, когда точность достигнута. */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double ReturnPi(int round)
{
    double numPi = 3.0;
    double numPiR = 3.0;
    ulong i = 1;
    sbyte k = 1;
    uint count = 1;
    while (true)
    {
        Console.Write($"Итерация {count} пи(округ)={numPiR} ");
        numPiR = Math.Round(numPi, round);
        numPi += NilPi(i, k);
        Console.WriteLine($"пи={numPi}");
        if (numPiR == Math.Round(numPi, round)) return numPiR;
        numPiR = Math.Round(numPi, round);
        i += 2;
        k *= -1;
        count++;
    }

}
double NilPi(ulong i, sbyte k)
{
    return k * (4.0 / ((i + 1) * (i + 2) * (i + 3)));
}
int round = InputNum("Введи точность числа Пи: ");
double numPi = ReturnPi(round);
Console.WriteLine($"Пи = {numPi}");
