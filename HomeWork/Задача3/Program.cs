// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int a = 89;
int result;

int b = a%10;
int c = (a%100 - b)/10;

if (b>c)
{
    result = b;
}
else
{
    result = c;
}
Console.WriteLine(result);