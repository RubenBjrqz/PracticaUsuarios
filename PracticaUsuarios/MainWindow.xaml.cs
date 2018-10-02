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

namespace PracticaUsuarios
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

        private void cbUsuario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            spPanelConfiguracion.Children.Clear();
            switch(cbUsuario.SelectedIndex)
            {
                case 0:
                    spPanelConfiguracion.Children.Add(new Maestro());
                    break;
                case 1:
                    spPanelConfiguracion.Children.Add(new Alumno());
                    break;
            }
        }
    }
}
