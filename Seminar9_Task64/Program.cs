// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
int M = 1;
int N = 5;

string NaturalNum (int M, int N)
{
    if (M<=N) return $"{M}" + NaturalNum(M+1, N);
    else return string.Empty;
}

Console.WriteLine(NaturalNum(M, N));
