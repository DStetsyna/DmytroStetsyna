
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Project_PR
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }
        SqlConnection conect = new SqlConnection("Data Source = Django; Initial Catalog = Form; Integrated Security = True");

        private void LoadData()
        {
            conect.Open();
            SqlCommand c = new SqlCommand();
            c.CommandText = "select * from [User_data]";
            c.Connection = conect;
            SqlDataAdapter adapter = new SqlDataAdapter(c);
            DataTable dt = new DataTable("User_data");
            adapter.Fill(dt);
            MoviesGrid.ItemsSource = dt.DefaultView;
        }

        private void NewELButton_Click(object sender, RoutedEventArgs e)
        {
           Add add_window = new Add();
            add_window.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Edit edit_window = new Edit();
            edit_window.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Chcesz usunąć film?", "Uwaga", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(Txtbid.Text);
                //SqlConnection conect = new SqlConnection("Data Source = Django; Initial Catalog = Form; Integrated Security = True");
                // conect.Open();
                SqlCommand com = new SqlCommand("Delete User_data where Film_id = '" + id + "'", conect);
                com.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted");
            }
        }
    }
}

