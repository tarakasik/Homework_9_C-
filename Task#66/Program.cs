// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Input number M:");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Input number N:");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int sum(int start, int end)
{
    if (start == end) return end;
    {
        return end + sum(start, end - 1);
    }

}
Console.WriteLine("The sum of all numbers from M to N - " + sum(M, N));
