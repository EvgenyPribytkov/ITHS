using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace DailyWeatherData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<DailyWeather> dailyWeatherList = new List<DailyWeather>();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool sunnyOrNot = false;
            bool temperatureParsed = false;
            bool windSpeedParsed = false;
            if ((bool)Sunny.IsChecked)
            {
                sunnyOrNot = true;
            }
            else if ((bool)NotSunny.IsChecked)
            {
                sunnyOrNot = false;
            }
            else
            {
                MessageBox.Show("Please choose if the weather is sunny or not");
            }
            double windSpeed = 0;
            if (WindSpeed != null)
            {
                windSpeedParsed = double.TryParse(WindSpeed.Text, out windSpeed);
                if (!windSpeedParsed)
                {
                    MessageBox.Show("Choose valid wind speed");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Choose wind speed");
            }
            double temperature = 0;
            if (Temperature != null)
            {
                temperatureParsed = double.TryParse(Temperature.Text, out temperature);
                if (!temperatureParsed)
                {
                    MessageBox.Show("Choose valid temperature");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Choose temperature");
            }
            if (temperatureParsed && windSpeedParsed && ((bool)Sunny.IsChecked || (bool)NotSunny.IsChecked))
            {
                dailyWeatherList.Add(new DailyWeather(sunnyOrNot, windSpeed, temperature));
                MessageBox.Show("Day is added");
                ClearContext();
                DisplayContent();
            }
        }

        private void ClearContext()
        {
            WindSpeed.Clear();
            Temperature.Clear();
            Sunny.IsChecked = false;
            NotSunny.IsChecked = false;
        }

        public void DisplayContent()
        {
            weatherList.ItemsSource = null;
            weatherList.ItemsSource = dailyWeatherList;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            await SerializeList();
            weatherList.ItemsSource = null;
        }

        private async Task SerializeList()
        {
            using FileStream fs = File.Create("weatherdata.json");
            await JsonSerializer.SerializeAsync(fs, dailyWeatherList);
            await fs.DisposeAsync();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            await DeserializeList();
            DisplayContent();
        }

        private async Task DeserializeList()
        {
            using (FileStream fs = File.OpenRead("weatherdata.json"))
            {
                dailyWeatherList = await JsonSerializer.DeserializeAsync<List<DailyWeather>>(fs);
            }
        }
    }
}
