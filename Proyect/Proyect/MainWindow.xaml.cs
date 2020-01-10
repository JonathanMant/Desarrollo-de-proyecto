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
using System.Data;
using MySql.Data.MySqlClient;

namespace Proyect
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

            MySqlConnection sqlcon = new MySqlConnection("datasource=127.0.0.1;username=root;password=;database=proyect");

        


        private void button_Click(object sender, RoutedEventArgs e)
        {
          
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    String consulta = "select count(1) from tbusuarios where login=@username and password= @password";
                    MySqlCommand sqlcmd = new MySqlCommand(consulta, sqlcon);
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Parameters.AddWithValue("@username", txtuser.Text);
                    sqlcmd.Parameters.AddWithValue("@password", txtpass.Password);
                    int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                    if (count == 1)
                    {
                        
                        Menu dashboard = new Menu();
                        dashboard.Show();
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario o password incorrecto");
                    }

                }
                

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }

        }
    }
}
