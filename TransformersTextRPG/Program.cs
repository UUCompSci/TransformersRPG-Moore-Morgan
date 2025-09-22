using static System.Console;
//Bytes for character Selection
const byte BumbleBee = 0;
const byte SmokeScreen = 1;
const byte Warpath = 2;
byte? SelectedCharacter = BumbleBee;

//Grabs Concole Keys for Input
const ConsoleKey Z = ConsoleKey.Z;
const ConsoleKey X = ConsoleKey.X;
const ConsoleKey C = ConsoleKey.C;
const ConsoleKey V = ConsoleKey.V;
const ConsoleKey ESC = ConsoleKey.Escape;
ConsoleKey CharacterChoice()
{
    ConsoleKey choice = ReadKey(true).Key;
    Console.WriteLine();
    return choice;
}

//Three main stats that class determines the baseline
int Speed;
int Strength;
int Health;
int MaxHealth;

//Determines Vehicle and Weapon the PC uses
string[] AltMode;
string[] Weapon;

//Starts the character selection 
if (args.Length == 0)
{
    WriteLine();
    Console.WriteLine("Default Character: 'BumbleBee' Selected");
    Speed = 80;
    Strength = 50;
    Health = 40;
    MaxHealth = 40;
    AltMode = new string[] { "Small Car" };
    Weapon = new string[] { "Subsonic Repeater" };
}
else
{
    WriteLine();
    Console.WriteLine("Characters Available:");
    Console.WriteLine("BumbleBee(Z): Speed = 80, Strength = 30, Health = 40");
    Console.WriteLine("SmokeScreen(X): Speed = 50, Strength = 50, Health = 50");
    Console.WriteLine("Warpath: Speed(C) = 30, Strength = 70, Health = 50");
    bool CharacterSelectionState = false;

    while (!CharacterSelectionState)
    {
        switch (CharacterChoice())
        {
            case Z:
                Console.WriteLine("Character Selected: BumbleBee");
                SelectedCharacter = BumbleBee;
                Speed = 80;
                Strength = 50;
                Health = 40;
                MaxHealth = 40;
                AltMode = new string[] { "Small Car" };
                Weapon = new string[] { " Subsonic Repeater" };
                CharacterSelectionState = true;
            
                break;
            


            case X:
                Console.WriteLine("Character Selected: SmokeScreen");
                SelectedCharacter = SmokeScreen;
                Speed = 50;
                Strength = 50;
                Health = 50;
                MaxHealth = 50;
                AltMode = new string[] { "Car" };
                Weapon = new string[] { "Scatter Blaster" };
                CharacterSelectionState = true;
                break;

            case C:
                Console.WriteLine("Character Selected: Warpath");
                SelectedCharacter = Warpath;
                Speed = 30;
                Strength = 70;
                Health = 50;
                MaxHealth = 50;
                AltMode = new string[] { "Tank" };
                 Weapon = new string[] { "Riot Cannon" };
                CharacterSelectionState = true;
                break;

            default:
                Console.WriteLine("Deafault Character Selected: BumbleBee");
                SelectedCharacter = BumbleBee;
                Speed = 80;
                Strength = 50;
                Health = 40;
                MaxHealth = 40;
                AltMode = new string[] { "Small Car" };
                Weapon = new string[] { "Subsonic Repeater" };
                CharacterSelectionState = true;
            break;
        }
    }
    
    /*try
    {
        
    }
    catch (FormatException)
    {
        Console.WriteLine("No Selection Made. Setting Character to Default: BumbleBee.");
        Speed = 80;
        Strength = 50;
        Health = 40;
        MaxHealth = 40;
        AltMode = new string[] { "Small Car" };
        Weapon = new string[] { "Repeater Blaster" };
        CharacterSelectionArg = false;
    }
    if (CharacterSelectionArg)
    {
       
    }*/
   
}

