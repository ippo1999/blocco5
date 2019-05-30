namespace Esercizio01
{
    public class TaxableBus : Bus, ITaxable
    {

        public TaxableBus(int numberOfSeats, int regNumber, decimal value) : base(numberOfSeats, regNumber, value)
        {
        }

        public decimal TaxValue()
        {
            if (numberOfSeats > 30) return (value / 20) + 20M * numberOfSeats;

            else return (value / 20) + 10M * numberOfSeats;
        }
    }
}
