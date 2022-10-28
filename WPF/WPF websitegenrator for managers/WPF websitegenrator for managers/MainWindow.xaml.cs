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

namespace WPF_websitegenerator_for_managers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateWebsite(object sender, RoutedEventArgs e)
        {
            string[] techniques = Technologies.Text.Split(Environment.NewLine);
            string[] messagesToClass = Messages.Text.Split(Environment.NewLine);
            string color = "";
            if (MyLabel.Content.ToString() == "Red")
            {
                color = "red";
            }
            else if (MyLabel.Content.ToString() == "Green")
            {
                color = "green";
            }
            else if (MyLabel.Content.ToString() == "Purple")
            {
                color = "purple";
            }
            StyledWebsiteGenerator website = new StyledWebsiteGenerator("Klass A", color, messagesToClass, techniques);
            Content.Text = website.printPage();

        }

        private void GenerateGreenWebsite(object sender, RoutedEventArgs e)
        {
        }

        private void GenerateRedWebsite(object sender, RoutedEventArgs e)
        {
        }

        private void GeneratePurpleWebsite(object sender, RoutedEventArgs e)
        {
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            MyLabel.Content = rb.Content.ToString();
           
        }
        
    }
}
