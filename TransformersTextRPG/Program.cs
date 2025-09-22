//For Character Selection
int CharacterNumber;

//Three main stats that class determines the baseline
int Speed;
int Strength;
int Health;

//Determines Vehicle and Weapon the PC uses
string[] AltMode;
string[] Weapon;

//Starts the character selection 
if (args.Length == 0)
{
    Console.WriteLine("Default Character: 'BumbleBee' Selected");
    Speed = 80;
    Strength = 50;
    Health = 40;
    AltMode = new string[] { "Small Car" };
    Weapon = new string[] { "Repeater Blaster" };
}
else
{
    Console.WriteLine("Characters Available:");
    Console.WriteLine("BumbleBee: Speed = 80, Strength = 30, Health = 40");
    Console.WriteLine("SmokeScreen: Speed = 50, Strength = 50, Health = 50");
    Console.WriteLine("Warpath: Speed = 30, Strength = 70, Health = 50");
    bool CharacterSelectionArg = true;

    try
    {
        CharacterNumber = int.Parse(args[0]);

    }
    catch (FormatException)
    {
        Console.WriteLine("No Selection Made. Setting Character to Default: BumbleBee.");
        Speed = 80;
        Strength = 50;
        Health = 40;
        AltMode = new string[] { "Small Car" };
        Weapon = new string[] { "Repeater Blaster" };
        CharacterSelectionArg = false;
    }
    /*if (CharacterSelectionArg)
    {
        if (CharacterNumber = 1)
        {
            
        }
    }*/
}

