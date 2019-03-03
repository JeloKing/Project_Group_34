using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5
{
    public class PersonTree
    {
        #region given code
        private Person person;
        private PersonTree lessEvil;
        private PersonTree moreEvil;

        public PersonTree(Person p)
        {
            person = p;
        }

        public string GetPersonName()
        {
            return person.GetName();
        }

        public string GetMostEvilPerson()
        {
            if (moreEvil == null)
                return person.GetName();
            else
                return moreEvil.GetMostEvilPerson();
        }
        #endregion

        public void Add(Person p)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// return names of persons in the tree sorted from good to evil
        /// </summary>
        /// <returns>names of persons in the tree sorted from good to evil</returns>
        public string GetAllNamesSorted()
        {
            throw new NotImplementedException();
        }
    }
}
