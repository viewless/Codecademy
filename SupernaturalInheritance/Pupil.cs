using System;
using System.Collections.Generic;
using System.Text;

namespace SupernaturalInheritance
{
    class Pupil
    {
        public string Title { get; private set; }

        public Pupil(string title)
        {
            this.Title = title;
        }

        public Storm CastWindStorm()
        {
            Storm storm = new Storm("wind", false, Title);

            return storm;
        }
    }
}
