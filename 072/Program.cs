// 72. Показать натуральные числа от M до N, N и M заданы

double NaturalNumber(int M, int N)
{
    if (N <= M) return NaturalNumber(N+1, M);
else return NaturalNumber(M+1, N);
}
NaturalNumber(10, 1);