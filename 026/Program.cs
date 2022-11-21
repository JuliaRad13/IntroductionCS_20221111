// 26. Найти сумму чисел от 1 до А
System.Console.WriteLine("Введите число:");
int Number=Convert.ToInt32(Console.ReadLine());
Number=Math.Abs(Number);
int count=0;

while (Number>0)
{
    Number=Number/10;
    count++;
}
System.Console.WriteLine(count);

int sum=0;
for (int i=1; i<=Number; i++)
    {
        sum=sum+i;
    }
    System.Console.WriteLine(sum);


/*int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
*/