using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local
{
    internal static class Record
    {
        internal const int COLONNE_G = 2;
        internal const int COLONNE_M_G = 8;
        internal const int COLONNE_M_D = 14;
        internal const int COLONNE_D = 20;
        internal const int COLONNE_Q = 26;
        internal const int COLONNE_R = 13;
        internal const int LIGNE_H = 1;
        internal const int LIGNE_M_H = 2;
        internal const int LIGNE_M_B = 3;
        internal const int LIGNE_B = 4;
        internal const int LIGNE_R = 5;
        internal const int BTN_PRESS = 0x0001;

        internal static string? num1;
        internal static string? num2;
        internal static double calc1 = 0;
        internal static double calc2 = 0;         
        internal static string ope = "";
        internal static double resultat = 0;
        internal static string? resultat_litt="impossible";
        internal static bool ope_check = false;
    }
}