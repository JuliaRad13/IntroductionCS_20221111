//12.С клавиатуры вводится целое число из  диапазона  [10, 99]. 
//Показать наибольшую цифру числа
int n;
do
{
    System.Console.WriteLine("Введите число:");
    n=Convert.ToInt32(Console.ReadLine());
} while (n<10 || n>99);