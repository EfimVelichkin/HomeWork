Console.Write("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z ");
int z = Convert.ToInt32(Console.ReadLine());
int [, ,] arr = new int [x,y,z];
Console.Write("Введите диапазон чисел от ");
int Fst = Convert.ToInt32(Console.ReadLine());
Console.Write("До ");
int Fnl = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
Queue<int> que = new Queue<int>(Enumerable.Range(0, x * y * z));
for (int i = 0; i < x; i++) {
    int temp = 0;
    temp = rnd.Next(0, 9);
    for (int j = 0; j < y; j++) {
        for (int l = 0; l < z; l++) {
            if (l != arr.Length){
            arr[i,j,l] = rnd.Next(Fst,Fnl);
            arr[i,j,l] = que.Dequeue();
            Console.Write($"{arr[i,j,l]}-{i}{j}{l} ");
            }
        }
    }
    Console.WriteLine();
}