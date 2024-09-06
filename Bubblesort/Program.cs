using System.Globalization;

int[] number = { 5, 2, 3, 1, 9, 33, 11, 22  };


for (int i = 0; i < number.Length - 1; i++)
{
    for (int j = 0; j < number.Length - 1 - i; j++)
    {
        if (number[i] == number[j])
        {
            int temp = number[j];
            number[j] = number[i + 1];
            number[j + 1] = temp;

        }
    }
}

Console.WriteLine("Sorterad array");
foreach (int num in number)
{
    Console.WriteLine(num +" "); 
}