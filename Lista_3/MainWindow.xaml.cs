using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Lista_3
{
    public partial class MainWindow : Window
    {
        List<Person> Personslist = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("C://test.xml"))
            {
                Personslist = Serialization.DeserializeToObject<List<Person>>("C://test.xml");
            }
            else
            {
               Personslist.Add(new Person("1111", "Roman", "Kaczor", "10"));
               Personslist.Add(new Person("1111", "Roman", "Kaczor", "10"));
               Personslist.Add(new Person("1111", "Roman", "Kaczor", "10"));
               Personslist.Add(new Person("1111", "Roman", "Kaczor", "10"));
            }
            tablePerson.ItemsSource = Personslist;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow window = new SecondWindow();
            Person person = new Person();
            window.DataContext = person;
            window.ShowDialog();
            if (window.okPressed)
            {
                Personslist.Add(person);
                tablePerson.Items.Refresh();
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Serialization.SerializeToXml<List<Person>>(Personslist, "C://test.xml");
        }
    }
}
