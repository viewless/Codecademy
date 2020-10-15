using System;
using System.Collections.Generic;
using System.Text;

namespace SupernaturalInheritance
{
    class Storm
    {
        public string Essence { get; set; }
        public bool IsStrong { get; set; }
        public string Caster { get; set; }

        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;

        }

        public string Announce()
        {
            string weakStrong;
            if (IsStrong == true)
            {
                weakStrong = "strong";
            }
            else
            {
                weakStrong = "weak";
            }
            return $"{Caster} cast a {weakStrong} {Essence} storm!";
        }
    }
}
