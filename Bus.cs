﻿namespace Esercizio01
{
    public class Bus : Vehicle
    {

        protected int numberOfSeats;

        public Bus(int numberOfSeats, int regNumber, decimal value) :
            base(regNumber, 80, value)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats
        {
            get
            {
                return numberOfSeats;
            }
        }

    }
}
