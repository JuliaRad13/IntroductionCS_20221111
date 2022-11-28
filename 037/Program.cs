// 37. Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int[] RandomIntArray(int size) 
{
    int[] a=new int[size];
    Random random=new Random();
    for (int i = 0; i < size; i++)
        a[i]=random.Next(100, 1000);
    return a;
}

int EvenPosition(int[] a)
{
    int even=0;
    int uneven=0;
    for (int i = 1; i < a.Length; i++)
        if (a[i] % 2 == 0) even++;
        else uneven++;
    return even;    
}   
void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],5}");   
}

int[] a=RandomIntArray(10);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел {EvenPosition(a)}, количество нечетных чисел {EvenPosition}");
