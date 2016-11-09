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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void X_O(object sender, RoutedEventArgs e)
        {
            FirstWindow cross_null = new FirstWindow();
            cross_null.Show();
            this.Close();
        }

        private void Sudoku_Game(object sender, RoutedEventArgs e)
        {
            SecondWindow sudoku = new SecondWindow();
            sudoku.Show();
            this.Close();
        }

        private void New_Game(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please select first game");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
           if( MessageBox.Show("Close Game ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void About_Programe(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a program that allows you to play two games. You can play as a logical game sudoku or cross and null. In next version you will play Cross and Null on Internet");
        }
    }
}
