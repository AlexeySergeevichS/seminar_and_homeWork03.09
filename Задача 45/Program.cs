/* Задача 45:
 Напишите программу, которая будет создавать копию 
 заданного массива с помощью поэлементного копирования. */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[] CreateArray(int size)
{
    return new int[size];
}
void FillArray(int[] arr, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int[] CopyArray(int[] arr)
{
    int[] res = CreateArray(arr.Length);
    for (int i = 0; i < arr.Length; i++)
    {
        res[i] = arr[i];
    }
    return res;
}
int size = InputNum("Введи длину массива: ");
int minValue = InputNum("Введи мин элемент: ");
int maxValue = InputNum("Введи макс элемент: ");
int[] array = CreateArray(size);
FillArray(array, minValue, maxValue);
PrintArray(array);
int[] arrayCopy = CopyArray(array);
FillArray(array, minValue, maxValue);
PrintArray(array);
PrintArray(arrayCopy);