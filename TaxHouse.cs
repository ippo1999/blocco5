namespace Esercizio01
{
    public class TaxableHouse : House, ITaxable
    {

        public TaxableHouse(string location, bool inCity, double area, decimal value) :
          base(location, inCity, area, value)
        {
        }

        public decimal TaxValue()
        {
            if (inCity && area > 300)

                return (estimatedValue / 1000.0M) * 5M + 10M * (decimal)area;
            else if (inCity && area <= 300)

                return (estimatedValue / 1000.0M) * 5M + 5M * (decimal)area;
            else
                return (estimatedValue / 1000.0M) * 3M;
        }
    }
}