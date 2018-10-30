using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryProject
{
    public class MemorySaveGameInformation
    {
        private string txtdata1;
        private string txtdata2;
        private string txtdata3;
        private string txtdata4;
        private string txtdata5;


        public string Player1Name
        {
            get { return txtdata1; }
            set { txtdata1 = value; }
        }

        public string Player2Name
        {
            get { return txtdata2; }
            set { txtdata2 = value; }
        }

        public string Player1Score
        {
            get { return txtdata3; }
            set { txtdata3 = value; }
        }

        public string Player2Score
        {
            get { return txtdata4; }
            set { txtdata4 = value; }
        }

        public string ThemeSelected
        {
            get { return txtdata5; }
            set { txtdata5 = value; }
        }




    }
}
