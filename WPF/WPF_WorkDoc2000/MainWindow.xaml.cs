using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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
using static System.Console;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string choice = "";
        string fileName = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RäknaAntalOrd(object sender, RoutedEventArgs e)
        {
            WordAmount.Text = (MyTextBox.Text.Split(" ").Length).ToString();
        }

        private void Upload(object sender, RoutedEventArgs e)
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
                string text = "";
                foreach (string s in readText)
                {
                    text += s + "\n";
                }
                MyTextBox.Text = text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Save(object sender, RoutedEventArgs e)
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

                File.WriteAllText(dlg.FileName, MyTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MakeCapitalLetters(object sender, RoutedEventArgs e)
        {
            string[] arr = MyTextBox.Text.Split(". ");
            string text = "";
            foreach(string s in arr)
            {
                text += s.First().ToString().ToUpper() + s.Substring(1) + ". ";
            }
            MyTextBox.Text = text;
        }

        private void CapitalizeText(object sender, RoutedEventArgs e)
        {
            MyTextBox.Text = MyTextBox.Text.ToUpper();
        }

        private void LettersToNumbers(object sender, RoutedEventArgs e)
        {
            MyTextBox.Text = MyTextBox.Text.Replace(Letter.Text, Number.Text);
            //char[] arr = MyTextBox.Text.ToCharArray();
            //string text = "";
            //foreach(char c in arr)
            //{
            //    if(c.ToString() == Letter.Text)
            //    {
            //        text += Number.Text;
            //    }
            //    else
            //    {
            //        text += c.ToString();
            //    }
            //}
            //MyTextBox.Text = text;
        }
    }
}