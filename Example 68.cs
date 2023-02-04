int Ack(int M, int N){
    if (M == 0){
        return N+1;
    }
    else if((M != 0) && (N == 0)){
        return Ack(M-1,1);
    }
    else{
        return Ack(M-1, Ack(M,N-1));
    }
}
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.Write(Ack(M,N));