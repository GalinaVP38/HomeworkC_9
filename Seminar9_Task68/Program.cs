// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetAcerman (int m, int n)
{
   if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return GetAcerman(m - 1, 1);
    }
    else
    {
        return (GetAcerman(m - 1, GetAcerman(m, n - 1)));
    } 
}

Console.WriteLine(GetAcerman(m, n));
