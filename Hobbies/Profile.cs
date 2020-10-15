using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Hobbies
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            //this.hobbies = new string[] { };
        }

        public string ViewProfile()
        {
            return $"{name},{age},{city},{country},{pronouns} hobies are:\n";
        }

        public void SetHobbies(string[] hobbies)
        {
            
            foreach (var item in hobbies)
            {
                Console.WriteLine(item);
            }
        }
    }
}

