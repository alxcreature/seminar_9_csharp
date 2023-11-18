/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int ReadInt(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNatural(int N)
{
    // int [] array = new int [N];
    // for (int i = N-1; i >= 0; i--) array[i]=N-i;
    // Console.WriteLine($"{N} -> {String.Join(", ", array)}");
    if (N<1) return;
    if (N==1) Console.Write(N);
    else Console.Write(N + ", ");
    PrintNatural(N-1);
}

PrintNatural(ReadInt("Введите значение N:"));