using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)// true equazione determinata a>0
        {
            bool determinata = false;     
            if (a>0)
            {
                return determinata = true;
            }
            return determinata;
        }
        public static bool IsInconsisted(double a, double b)// true equazione impossibile a=0, b=0 
        {
            if (a == 0 && b == 0)
                return true;

            return false;
        }
        public static bool IsDegree2(double esponente)// false se l'equazione non è di secondo grado
        {
            if(esponente == 1)
            {
                return false;
            }
            return true;
        }
        public static double Delta(double a, double b, double c)
        {
            double delta = (b * b) + (-4 * a * c);
            return delta;
        }
       public static string Soluzioni(double a, double b, double c)
        {
            double delta = Delta(a, b, c);
            if (delta < 0)
            {
                string s = "impossibile";
                return s;
            }
            double x1 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
            double x2 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);
            string x1_x2= $"la soluzione è: {x1} e {x2}";
            return x1_x2;
        }

    }
}
