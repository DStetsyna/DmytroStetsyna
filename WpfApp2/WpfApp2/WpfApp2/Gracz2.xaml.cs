using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public partial class Gracz2 : Window
    {
        public Gracz2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (((Game)plnPersonForm.DataContext).PersonIdTwo[Convert.ToInt32(btn.Tag.ToString())] == 0)
                ((Game)plnPersonForm.DataContext).PersonIdTwo[Convert.ToInt32(btn.Tag.ToString())]++;
            else if (((Game)plnPersonForm.DataContext).PersonIdTwo[Convert.ToInt32(btn.Tag.ToString())] == 1)
                ((Game)plnPersonForm.DataContext).PersonIdTwo[Convert.ToInt32(btn.Tag.ToString())]--;
        }

        private void Button_Click_shot(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (((Game)plnPersonForm.DataContext).PersonIdOne[Convert.ToInt32(btn.Tag.ToString())] == 0 || ((Game)plnPersonForm.DataContext).PersonIdOne[Convert.ToInt32(btn.Tag.ToString())] == 1)
                ((Game)plnPersonForm.DataContext).PersonIdOne[Convert.ToInt32(btn.Tag.ToString())] += 2;
        }
    }
}
