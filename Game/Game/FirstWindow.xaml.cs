using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Game
{
    /// <summary>
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void New_Game(object sender, RoutedEventArgs e)
        {
            FirstWindow new_game = new FirstWindow();
            if (MessageBox.Show("Start new game ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                new_game.Show();
                this.Close();
            }
        }
        private void X_O(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You play this game now");
        }

        private void Sudoku_Game(object sender, RoutedEventArgs e)
        {
            SecondWindow new_game = new SecondWindow();
            if (MessageBox.Show("Do you really want to move to a new game ? The data will not be saved.", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                new_game.Show();
                this.Close();
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Close Game ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void About_Programe(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Players take turns putting on the free cell field 3x3 characters (always one crosses, the other crosses always). The first who managed to build a series of 3 of its shape vertically, horizontally or diagonally wins. The first player makes a move that puts daggers. Usually at the end of the party the party that won its three crosses feature a mark(cross or crosses) which form a continuous row.");
        }
    }
}
