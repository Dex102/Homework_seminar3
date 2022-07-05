bool CheckPalindrom (int n)
{
    int oldNum = n;
    int ReverseNum = 0;
    while (n > 0) 
    {
        ReverseNum = ReverseNum * 10 + n % 10;
        n = n / 10;
    }
    if (oldNum == ReverseNum) return true;
    else return false;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckPalindrom(number)) Console.WriteLine("PALINDROM");
else Console.WriteLine("NOT PALINDROM");
