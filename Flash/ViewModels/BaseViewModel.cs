using Flash.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Flash.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<int> Numeros;
        public List<int> Etoiles;
        public Random randomNumero;
        public Random randomEtoile;
        public bool save;


        private Loto loto;
        public Loto Loto
        {
            get
            {
                return loto;
            }
            set
            {
                if (value != loto)
                {
                    loto = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Loto"));
                }
            }
        }

        private EuroMillions euro;
        public EuroMillions Euro
        {
            get
            {
                return euro;
            }
            set
            {
                if (value != euro)
                {
                    euro = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Euro"));
                }
            }
        }
    }
}
