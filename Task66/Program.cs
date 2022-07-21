// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.;

int SumOfNum(int m, int n)
{
    if (m < n)
    {
        return n + SumOfNum(m,n-1);
    }
    else return n;
}
Console.WriteLine("Input first number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfNum(m,n));