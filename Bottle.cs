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
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));

            if (procent < 0 || procent > 100)
                throw new ArgumentOutOfRangeException(nameof(procent));

            this.capacity = capacity;
            this.procent = procent;
        }

        public double CalculateTotalVolume(int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            return capacity * count;
        }

        public double CalculatePureSubstance(int count)
        {
            double totalVolume = CalculateTotalVolume(count);
            return totalVolume * procent / 100;
        }


    }
}
