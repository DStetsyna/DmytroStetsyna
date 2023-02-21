using System;
using System.Data.SqlClient;
using System.Windows;

namespace Project_PR
{
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
        }
        SqlConnection conect = new SqlConnection("Data Source = Django; Initial Catalog = Form; Integrated Security = True");
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(TxtbID.Text); 
            string category = TxtbCategory.Text, name = TxtbName.Text, country = TxtbCountry.Text;
            int prod_year = Convert.ToInt32(TxtbYear.Text), film_lenght = Convert.ToInt32(TxtbLength.Text);
            conect.Open();
            SqlCommand cmd = new SqlCommand("exec UpdateData'" + id + "', '" + category + "','" + name + "','" + country + "','" + prod_year + "','" + film_lenght + "'",conect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated");
            MainWindow main_window = new MainWindow();
            main_window.Show();
            this.Close();
        }
    }
}
