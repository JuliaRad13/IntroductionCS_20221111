// 38. В одномерном массиве из 123 чисел 
// найти количество элементов из отрезка [10,99]

/*
int[] RandomIntArray(int size) 
{
    int[] a=new int[size];
    Random random=new Random();
    for (int i = 0; i < a.Length; i++)
        a[i]=random.Next(-50, 150);
    return a;
}
int Count(int[] a)
{
    int count=0;
    for (int i = 0; i < a.Length; i++)
        if (a[i] > 10 && a[i] < 99) count++; 
    return count;    
}
void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i],5}"); 
}
int[] a=RandomIntArray(123);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Колличество элементов из отрезка [10.99] равно {Count(a)}");
*/

// Создали массив
int N=5;
int[] a=new int[N];
// Заполнили массив
Random random=new Random();
for (int i = 0; i < a.Length; i++)
     a[i]=random.Next(0,200);
for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i], 5}");
// Обработка массива
// 1 способ
int count=0;
for (int i = 0; i < a.Length; i++)
     if(a[i]>=10 && a[i]<=99)
         count++;

// foreach // коллекция элементов в массиве
// 2 способ
count=0;
foreach (int el in a)
     if(el>=10 && el<=99)
         count++;
System.Console.WriteLine();
System.Console.WriteLine(count);