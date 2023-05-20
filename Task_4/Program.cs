// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input lenght of numbers");
int N = int.Parse(Console.ReadLine());
int [] array = new int [N];
for (int i = 0; i < N; i++){
    Console.Write($"Input number |{i+1}| ");
    array [i] = int.Parse(Console.ReadLine()); 
}
int minValue = array[0];
for (int j = 1; j < N; j++){
    if (array[j] < minValue) minValue = array[j]; 
}
Console.WriteLine($"Minimum number is {minValue}");
