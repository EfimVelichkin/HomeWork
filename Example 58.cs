Console.Write("Введите количество строк для матрицы №1 ");
int raw1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для матрицы №1 ");
int col1 = Convert.ToInt32(Console.ReadLine());
int [,] arr1 = new int [raw1,col1];
Console.Write("Введите количество строк для матрицы №2 ");
int raw2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для матрицы №2 ");
int col2 = Convert.ToInt32(Console.ReadLine());
int [,] arr2 = new int [raw2,col2];
Console.Write("Введите диапозон чисел от ");
int Fst = Convert.ToInt32(Console.ReadLine());
Console.Write("До ");
int Fnl = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
Console.WriteLine("Матрица №1");
for (int i = 0; i < raw1; i++) {
    for (int j = 0; j < col1; j++) {
        arr1[i,j] = rnd.Next(Fst,Fnl);
        Console.Write(arr1[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Матрица №2");
for (int i = 0; i < raw2; i++) {
    for (int j = 0; j < col2; j++) {
        arr2[i,j] = rnd.Next(Fst,Fnl);
        Console.Write(arr2[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
if (arr1.GetLength(0) == arr2.GetLength(1)) {
var arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
for (int i = 0; i < arr3.GetLength(0); i++) {
    for (int j = 0; j < arr3.GetLength(1); j++) {
        arr3[i,j] = 0;
        for (int k = 0; k < arr1.GetLength(1); k++) {
            arr3[i,j] += arr1[i,k] * arr2[k,j];
            Console.Write(arr3[i,j] + " ");
        }
        Console.WriteLine();
    }
}
}
else {
    Console.Write("Создайте 2 матрицы где кол-во столбцов и строк будет одинаковое");
}