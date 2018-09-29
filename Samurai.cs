using System;

namespace WizardNinjaSam
{
    public class Samurai : Human
    {
        public Samurai(string name):base(name)
        {
            this.name = name;
            this.health = 200;
        }

        public void DeathBlow(Human victim)
        {
            if(victim.health < 50)
            {
                victim.health = 0;
            }else{
                this.health -=20;
            }
        }
        public void Meditate()
        {
            this.health = 200;
        }
    }
}