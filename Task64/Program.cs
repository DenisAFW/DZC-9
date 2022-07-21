// Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

int Numbers(int n)
{
    if (n/10 != 0) return Numbers(n / 10) + 1;
    else return 1;
}
Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Numbers(n));