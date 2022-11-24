// Массив из случайных чисел

/*int[] RandomIntArray(int size) 
{
    int[] a=new int[size];
    Random random=new Random();
    for (int i = 0; i < size; i++)
        a[i]=random.Next(0,100);
    return a;
}
void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],5}");   
}
int[] m=RandomIntArray(10);
Print(m);
*/

 // использовать этот вариант
int[] RandomIntArray(int size, int min, int max) // или int min=0, int max=100
{
    int[] a=new int[size];
    Random random=new Random();
    for (int i = 0; i < size; i++)
        a[i]=random.Next(min,max);
    return a;
}
void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],5}");   
}
int[] m=RandomIntArray(10,-100,100);// то сюда -100,100 не выводить
Print(m);

/*
void RandomIntArray(ref int [] a, int size, int min, int max) 
{
    a=new int[size];
    Random random=new Random();
    for (int i = 0; i < size; i++)
        a[i]=random.Next(min,max);
}
void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],5}");   
}
int[] m=new int[3];
RandomIntArray(ref m);
Print(m);
*/