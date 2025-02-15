﻿using PokemonCommon.Enums;

namespace PokeGame;

public static class BattleUi
{
    private static Dictionary<Effectiveness, string> messages = new Dictionary<Effectiveness, string>()
    {
        { Effectiveness.None, "It har no effect!"},
        { Effectiveness.NotVery, "It´s not very effective..."},
        { Effectiveness.Normal , ""},
        { Effectiveness.Super , "It´s super effective!"}
    };

    public static void DisplayDamageEffectiveness(Effectiveness effectiveness, string attackName, string attacker)
    {
        Console.WriteLine($" {attacker} used {attackName} {messages[effectiveness]}");
    }
}