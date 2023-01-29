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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MultiPlayer.xaml
    /// </summary>
    public partial class MultiPlayer : Window
    {
        public static int pxWins = 0;
        public static int poWins = 0;
        public MultiPlayer()
        {
            InitializeComponent();
        }

        //booleans to decide whose turn it is
        public static Boolean player1 = true;
        public static Boolean player2 = false;
        //element meanign x or o
        public static String element = "";
        //count is how many turns were had (when 9 done then tie)
        public static int Count = 0;

        //since multiple buttons will be doing the same thing, 1 event handler made
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Count++;
            //which button was acually clicked
            Button btn = (Button)sender;
            btn.IsEnabled = false;

            if (player1 == true)
            {
                btn.Background = Brushes.Blue;
                btn.Content = "X";
                element = "X";
                //player 2 turn true
                player1 = false;
                player2 = true;
            }
            else if (player2 == true)
            {
                btn.Background = Brushes.Orange;
                btn.Content = "O";
                element = "O";
                //player 1 turn true
                player1 = true;
                player2 = false;
            }

            IsWin(sender, e);
        }

        public void IsWin(object sender, RoutedEventArgs e)
        {
            //all possible win outcomes
            String winMessage = "Congratulations " + element + " you win!";

            if (
                //diaganol
                outcome(btn1, btn5, btn9) ||
                //antidiaganol
                outcome(btn7, btn5, btn3) ||
                //1st row
                outcome(btn1, btn2, btn3) ||
                //2nd row
                outcome(btn4, btn5, btn6) ||
                //3rd row
                outcome(btn7, btn8, btn9) ||
                //1st col
                outcome(btn1, btn4, btn7) ||
                //2nd col
                outcome(btn2, btn5, btn8) ||
                //3rd col
                outcome(btn3, btn6, btn9)
                )
            {
                MessageBox.Show(winMessage);

                pxlbl.Content = "Player X Wins: " + pxWins;
                polbl.Content = "Player O Wins: " + poWins;

                //restting board
                resetbtn_Click(sender, e);
            }

            //in case of tie, reset board
            if (Count == 9)
            {
                MessageBox.Show("A tie!");
                resetbtn_Click(sender, e);
            }

        }

        public Boolean outcome(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Content.ToString().Equals(element) && btn2.Content.ToString().Equals(element) && btn3.Content.ToString().Equals(element))
            {
                //win count for players going up
                if (element.Equals("X"))
                {
                    pxWins++;
                }
                else
                {
                    poWins++;
                }
                return true;
            }
            return false;
        }

        private void resetbtn_Click(object sender, RoutedEventArgs e)
        {
            Count = 0;
            //list with all buttons
            List<Button> button = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            //resetting board
            foreach (Button btn in button)
            {
                btn.Content = "";
                btn.IsEnabled = true;
                btn.Background = Brushes.LightGray;
            }
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
