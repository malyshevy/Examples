int x=0, y=0,
    xa=10,  ya=1,
    xb=1,  yb=10,
    xc=20, yc=10;
Console.Clear();
Console.SetCursorPosition(xa, ya);
Console.WriteLine("a");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("a");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("a");
int count =0;
while (count < 10)
{
    int what=new Random().Next(0,3);
    if (what==0)
    {
       x=(x+xa)/2;
       y=(y+ya)/2; 
    }
    if (what==1)
    {
       x=(x+xb)/2;
       y=(y+yb)/2; 
    }
    if (what==2)
    {
       x=(x+xc)/2;
       y=(y+yc)/2; 
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count=count+1;
}