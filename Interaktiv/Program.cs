
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("You wake up in a dark, cold room. Your heart is racing, and you feel a chill run down your spine");
Console.WriteLine("You see two exits in front of you, a corridor with a faint light flickering in the distance and \na staircase leading towards a basement");
Console.WriteLine("You see a sign on the right wall stating 'Left is always right'");
Console.WriteLine("Do you go to the 'Corridor' or the 'Basement'?");
Console.WriteLine("""
                              .     .
                               !!!!!!!
                       .       [[[|]]]    .
                       !!!!!!!!|--_--|!!!!!
                       [[[[[[[[\_(X)_/]]]]]
               .-.     /-_--__-/_--_-\-_--\
               |=|    /-_---__/__-__-_\__-_\
           . . |=| ._/-__-__\===========/-__\_
           !!!!!!!!!\========[ /]]|[[\ ]=====/
          /-_--_-_-_[[[[[[[[[||==  == ||]]]]]]
         /-_--_--_--_|=  === ||=/^|^\ ||== =|
        /-_-/^|^\-_--| /^|^\=|| | | | ||^\= |
       /_-_-| | |-_--|=| | | ||=|_|_|=||"|==|
      /-__--|_|_|_-_-| |_|_|=||______=||_| =|
     /_-__--_-__-___-|_=__=_.`---------'._=_|__
    /-----------------------\===========/-----/
   ^^^\^^^^^^^^^^^^^^^^^^^^^^[[|]]|[[|]]=====/
       |.' ..==::'"'::==.. '.[ /~~~~~\ ]]]]]]]
       | .'=[[[|]]|[[|]]]=`._||==  =  || =\ ]
       ||== =|/ _____ \|== = ||=/^|^\=||^\ ||
       || == `||-----||' = ==|| | | |=|| |=||
       ||= == ||:^s^:|| = == ||=| | | || |=||
       || = = ||:___:||= == =|| |_|_| ||_|=||
      _||_ = =||o---.|| = ==_||_= == =||==_||_
      \__/= = ||:   :||= == \__/[][][][][]\__/
      [||]= ==||:___:|| = = [||]\\//\\//\\[||]
      }  {---'"'-----'"'- --}  {//\\//\\//}  {
    __[==]__________________[==]\\//\\//\\[==]_
   |`|~~~~|================|~~~~|~~~~~~~~|~~~~||
   |^| ^  |================|^   | ^ ^^ ^ |  ^ ||
  \|//\\/^|/==============\|/^\\\^/^.\^///\\//|///
 \\///\\\//===============\\//\\///\\\\////\\\/////
 
 """);

string choice = Console.ReadLine().ToLower();

if (choice == "corridor")
{
    Console.Clear();
    Console.WriteLine("You walk down the dark corridor. The whispers grow louder, almost as if they are following you.");
    Console.WriteLine("You come across two doors: one on the 'left' and one on the 'right'. Which one do you choose?");
    Console.WriteLine(""" 
            __________       __________
           |  __  __  |     |  __  __  |        
           | |  ||  | |     | |  ||  | |
           | |  ||  | |     | |  ||  | |
           | |__||__| |     | |__||__| |
           |  __  __()|     |  __  __()|
           | |  ||  | |     | |  ||  | |
           | |  ||  | |     | |  ||  | |
           | |  ||  | |     | |  ||  | |
           | |  ||  | |     | |  ||  | |
           | |__||__| |     | |__||__| |
           |__________|     |__________| 
           """);

    string door = Console.ReadLine().ToLower();

    if (door == "right")
    {
        Console.Clear();
        Console.WriteLine("You push the door open, and a wave of cold air rushes out, freezing you in place.");
        Console.WriteLine("Inside, you see a dark void, an endless pit that seems to pull you in.");
        Console.WriteLine("Before you can react, a pair of ghostly hands emerge from the darkness, grabbing you by the throat.");
        Console.WriteLine("You realize too late that 'Left is always right' was more than just a hint... It was a warning.");
        Console.WriteLine("You feel your consciousness slipping away, the cold grip tightening. You are pulled into the void, and everything goes black.");
        Console.WriteLine("You are dead.");
        Console.WriteLine("""  
                   ,____
                   |---.\
           ___     |    `
          / .-\  ./=)
         |  |"|_/\/|
         ;  |-;| /_|
        / \_| |/ \ |
       /      \/\( |
       |   /  |` ) |
       /   \ _/    |
      /--._/  \    |
      `/|)    |    /
        /     |   |
      .'      |   |
     /         \  |
    (_.-.__.__./  /
    """);
    }
    else if (door == "left")
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("Remembering the sign's warning, you choose the left door and gently push it open.");
        Console.WriteLine("You step inside and find a hidden room filled with old furniture and a window that's slightly open.");
        Console.WriteLine("Through the window, you see the outside world. You quickly make your way to it and climb out.");
        Console.WriteLine("As you breathe the fresh air, relief washes over you. You have escaped the haunted mansion.");
        Console.WriteLine("Good job, you escaped!");

    }
}
else if (choice == "basement")
{
    Console.Clear();
    Console.WriteLine("You descend into the basement, each step creaking loudly. The air is damp and cold.");
    Console.WriteLine("As you reach the bottom, you see a faint light coming from a room at the end of the hall.");
    Console.WriteLine("Do you enter the room with the light or turn back? (Type 'enter' to enter the room or 'back' to turn back)");

    string room = Console.ReadLine().ToLower();

    if (room == "enter")
    {
        Console.Clear();
        Console.WriteLine("You push open the door and step into the room. The light flickers, revealing a horrifying sight.");
        Console.WriteLine("A group of ghostly figures are gathered around an old mirror, whispering in an unknown language.");
        Console.WriteLine("One figure turns to you and says, 'The key to escape is in the right room... but this is not the right place.'");
        Console.WriteLine("The figures rush towards you, and you are overwhelmed by a cold, suffocating darkness.");
        Console.WriteLine("""  
                   ,____
                   |---.\
           ___     |    `
          / .-\  ./=)
         |  |"|_/\/|
         ;  |-;| /_|
        / \_| |/ \ |
       /      \/\( |
       |   /  |` ) |
       /   \ _/    |
      /--._/  \    |
      `/|)    |    /
        /     |   |
      .'      |   |
     /         \  |
    (_.-.__.__./  /
    """);
    }
    else if (room == "back")
    {
        Console.Clear();
        Console.WriteLine("You decide to turn back, but as you reach the top of the stairs, the door slams shut.");
        Console.WriteLine("You hear a voice whisper, 'Too late...' The walls start closing in, and you realize there's no escape.");
        Console.WriteLine("You are trapped forever in the haunted mansion.");
        Console.WriteLine("""  
                   ,____
                   |---.\
           ___     |    `
          / .-\  ./=)
         |  |"|_/\/|
         ;  |-;| /_|
        / \_| |/ \ |
       /      \/\( |
       |   /  |` ) |
       /   \ _/    |
      /--._/  \    |
      `/|)    |    /
        /     |   |
      .'      |   |
     /         \  |
    (_.-.__.__./  /
    """);
    }
}
else
{
    Console.Clear();
    Console.WriteLine("You hesitate, unable to decide. The shadows grow darker, and you hear a sinister laugh echoing around you.");
    Console.WriteLine("You are consumed by the darkness, and your fate is sealed in the haunted mansion.");
    Console.WriteLine("""  
                   ,____
                   |---.\
           ___     |    `
          / .-\  ./=)
         |  |"|_/\/|
         ;  |-;| /_|
        / \_| |/ \ |
       /      \/\( |
       |   /  |` ) |
       /   \ _/    |
      /--._/  \    |
      `/|)    |    /
        /     |   |
      .'      |   |
     /         \  |
    (_.-.__.__./  /
    """);
}

Console.ReadLine();