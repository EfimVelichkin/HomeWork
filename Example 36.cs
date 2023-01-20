Console.Write("Количество рандомных чисел: ");
int val = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[val];
    Random rnd = new Random();
    int j = 0;
 for(int i = 0;i<arr.Length;i++) {
   arr[i] = rnd.Next();
        if (i % 2 == 0) {
            System.Console.Write($"{i} чётный индекс");
        }
        else {
            j = j + arr[i];
        }
    System.Console.WriteLine($" {arr[i]} = Рандомное число");
 }

Console.WriteLine($"{j} = сумма чисел с нечётным индексом");