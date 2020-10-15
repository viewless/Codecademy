using System;

namespace SupernaturalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm storm = new Storm("wind", false, "Zul'rajas");

            Console.WriteLine(storm.Announce());

            Pupil pupil = new Pupil("Mezil-kree");

            Storm storm2 = pupil.CastWindStorm();

            Console.WriteLine(storm2.Announce());

            Mage mage = new Mage("Gul’dan");

            var temp = mage.CastRainStorm();
            Console.WriteLine(temp.Announce());

            Archmage archmage = new Archmage("Nielas Aran");
            var temp1 = archmage.CastRainStorm();
            var temp2 = archmage.CastLightningStorm();

            Console.WriteLine(temp1.Announce());
            Console.WriteLine(temp2.Announce());
        }
    }
}
