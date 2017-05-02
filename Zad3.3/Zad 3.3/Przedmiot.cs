using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad_3._3
{
    public class Przedmiot
    {
        public string nazwa;

        public Przedmiot(string nazwa) 
        {
            this.nazwa = nazwa;
        }

        public void EdytujOcene(string nazwa)
        {
            if (nazwa.Trim().Length > 0)
                this.nazwa = nazwa;
        }
    }
}
