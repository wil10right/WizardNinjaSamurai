using System;

namespace WizardNinjaSam
{
    public class Wizard : Human
    {
        public Wizard(string name):base(name)
        {
            this.name = name;
            this.health = 50;
            this.intelligence = 25;
        }

        public void Heal()
        {
            this.intelligence += 10;
        }

        public void Fireball(Human victim)
        {
            Random randy = new Random();
            victim.health -= randy.Next(20,50);
            System.Console.WriteLine("Sick Burn! Victim health is now: "+victim.health);
        }
    }

}