

string choice = "";

Console.WriteLine("You wake up in a dark, cold room. Your heart is racing, and you feel a chill run down your spine");
Console.WriteLine("You see two exits in front of you, a corridor with a faint light flickering in the distance and a staircase leading towards a basement");
Console.WriteLine("You see a sign on the right wall stating 'Left is always right'");
Console.WriteLine("Do you go to the 'Corridor' or the 'Basement'?");

choice = Console.ReadLine(); 
choice = choice.ToLower();


if (choice == "Basement")
{
    Console.WriteLine("good");
}
else 
{
    Console.WriteLine("Fuck off");
}

Console.ReadLine();