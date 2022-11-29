// Пузырьковая сортировка

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

void BubbleSort(int[] a)// если добавить out int count(сколько раз обработается массив)
{
    // count=0;
    for (int i = 0; i <a.Length; i++)
        for (int j = 0; j <a.Length-1; j++)// a.Length-1-i добавить i для уменьшения сравнений
       // {
            if (a[j]>a[j+1])// сравнить элементы, сортируем
                Swap(ref a[j],ref a[j+1]);// меняем местами
           // count++;
        //}   
}

int[] a=RandomIntArray(10,0,10);
Print(a);
BubbleSort(a);
System.Console.WriteLine();
Print(a);