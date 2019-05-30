using System;
using System.Collections;
using System.Collections.Generic;

namespace Esercizio04
{
    public class Company
    {
        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

        public void FillCollection()
        {
            Developer dev = new Developer();
            dev.Name = "John";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C++";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Paul"; //Not mention Role and PreferredLanguage, it will copy above

            Typist typist = new Typist();
            typist.Name = "Elisabeth";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Mark";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above
        }
    }
}

