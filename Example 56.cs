Console.Write("Введите количество строк ");
int raw = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int col = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [raw,col];
int [] min = new int [raw];
int minn = 0;
Console.Write("Введите диапазон чисел от ");
int Fst = Convert.ToInt32(Console.ReadLine());
Console.Write("До ");
int Fnl = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
for (int i = 0; i < raw; i++) {
    for (int j = 0; j < col; j++) {
    arr[i,j] = rnd.Next(Fst,Fnl);
    Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine(); 
}
Console.WriteLine("----------------------------------");
for (int i = 0; i < raw; i++) {
    for (int j = 0; j < col; j++) {
        min[i] += arr[i,j];
        }
    }

for (int i = 0; i < raw; i++) {
    Console.Write(min[i] + $" Строка №{i+1} ");
    minn = min.Min();
    if (min[i] == minn) {
        Console.WriteLine($"- {i+1} Наименьшая строка");
    }
}