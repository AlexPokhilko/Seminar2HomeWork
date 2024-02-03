// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int x = 0;
int y = 0;

while (x == 0)
{
    Console.WriteLine("Введите координату Х");
    x = int.Parse(Console.ReadLine()!);
}

while (y == 0)
{
     Console.WriteLine("Введите координату Y");
    y = int.Parse(Console.ReadLine()!);
}

if (x > 0 )
{
    if (y > 0)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(4);
    }
}
else
    if (y > 0)
    {
        Console.WriteLine(2);
    }
    else
    {
        Console.WriteLine(3);
    }