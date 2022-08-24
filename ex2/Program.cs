// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, больше первого");
int N = Convert.ToInt32(Console.ReadLine());

int SumRec(int M, int N)
{
    if (N == M) return M;
    else return N + SumRec(M, N - 1);
}

Console.WriteLine($"{SumRec(M, N)}");
