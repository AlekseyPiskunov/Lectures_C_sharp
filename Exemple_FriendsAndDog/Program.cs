int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
double distance = 10000;
double time = 0;
int count = 0;
int friend = 2;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.Write($"Собака пробежит {count} раз!");