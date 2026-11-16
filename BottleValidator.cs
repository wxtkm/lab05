using System;
using System.Collections.Generic;
using System.Text;

namespace zadania_5_24832
{
    internal static class BottleValidator
    {
        public static bool ValidateBottle(
            double capacity, double procent, out string error)
        {
            if (double.IsNaN(capacity) || double.IsInfinity(capacity) || capacity <= 0)
            {
                error = "Pojemność musi być większa od zera.";
                return false;
            }

            if (double.IsNaN(procent) || double.IsInfinity(procent) ||
                procent < 0 || procent > 100)
            {
                error = "Procent musi być od 0 do 100.";
                return false;
            }

            error = "";
            return true;
        }

        public static bool ValidateCount(int count, out string error)
        {
            if (count <= 0)
            {
                error = "Liczba naczyń musi być większa od zera.";
                return false;
            }

            error = "";
            return true;
        }
    }
}
