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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        
        public MainWindow()
        {
            controller = Controller.GetInstance();
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(firstname.Text != "" && lastname.Text != "" && age.Text != "" && phone.Text != "")
            {
                controller.AddPerson(new Person(firstname.Text, lastname.Text, Int32.Parse(age.Text), phone.Text));
                count.Text = controller.PersonCount.ToString();
                index.Text = controller.PersonIndex.ToString();
                
            }
            
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            count.Text = controller.PersonCount.ToString();
            index.Text = controller.PersonIndex.ToString();
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            count.Text = controller.PersonCount.ToString();
            index.Text = controller.PersonIndex.ToString();
            firstname.Text = controller.CurrentPerson.FirstName;
            lastname.Text = controller.CurrentPerson.LastName;
            age.Text = controller.CurrentPerson.Age.ToString();
            phone.Text = controller.CurrentPerson.TelephoneNr;
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            count.Text = controller.PersonCount.ToString();
            index.Text = controller.PersonIndex.ToString();
            firstname.Text = controller.CurrentPerson.FirstName;
            lastname.Text = controller.CurrentPerson.LastName;
            age.Text = controller.CurrentPerson.Age.ToString();
            phone.Text = controller.CurrentPerson.TelephoneNr;
        }
    }
}
