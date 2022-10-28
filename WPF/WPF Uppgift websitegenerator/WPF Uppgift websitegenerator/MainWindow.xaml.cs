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



namespace WPF_Uppgift_websitegenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        static string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };
        static string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };

        // Vi skapar ett objekt för att kunna hantera en hemsida
        WebsiteGenerator website = new WebsiteGenerator("Klass A", messagesToClass, techniques);

        //// Vi skapar en hemsida som tillåter styling, vi skickar in en färg utöver andra delar
        //StyledWebsiteGenerator styledWebsite = new StyledWebsiteGenerator("Klass A", "blue", messagesToClass, techniques);

        private void GenerateWebsite(object sender, RoutedEventArgs e)
        {
            //Content.Text = "< !DOCTYPE html >\n< html >\n< body >\n< main >\n< h1 > Valkomna Klass A! </ h1 >\n< p >< b > Meddelande: </ b > Glom inte att ovning ger fardighet! </ p >" +
            //"\n< p >< b > Meddelande: </ b > Oppna boken pa sida 257. </ p >\n< p > C#</p>\n< p > Databaser </ p >\n< p > Webbutveckling </ p >\n< p > Clean code </ p >\n </ main >\n </ body >\n </ html >";
            Content.Text = website.printPage();
        }
        private void GenerateStyledWebsite(object sender, RoutedEventArgs e)
        {
            StyledWebsiteGenerator styledWebsite = new StyledWebsiteGenerator("Klass A", "red", messagesToClass, techniques);
            Content.Text = styledWebsite.printPage();
        }

        private void OpenHTML(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".html"; // Default file extension
            dlg.Filter = "HTML documents (.htm)|*.html"; // Filter files by ex
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
            Content.Text = text;
        }


        private void SaveFile(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".html"; // Default file extension
            dlg.Filter = "Webpage, HTML Only (.html)|*.html"; // Filter files by ex
                                                        // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();
            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filename = dlg.FileName;
            }
            File.WriteAllText(dlg.FileName, Content.Text);
        }

        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
