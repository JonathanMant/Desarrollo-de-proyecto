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
using System.Runtime.InteropServices;
namespace Proyect
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Menuvertical.Width == 150 && panmenu.Width == 682)
            {
                Menuvertical.Width = 59;
                panmenu.Width = 778;

                
            }
            else
            {
                Menuvertical.Width = 150;
                panmenu.Width = 682;
            }

        }

        private void Btnpeq_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Btncerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
    }

    
    
}
