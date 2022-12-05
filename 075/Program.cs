// 75.Написать программу вычисления функции Аккермана - 5*


int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0 && M > 0)
        return Akkerman(M - 1, 1);
    else return (Akkerman(M - 1, Akkerman(M, N - 1)));
}
System.Console.WriteLine(Akkerman(2,5));