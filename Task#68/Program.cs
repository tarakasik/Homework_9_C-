//// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// A(0,n) = n+1
// A(m,0) = A(m-1,1)
// A(m,n) = A(m-1,A(m,n-1))

Console.Clear();
int Accerman(int m, int n)
{
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return Accerman(1, n - 1);
    return Accerman(Accerman(m - 1, n), n - 1);
}

Console.Write("Введите M: ");
int numberM = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите N: ");
int numberN = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(Accerman(numberM, numberN));