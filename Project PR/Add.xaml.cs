using System;
using System.Data.SqlClient;
using System.Windows;

namespace Project_PR
{
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }
        SqlConnection conect = new SqlConnection("Data Source = Django; Initial Catalog = Form; Integrated Security = True");
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            string category = TxtbCategory.Text, name = TxtbName.Text, country = TxtbCountry.Text;
            int prod_year = Convert.ToInt32(TxtbYear.Text), film_lenght = Convert.ToInt32(TxtbLength.Text);
            conect.Open();
            SqlCommand cmd = new SqlCommand("exec InsertData'" + category + "','" + name + "','" + country + "','" + prod_year + "','" + film_lenght + "'", conect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted");
            MainWindow main_window = new MainWindow();
            main_window.Show();
            this.Close();
        }
    }
}
