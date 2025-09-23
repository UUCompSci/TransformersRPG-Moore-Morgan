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

const ConsoleKey Y = ConsoleKey.Y;
const ConsoleKey N = ConsoleKey.N;
ConsoleKey ChoiceSelection()
{
    ConsoleKey choice = ReadKey(true).Key;
    Console.WriteLine();
    return choice;
}

//Create locations
const byte LithiumFlats = 18;
const byte Praxus = 19;
const byte Nyon = 20;
const byte Rodion = 3;
const byte AcidWastes = 4;
const byte Iacon = 5;
const byte HydraxCity = 6;
const byte Stanix = 7;
const byte Altihex = 8;
const byte Tyrest = 9;
const byte Praxus2 = 10;
const byte Iacon2 = 11;
const byte Altihex2 = 12;
const byte Tyrest2 = 13;
const byte Stanix3 = 14;
const byte AcidWastes3 = 15;
const byte Stanix2 = 16;
const byte AcidWastes2 = 17;
const byte AcidWastes4 = 21;
const byte AcidWastes5 = 22;
byte? currentRegion = LithiumFlats;

//Three main stats that class determines the baseline
int Speed = 0;
int Strength = 0; 
int Health = 0;
int MaxHealth = 0;
int StrongAttack = Strength * 2;
int LightAttack = Strength / 2;

//Enemy stats
int EnemySpeed = 0;
int EnemyStrength = 0;
int EnemyHealth = 0;

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
    Console.WriteLine("Warpath(C): Speed = 30, Strength = 70, Health = 50");
    bool CharacterSelectionState = false;

    while (!CharacterSelectionState)
    {
        switch (ChoiceSelection())
        {
            case Z:
                Console.WriteLine("Character Selected: BumbleBee");
                SelectedCharacter = BumbleBee;
                Speed = 80;
                Strength = 50;
                Health = 40;
                MaxHealth = 40;
                AltMode = new string[] { "Small Car" };
                Weapon = new string[] { "Subsonic Repeater" };
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
    
    try
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
        CharacterSelectionState = false;
    }
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
        case Praxus:
            PraxusLoop();
            CheckDeath();
            break;
        case Nyon:
            NyonLoop();
            CheckDeath();
            break;
        case Rodion:
            RodionLoop();
            CheckDeath();
            break;
        case AcidWastes:
            AcidWastesLoop();
            CheckDeath();
            break;
        case Iacon:
            IaconLoop();
            CheckDeath();
            break;
        case HydraxCity:
            HydraxCityLoop();
            CheckDeath();
            break;
        case Stanix:
            StanixLoop();
            CheckDeath();
            break;
        case Altihex:
            AltihexLoop();
            CheckDeath();
            break;
        case Tyrest:
            TyrestLoop();
            CheckDeath();
            break;
         case Praxus2:
            Praxus2Loop();
            CheckDeath();
            break;
        case Stanix2:
            Stanix2Loop();
            CheckDeath();
            break;
        case Altihex2:
            Altihex2Loop();
            CheckDeath();
            break;
        case Tyrest2:
            Tyrest2Loop();
            CheckDeath();
            break;
         case Iacon2:
            Iacon2Loop();
            CheckDeath();
            break;
        case Stanix3:
            Stanix3Loop();
            CheckDeath();
            break;
        case AcidWastes2:
            AcidWastes2Loop();
            CheckDeath();
            break;
        case AcidWastes3:
            AcidWastes3Loop();
            CheckDeath();
            break;
        case AcidWastes4:
            AcidWastes4Loop();
            CheckDeath();
            break;
        case AcidWastes5:
            AcidWastes5Loop();
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
    if (Health <= 0)
    {
        currentRegion = null;
    }
}

//Location loops
//Starting location
void LithiumFlatsLoop()
{
    WriteLine("You have arrived at the Lithium Flats.");
    WriteLine("Upon arrival you receive a letter, it is from Megatron, he is requesting you to aid him in his fight against the autobots and is planning on launching an attack soon."); //idk abt the letter thing just however the user is informed
    WriteLine("Megatron leads the Decepticons, a widely disliked group of transformors who wishes to take over the universe and kill the Autobots.");
    WriteLine("Would you like to help the Autobots and inform them of the threat (Z), side with the Autobots and fight Megatron solo (X), or join the Decepticons (C)? ");


    switch (ChoiceSelection())
    {

        bool EnemeyDefeated = false;


    if (EnemeyDefeated is false)
    {
        while (!EnemeyDefeated) {

            WriteLine("A Decepticon Seeker has Attacked! You Must Fight!");
            WriteLine("What Will You Do?");
            switch (ChoiceSelection())
            {


                case Z:

            }
        }
    }


    if (EnemeyDefeated is true) {

        switch(ChoiceSelection()){
        case Z:
            currentRegion = Praxus;
            break;
        case X:
            currentRegion = Praxus2;
            break;
        case C:
            currentRegion = Nyon;
            break;

        }
    }
}

//Destination progression if chose z
void PraxusLoop()
{
    WriteLine("You have arrived at Praxus.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to fight the Decepticons? (Y)es or (N)o? ");
    switch (ChoiceSelection())
    {
    case Y:
            WriteLine("Great!");
    currentRegion = Iacon;
    break;
    case N:
    WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}
void IaconLoop()
{
    WriteLine("You have arrived at Iacon. You collect resources here and prepare to fight.");
    WriteLine("You find Optimus, would you like to inform him of the threat from the Decepticons? (Y or N)");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Optimus thanks you and you the Autobots and progress on your journey to fight the Decepticons!");
            currentRegion = Altihex;
            break;
        case N:
            WriteLine("You changed your mind and decided to continue alone, good luck!");
            currentRegion = Altihex2;
    break;
    }
}
void AltihexLoop()
{
    WriteLine("You have arrived at Altihex.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to fight the Decepticons? (Y)es or (N)o? ");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = Tyrest;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}
void TyrestLoop()
{ 
    WriteLine("You have arrived at Tyrest.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to fight the Decepticons? (Y)es or (N)o? ");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = Stanix;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}
void StanixLoop()
{
    WriteLine("You have arrived at Stanix.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to fight the Decepticons? (Y)es or (N)o? ");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = AcidWastes;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}


//Destination progression if chose x
void Praxus2Loop()
{
    WriteLine("You have arrived at Praxus.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to fight the Decepticons? (Y)es or (N)o? ");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = Iacon2;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}
void Iacon2Loop()
{ 
    WriteLine("You have arrived at Iacon.");
    WriteLine("You collect resources here and prepare for battle."); // Idk what specific stuff but you can come up with that bc you know transformers better than me
    WriteLine("Are you ready to continue your journey to fight the Decepticons? (Y)es or (N)o? ");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = Altihex2;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}
void Altihex2Loop()
{
    WriteLine("You have arrived at Altihex.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to fight the Decepticons? (Y)es or (N)o? ");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = Tyrest2;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}
void Tyrest2Loop()
{ 
    WriteLine("You have arrived at Tyrest. It feels lonely by yourself, but you're determined to see this journey to the end.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to fight the Decepticons? (Y)es or (N)o? ");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = Stanix2;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;
    
}
}
void Stanix2Loop()
{
    WriteLine("You have arrived at Stanix.");
    WriteLine(""); // I'm guessing some type of fight will happen

    WriteLine("As you near the Decepticon base you worry you may have made the wrong decision going by yourself...");
    WriteLine("Are you ready to continue your journey to fight the Decepticons? (Y)es or (N)o? ");
    switch (ChoiceSelection())
{ 
        case Y:
            WriteLine("Great!");
            currentRegion = AcidWastes2;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}

//Destination progression for choice c
void NyonLoop()
{ 
    WriteLine("You have arrived at Nyon.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to help the Decepticons beat the Autobots? (Y or N)");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = Rodion;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}
void RodionLoop()
{ 
    WriteLine("You have arrived at Rodion.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to help the Decepticons beat the Autobots? (Y or N)");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = HydraxCity;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}
void HydraxCityLoop()
{
    WriteLine("You have arrived at Hydrax City.");
    WriteLine("As you grow nearer to Acid Wastes you start to wonder if conquering the universe with Megatron is your true desire.");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to help the Decepticons beat the Autobots? (Y or N)");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = Stanix3;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}
void Stanix3Loop()
{
    WriteLine("You have arrived at Stanix.");
    WriteLine("You miss home. Will life ever be the same after betraying your family and city? Is conquering the universe worth losing your soul?");
    WriteLine(""); // I'm guessing some type of fight will happen


    WriteLine("Are you ready to continue your journey to help the Decepticons beat the Autobots? (Y or N)");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("Great!");
            currentRegion = AcidWastes3;
            break;
        case N:
            WriteLine("That's too bad, maybe we'll see you another time!");
            currentRegion = LithiumFlats;
            break;

    }
}



//endings
void AcidWastesLoop()
{
    WriteLine("You have arrived at the Acid Wastes, get ready to fight Decepticon!");
    WriteLine("You approach the base with *insert whoever* and stand ready to fight");
    //you can write out the fight story line because I don't really know what everyone can do etc.
    WriteLine("The Autobots won! Megatron was no competition for the mighty Optimus Prime and the Autobots. The universe is saved and Cybertron remains safe!");
    WriteLine("You Won!");
    currentRegion = null;
}

void AcidWastes2Loop()
{
    WriteLine("You have arrived at the Acid Wastes, get ready to fight Decepticon!");
    WriteLine("As you gaze at the base, a feeling of impending doom and fear lingers upon you.");
    WriteLine("Do you have the power necessary to defeat Megatron by yourself? If you fail what will happen to the world? Should you turn back?");
    WriteLine("It's too late to turn back now, you must defeat Megatron and the Decepticons.");
    WriteLine("You stumble upon an injured autobot on the side of the road, do you want to help him? (Y or N)");
    switch (ChoiceSelection())
    {
        case Y:
            WriteLine("You use some of your resources to help the autobot.");
            currentRegion = AcidWastes4;
            break;
        case N:
            WriteLine("You leave the autobot to die alone, he is only a hinderance to your mission.");
            currentRegion = AcidWastes5;
            break;

    }
    //once again you can finish and adjust dialogue
}
void AcidWastes3Loop()
{
    WriteLine("You have arrived at the Acid Wastes, be ready to meet the Decepticons!");
    WriteLine("As you approach the base you start to feel conviction in your heart for the choice you have made.");
    WriteLine("Do you really think the Decepticons are capable of defeating someone like Optimus Prime?");
    WriteLine("With you there to help them of course they do!....Right?");
    WriteLine("As you're being introduced to Megatron and the rest of the Decepticons you see the autobots approaching, get ready to fight them.");
    WriteLine(""); //idk stuff about the fight
    WriteLine("Everything has fallen apart, nothing is going to plan, you lie there injured and quickly dying. Why did you ever choose to side with Megatron? Why did you want the power?");
    WriteLine("Game Over.");
    currentRegion = null;
}

//what happens if you choose to help the autobot
void AcidWastes4Loop()
    {
        WriteLine("");
    }

//what happens if you choose to abandon the autobot
void AcidWastes5Loop()
    {
        WriteLine("You were too weak, the overwhelming power of Megatron was too much for you, a singular weak autobot, to overcome. Hopefully the Autobots hear of Megatron's plan and are successful unlike you.");
        WriteLine("Game Over.");
        currentRegion = null;
    }

//An Enemy Fight
void Seeker()
{
    EnemyHealth = 100;
    EnemySpeed = 60;
    EnemyStrength = 20;
}

void TurnOne()
{

}

void UpdateHealth(int h)
{
    
}