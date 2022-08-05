int N = 0;
Console.WriteLine("Введите трёхзначное число:" );
N = Convert.ToInt32(Console.ReadLine());
if (N >= 100 && N <= 999)
{
    int lastDigit = N % 10;
    Console.WriteLine("Последняя цифра числа = " + lastDigit);
}
else
{
    Console.WriteLine("Это не трёхзначное число!" );
}

