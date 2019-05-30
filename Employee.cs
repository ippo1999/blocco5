using System;

namespace Esercizio04
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public Address Address { get; set; }

        public abstract Employee Clone();
        public abstract override String ToString();
    }
}
