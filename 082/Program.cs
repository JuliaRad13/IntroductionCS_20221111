// 82. C клавиатуры вводится строка разделенная точкой.
// Подсчитать количество символов до точки

string s = Console.ReadLine();
int k = 0;
for(int i=0;i<s.IndexOf(".");i++)
   k++;
System.Console.Write(k); 
