int Sum(int N, int  M){
    if (M == 0){                            //M = 0
        return N * (N+1) / 2;               
    }
    else if (N == 0){                       //N = 0
        return M * (M+1) / 2;
    }
    else if (N == M){                       //N = M
        return M;
    }
    else if (N > M){                        //N > M
        return N + Sum(M,N-1);
    }
    else{                                   //N < M
        return N + Sum(M,N+1);
    }
}
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine(Sum(M,N));
