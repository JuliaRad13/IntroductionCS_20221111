// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1

/*
int n=10;
int[] a=new int[n];
a[0]=0;
a[1]=1;
for(int i=2; i<n; i++)
  a[i]=a[i-1]+a[i-2]; // рекурентная формула(следующее значение за счет использования предыдущих)
for(int i=0; i<n; i++)
     System.Console.Write($"{a[i]} ");
*/

// f(0) =0
// f(1) =1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n==0) return 0;
    else if (n==1) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}