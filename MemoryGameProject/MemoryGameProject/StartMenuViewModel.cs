using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGameProject
{
    public class StartMenuViewModel
    {
        private const int nr_of_cols = 4;
        private const int nr_of_rows = 4;

        MemoryGrid grid;

        


        private MainWindow _mainWindow;

        public StartMenuViewModel(MainWindow main)
        {
            _mainWindow = main;
        }

        public void StartNewGame()
        {
            // GameViewModel newGame = new GameViewModel(GameGrid, nr_of_rows, nr_of_cols);
            // _mainWindow.DataContext = newGame;
        }

    }
}
