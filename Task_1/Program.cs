// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input integer number");
int a = int.Parse(Console.ReadLine());
if (a%2 == 0)// проверка на четность
{
    Console.WriteLine("Your number is even");
}
else
{
    Console.WriteLine("Your number is odd");
}
