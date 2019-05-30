using System;

namespace Esercizio04
{
    public class Address
    {
        public String Street { get; set; }
        public String Town { get; set; }
        public String Country { get; set; }
        public String ZIPCode { get; set; }
        public Address(string street, string town, string country, string zipCode)
        {
            this.Street = street;
            this.Town = town;
            this.Country = country;
            this.ZIPCode = zipCode;
        }
        public override string ToString()
        {
                return string.Format("{0}, {1} - {2} ({3})", Street, ZIPCode, Town, Country);
        }

    }
}
