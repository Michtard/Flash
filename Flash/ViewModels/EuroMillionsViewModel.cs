using Flash.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Flash.ViewModels
{
    class EuroMillionsViewModel : BaseViewModel
    {
        public EuroMillionsViewModel()
        {
            randomNumero = new Random();
            randomEtoile = new Random();
            Numeros = new List<int>();
            Etoiles = new List<int>();
            Euro = new EuroMillions();
            ExecuteEuroFlash();
        }

        private void ExecuteEuroFlash()
        {
            Numeros.Clear();
            Etoiles.Clear();

            while (Numeros.Count != 5)
            {
                int numeroAleatoire = randomNumero.Next(1, 51);
                save = true;

                foreach (var numero in Numeros)
                {
                    if (numero == numeroAleatoire)
                    {
                        save = false;
                    }
                }

                if (save)
                    Numeros.Add(numeroAleatoire);
            }

            while (Etoiles.Count != 2)
            {
                int etoileAleatoire = randomEtoile.Next(1, 13);
                save = true;

                foreach (var etoile in Etoiles)
                {
                    if (etoile == etoileAleatoire)
                    {
                        save = false;
                    }
                }

                if (save)
                    Etoiles.Add(etoileAleatoire);
            }

            Euro.Numero_un = Numeros.ElementAt(0);
            Euro.Numero_deux = Numeros.ElementAt(1);
            Euro.Numero_trois = Numeros.ElementAt(2);
            Euro.Numero_quatre = Numeros.ElementAt(3);
            Euro.Numero_cinq = Numeros.ElementAt(4);
            Euro.Etoile_un = Etoiles.ElementAt(0);
            Euro.Etoile_deux = Etoiles.ElementAt(1);
        }
    }
}
