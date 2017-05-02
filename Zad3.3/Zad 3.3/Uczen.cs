﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_3._3
{
    public class Uczen
    {
        private string imie;
        private string nazwisko;
        public List<Ocena> oceny;

        public Uczen(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.oceny = new List<Ocena>();
        }

        public void DodajOcene (Ocena ocena)
        {
            if (ocena.wartosc >= 1.0 && ocena.wartosc <= 6.0)
                oceny.Add(ocena);
        }

        public double ObliczSredniaOcen()
        {
            double suma = 0;
            foreach (Ocena ocena in this.oceny)
            {
                suma += ocena.wartosc;
            }
            return suma / this.oceny.Count;
        }

    }
}
