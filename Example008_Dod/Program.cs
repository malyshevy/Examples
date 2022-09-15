double count=0, 
    fFS=1, 
    sFS=2, 
    dogSpeed=5, 
    friend=2, 
    distance=30003,
    minDistance=10,
    time;
while (distance>minDistance)
{
    if (friend == 1)
    {
        time=distance/(fFS+dogSpeed);
        friend=2;
    }
    else
    {
        time=distance/(sFS+dogSpeed);
        friend=1;
    }
    distance=distance-(fFS+sFS)*time;
    count++;
}
Console.Write("Cобака пробежит  ");
Console.Write(count);
Console.WriteLine("  раз");