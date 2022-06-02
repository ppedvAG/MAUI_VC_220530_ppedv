using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_App.MVVM.ViewModel
{
    //Im ViewModel-Teil eines MVVM-Programms werden Klassen definiert, welche als Verbindungsstück zwischen den Views und den Modelklassen fungieren.
    //Diese Klassen sind die einzigen Programmteile, welche Referenzen auf Model-Klassen beinhalten. Sie selbst sind jeweils einem View zugrordnet,
    //mit welchem sie (nur) über den BindingContext des jeweiligen Views verbunden sind.
    //INotifyPropertyChanged informiert die GUI über Veränderungen in den Daten
    internal class BeispielViewModel : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Aufruf des PropertyChanged-Events zur Benachrichtigung der GUI über Veränderungen
        private void InformView(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        } 
        #endregion

        
        //Property zur Repräsentation der Anzahl der geladenen Personen (verlinkt an die Model-Klasse)
        public ObservableCollection<Model.PKW> PkwListe
        {
            get { return Model.PKW.PkwListe; }
            set { Model.PKW.PkwListe = value; }
        }

        private string neuerHersteller = String.Empty;
        public string NeuerHersteller { get => neuerHersteller; set { neuerHersteller = value; AddCmd.ChangeCanExecute(); } }
        public int NeueMaxGeschwindigkeit { get; set; }
        public DateTime NeuesJahr { get; set; }

        //Command-Properties
        public Command AddCmd { get; set; }
        public Command DeleteCmd { get; set; }


        //Konstruktor
        public BeispielViewModel()
        {
            AddCmd = new Command
                (
                    //Execute-Methode des Commands (Definiert, was das Command bei Ausführung tut)
                    () =>
                    {
                        Model.PKW pkw = new Model.PKW() { Hersteller = NeuerHersteller, MaxGeschwindigkeit = NeueMaxGeschwindigkeit, Herstellungjahr = NeuesJahr };

                        PkwListe.Add(pkw);

                        NeuerHersteller = String.Empty;
                        NeueMaxGeschwindigkeit = 0;
                        NeuesJahr = DateTime.Now;

                        InformView(nameof(NeuerHersteller));
                        InformView(nameof(NeueMaxGeschwindigkeit));
                        InformView(nameof(NeuesJahr));
                    },
                    //CanExecute-Methode des Commands (Definiert, wann das Command ausgeführt werden darf)
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
