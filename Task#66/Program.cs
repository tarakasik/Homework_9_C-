// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Input number M:");
int N = int.Parse(Console.ReadLine());
Console.Write("Input number N:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine(M,N);
string SumPrintNumbers(int start, int end)
{
    while(start<=end)start++;end--;
    // if(start == end)return start.ToString();
    return  SumPrintNumbers(start+start+end);
}