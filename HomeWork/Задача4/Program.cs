// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


long a = 545678890;
long b = a;
int d = 10;
string s = "";
int flag = 1;
long c = 0;

while (b > 0)
{
    b = a;
    b = b / d;


    //Console.WriteLine("b= "+b);

    c = (a % d - c) / (d / 10);

    d = d * 10;

    //Console.WriteLine("c= "+c);

    if (flag == 1)
    {
        s = c + s;
    }
    else
    {
        s = c + ", " + s;
    }
    flag = 0;
}
Console.WriteLine(s);
