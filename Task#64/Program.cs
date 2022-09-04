// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Input M : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N : ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (M <= 0 || N <= 0)
{
    Console.Write("The input number is not natural");
}
else
{
    Console.WriteLine("All natural numbers from M to N: ");

    {
        int range = 0;
        while (M <= N)
        {
            M++;
            range = M;
            Console.Write(" ");
            Console.Write($"{range - 1}");
        }
    }
}