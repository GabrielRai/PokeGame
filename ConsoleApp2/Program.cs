using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using PokemonCommon;
using PokemonCommon.Characters;
using PokemonCommon.Enums;
using PokemonCommon.Pokemons;
using PokemonCommon.Pokemons.Attacks;

Trainer ash = new Trainer("Ash");

Pokemon sobble = new Pokemon("Sobble", PokeTypes.Water);
Pokemon charmander = new Pokemon("Charmander", PokeTypes.Fire);

Ember ember = new Ember();
charmander.LearnAttack(ember, 0);

QuickAttack quickAttack = new QuickAttack();
charmander.LearnAttack(quickAttack, 1);

WaterGun waterGun = new WaterGun();
sobble.LearnAttack(waterGun, 0);

List<string> pokeList = new List<string>();
{
    pokeList.Add("Sobble");
    pokeList.Add("Charmander");
}

Console.WriteLine("Välkommen till Pokemon-Battle simulator");

Console.WriteLine("Är du redo?");
Console.WriteLine("1: Jag är redo.");
Console.WriteLine("2: Nej.");
string userInput = Console.ReadLine();
string yourPokemon = "";
string pokeAttack1 = "";
string pokeAttack2 = "";

var userPokemon = charmander;
if (userInput == "1")
{
    Console.WriteLine("Välj en Pokemon:");
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine((i + 1 ) + ". " + pokeList[i]);

    }

    
}

userInput = Console.ReadLine();
if (userInput == "1")
{
    userPokemon = sobble;
    yourPokemon = "Sobble";
}
else if (userInput == "2")
{
    userPokemon = charmander;
    yourPokemon = "Charmander";
    pokeAttack1 = "Ember";
    pokeAttack2 = "Quick attack";
}

Console.WriteLine("Nu börjar matchen.");

bool alive = true;
int userAttack = 0;
string attack = "";
while(alive)
{

    Console.WriteLine("Choose an attack:");
    Console.WriteLine("1: " + pokeAttack1 + "2: " + pokeAttack2);
    attack = Console.ReadLine(); 
    userAttack = Convert.ToInt32(attack);

    BattleEngine.MakeAttack(userPokemon, sobble.Attacks[0], sobble.Name);
    BattleEngine.MakeAttack(sobble, userPokemon.Attacks[userAttack - 1], userPokemon.Name);  

    Console.WriteLine("Sobble´s hp: " + sobble.HealthPoints); 
    Console.WriteLine(yourPokemon + "´s hp is " + userPokemon.HealthPoints); 
    alive = IsAlive.HealthPointCheck(userPokemon, sobble);
    Console.ReadKey();
}

