using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_App
{
    internal class Person : INotifyPropertyChanged
    {
        private int alter;

        public string Name { get; set; }
        public int Alter { get => alter; set { alter = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter))); } }

        public event PropertyChangedEventHandler PropertyChanged;


        public ObservableCollection<DateTime> WichtigeDaten { get; set; } 

        public Person()
        {
            WichtigeDaten = new ObservableCollection<DateTime>();

            WichtigeDaten.Add(new DateTime(2002, 12, 3));
            WichtigeDaten.Add(new DateTime(2013, 1, 2));
        }



    }
}
