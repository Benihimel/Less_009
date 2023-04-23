// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumb(int m, int n)
{
    if (m == n) return n;
    else return m + SumNumb(m + 1, n);

}
Console.Write($"{SumNumb(1, 15)}");

// SumNumb(1, 6);

