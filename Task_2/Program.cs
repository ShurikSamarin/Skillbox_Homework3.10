// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input number of your cards");
int a = int.Parse(Console.ReadLine());//кол-во карт
int result = 0;// сумма карт
for (int i=0; i<a; i++)
{
    Return:
    Console.WriteLine("Input your card");
    string card = Console.ReadLine();
    if (card != "J" && card !="Q" && card !="T" && card !="K" && card !="6" && card !="7" && card !="8" && card !="9" && card !="10") 
    {Console.WriteLine("Out of range, try again");
    goto Return;
    }
    Console.WriteLine("Correct");
    if (card == "J" || card == "Q" || card == "K" || card == "T") result = result+10;
    else result = result+int.Parse(card);
    }
Console.WriteLine("");
Console.WriteLine("Your sum is "+result);
Console.WriteLine("");

