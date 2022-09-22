// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите начальное число M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int numN = Convert.ToInt32(Console.ReadLine());


void GetNaturalSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов от M до N: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    GetNaturalSum(numM, numN, sum);
}

GetNaturalSum(numM, numN, 0);