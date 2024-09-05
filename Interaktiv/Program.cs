
Console.WriteLine("You wake up in a dark, cold room. Your heart is racing, and you feel a chill run down your spine");
Console.WriteLine("You see two exits in front of you, a corridor with a faint light flickering in the distance and a staircase leading towards a basement");
Console.WriteLine("You see a sign on the right wall stating 'Left is always right'");
Console.WriteLine("Do you go to the 'Corridor' or the 'Basement'?");

string choice = Console.ReadLine();

if (choice.ToLower() == "corridor")
{
    Console.WriteLine("You walk down the dark corridor. The whispers grow louder, almost as if they are following you.");
    Console.WriteLine("You come across two doors: one on the 'left' and one on the 'right'. Which one do you choose?");

    string door = Console.ReadLine();

    if (door == "right")
    {
        Console.WriteLine("Stupid, Left is always right. You are dead now");
    }
    else if (door == "left")
    {
        Console.WriteLine("Good job you escaped");
    }
}
else if (choice.ToLower() == "basement")
{
    Console.WriteLine("You descend into the basement, each step creaking loudly. The air is damp and cold.");
    Console.WriteLine("As you reach the bottom, you see a faint light coming from a room at the end of the hall.");
    Console.WriteLine("Do you enter the room with the light or turn back? (Type 'enter' to enter the room or 'back' to turn back)");

    string room = Console.ReadLine();

    if (room == "enter")
    {
        Console.WriteLine("You push open the door and step into the room. The light flickers, revealing a horrifying sight.");
        Console.WriteLine("A group of ghostly figures are gathered around an old mirror, whispering in an unknown language.");
        Console.WriteLine("One figure turns to you and says, 'The key to escape is in the right room... but this is not the right place.'");
        Console.WriteLine("The figures rush towards you, and you are overwhelmed by a cold, suffocating darkness.");
    }
    else if (room == "back")
    {
        Console.WriteLine("You decide to turn back, but as you reach the top of the stairs, the door slams shut.");
        Console.WriteLine("You hear a voice whisper, 'Too late...' The walls start closing in, and you realize there's no escape.");
        Console.WriteLine("You are trapped forever in the haunted mansion.");
    }
}
else
{
    Console.WriteLine("FU");
}

Console.ReadLine();