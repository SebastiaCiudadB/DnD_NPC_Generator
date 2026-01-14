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

namespace WpfApp_RandomNPC
{
    /// <summary>
    /// Lógica de interacción para RaceSelectionWindow.xaml
    /// </summary>
    public partial class RaceSelectionWindow : Window
    {
        //======================================================================================
        // VARIABLES  GLOBALES
        //======================================================================================
        public List<bool> ListaRazasSeleccionadas { get; }  //Lista para recordar razas seleccionadas

        //======================================================================================
        // CONSTRUCTOR VENTANA
        //======================================================================================
        public RaceSelectionWindow(List<bool> lista)
        {
            InitializeComponent();
            ListaRazasSeleccionadas = lista;
            SeleccionarRazasEnMemoria(ListaRazasSeleccionadas);
        }

        //======================================================================================
        // FUNCIONES ELEMENTOS DE VENTANA
        //======================================================================================
        private void BtAceptar(object sender, RoutedEventArgs e)
        {
            GuardarRazasEnMemoria();
            DialogResult = true;
        }

        //Funcion para seleccionar todas las casillas a la vez.
        private void BtSelecionarTodo(object sender, RoutedEventArgs e)
        {
            //Recorremos cada uno de los hijos del Grid CHeckBoexes.
            //Nos hemos asegurado qu en ese Grid solo haya CheckBoxes.
            foreach (CheckBox ChB in CheckBoxes.Children)
            {
                ChB.IsChecked = true;   //Ponemos el valor a true (seleccionado).
            }
        }

        //Funcion para deseleccionar todas las casillas a la vez.
        private void BtSeleccionrNada(object sender, RoutedEventArgs e)
        {
            //Lo mismo que en la funcion anterior.
            foreach (CheckBox ChB in CheckBoxes.Children)
            {
                ChB.IsChecked = false;  //Ponemos el valor a false (deseleccionado).
            }
        }

        //Funcion seleccionar las razas de la lista de memoria
        private void SeleccionarRazasEnMemoria(List<bool> listaRazas)
        {
            //Indice para recorrer la lista de memoria
            int index = 0;

            //Recorremos cada uno de los checkboxes
            foreach(CheckBox ChB in CheckBoxes.Children)
            {
                //Ponemos el valor que le corresponde de la lista de memoria.
                ChB.IsChecked = listaRazas[index];
                index++;    //Avanzamos el indice.
            }
        }

        private void GuardarRazasEnMemoria()
        {
            //Indice para recorrer la lista de memoria
            int index = 0;

            //Recorremos cada uno de los checkboxes
            foreach (CheckBox ChB in CheckBoxes.Children)
            {
                //Ponemos el valor que le corresponde de la lista de memoria.
                ListaRazasSeleccionadas[index] =  ChB.IsChecked ?? false;
                index++;    //Avanzamos el indice.
            }
        }
    }
}
