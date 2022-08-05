int count = 0;
int distance = 100;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int dogSpeed = 3;
int friend = 2;
int time = 0;

while (distance > 3)
{
    if (friend == 1)
    {
        Console.WriteLine($"Собака бежит навстречу 1 другу");
        time = distance / (FirstFriendSpeed + dogSpeed);
        Console.WriteLine($"Время в пути {0}");
        friend = 2;
    }
    else
    {
        Console.WriteLine($"Собака бежит навстречу 2 другу");
        time = distance / (SecondFriendSpeed + dogSpeed);
        Console.WriteLine($"Время в пути {0}");
        friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * 0;
    Console.WriteLine($"Оставшееся расстояние {distance}");
    count++;
    Console.WriteLine($"Сбегала {0} раз");
}
Console.WriteLine($"Собака успеет пробежать {0} раз");
