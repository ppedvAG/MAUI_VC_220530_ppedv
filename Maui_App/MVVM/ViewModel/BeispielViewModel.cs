using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_App.MVVM.ViewModel
{
    internal class BeispielViewModel
    {
        private string neuerHersteller = String.Empty;

        public ObservableCollection<Model.PKW> PkwListe
        {
            get { return Model.PKW.PkwListe; }
            set { Model.PKW.PkwListe = value; }
        }

        public string NeuerHersteller { get => neuerHersteller; set { neuerHersteller = value; AddCmd.ChangeCanExecute(); } }
        public int NeueMaxGeschwindigkeit { get; set; }
        public DateTime NeuesJahr { get; set; }

        public Command AddCmd { get; set; }
        public Command DeleteCmd { get; set; }


        public BeispielViewModel()
        {
            AddCmd = new Command
                (
                    () =>
                    {
                        Model.PKW pkw = new Model.PKW() { Hersteller = NeuerHersteller, MaxGeschwindigkeit = NeueMaxGeschwindigkeit, Herstellungjahr = NeuesJahr };

                        PkwListe.Add(pkw);
                    },
                    () =>
                    {
                        return !NeuerHersteller.Equals(String.Empty);
                    }
                );
            DeleteCmd = new Command
                (
                    p =>
                    {
                        PkwListe.Remove(p as Model.PKW);
                    },
                    p => p is Model.PKW
                );
        }
    }
}
