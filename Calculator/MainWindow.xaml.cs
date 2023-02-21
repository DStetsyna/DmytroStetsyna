using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement el in CalGrid.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += ButtonClick; 
                }
            }
        }

       private void ButtonClick(Object sender, RoutedEventArgs e)
        {
            try
            {
                string TextButton = ((Button)e.OriginalSource).Content.ToString();

                if (TextButton == "C")
                {
                    Display.Clear();
                }
                else if (TextButton == "=")
                {
                    Display.Text = new DataTable().Compute(Display.Text, null).ToString();
                }
                else Display.Text += TextButton;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
