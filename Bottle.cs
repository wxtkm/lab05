using System;
using System.Collections.Generic;
using System.Text;

namespace zadania_5_24832
{
    internal class Bottle
    {
        double capacity;
        double procent;
        public Bottle(double capacity, double procent)
        {
            if (!BottleValidator.ValidateBottle(capacity, procent, out string error))
                throw new ArgumentException(error);

            this.capacity = capacity;
            this.procent = procent;
        }

        public double CalculateTotalVolume(int count)
        {
            if (!BottleValidator.ValidateCount(count, out string error))
                throw new ArgumentException(error);

            return capacity * count;
        }

        public double CalculatePureSubstance(int count)
        {
            double totalVolume = CalculateTotalVolume(count);
            return totalVolume * procent / 100;
        }


    }
}
