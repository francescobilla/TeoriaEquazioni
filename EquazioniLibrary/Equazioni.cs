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
    }
}
