using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personendatenbank.Model
{
    internal class Person
    {
        public string Name { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public Gender Geschlecht { get; set; }
        public bool Verheiratet { get; set; }

        public Person()
        {
            Geburtsdatum = DateTime.Now;

            Geschlecht = Gender.Weiblich;
        }
    }
}
