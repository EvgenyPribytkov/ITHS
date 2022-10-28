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
using System.IO;

namespace Labb_3
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

        public void DisplayContent()
        {
            Bookings.Items.Clear();
            foreach(Booking booking in listOfBookings)
            {
                Bookings.Items.Add($"{booking.Date} {booking.Time} {booking.Name} {booking.TableNumber}");
            }
            //Bookings.ItemsSource = null;
            //Bookings.ItemsSource = listOfBookings.Select(booking => $"{booking.Date} {booking.Time} {booking.Name} {booking.TableNumber}").ToList();
        }
        List<Booking> listOfBookings = new List<Booking>() {
            new Booking("25.11.2022", "16:00", "Anna", "1"),
            new Booking("26.11.2022", "21:00", "Peter", "5"),
            new Booking("28.11.2022", "19:00", "Karl", "3"),
            new Booking("29.11.2022", "20:00", "Martin", "2"),};

        private string formatted;

        private void Boka(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = MyDatePicker.SelectedDate;
            if (selectedDate.HasValue)
            {
                formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

            
            List<Booking> Matches = listOfBookings
    .Where(b => b.Date == formatted && b.Time == TimeChoice.SelectionBoxItem.ToString())
    .Where(b => b.TableNumber == TableNumberChoice.SelectionBoxItem.ToString()).ToList();
            
            try
            {
                if (MyDatePicker.SelectedDate == null)
                {
                    MessageBox.Show("Please enter date");
                }
                else if (TimeChoice.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter time");
                }
                else if (Name.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Please enter the name");
                }
                else if (TableNumberChoice.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter table number");
                }
                else if (Matches.Count < 5)
                {
                    listOfBookings.Add(new Booking(formatted, TimeChoice.SelectionBoxItem.ToString(), Name.Text, TableNumberChoice.SelectionBoxItem.ToString()));
                    TableNumberChoice.SelectedIndex = -1;
                    MyDatePicker.SelectedDate = null;
                    TimeChoice.SelectedIndex = -1;
                    Name.Text = "";
                    DisplayContent();
                }
                else if (listOfBookings
                    .Where(b => b.Date == formatted && b.Time == TimeChoice.SelectionBoxItem.ToString()).ToList().Count() >= 25)
                {
                    MessageBox.Show("All seats at five tables for this timeslot are booked. Please try with another timeslot.");
                }
                else
                {
                    MessageBox.Show("This time and table are not available. Please try with another table.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
        //class InvalidChoiceException : Exception
        //{
        //    public InvalidChoiceException() { }

        //    public InvalidChoiceException(i)
        //        : base(String.Format("Invalid Choice: {0}", choice))
        //    {
        //    }
        //}
        private void VisaBokningar(object sender, RoutedEventArgs e)
        {
            //Bookings.Text = ShowAListOfBookings();
            DisplayContent();
        }
        private string ShowAListOfBookings()
        {
            string bookings = "";
            foreach (Booking booking in listOfBookings)
            {
                bookings += $"{booking.Date} {booking.Time} {booking.Name} {booking.TableNumber}\n";
            }
            return bookings;
        }

        private void Avboka(object sender, RoutedEventArgs e)
        {
            if (Bookings.SelectedItem == null)
                return;
            
            listOfBookings.RemoveAt(Bookings.SelectedIndex);
            Bookings.Items.Remove(Bookings.SelectedItem);
            //DisplayContent();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            try
            {
                // Configure open file dialog box
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.FileName = "Document"; // Default file name
                dlg.DefaultExt = ".txt"; // Default file extension
                dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by ex
                                                            // Show open file dialog box
                Nullable<bool> result = dlg.ShowDialog();
                // Process open file dialog box results
                if (result == true)
                {
                    // Open document
                    string filename = dlg.FileName;
                }
                string[] readText = File.ReadAllLines(dlg.FileName);
                listOfBookings.Clear();
                List<string> bookingsList = readText.ToList<string>();
                foreach (string x in bookingsList)
                {
                    string[] bookings = x.Split(" ");
                    listOfBookings.Add(new Booking(bookings[0], bookings[1], bookings[2], bookings[3]));
                }
                DisplayContent();
                //string text = "";
                //foreach (string s in readText)
                //{
                //    text += s + "\n";
                //}
                
                //Bookings.Text = text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
        private void SaveFile(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "Document"; // Default file name
                dlg.DefaultExt = ".txt"; // Default file extension
                dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by ex
                                                            // Show save file dialog box
                Nullable<bool> result = dlg.ShowDialog();
                // Process save file dialog box results
                if (result == true)
                {
                    // Save document
                    string filename = dlg.FileName;
                }

                File.WriteAllText(dlg.FileName, ShowAListOfBookings());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
