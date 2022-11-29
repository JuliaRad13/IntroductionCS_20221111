// 38. В одномерном массиве из 123 чисел 
// найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int N, int min, int max) 
{
    int[] a=new int[N];
    Random random=new Random();
    for (int i = 0; i < a.Length; i++)
        a[i]=random.Next(0, 200);
    return a;
}
void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],5}"); 
}
void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}
void Reverse(int[] a)
{
    for (int i = 0; i < a.Length/2; i++)
    Swap(ref a[i], ref a[a.Length-1-i]);
}
int M=10;
int[] a=RandomIntArray(M,0,200);
Print(a);
Reverse(a);
//a=a.Reverse().ToArray(); или с осторожностью
System.Console.WriteLine();
Print(a);
