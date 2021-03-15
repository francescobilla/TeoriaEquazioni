using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest2
    {
        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(1, true)]
        [DataRow(5, true)]
        [DataRow(-5, true)]
        public void IsDeterminedTest(double a, bool risultato_aspettato)
        {
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(risultato_aspettato, risp);
        }
        [DataTestMethod]
        [DataRow(3,4,7, -68)]
        [DataRow(2, 4, 0, 16)]
        [DataRow(2, 4, 2, 0)]
        public void DeltaTest(double a, double b, double c, double risultato_aspettato)
        {
            double risp = Equazioni.Delta(a, b, c);
            Assert.AreEqual(risultato_aspettato, risp);
        }
    }
}
