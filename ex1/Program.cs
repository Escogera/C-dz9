// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, больше первого");
int N = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int M, int N)
{
    if (M <= N) return NumbersRec(M, N - 1) + $"{N}, ";
    else return String.Empty;
}
Console.WriteLine($"{NumbersRec(M, N)}");