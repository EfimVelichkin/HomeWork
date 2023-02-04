static int printNatural(int N,int A)
{
    if (N < 1)
	{
	    return A;
	}
Console.Write(N + " ");
N--;
return printNatural(N,A);
}
    
Console.Write("Сколько чисел вы хотите вывести: ");
int N= Convert.ToInt32(Console.ReadLine());
printNatural(N,1);