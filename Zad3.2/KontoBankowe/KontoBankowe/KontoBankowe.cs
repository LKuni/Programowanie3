using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoBankowe
{
    public class KontoBankowe

    {
        public string ImieINazwisko;
        public string NumerKonta;
        public double Fundusze;
        public int IDKonta;

        static int nr = 1;

        public KontoBankowe(string ImieINazwisko, string NrKonta, double Fundusze)
        {
            this.ImieINazwisko = ImieINazwisko;
            this.NumerKonta = NrKonta;
            this.Fundusze = Fundusze;
            this.IDKonta = nr;
            nr++;
        }

        public double SprawdzFundusze()
        {
            return Fundusze;
        }


        public double WplacFundusze(double kwota)
        {
            if (kwota > 0)
            {
                Fundusze += kwota;
            }
            return Fundusze;
    
        }

        public double WyplacFundusze(double kwota)
        {
            if (kwota <= Fundusze)
            {
                Fundusze -= kwota;
            }
            return Fundusze;
        }
        
        

        public double PrzelejFundusze(double kwota, KontoBankowe user)
        {
            if (kwota<= Fundusze)
            {
                Fundusze -= kwota;
                user.WplacFundusze(kwota);
            }
            return Fundusze;
        }
    }
}
