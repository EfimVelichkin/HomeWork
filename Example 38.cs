Console.Write("Количество рандомных чисел: ");
int val = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[val];
Random rnd = new Random();
int max = 0;
int min = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next();
    System.Console.WriteLine($"{arr[i]} рандомное число");
}
 
min = arr[0];
max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
       if (arr[i] < min)
            min = arr[i];
       if (arr[i] > max)
            max = arr[i];
}
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");
System.Console.WriteLine($"{max - min} итоговое число");
