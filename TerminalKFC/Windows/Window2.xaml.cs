using System;
using System.Windows;

namespace TerminalKFC.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public int sum = 0;
        public string bracket = "";
        public Window2()
        {
            InitializeComponent();
        }

        public void Shefburger(object sender, RoutedEventArgs e)
        {
            sum = GetNewSum(sum, 100);
            AddNewProduct("Шефбургер\t\t\t100 p.");
            BracketTB.Text = bracket;
        }

        private void Milksheik_Click(object sender, RoutedEventArgs e)
        {
            sum = GetNewSum(sum, 200);
            AddNewProduct("Милкшейк\t\t\t\t200 p.");
            BracketTB.Text = bracket;
        }

        private void Pirozhok_Click(object sender, RoutedEventArgs e)
        {
            sum = GetNewSum(sum, 70);
            AddNewProduct("Пирожок\t\t\t70 p.");
            BracketTB.Text = bracket;
        }

        private void Pirog_Click(object sender, RoutedEventArgs e)
        {
            sum = GetNewSum(sum, 150);
            AddNewProduct("Пирог\t\t\t\t150 p.");
            BracketTB.Text = bracket;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridButton.Visibility = Visibility.Hidden;
            TabControlMenu.Visibility = Visibility.Hidden;
            GridOplata.Visibility = Visibility.Visible;

            PriceTB.Text = "Итого: " + Convert.ToString(sum);
        }

        public int GetNewSum(int sum, int price)
        {
            return (sum + price);
        }

        public void AddNewProduct(string productName)
        {
            bracket += Environment.NewLine + productName;
        }
    }
}
