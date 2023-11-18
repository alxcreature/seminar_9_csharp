/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int ReadInt(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNaturalSum(int M, int N, int sum = 0)
{
    if (M < 1 || M > N) return;
    sum+=M;
    PrintNaturalSum(M + 1, N, sum);
    if (M == N) Console.WriteLine(sum);
}

PrintNaturalSum(ReadInt("Введите значение M:"), ReadInt("Введите значение N:"));