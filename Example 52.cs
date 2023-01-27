Console.Write("Количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
float[,] arr = new float[m, n];
Random random = new Random();
float Mid_Num = 0;
float NUM_C = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = random.Next(1, 100);
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}
for (int j = 0; j < n; j++) {
    for (int i = 0; i < m; i++) {
        NUM_C = NUM_C + arr
    [i, j];
        Mid_Num = NUM_C / n;
    }
    Console.Write($"{Mid_Num}-столбец№{j+1} ");
}