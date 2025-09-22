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


//Create locations
const byte LithiumFlats = 0;
const byte Place2 = 1;
const byte Place3 = 2;
const byte Place4 = 3;
const byte AcidWaste = 4;
const byte Iacon = 5;
byte? currentRegion = Place1;

//For Character Selection
int CharacterNumber;

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
    Console.WriteLine("Default Character: 'BumbleBee' Selected");
    Speed = 80;
    Strength = 50;
    Health = 40;
    MaxHealth = 40;
    AltMode = new string[] { "Small Car" };
    Weapon = new string[] { "Repeater Blaster" };
}
else
{
    Console.WriteLine("Characters Available:");
    Console.WriteLine("BumbleBee(1): Speed = 80, Strength = 30, Health = 40");
    Console.WriteLine("SmokeScreen(2): Speed = 50, Strength = 50, Health = 50");
    Console.WriteLine("Warpath: Speed(3) = 30, Strength = 70, Health = 50");
    bool CharacterSelectionState = true;

    while (CharacterSelectionState)
    {
        Console.WriteLine();
        switch (SelectedCharacter)
        {
            case BumbleBee:
                Console.WriteLine("Character Selected: BumbleBee");
                break;


            case SmokeScreen:
                Console.WriteLine("Character Selected: SmokeScreen");
                break;

            case Warpath:
                Console.WriteLine("Character Selected: Warpath");
                break;

            default:
                Console.WriteLine("Selected Deafault Character: BumbleBee");
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

//Game loop
bool exit = false;
while (!exit)
{
    WriteLine();
    switch (currentRegion)
    {
        case LithiumFlats:
            LithiumFlatsLoop();
            CheckDeath();
            break;
        case Place2:
            Place2Loop();
            CheckDeath();
            break;
        case Place3:
            Place3Loop();
            CheckDeath();
            break;
        case AcidWaste:
            AcidWasteLoop();
            CheckDeath();
            break;
        case Iacon:
            IaconLoop();
            CheckDeath();
            break;
        default:
            WriteLine("Game over");
            exit = true;
            break;
    }
}
Thread.Sleep(3000);

void CheckDeath()
{
    if (HP <= 0)
    {
        currentRegion = null;
    }
}
void LithiumFlatsLoop()
{

}

void Place2Loop()
{ 
    
}
void Place3Loop()
{ 
    
}
void Place4Loop()
{ 
    
}
void AcidWasteLoop()
{ 
    
}

void IaconLoop()
{ 
    
}


