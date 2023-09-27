using StenSaxPaseFor2;
using System.Data;

Players player1 = new Players();
Players player2 = new Players();

Console.Write("Namn på spelare 1: ");
player1.name = Console.ReadLine();
Console.Write("Namn på spelare 2: ");
player2.name = Console.ReadLine();


string Randomizer() // Slumpar vem som börjar
{
    Random r = new Random();
    int rPlayer = r.Next(0, 2);

    if (rPlayer == 0)
    {
        return player1.name;
    }
    else
    {
        return player2.name; 
    }
}

string startingPlayer = Randomizer();


Console.WriteLine($"Välkommen {player1.name} & {player2.name}! Jag har bestämt att {startingPlayer} ska börja, helt slumpmässigt så klart.. ;)");


bool hasWon = false;
bool player1turn = false;
bool player2turn = false;
int player1Points = 0;
int player2Points = 0;


string TempRound() 
{
    if (startingPlayer == player1.name)
    {

        Console.WriteLine($"{player1.name} var god välj ditt drag genom att skriva respektive siffra");
        Console.WriteLine("1. Sten");
        Console.WriteLine("2. Sax");
        Console.WriteLine("3. Påse");
        string player1move = Console.ReadLine();
        player1turn = true;

        if (player1move != "1" && player1move != "2" && player1move != "3")
        {
            Console.WriteLine("Fel inmatning, försök igen");
        }
        return player1move;
    }
    else
    {
        Console.WriteLine($"{player2.name} var god välj ditt drag genom att skriva respektive siffra");
        Console.WriteLine("1. Sten");
        Console.WriteLine("2. Sax");
        Console.WriteLine("3. Påse");
        string player2move = Console.ReadLine();
        player2turn = true;
        if (player2move != "1" && player2move != "2" && player2move != "3")
        {
            Console.WriteLine("Fel inmatning, försök igen");
        }
        return player2move; 
    }
}


while (!hasWon)
{
    TempRound();
    if (player1turn == true)
    {
        Console.WriteLine($"{player2.name} var god välj ditt drag genom att skriva respektive siffra");
        Console.WriteLine("1. Sten");
        Console.WriteLine("2. Sax");
        Console.WriteLine("3. Påse");
        string player2move = Console.ReadLine();
    }
    else
    {
        Console.WriteLine($"{player1.name} var god välj ditt drag genom att skriva respektive siffra");
        Console.WriteLine("1. Sten");
        Console.WriteLine("2. Sax");
        Console.WriteLine("3. Påse");
        string player1move = Console.ReadLine();
    }

    
    
}




