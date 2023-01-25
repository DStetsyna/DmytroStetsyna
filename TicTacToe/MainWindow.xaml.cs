using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        public bool Player1Turn { get; set; } 
        public int Count { get; set; } 
        public MainWindow()
        {
            InitializeComponent();
            Game();
        }

        public void Game()
        {
            Player1Turn = false;
            Count = 0;
            Button_00.Content = string.Empty;
            Button_10.Content = string.Empty;
            Button_20.Content = string.Empty;
            Button_01.Content = string.Empty;
            Button_11.Content = string.Empty;
            Button_21.Content = string.Empty;
            Button_02.Content = string.Empty;
            Button_12.Content = string.Empty;
            Button_22.Content = string.Empty;

            Button_00.Background = Brushes.White;
            Button_10.Background = Brushes.White;
            Button_20.Background = Brushes.White;
            Button_01.Background = Brushes.White;
            Button_11.Background = Brushes.White;
            Button_21.Background = Brushes.White;
            Button_02.Background = Brushes.White;
            Button_12.Background = Brushes.White;
            Button_22.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player1Turn ^= true;
            Count++;

            if (Count > 9)
            {
                Game();
                return;
            }
            var button = sender as Button;
            button.Content = Player1Turn ? "O" : "X";

            if (CheckWin())
            {
                Count = 9;
            }
        }

        private bool CheckWin()
        {
            if (Button_00.Content.ToString() != string.Empty &&
                Button_00.Content == Button_01.Content && Button_01.Content == Button_02.Content)
            {
                Button_00.Background = Brushes.Green;
                Button_01.Background = Brushes.Green;
                Button_02.Background = Brushes.Green;
                return true;
            }
            if (Button_10.Content.ToString() != string.Empty &&
                Button_10.Content == Button_11.Content && Button_11.Content == Button_12.Content)
            {
                Button_10.Background = Brushes.Green;
                Button_11.Background = Brushes.Green;
                Button_12.Background = Brushes.Green;
                return true;
            }
            if (Button_20.Content.ToString() != string.Empty &&
                Button_20.Content == Button_21.Content && Button_21.Content == Button_22.Content)
            {
                Button_20.Background = Brushes.Green;
                Button_21.Background = Brushes.Green;
                Button_22.Background = Brushes.Green;
                return true;
            }
            if (Button_00.Content.ToString() != string.Empty && 
                Button_00.Content == Button_10.Content && Button_10.Content == Button_20.Content)
            {
                Button_00.Background = Brushes.Green;
                Button_10.Background = Brushes.Green;
                Button_20.Background = Brushes.Green;
                return true;
            }
            if (Button_01.Content.ToString() != string.Empty && 
                Button_01.Content == Button_11.Content && Button_11.Content == Button_21.Content)
            {
                Button_01.Background = Brushes.Green;
                Button_11.Background = Brushes.Green;
                Button_21.Background = Brushes.Green;
                return true;
            }
            if (Button_02.Content.ToString() != string.Empty && 
                Button_02.Content == Button_12.Content && Button_12.Content == Button_22.Content)
            {
                Button_02.Background = Brushes.Green;
                Button_12.Background = Brushes.Green;
                Button_22.Background = Brushes.Green;
                return true;
            }
            if (Button_00.Content.ToString() != string.Empty && 
                Button_00.Content == Button_11.Content && Button_11.Content == Button_22.Content)
            {
                Button_00.Background = Brushes.Green;
                Button_11.Background = Brushes.Green;
                Button_22.Background = Brushes.Green;
                return true;
            }
            if (Button_02.Content.ToString() != string.Empty && 
                Button_02.Content == Button_11.Content && Button_11.Content == Button_20.Content)
            {
                Button_02.Background = Brushes.Green;
                Button_11.Background = Brushes.Green;
                Button_20.Background = Brushes.Green;
                return true;
            }
            return false;
        }
    }
}
