int[] array = {13, 32, 22, 35, 41, 50, 69, 37, 94, 55};

int n = array.Length;

int Find = 55;

int index = 0;

while (index < n)
{
    if(array[index] == Find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}