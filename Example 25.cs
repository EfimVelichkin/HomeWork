Console.Write("Введите любое число ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа ");
int Deg = Convert.ToInt32(Console.ReadLine());
int N = 1;

for (int i = 0; i < Deg; i++)
{
    N = N * Num;
}

Console.WriteLine($"N = {N}");