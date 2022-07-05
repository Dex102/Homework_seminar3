void CubesNumbers (int N)
{
    for (int i = 1; i <= N; i++)
    {
        int result = i*i*i;
        Console.Write(result + " ");
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

CubesNumbers(number);
