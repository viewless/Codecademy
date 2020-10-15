using System;
using System.Collections.Generic;
using System.Text;

namespace SupernaturalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        {
        }

        public override Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", true, Title);
            return storm;
        }

        public Storm CastLightningStorm()
        {
            Storm storm = new Storm("lightning", true, Title);
            return storm;
        }
    }
}
