// 51. С клавиатуры вводится число N. Затем вводятся N чисел. 
// Определить сколько чисел больше 0 введено с клавиатуры

int N=3;
int[] t=new int[N];
int count=0;
// заполнить массив
for(int i=0; i<N; i++) 
    t[i]=Convert.ToInt32(Console.ReadLine());
// Обработать массив
for (int i = 0; i < N; i++)
    if (t[i] > 0) count++;
// Вывод результата
    System.Console.WriteLine($"Кол-во элементов > 0: {count}");