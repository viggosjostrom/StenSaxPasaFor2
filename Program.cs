using StenSaxPaseFor2;
using System.Data;

Console.WriteLine("STEN SAX PÅSE ~ Bäst av 3!");
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



Players startingPlayer = GetRandomPlayer();

Console.WriteLine($"Välkommen {player1.name} & {player2.name}! Jag har bestämt att {startingPlayer.name} ska börja, helt slumpmässigt så klart.. ;)");






Drag player1moveEnum;
Drag player2moveEnum; 

player1.points = 0;
player2.points = 0;
bool hasWon = false;



while(!hasWon)
{
    Console.WriteLine($"{player1.name} var god välj ditt drag genom att skriva respektive siffra\n{(int)Drag.Sten}. {Drag.Sten}\n{(int)Drag.Sax}. {Drag.Sax}\n{(int)Drag.Påse}. {Drag.Påse}");
    player1moveEnum = Enum.Parse<Drag>(Console.ReadLine());
    Console.Clear();
    Console.WriteLine($"{player2.name} var god välj ditt drag genom att skriva respektive siffra\n{(int)Drag.Sten}. {Drag.Sten}\n{(int)Drag.Sax}. {Drag.Sax}\n{(int)Drag.Påse}. {Drag.Påse}");
    player2moveEnum = Enum.Parse<Drag>(Console.ReadLine());
    Console.Clear();
    Round(player1moveEnum, player2moveEnum);
    if (Round(player1moveEnum, player2moveEnum) == player1.name)
    {
        player1.points++;
        Console.WriteLine($"{player1.name} har vunnit rundan!\nResultatet är just nu följande:\n{player1.name}: {player1.points}\n{player2.name}: {player2.points}");
    }
    else
    {
        player2.points++;
        Console.WriteLine($"{player2.name} har vunnit rundan!\nResultatet är just nu följande:\n{player1.name}: {player1.points}\n{player2.name}: {player2.points}");

    }
}









string Round(Drag player1moveEnum, Drag player2moveEnum)
{
    if (player2moveEnum == player1moveEnum)
    {
        return "Oavgjort"; 
    }
    switch (player1moveEnum)
    {
        case Drag.Sten:
            if (player2moveEnum == Drag.Påse)
            {
                return player2.name;
            }
            else
            {
                return player1.name; 
            }
        case Drag.Sax:
            if (player2moveEnum == Drag.Sten)
            {
                return player2.name;
            }
            else
            {
                return player1.name;
            }
        case Drag.Påse:
            if (player2moveEnum == Drag.Sax)
            {
                return player2.name;
            }
            else
            {
                return player1.name;
            }
        default: return "error";
     
    }
}

