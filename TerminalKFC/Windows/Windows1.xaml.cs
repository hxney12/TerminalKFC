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
using System.Windows.Shapes;

namespace TerminalKFC.Windows
{
    /// <summary>
    /// Логика взаимодействия для Windows1.xaml
    /// </summary>
    public partial class Windows1 : Window
    {
        public Windows1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Windows.Window2 wnd = new Windows.Window2();
            wnd.Show();
            Close();
        }
    }
}
