/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и nn.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int ReadInt(string text)
{
    Console.Write(text + " ");
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int AkkermanFn(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFn(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFn(m - 1, AkkermanFn(m, n - 1));
    return 0;
}

Console.WriteLine("A(m,n) = " + AkkermanFn(ReadInt("Введите неотрицательное значение m:"), 
                                           ReadInt("Введите неотрицательное значение n:")));
                                         