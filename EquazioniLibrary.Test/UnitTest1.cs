using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsDeterminedTest()
        {
            double a = 0;//5,0
            bool risultato_aspettato = false;//true, false
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(risultato_aspettato, risp); 
        }
        [TestMethod]
        public void IsInconsistedTest()
        {
            double a = 10;//0,10
            double b = 3;//0,3
            bool risultato_aspettato = false;
            bool risp = Equazioni.IsInconsisted(a,b);
            Assert.AreEqual(risultato_aspettato, risp);
        }
        [TestMethod]
        public void IsDegree2Test()
        {
            double esponente = 3;//1, 3
            bool risultato_aspettato = true;// false, true
            bool risp = Equazioni.IsDegree2(esponente);
            Assert.AreEqual(risultato_aspettato, risp);
        }
        [TestMethod]
        public void DeltaTest()
        {
            double a = 2;//3,2 test nullo 2
            double b = 4;//4,4 test nullo 4
            double c = 2;//7,0 test nullo 2
            double risultato_aspettato = 0;//-68,16 test nullo 0
            double risp = Equazioni.Delta(a,b,c);
            Assert.AreEqual(risultato_aspettato, risp);
        }
        [TestMethod]
        public void Soluzioni()
        {
            double a = 2;//2,3,2
            double b = 4;//4,4,4
            double c = 0;//2,7,0
            string risultato_aspettato = "la soluzione è: 0 e -2";//"la soluzione è: -1 e -1","impossibile","la soluzione è: 0 e -2"
            string risp = Equazioni.Soluzioni(a, b, c);
            Assert.AreEqual(risultato_aspettato, risp);
        }
        [TestMethod]
        public void EquationDegree1Test()
        {
            double a = 3;//2, 2,0,3
            double b = 0;//4, -4,0,0
            string risultato_aspettato = "impossibile";//"il risultato dell'equazione è: 2","il risultato dell'equazione è: -2","indeterminato","impossibile"
            string risp = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risultato_aspettato, risp);
        }
    }
}
