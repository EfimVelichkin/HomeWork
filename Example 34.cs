Console.Write("Количество рандомных чисел: ");
int val = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[val];
    Random rnd = new Random();
    int j = 0;
 for(int i = 0;i<arr.Length;i++) {
   arr[i] = rnd.Next(99,1000);
        if (arr[i] % 2 == 0) {
            j++;
        }
    System.Console.WriteLine($"{arr[i]} = Рандомка");
 }

Console.WriteLine(j);