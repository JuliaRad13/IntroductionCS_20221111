// Сортировка выбором

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

void SelectSort(int[] a, out int count)
{
    count=0;
    int im;
    for (int i = 0; i < a.Length; i++)
    {
        im=i;
        for (int j = i+1; j < a.Length; j++) 
        {
            if (a[im]>a[j]) im=j;
            count++;
        }
        Swap(ref a[i], ref a[im]);
        
    }
    
}

int[] a=RandomIntArray(5,0,10);
Print(a);
int count=0;
SelectSort(a, out count);
System.Console.WriteLine();
Print(a);
System.Console.WriteLine();
System.Console.WriteLine(count);