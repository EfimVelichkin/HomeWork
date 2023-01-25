Console.Write("Введите количество чисел ");
int val = Convert.ToInt32(Console.ReadLine());
int[] M = new int [val];
int j = 0;
for (int i = 0; i < M.Length; i++) {
    Console.Write($"Число №{i+1} = ");
    int value = Convert.ToInt32(Console.ReadLine());
    if (value > 0) {
        j++;
    }
}
Console.WriteLine($"{j} - количество положительных чисел");