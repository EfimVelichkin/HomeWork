Console.Write("Введите количество строк ");
int raw = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int col = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [raw,col];
Random rnd = new Random();
Console.Write($"Выбрать диапозон целых чисел от ");
int Fst = Convert.ToInt32(Console.ReadLine());
Console.Write("До ");
int Fnl = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < raw; i++) {
    for (int j = 0; j < col; j++) {
        arr[i,j] = rnd.Next(Fst,Fnl);
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("------------------------------");
for (int k = 0; k < raw; k++) {
    for (int i = 0; i < col; i++) {
        for (int j = col - 1; j > i; j--) {
            if (arr[k,j] < arr[k,j-1]) {
                int max = arr[k,j];
                arr[k,j] = arr[k,j-1];
                arr[k,j-1] = max;
            }
        }
        Console.Write($"{arr[k,i]} ");
    }
    System.Console.WriteLine();
}
