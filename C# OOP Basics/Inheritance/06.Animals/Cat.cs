﻿public class Cat : Animal
{
    public Cat(string name, string age, string gender)
        : base(name, age, gender)
    {
    }

    public override string PorduceSound()
    {
        return "MiauMiau";
    }
}