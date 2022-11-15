

int[] array = {10,99};

int n = array.Length;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
    }
    //index = index +1;
    index++;
}