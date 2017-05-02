using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace Zad_3._3.Tests
{
    [TestFixture]
    public class DziennikTests
    {


        [Test]
        public void EdytujOcene_ValidString_Updated()
        {
            Przedmiot przedmiot = new Przedmiot("Historia");
            przedmiot.EdytujOcene("Przyroda");
            Assert.AreEqual("Przyroda", przedmiot.nazwa);
        }

        [Test]
        public void EdytujOcene_EmptyString_NotUpdated()
        {
            var przedmiot = new Przedmiot("Historia");
            przedmiot.EdytujOcene(" ");
            Assert.AreEqual("Historia", przedmiot.nazwa);
        }

        [Test]
        public void SprawdzObecnosc_BoolValue_ObecnoscChanged()
        {
            Przedmiot przedmiot = new Przedmiot("Historia");
            Obecnosc obecnosc = new Obecnosc(true, przedmiot);
            obecnosc.SprawdzObecnosc(false);
            Assert.AreEqual(false, obecnosc.obecny);
        }

        [Test]
        public void ZmienOcene_DoubleValue_OcenaChanged()
        {
            Przedmiot przedmiot = new Przedmiot("Historia");
            Ocena ocena = new Ocena(5.0, przedmiot);
            ocena.ZmienOcene(4.0);
            Assert.AreEqual(4.0, ocena.wartosc);
        }


        [Test]
        public void DodajOcene_DoubleValueInRange_OcenaAdded()
        {
            Przedmiot przedmiot = new Przedmiot("Historia");
            Ocena ocena = new Ocena(5.0, przedmiot);
            Uczen uczen = new Uczen("Kinga", "Lemm");
            uczen.DodajOcene(ocena);
            Assert.IsTrue(uczen.oceny.Contains(ocena));
        }

        [Test]
        public void DodajOcene_DoubleValueOutOfRange_OcenaNotAdded()
        {
            Przedmiot przedmiot = new Przedmiot("Historia");
            Ocena ocena = new Ocena(7.5, przedmiot);
            Uczen uczen = new Uczen("Kinga", "Lemm");
            uczen.DodajOcene(ocena);
            Assert.IsTrue(!uczen.oceny.Contains(ocena));
        }

        [Test]
        public void ObliczSrednia_CalculateGrades_SredniaCalculated()
        {
            Przedmiot historia = new Przedmiot("Historia");
            Przedmiot przyroda = new Przedmiot("Przyroda");
            Ocena ocena1 = new Ocena(2.0, historia);
            Ocena ocena2 = new Ocena(3.0, przyroda);
            Ocena ocena3 = new Ocena(5.0, przyroda);
            Ocena ocena4 = new Ocena(6.0, historia);
            Uczen uczen = new Uczen("Kinga", "Lemm");
            uczen.DodajOcene(ocena1);
            uczen.DodajOcene(ocena2);
            uczen.DodajOcene(ocena3);
            uczen.DodajOcene(ocena4);
            Assert.AreEqual(4.0, uczen.ObliczSredniaOcen());
        }

        


    }
}
