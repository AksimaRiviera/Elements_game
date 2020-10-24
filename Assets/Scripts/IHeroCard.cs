using System;
using UnityEngine;

public interface IHeroCard 
{
    string PlayerID { get; }
    string HeroName { get; }

    int Reflex { get; set; }
    int Body { get; set; }
    int Intellegence { get; set; }
    int Wisdom { get; set; }
    int Level { get; set; }
    int Money { get; set; }
    float Expirience { get; set; }
    float HitPoints { get; set; }
    float ManaPoints { get; set; }
    float MagicalArmorClass { get; set; }
    float RecoveryHitPoints { get; set; }
    float RecoveryManaPoints { get; set; }

    string TakeReflex();
    string TakeBody();
    string TakeIntellegence();
    string TakeWisdom();

    void AddingCharacteristics(int r, int b, int i, int w);



}
