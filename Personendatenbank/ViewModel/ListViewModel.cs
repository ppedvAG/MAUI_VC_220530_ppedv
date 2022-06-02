using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personendatenbank.ViewModel
{
    internal class ListViewModel
    {
        public ObservableCollection<Model.Person> Personenliste
        {
            get { return Model.Person.Personenliste; }
        }

        public Command DeleteCmd { get; set; } = new Command
            (
                p =>
                {
                    Model.Person.Personenliste.Remove(p as Model.Person);
                },
                p => p is Model.Person
            );
    }
}
