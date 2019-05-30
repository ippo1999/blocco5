namespace Esercizio04
{
    public class Developer : Employee
    {
        public string PreferredLanguage { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - Address: {3}", Name, Role, PreferredLanguage, Address);
        }
        public override Employee Clone()
        {
            return this.MemberwiseClone() as Employee;
        }
    }
}