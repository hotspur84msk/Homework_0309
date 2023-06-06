// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное цисло: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное цисло: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    (m, n) = (n, m);
}


int SumElements(int start, int end)
{
    if(end == start)
        return start;
    else
    {
        return start + SumElements(start +1, end);
    }
}

Console.WriteLine(SumElements(m, n));