using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5
{
    public class Person
    {
        private string name;
        private int evilness = 50;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int evilness)
        {
            this.name = name;
            SetEvilness(evilness);
        }

        public string GetName()
        {
            return name;
        }

        private void SetEvilness(int evilness)
        {
            if ((evilness >= 0) && (evilness <= 100))
            {
                this.evilness = evilness;
            }
        }

        /// <summary>
        /// Returns true when this person is more evil then given person as parameter
        /// </summary>
        /// <param name="p">person compared to</param>
        /// <returns>true if this person is more evil then person given as parameter</returns>
        public bool IsMoreEvil(Person p)
        {
            return evilness > p.evilness;
        }
    }
}