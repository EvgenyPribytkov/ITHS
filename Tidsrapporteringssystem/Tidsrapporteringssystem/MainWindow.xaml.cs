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

namespace Tidsrapporteringssystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] availableTime = new string[] { "08:00", "08:30", "09:00", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00" };
        List<string> registrations = new List<string>();
        public string[] AvailableTime
        {
            get { return availableTime; }
            set { availableTime = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            EnableButton();
        }

        private void EnableButton()
        {
            if (InputWork.Text.Length == 0 || MyCalendar.SelectedDate == null || Start.SelectedItem == null || End.SelectedItem == null)
            {
                Register.IsEnabled = false;
            } 
            else Register.IsEnabled = true;
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan();
            timeSpan = TimeSpan.Parse(End.SelectedItem.ToString()) - TimeSpan.Parse(Start.SelectedItem.ToString());
            registrations.Add($"{InputWork.Text} {MyCalendar.SelectedDate.Value.ToString("d")} {timeSpan.ToString("hh\\:mm")}");
            //RefreshListBox();
        }
        private void RefreshListBox()
        {
            ListOfRegistrations.ItemsSource = null;
            ListOfRegistrations.ItemsSource = registrations;
        }

        private void Changed(object sender, SelectionChangedEventArgs e)
        {
            EnableButton();
        }

        private void Changed(object sender, TextChangedEventArgs e)
        {
            EnableButton();
        }
    }
}
