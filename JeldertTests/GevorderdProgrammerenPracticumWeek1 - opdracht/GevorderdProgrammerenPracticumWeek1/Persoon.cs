using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek1
{
    class Persoon
    {
        private string voornaam;
        private string achternaam;
        private int leeftijd;
        private string woonplaats;
        private List<Huisdier> huisdieren;

        public Persoon(string voornaam, string achternaam, int leeftijd, string woonplaats)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.leeftijd = leeftijd;
            this.woonplaats = woonplaats;
            huisdieren = new List<Huisdier>();
        }

        public string GetNaam()
        {
            return voornaam + " " + achternaam;
        }

        public List<Huisdier> GetHuisdieren()
        {
            return huisdieren;
        }

        public void AddHuisdier(Huisdier huisdier)
        {
            huisdieren.Add(huisdier);
        }

        public int GetLeeftijd()
        {
            return leeftijd;
        }

        public string GetWoonplaats()
        {
            return woonplaats;
        }
        ///<summary>
        ///laat je een persoon toevoegen aan de lijst
        /// </summary>
        /// <param name="voornaam">zet de voornaam in een string</param>
        /// <param name="achtrnaam">zet de achternaam in een string</param>
        /// <param name="leeftijd">zet de leeftijd van de persoon in een int</param>
        /// <return>geeft de voornaam, achternaam en leeftijd van een persoon weer</return>
    }
}
