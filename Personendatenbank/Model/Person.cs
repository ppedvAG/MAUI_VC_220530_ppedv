using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        public static ObservableCollection<Person> Personenliste { get; set; } = new ObservableCollection<Person>()
        {
            new Person(){ Name = "Anna Nass", Geschlecht=Gender.Weiblich, Verheiratet = true, Geburtsdatum=new DateTime(2003, 12, 3) },
        };
    }
}
