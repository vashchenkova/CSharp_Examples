int a = 0;
int b = 0;
Console.WriteLine("Введите число a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
b = Convert.ToInt32(Console.ReadLine());

if (b * b == a){
    Console.WriteLine("Число a - квадрат числа b");
}
else {
    Console.WriteLine("Число a - не квадрат числа b");
}