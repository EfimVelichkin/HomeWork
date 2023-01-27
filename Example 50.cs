Console.Write("Введите количестов строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
}
 Console.Write("Введите координаты по строке ");
 int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по столбцу ");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a == m && b == n || a < m && b < n)
 Console.WriteLine(array[a,b]);
 else
 {
 Console.WriteLine("Такого числа нет");
 }