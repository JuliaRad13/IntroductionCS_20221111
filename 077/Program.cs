// 77. Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности 0 и 1 
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