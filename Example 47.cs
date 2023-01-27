Console.Write("Количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] a = new double[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = random.NextDouble();
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine();
}
