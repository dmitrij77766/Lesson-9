// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// Console.WriteLine("Enter number N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(N, 1));

// string PrintNumbers(int start, int end){
//     if(start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start - 1 , end ));
// }

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Enter number M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter number N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Summ numbers from {M} to {N} = {CountNaturalSum(M, N)}");

// int CountNaturalSum(int M, int N)
// {
//     if (M == N)
//         return N;
//     return N + CountNaturalSum(M, N - 1);
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Enter number M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A({M}, {N}) = {Akkerman(M, N)}");

int Akkerman(int M, int N)
{
    if (M == 0)
        return N + 1;
    if (M > 0 && N == 0)
        return Akkerman(M - 1, 1);
    else
        return Akkerman(M - 1, Akkerman(M, N - 1));
}

