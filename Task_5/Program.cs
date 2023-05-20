// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input the range of numbers");
int N = int.Parse(Console.ReadLine());
int puzzle = new Random().Next(0, N);
Console.WriteLine("Input your Max attempts number");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("If you want to stop, press Space bar");
for (int i = 0; i < max; i++){
    Console.Write("Input your number ");
    string numberString = Console.ReadLine();
    char stop = char.Parse(numberString);
    if (stop == ' ') {
        Console.WriteLine("You stopped the game");
        break;
    }
    int number = int.Parse(numberString);
    if (number > puzzle) Console.WriteLine("Your number is more");
    if (number < puzzle) Console.WriteLine("Your number is less");
    if (number == puzzle) {
        Console.WriteLine("You win");
        break;
        }
}
Console.WriteLine($"Secret number is {puzzle}");
