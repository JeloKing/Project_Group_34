using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek1
{
    class Huisdier
    {
        private string naam;
        private string soort;
        private bool zindelijk;

        public Huisdier(string naam, string soort, bool zindelijk)
        {
            this.naam = naam;
            this.soort = soort;
            this.zindelijk = zindelijk;
        }

        public string GetNaam()
        {
            return naam;
        }

        public string GetSoort()
        {
            return soort;
        }
        public string GetBeschrijving()
        {
            return naam + " is een " + soort;
        }
        public bool GetZindelijk()
        {
            return zindelijk;
        }
        ///<summary>
        ///laat je huisdieren aan een persoon toevoegen en geeft dit weer
        ///</summary>
        ///<param name="naam">de naam van het huisdieren(string)</param>
        ///<param name="soort">de soort van het huisdier(string)</param>
        ///<returns>geeft de naam en soort van toegevoegd dier weer</returns>
    }

}
