using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5
{
    public class MorseTree
    {
        #region given code
        private char character;
        private MorseTree dot;
        private MorseTree dash;

        public MorseTree AddCharacter(char c, string morsecode)
        {
            c = Char.ToLower(c);
            if (morsecode == "")
                character = c;
            else if (morsecode[0] == '.')
            {
                if (dot == null)
                    dot = new MorseTree();
                dot.AddCharacter(c, morsecode.Remove(0, 1));
            }
            else
            {
                if (dash == null)
                    dash = new MorseTree();
                dash.AddCharacter(c, morsecode.Remove(0, 1));
            }

            return this;
        }
        #endregion

        public char GiveCharacterByMorseCode(string morsecode)
        {
            throw new NotImplementedException();
        }

        public string GiveMorsecode(char c)
        {
            return GiveMorsecode(Char.ToLower(c), "");
        }

        private string GiveMorsecode(char c, string code)
        {
            throw new NotImplementedException();
        }
    }
}
