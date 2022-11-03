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

namespace Shopping_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowProducts();
            EnableButton();
            List<Product> products = new List<Product>() { new Product("Oats", "26", "1") };
        }

        private void ShowProducts()
        {
            foreach (Product product in products)
            {
                ProductsListView.Items.Add(product);
            }
            ChangeTotal();
        }

        List<Product> products = new List<Product>() { new Product("Oats", "26", "1") };
        private void AddProduct(object sender, RoutedEventArgs e)
        {
            if (checkIfNumber())
            {
                ProductsListView.Items.Clear();
                products.Add(new Product(ProductName.Text, Price.Text, Quantity.Text));
                ShowProducts();
                ClearTextBoxes();
            }
        }

        private void RemoveProduct(object sender, RoutedEventArgs e)
        {
            products.RemoveAt(ProductsListView.SelectedIndex);
            ProductsListView.Items.Remove(ProductsListView.SelectedItem);
            ChangeTotal();
        }

        private void UpdateProduct(object sender, RoutedEventArgs e)
        {
            if (checkIfNumber())
            {
                products[ProductsListView.SelectedIndex] = new Product(ProductName.Text, Price.Text, Quantity.Text);
                ProductsListView.Items.Clear();
                ShowProducts();
                ChangeTotal();
                ClearTextBoxes();
            }
        }
        private void ChangeTotal()
        {
            int total = 0;
            int totalItems = 0;
            products.ForEach(a => total += Int32.Parse(a.Price) * Int32.Parse(a.Quantity));
            products.ForEach(a => totalItems += Int32.Parse(a.Quantity));
            TotalItems.Content = $"Total items: {totalItems}";
            Total.Content = $"Total: {total} SEK";
        }
        private void ClearTextBoxes()
        {
            ProductName.Text = null;
            Price.Text = null;
            Quantity.Text = null;
        }
        private void EnableButton()
        {
            if (ProductName.Text.Length == 0 || Price.Text.Length == 0 || Quantity.Text.Length == 0)
            {
                AddButton.IsEnabled = false;
            }
            else
            {
                AddButton.IsEnabled = true;
            }
            if (ProductName.Text.Length == 0 || Price.Text.Length == 0 || Quantity.Text.Length == 0 || ProductsListView.SelectedItem == null)
            {
                UpdateButton.IsEnabled = false;
            }
            else
            {
                UpdateButton.IsEnabled = true;
            }
        }


        private void UpdateButtonState(object sender, TextChangedEventArgs e)
        {
            EnableButton();
        }

        private void UpdateButtonState_ProductListView(object sender, SelectionChangedEventArgs e)
        {
            EnableButton();
        }
        private bool checkIfNumber()
        {
            int number;
            bool success = int.TryParse(Price.Text, out number);
            if (!success || number < 1)
            {
                MessageBox.Show("Please enter valid price");
                return false;
            }
            success = int.TryParse(Quantity.Text, out number);
            if (!success || number < 1)
            {
                MessageBox.Show("Please enter valid quantity");
                return false;
            }
            return true;
        }
    }
}
