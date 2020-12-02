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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        
        public MainWindow()
        {
            string imgPath = "C:\\Users\\netto\\Pictures\\demo\\"; //No funciona con Path relativo
            InitializeComponent();

            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Icon= imgPath+"Icons\\Luma-Red.png" });
            people.Add(new Person { FirstName = "Violeta", LastName = "Romero", Icon = imgPath + "Icons\\Luma-Yellow.png" });
            people.Add(new Person { FirstName = "Breneli", LastName = "Galvez", Icon = imgPath + "Icons\\Luma-Green.png" });


            myComboBox.ItemsSource = people;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hola {firstNameText.Text}");
        }
    }


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Icon { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName } ";
            }
        }
    }
}
