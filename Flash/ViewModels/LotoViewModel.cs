using Flash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Flash.ViewModels
{
    class LotoViewModel : BaseViewModel
    {
        public LotoViewModel()
        {
            randomNumero = new Random();
            randomEtoile = new Random();
            Numeros = new List<int>();
            Loto = new Loto();
            ExecuteLotoFlash();
        }

        private void ExecuteLotoFlash()
        {
            Numeros.Clear();

            while (Numeros.Count != 5)
            {                
                int numeroAleatoire = randomNumero.Next(1, 50);
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

            int etoileAleatoire = randomEtoile.Next(1, 11);

            Loto.Numero_un = Numeros.ElementAt(0);
            Loto.Numero_deux = Numeros.ElementAt(1);
            Loto.Numero_trois = Numeros.ElementAt(2);
            Loto.Numero_quatre = Numeros.ElementAt(3);
            Loto.Numero_cinq = Numeros.ElementAt(4);
            Loto.Etoile_un = etoileAleatoire;
        }
    }
}
