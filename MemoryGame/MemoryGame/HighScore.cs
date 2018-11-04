using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class HighScore
    {
        /// <summary>
        /// On method call opens the HighScores.txt file, takes all the string in said file and puts them in a list.
        /// Which it then sorts based on score and puts them back in the file.
        /// </summary>
        /// <param name="Score"></param>
        /// <param name="Playername"></param>
        public void NewHighScore(int Score, string Playername)
        {
            string Filename = "HighScores.txt";
            List<string> ScoreList;

            if (File.Exists(Filename))
            {
                ScoreList = File.ReadAllLines(Filename).ToList();
            } else
            {
                ScoreList = new List<string>();
            }

            ScoreList.Add(Playername + " " + Convert.ToString(Score));

            var SortedScoreList = ScoreList.OrderByDescending(ss => int.Parse(ss.Substring(ss.LastIndexOf(" ") + 1)));
            var SortedScoreListArray = SortedScoreList.ToArray();

            if (SortedScoreListArray.Length > 10) SortedScoreListArray.Reverse().Skip(1).Reverse().ToArray();
            File.WriteAllLines(Filename, SortedScoreListArray.ToArray());
        }

    }
}
