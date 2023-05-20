// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input integer number");
int N = int.Parse(Console.ReadLine());
int remains = 0;
bool result = false;
for (int i = 2; i < N-1; i++) {
    remains  = N%i;
    if (remains == 0) result = true;
}
if (result == false) Console.WriteLine("Your number is prime");
else Console.WriteLine("Your number is not prime");
