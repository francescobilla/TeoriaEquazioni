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
    }
}
