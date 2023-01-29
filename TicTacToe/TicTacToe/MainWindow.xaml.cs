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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void singleplyBtn_Click(object sender, RoutedEventArgs e)
        {
            SinglePlayer sp = new SinglePlayer();
            sp.Show();
        }

        private void multiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            MultiPlayer mp = new MultiPlayer();
            mp.Show();
        }

        private void howtoBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                            "1. The game is played on a grid that's 3 squares by 3 squares.\n"+
                            "2.You are X, your friend(or the computer if single player) is O. Players take turns putting their marks in empty squares.\n"+
                            "3.The first player to get 3 of their marks in a row(up, down, across, or diagonally) is the winner.\n"+
                            "4.When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie."
                            );
        }
    }
}
