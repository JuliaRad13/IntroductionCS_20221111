// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

string s = Console.ReadLine();
int k = 0;
for(int i=0;i<s.Length;i++)
    if (s[i]=='a') k++;
System.Console.Write(k); 
