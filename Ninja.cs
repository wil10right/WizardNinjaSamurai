using System;

namespace WizardNinjaSam
{
    public class Ninja : Human
    {
        public Ninja(string name):base(name)
        {
            this.name = name;
            this.dexterity = 175;
        }
        public void Steal(Human victim)
        {
            this.Attack(victim);
            this.health += 10;
            System.Console.WriteLine(victim.name+" just got stole on! Ninja health is now: "+this.health);
        }
        public void GetAway()
        {
            this.health -= 15;
            System.Console.WriteLine(this.name+" got away! Health down 15.");
        }

    }
}