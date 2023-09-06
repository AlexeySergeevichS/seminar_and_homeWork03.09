/* С помощью ряда Нилаканта (Google в помощь) вычислить значение числа пи. 
Решение должно быть оформлено в функцию. Функция должна принимать точность - 
количество знаков после запятой, сколько указал пользователь. 
Точность расчета не должна сравниваться с уже известным значением числа, 
то есть цикл останавливается не потому, что Вы точно знаете, что в сотых будет ,14. 
Вы этого не знаете. Программа должна сама оценить, когда точность достигнута. */
using System.Runtime.CompilerServices;

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double ReturnPi(int round)
{
    double numPi = 3.0;
    double numPiNext = 3.0;
    ulong i = 1;
    sbyte k = 1;
    uint count = 1;
    double accuracy=Math.Pow(10, -round);
    double diff =Math.Abs(numPiNext - numPi);
    while (true)
    {
        Console.Write($"Итерация {count}, пи(текущ)={numPi}, ");
        numPi += NilPi(i, k);
        diff=Math.Abs(numPiNext - numPi);
        Console.WriteLine($"пи(след)={numPi} точность={accuracy}, текущая разница={diff}");
        if (diff < accuracy) return numPi;
        numPiNext = numPi;
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
Console.WriteLine($"Пи = {Math.Round(numPi)}");
