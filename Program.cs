using System;

namespace WizardNinjaSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Earthlings!");
            Human PlayerOne = new Human("William");
            Wizard NPC1 = new Wizard("Kyle");
            System.Console.WriteLine(PlayerOne);
            System.Console.WriteLine(NPC1);
            NPC1.Fireball(PlayerOne);
            System.Console.WriteLine(PlayerOne);
            Ninja NPC2 = new Ninja("Chris");
            NPC2.Steal(PlayerOne);
            NPC2.GetAway();
            System.Console.WriteLine("Ninja health: "+NPC2.health);

        }
    }
}
