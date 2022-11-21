// Алгоритм Евклида

int k=0;
int GCD(int a, int b)
{
    while (a!=b)
    {
        //k++;
        if (a>b)
            a=a-b;
        else
            b=b-a;
    }
    return a;     
}
System.Console.WriteLine(GCD(15,30));
System.Console.WriteLine(k);

System.Console.WriteLine(QuickGCD(15,300));
System.Console.WriteLine(k);

int QuickGCD(int a, int b)
{
    while (a!=0 && b!=0)
    {
        k++;
        if (a>b)
            a=a%b;
        else
            b=b%a;
    }
    return a+b;     
}
