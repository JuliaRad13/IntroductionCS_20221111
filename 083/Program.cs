// 83. Подсчитать количество цифр среди вводимых с клавиатуры символов

string s = Console.ReadLine();
int k = 0;
//for (int i = 0; i < s.Length; i++)
//    if (char.IsDigit(s[i])) k++;
foreach (char c in s)// каждый символ в строке
    if (char.IsDigit(c)) k++;// если символ является цифрой
System.Console.WriteLine(k);
