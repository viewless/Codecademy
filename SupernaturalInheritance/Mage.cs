using System;
using System.Collections.Generic;
using System.Text;

namespace SupernaturalInheritance
{
    class Mage : Pupil
    {
        public Mage(string title) : base(title)
        {

        }
        
        public virtual Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", false, Title);
            return storm;
        }
    }
}
