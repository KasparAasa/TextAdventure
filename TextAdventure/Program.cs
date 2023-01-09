// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello! \nThis is a start of a new adventure.\nAre you ready for it?\nWhats your name litte fellow?");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}! \nWelcome to your story");
Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
Console.WriteLine("Type YES or NO");
string whatever;
whatever = Console.ReadLine().ToUpper();
if (whatever == "NO")
{
    Console.WriteLine("Not much of an adventure if we don't leave our room innit? \nTHE END! :(");
    return;
}
if (whatever == "YES")
{
    Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. \nYou walk towards it. \nDo you open it or knock?");
    Console.WriteLine("Type OPEN or KNOCK");
    whatever = Console.ReadLine().ToUpper();
}

if (whatever == "KNOCK")
{
    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \" \n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
    Console.WriteLine("Type your answer:");
    string riddleAnswer = Console.ReadLine().ToUpper();
    if (riddleAnswer == "NOTHING")
    {
        Console.WriteLine("The door opens and NOTHING is there. \nYou turn the lights off and run back to your room and lock the door. \nTHE END!");
        return;
    }
    Console.WriteLine("You have answered incorrectly. \nThe door doesn't open. \nTHE END!");
    return;
}

else if (whatever == "OPEN")
{
    Console.WriteLine("The door is locked. \nSee of any of your three keys will open it.");
    Console.WriteLine("Enter a number (1-3)");
}
string keyChoice = Console.ReadLine().ToUpper();
switch (keyChoice)
{
    case "1":
        Console.WriteLine("You chose the first key. \nLucky you! \nThe door opens and a monster tentacles you. \nFUN! \nTHE END!");
        return;
    case "2" :
        Console.WriteLine("You chose the second key. \nThe door doesn't open. \nTHE END!");
        return;
    case "3":
        Console.WriteLine("You chose the third key. \nThe innkeeper heard you and punished you with some fun times.\nLucky you! \nTHE END!");
        return;
}
