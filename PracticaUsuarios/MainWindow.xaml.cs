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
    /// Interaction logic for MainWindow.xaml
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
            var indexSeleccionado = cbUsuario.SelectedIndex;
            if (indexSeleccionado == 0)
            {
                spPanelConfiguracion.Children.Add(new ControlAlumno());
            }
            else if (indexSeleccionado == 1)
            {
                spPanelConfiguracion.Children.Add(new ControlMaestro());
            }
        }

        private void btnGuardarUsuario_Click(object sender, RoutedEventArgs e)
        {
            var indexSeleccionado = cbUsuario.SelectedIndex;
            if (indexSeleccionado == 0)
            {
                var controlAlumno = (ControlAlumno)spPanelConfiguracion.Children[0];
                if (controlAlumno.txtNombreA.Text == "")
                {
                    controlAlumno.lblNombreA.Foreground = Brushes.Orange;
                }
                else
                {
                    controlAlumno.lblNombreA.Foreground = Brushes.Black;
                }
                if (controlAlumno.txtDireccionA.Text == "")
                {
                    controlAlumno.lblDireccionA.Foreground = Brushes.Orange;
                }
                else
                {
                    controlAlumno.lblDireccionA.Foreground = Brushes.Black;
                }
                if (controlAlumno.cbCarrera.Text == "")
                {
                    controlAlumno.lblCarrera.Foreground = Brushes.Orange;
                }
                else
                {
                    controlAlumno.lblCarrera.Foreground = Brushes.Black;
                }
                if (controlAlumno.txtPreparatoriaA.Text == "")
                {
                    controlAlumno.lblPreparatoriaA.Foreground = Brushes.Orange;
                }
                else
                {
                    controlAlumno.lblPreparatoriaA.Foreground = Brushes.Black;
                }
            }
            else if (indexSeleccionado == 1)
            {
                var controlMaestro = (ControlMaestro)spPanelConfiguracion.Children[0];
                if (controlMaestro.txtNombreM.Text == "")
                {
                    controlMaestro.lblNombreM.Foreground = Brushes.Orange;
                }
                else
                {
                    controlMaestro.lblNombreM.Foreground = Brushes.Black;
                }
                if (controlMaestro.txtTelefonoM.Text == "")
                {
                    controlMaestro.lblTelefonoM.Foreground = Brushes.Orange;
                }
                else
                {
                    controlMaestro.lblTelefonoM.Foreground = Brushes.Black;
                }
                if (controlMaestro.txtCedulaM.Text == "")
                {
                    controlMaestro.lblCedulaM.Foreground = Brushes.Orange;
                }
                else
                {
                    controlMaestro.lblCedulaM.Foreground = Brushes.Black;
                }
                if (controlMaestro.txtCarreraM.Text == "")
                {
                    controlMaestro.lblCarreraM.Foreground = Brushes.Orange;
                }
                else
                {
                    controlMaestro.lblCarreraM.Foreground = Brushes.Black;
                }
            }
        }
    }
}