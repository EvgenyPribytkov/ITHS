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
using System.Text.RegularExpressions;

namespace WPF_övning_3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var regex = new Regex(@"^[a-zA-Z]\w*@\w+\.[a-zA-Z]{2,}$");
            bool isMatch = regex.IsMatch(myTextBox.Text);
            if (isMatch)
            {
                myLabel.Content = "Valid email";
            }
            else
            {
                myLabel.Content = "Invalid email";
            }
            
        }
    }
}
