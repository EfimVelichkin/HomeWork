Console.Write("Введите число b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());
if ((k1 == k2) && (b1 == b2)) {
    Console.WriteLine("Прямые совпадают");
}
else {
    if (k1 == k2) {
    Console.WriteLine("Прямые параллельные");
    }
else {
        double x = (b2-b1)/(k1-k2);
        double y = k1 * x + b1;
        Console.WriteLine($"{x};{y}");
    }
}