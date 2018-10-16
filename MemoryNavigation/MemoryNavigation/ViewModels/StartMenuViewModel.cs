using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MemoryNavigation.ViewModels
{
    public class StartMenuViewModel
    {

        private MainWindow _mainWindow;
        public StartMenuViewModel(MainWindow main)
        {
            _mainWindow = main;
            // MessageBox.Show("test");
        }


        public void StartNewGame()
        {
            GameViewModel newGame = new GameViewModel();
            _mainWindow.DataContext = newGame;
        }

        

    }
}
