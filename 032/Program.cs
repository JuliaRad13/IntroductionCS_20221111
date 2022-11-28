// 32. Задать массив из 8 целых элементов и вывести их на экран

int[] RandomIntArray(int size) 
{
    int[] a=new int[size];
    Random random=new Random();
    for (int i = 0; i < size; i++)
        a[i]=random.Next(1,100);
    return a;
}
void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],5}");   
}
int[] a=RandomIntArray(8);
Print(a);
System.Console.WriteLine();