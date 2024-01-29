// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int a = 617;

//double result = Math.Pow((a%100)/10, (a%10));


//Console.WriteLine(result);

int a = 487;

int second = (a %100) / 10;
int third = a % 10;
int result = 1;

for (int i = 1; i <= third; i++)
{
    result = result * second;

}


Console.WriteLine(result);