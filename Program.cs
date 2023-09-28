using StenSaxPaseFor2;
using System.Data;

Players player1 = new Players();
Players player2 = new Players();

Console.Write("Namn på spelare 1: ");
player1.name = Console.ReadLine();
Console.Write("Namn på spelare 2: ");
player2.name = Console.ReadLine();

Players GetRandomPlayer()
{
    Random r = new Random();
    int rPlayer = r.Next(0, 2);

    if (rPlayer == 0)
    {
        return player1;
    }
    else
    {
        return player2;
    }
}


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
Players startingPlayerNew = GetRandomPlayer();

Console.WriteLine($"Välkommen {player1.name} & {player2.name}! Jag har bestämt att {startingPlayerNew.name} ska börja, helt slumpmässigt så klart.. ;)");


bool playerturn;

if (startingPlayerNew.name == player1.name)
{
    playerturn = false;
}
else
{
    playerturn = true;
}


string player1move;
Drag player1moveEnum;
Drag player2moveEnum; 

string player2move;

player1.points = 0;
player2.points = 0;
int roundsCount = 3;
bool hasWon = false;



for (int i = 0; i < roundsCount; i++)
{
    if (roundsCount == 0)
    {
        Console.WriteLine("Spelet är över. Vinnaren är: ");
        if (player1.points > player2.points)
        {
            Console.Write(player1.name);

        }
        else
        {
            Console.Write(player2.name);

        }

    }
    if (playerturn == false)
    {
        Console.WriteLine($"{player1.name} var god välj ditt drag genom att skriva respektive siffra");
        Console.WriteLine($"{(int)Drag.Sten}. {Drag.Sten}");
        Console.WriteLine($"{(int)Drag.Sax}. {Drag.Sax}");
        Console.WriteLine($"{(int)Drag.Påse}. {Drag.Påse}");
        player1moveEnum = Enum.Parse<Drag>(Console.ReadLine());
        playerturn = true;
        Console.Clear();

    }
    if (playerturn == true)
    {
        Console.WriteLine($"{player2.name} var god välj ditt drag genom att skriva respektive siffra");
        Console.WriteLine($"{(int)Drag.Sten}. {Drag.Sten}");
        Console.WriteLine($"{(int)Drag.Sax}. {Drag.Sax}");
        Console.WriteLine($"{(int)Drag.Påse}. {Drag.Påse}");    
        player2moveEnum = Enum.Parse<Drag>(Console.ReadLine());
        playerturn = false;
        Console.Clear();


    }


}





// if playermove 1 == playermove 2 { i--; }
// if (player2move != "1" && player2move != "2" && player2move != "3")