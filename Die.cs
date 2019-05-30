using System;
using System.Collections.Generic;

namespace Esercizio02
{
    public delegate void Notifier();

    public class Die : IComparable
    {
        private int number;
        static private Random randomNumberSupplier = new Random((int)DateTime.Now.Ticks);
        private const int numMax = 6;
        public event Notifier twoSixesInARow = delegate { };
        public event Notifier fullHouse = delegate { };
        private List<int> previus = new List<int>();

        public Die()
        {
            Toss();
        }

        public void Toss()
        {
            number = NewToss();
            previus.Add(number);
            if (TwoSixesInARowDetector(previus))
                twoSixesInARow();
            if (FullHouseDetector(previus))
                fullHouse();
        }

        private bool TwoSixesInARowDetector(List<int> previus)
        {
            int prevCount = previus.Count;
            return prevCount >= 2 &&
                   previus[prevCount - 1] == 6 && previus[prevCount - 2] == 6;
        }

        private bool FullHouseDetector(List<int> previus)
        {
            int x1 = 0, x2 = 0,  
                y1 = 0, y2 = 0,   
                prevCount = previus.Count;
            if (prevCount >= 5)
            {
                for (int i = -5; i <= -1; i++)
                {    
                    if (x1 == 0) { x1 = previus[prevCount + i]; y1 = 1; }  
                    else if (x2 == 0 && x1 != previus[prevCount + i])
                    { x2 = previus[prevCount + i]; y2 = 1; }  
                    else if (x1 == previus[prevCount + i]) y1++;
                    else if (x2 == previus[prevCount + i]) y2++;
                    else return false;                                         
                }
                return (y1 == 2 && y2 == 3) || (y1 == 3 && y2 == 2);
            }
            else return false;
        }

        private int NewToss()
        {
            return randomNumberSupplier.Next(1, numMax + 1);
        }

        public int Number()
        {
            return number;
        }

        public override String ToString()
        {
            return String.Format("[{0}]", number);
        }

        public int CompareTo(object other)
        {
            return this.number.CompareTo(((Die)other).number);
        }
    }

}





