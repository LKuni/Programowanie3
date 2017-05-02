using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KontoBankowe.Tests
{
    [TestFixture]
    public class KontoBankoweTests
    {
        [Test]
        public void WplacFundusze_UjemnaWartosc_AreEqual()
        {
            KontoBankowe konto = new KontoBankowe("abc", "def123", 1234);
            Assert.AreEqual(konto.WplacFundusze(-100), 1234);
        }

        [Test]
        public void WplacFundusze_DodatniaWartosc_AreEqual()
        {
            KontoBankowe konto = new KontoBankowe("abc", "def123", 1234);
            Assert.AreEqual(konto.WplacFundusze(1000), 2234);
        }

        [Test]
        public void WyplacFundusze_MniejNizNaKoncie_AreEqual()
        {
            KontoBankowe konto = new KontoBankowe("abc", "def123", 1234);
            Assert.AreEqual(konto.WyplacFundusze(200), 1034);
        }

        [Test]
        public void WyplacFundusze_WiecejNizNaKoncie_AreEqual()
        {
            KontoBankowe konto = new KontoBankowe("abc", "def123", 1234);
            Assert.AreEqual(konto.WyplacFundusze(1500), 1234);
        }

        [Test]
        public void PrzelejFundusze_MniejNizNaKoncie_Konto1_AreEqual()
        {
            KontoBankowe konto1 = new KontoBankowe("abc", "def123", 1234);
            KontoBankowe konto2 = new KontoBankowe("abc", "def123", 1234);
            Assert.AreEqual(konto1.PrzelejFundusze(300, konto2), 934);
        }

        [Test]
        public void PrzelejFundusze_MniejNizNaKoncie_Konto2_AreEqual()
        {
            KontoBankowe konto1 = new KontoBankowe("abc", "def123", 1234);
            KontoBankowe konto2 = new KontoBankowe("abc", "def123", 1234);
            konto1.PrzelejFundusze(300, konto2);
            Assert.AreEqual(konto2.SprawdzFundusze(), 1534);
        }

        [Test]
        public void PrzelejFundusze_WiecejNizNaKoncie_Konto1_AreEqual()
        {
            KontoBankowe konto1 = new KontoBankowe("abc", "def123", 1234);
            KontoBankowe konto2= new KontoBankowe("abc", "def123", 1234);
            Assert.AreEqual(konto1.PrzelejFundusze(1300, konto2), 1234);
        }

        [Test]
        public void PrzelejFundusze_WiecejNizNaKoncie_Konto2_AreEqual()
        {
            KontoBankowe konto1 = new KontoBankowe("abc", "def123", 1234);
            KontoBankowe konto2 = new KontoBankowe("abc", "def123", 1234);
            konto1.PrzelejFundusze(1300, konto2);
            Assert.AreEqual(konto2.SprawdzFundusze(), 1234);
        }
    }
}
