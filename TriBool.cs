using System;

namespace Esercizio03
{
    public class TriBool
    {
        // The three possible TriBool values:
        public static TriBool isTrue = new TriBool(1);
        public static TriBool indeterminate = new TriBool(0);
        public static TriBool isFalse = new TriBool(-1);

        private int value;

        // Private constructor. The value parameter must be -1, 0, or 1:
        private TriBool(int value)
        {
            this.value = value;
        }

        // Implicit conversion from bool to TriBool
        public static implicit operator TriBool(bool x)
        {
            if (x)

                return isTrue;

            else

                return isFalse;
        }

        // Explicit conversion from TriBool to bool
        public static explicit operator bool(TriBool x)
        {
            if (x.value == 0)

                throw new InvalidOperationException();

            return x.value != 0;
        }

        // Equal operator
        public static TriBool operator ==(TriBool x, TriBool y)
        {
            if (x.value == 0 || y.value == 0)

                return indeterminate;

            else if (x.value == y.value)

                return isTrue;

            else return isFalse;

        }

        // Not equal operator
        public static TriBool operator !=(TriBool x, TriBool y)
        {
            if (x.value == 0 || y.value == 0)

                return indeterminate;

            else if (x.value != y.value)

                return isTrue;

            else return isFalse;
        }

        // Not operator
        public static TriBool operator !(TriBool x)
        {
            x = new TriBool(-x.value);

            return x;
        }

        //AND operator
        public static TriBool operator &(TriBool x, TriBool y)
        {
            if (x.value < y.value) return x;

            else return y;
        }

        //OR operator
        public static TriBool operator |(TriBool x, TriBool y)
        {
            if (x.value > y.value) return x;

            else return y;

        }

        //True operator
        public static bool operator true(TriBool x)
        {
            return x.value > 0;
        }

        // False operator
        public static bool operator false(TriBool x)
        {
            return x.value < 0;
        }

        // Conversion TriBool to string
        public static implicit operator string(TriBool x)
        {
            if (x.value > 0) return "True";

            else if (x.value < 0) return "False";

            else return "Indeterminate";

        }

        // Override the Object.Equals(object o) method:
        public override bool Equals(object o)
        {
            try
            {
                return (bool)(this.value == ((TriBool)o).value);
            }
            catch
            {
                return false;
            }
        }

        // Override the Object.GetHashCode() method:
        public override int GetHashCode()
        {
            return value;
        }

        // Override the ToString method to convert TriBool to a string:
        public override string ToString()
        {
            switch (value)
            {
                case -1:
                    return "False";
                case 0:
                    return "Indeterminate";
                case 1:
                    return "True";
                default:
                    throw new InvalidOperationException("Operation not valid!");
            }
        }
    }
}

