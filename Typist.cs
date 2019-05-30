namespace Esercizio04
{
    public class Typist : Employee
    {
        public int WordsPerMinute { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}wpm - Address: {3}", Name, Role, WordsPerMinute, Address);
        }
        public override Employee Clone()
        {
            return this.MemberwiseClone() as Employee;
        }
    }
}