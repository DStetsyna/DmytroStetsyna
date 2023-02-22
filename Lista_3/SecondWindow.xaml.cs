using System.Windows;

namespace Lista_3
{
    public partial class SecondWindow : Window
    {
        public bool okPressed { get; set; }
        public SecondWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            okPressed = false;
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            okPressed = true;
            this.Close();
        }
    }
}

