using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Permissions;
using WpfApp_RandomNPC;

namespace WpfApp_RandomNPC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //======================================================================================
        // INICIALIZAR VENTANA
        //======================================================================================

        public MainWindow()
        {
            InitializeComponent();
            ChB_SingleNPC.IsChecked = true;
        }
        public static class PaletaApp
        {
            public static readonly Color Primario = (Color)ColorConverter.ConvertFromString("#195e63");
            public static readonly Color Secundario = (Color)ColorConverter.ConvertFromString("#3e838c");
            public static readonly Color Fondo = (Color)ColorConverter.ConvertFromString("#8ebdb6");
            public static readonly Color Acento = (Color)ColorConverter.ConvertFromString("#ece1c3");
            public static readonly Color Texto = (Color)ColorConverter.ConvertFromString("#063940");
        }

        //======================================================================================
        // VARIABLES GLOBALES
        //======================================================================================

        //Lista global con todas las razas que podemos generar.
        List<string> listaDeRazas = new List<string>
        {
            "Aarakocra",
            "Aasmir",
            "Bugbear",
            "Centaur",
            "Changeling",
            "Deep_Gnome",
            "Dragonborn",
            "Duergar",
            "Dwarf",
            "Elf",
            "Eladin",
            "Fairy",
            "Firbolg",
            "GenasiFuego",
            "GenasiAire",
            "GenasiTierra",
            "GenasiAgua",
            "Githyanki",
            "Githzerai",
            "Gnome",
            "Goblin",
            "Goliath",
            "Grug",
            "Harengon",
            "HalfElf",
            "Halfling",
            "HalfOrc",
            "Hobgoblin",
            "Human",
            "Kenku",
            "Kobold",
            "Lizardfolk",
            "Locathah",
            "Minotaur",
            "Orc",
            "Owil",
            "Satyr",
            "SeaElf",
            "Shadar_Kai",
            "Shifter",
            "Tabaxi",
            "Tiefling",
            "Tortle",
            "Triton",
            "Verdan",
            "Yuan_ti"
        };
        List<bool> listaRazasSeleccionadas = Enumerable.Repeat(true, 46).ToList();


        //Creamos una lista vacia para añadir los datos de los NPCs
        List<NPC> listaNpcInfo = new List<NPC>();

        //Una variable para poder saber en que posicion nos encontramos de la lista de NPCs
        int posicionListaNpcs = 0;

        //======================================================================================
        // FUNCIONES NPCS
        //======================================================================================

        void MostrarInfoNPC(NPC npcAux)
        {
            //Una vez se ha creado la raza correcta, mostramos todos los datos en la pantalla.
            LabelRaza.Content = npcAux.getRaza();
            LabelCriatura.Content = npcAux.getCriatura();
            LabelEdad.Content = npcAux.getEdad();
            LabelAltura.Content = npcAux.getAltura();

            LabelColorOjos.Content = npcAux.getColorOjos();
            LabelColorPelo.Content = npcAux.getColorCabello();
            LabelColorPiel.Content = npcAux.getColorPiel();
            LabelConstitucion.Content = npcAux.getComplexión();

            LabelSexualidad.Content = npcAux.getSexualidad();
            LabelGenero.Content = npcAux.getGenero();

            LabelTamaño.Content = npcAux.getTamaño();
            LabelAlineacion.Content = npcAux.getAlineamiento();

            //Con  esta funcion escribimos todo lo que hay en una lista en una sola label.
            LabelLenguajes.Content = string.Join("\n", npcAux.getLenguaje());
            LabelHabilidades.Content = string.Join("\n", npcAux.getHabilidades());
            LabelRasgoEsp.Content = string.Join("\n", npcAux.getRasgoEspecial());
        }

        //Funcion para elegir una raza aleatoria de la lista de razas.
        NPC SeleccionarRazaNPC()
        {
            //Creamos una instancia de NPC que luego rellenaremos con los datos de uno de sus hijos.
            NPC npcInfo = new NPC();

            //Llamamos a la funcion para generar la lista de razas que vamos a usar
            List<string> nuevaListaDeRazas = GenerarNuevaListaDeRazas();

            //Elegimos un elemento aleatorio de una lista de Razas
            Random newRand = new Random();
            string npcRace = nuevaListaDeRazas[newRand.Next(nuevaListaDeRazas.Count)];

            //Segun la raza que ha salido antes aleatoriamente, se elige que hijo se creara.
            switch (npcRace)
            {
                case "Aarakocra":
                    npcInfo = new Aarakocra();
                    break;

                case "Aasmir":
                    npcInfo = new Aasmir();
                    break;

                case "Bugbear":
                    npcInfo = new Bugbear();
                    break;

                case "Centaur":
                    npcInfo = new Centaur();
                    break;

                case "Changeling":
                    npcInfo = new Changeling();
                    break;

                case "Deep_Gnome":
                    npcInfo = new DeepGnome();
                    break;

                case "Dragonborn":
                    npcInfo = new Dragonborn();
                    break;

                case "Duergar":
                    npcInfo = new Duergar();
                    break;

                case "Dwarf":
                    npcInfo = new Dwarf();
                    break;

                case "Elf":
                    npcInfo = new Elf();
                    break;

                case "Eladin":
                    npcInfo = new Eladin();
                    break;

                case "Fairy":
                    npcInfo = new Fairy();
                    break;

                case "Firbolg":
                    npcInfo = new Firbolg();
                    break;

                case "GenasiFuego":
                    npcInfo = new GenasiFuego();
                    break;

                case "GenasiAire":
                    npcInfo = new GenasiAire();
                    break;

                case "GenasiTierra":
                    npcInfo = new GenasiTierra();
                    break;

                case "GenasiAgua":
                    npcInfo = new GenasiAgua();
                    break;

                case "Githyanki":
                    npcInfo = new Githyanki();
                    break;

                case "Githzerai":
                    npcInfo = new Githzerai();
                    break;

                case "Gnome":
                    npcInfo = new Gnome();
                    break;

                case "Goblin":
                    npcInfo = new Goblin();
                    break;

                case "Goliath":
                    npcInfo = new Goliath();
                    break;

                case "Grug":
                    npcInfo = new Grug();
                    break;

                case "Harengon":
                    npcInfo = new Harengon();
                    break;

                case "HalfElf":
                    npcInfo = new HalfElf();
                    break;

                case "Halfling":
                    npcInfo = new Halfling();
                    break;

                case "HalfOrc":
                    npcInfo = new HalfOrc();
                    break;

                case "Hobgoblin":
                    npcInfo = new Hobgoblin();
                    break;

                case "Human":
                    npcInfo = new Human();
                    break;

                case "Kenku":
                    npcInfo = new Kenku();
                    break;

                case "Kobold":
                    npcInfo = new Kobold();
                    break;

                case "Lizardfolk":
                    npcInfo = new Lizardfolk();
                    break;

                case "Locathah":
                    npcInfo = new Locathah();
                    break;

                case "Minotaur":
                    npcInfo = new Minotaur();
                    break;

                case "Orc":
                    npcInfo = new Orc();
                    break;

                case "Owil":
                    npcInfo = new Owil();
                    break;

                case "Satyr":
                    npcInfo = new Satyr();
                    break;

                case "SeaElf":
                    npcInfo = new SeaElf();
                    break;

                case "Shadar_Kai":
                    npcInfo = new Shadar_Kai();
                    break;

                case "Shifter":
                    npcInfo = new Shifter();
                    break;

                case "Tabaxi":
                    npcInfo = new Tabaxi();
                    break;

                case "Tiefling":
                    npcInfo = new Tiefling();
                    break;

                case "Tortle":
                    npcInfo = new Tortle();
                    break;

                case "Triton":
                    npcInfo = new Triton();
                    break;

                case "Verdan":
                    npcInfo = new Verdan();
                    break;

                case "Yuan_ti":
                    npcInfo = new Yuan_ti();
                    break;

                default:
                    npcInfo = new NPC();
                    break;
            }

            //Devolvemos el NPC creado
            return npcInfo;
        }

        //Funcion para hacer una lista solo con los nombres de las razas que nos devuelve
        //el seleccionador de razas
        private List<string> GenerarNuevaListaDeRazas()
        {
            //Lista auxiliar que devolvemos
            List<string> listaAux = new List<string>();

            //Recorremos la lista de memorias
            for(int i = 0; i < listaDeRazas.Count; i++)
            {
                //Si el valor es true, se añade el nombre de la lista original con el mismo indice.
                if (listaRazasSeleccionadas[i] == true)
                {
                    listaAux.Add(listaDeRazas[i]);
                }
            }

            return listaAux;
        }

        //======================================================================================
        // FUNCIONES ELEMENTOS DE VENTANA
        //======================================================================================

        private void ChB_SingleNPC_Checked(object sender, RoutedEventArgs e)
        {
            ChB_SomeNPC.IsChecked = false;
            LstSomeNPC.IsEnabled = false;
        }
        private void ChB_SomeNPC_Checked(object sender, RoutedEventArgs e)
        {
            ChB_SingleNPC.IsChecked = false;
            LstSomeNPC.IsEnabled = true;
        }
        private void BtSeleccionarRazas(object sender, RoutedEventArgs e)
        {
            var w = new RaceSelectionWindow(listaRazasSeleccionadas);
            w.Owner = this;       // opcional: asocia con la principal
            w.ShowDialog();       // modal (bloquea la principal)
        }

        private void NextNPC(object sender, MouseButtonEventArgs e)
        {
            //El indice maximo es 0 a no ser que la casilla para varios NPCs este marcada
            int maxIndex = 0;
            if (ChB_SomeNPC.IsChecked == true)
            {
                maxIndex = int.Parse(LstSomeNPC.Text) - 1;   //Extraemos el valor que ha seleccionado el usuario.
                //Le restamos 1 para que coincida con las posiciones de una lista.
            }

            //Evitamos que sigamos subiendo el indice si estamos en la ultima posicion de la lista
            if (posicionListaNpcs < maxIndex)
            {
                //Avanzamos una posicion el indice, y mostramos la informacion en la nueva posicion.
                posicionListaNpcs++;
                MostrarInfoNPC(listaNpcInfo[posicionListaNpcs]);

                //Cuando llegemos a la ultima posicion de la lista, apagamos el boton de adelante para avisar
                //que no se puede seguir avanzando
                if (posicionListaNpcs == maxIndex)
                {
                    FlexaAdelante.Opacity = 0.2;
                    FlexaAdelante.Cursor = Cursors.Arrow;
                }

                //Siempre que adelantamos una posicion, sabemos que podremos atrasar una posicion. encendemos el 
                //boton de atras para avisar que se puede ir a la posicion anterior.
                FlexaAtras.Opacity = 1;
                FlexaAtras.Cursor = Cursors.Hand;
            }
        }

        private void PreviousNPC(object sender, MouseButtonEventArgs e)
        {
            //Evitamos que sigamos subiendo el indice si estamos en la ultima posicion de la lista
            if (posicionListaNpcs > 0)
            {
                //Restamos una posicion el indice, y mostramos la informacion en la nueva posicion.
                posicionListaNpcs--;
                MostrarInfoNPC(listaNpcInfo[posicionListaNpcs]);

                //Cuando llegemos a la primera posicion de la lista, apagamos el boton de atras para avisar
                //que no se puede ir a la posicion anterior
                if (posicionListaNpcs == 0)
                {
                    FlexaAtras.Opacity = 0.2;
                    FlexaAtras.Cursor = Cursors.Arrow;
                }

                //Siempre que atrasamos una posicion, sabemos que podremos adelantar una posicion. Encendemos el
                //boton para avisar de que podemos ir una posicion mas adelante.
                FlexaAdelante.Opacity = 1;
                FlexaAdelante.Cursor = Cursors.Hand;
            }
        }

        private void BtGenerarNpc_Click(object sender, RoutedEventArgs e)
        {
            listaNpcInfo.Clear();   //Vaciamos la lista para poder hacer el proceso limpiamente
            posicionListaNpcs = 0;  //Reiniciamos la posicion de la lista cada vez que generamos nuveos NPCs

            //Ponemos las imagenes de las flexas en sus estados neutros.
            FlexaAdelante.Opacity = 0.2;
            FlexaAdelante.Cursor = Cursors.Arrow;
            FlexaAtras.Opacity = 0.2;
            FlexaAtras.Cursor = Cursors.Arrow;

            if (ChB_SingleNPC.IsChecked == true)
            {
                listaNpcInfo.Add(SeleccionarRazaNPC());    //Añadimos un NPC a la ultima posicion de la lista
                MostrarInfoNPC(listaNpcInfo[0]);           //Llamamos para mostrar la informacion
            }
            else if (ChB_SomeNPC.IsChecked == true)
            {
                int numAux = int.Parse(LstSomeNPC.Text);   //Extraemos el valor que ha seleccionado el usuario.

                for (int i = 0; i < numAux; i++)
                {
                    listaNpcInfo.Add(SeleccionarRazaNPC()); //Añadimos un NPC a la ultima posicion de la lista
                }

                MostrarInfoNPC(listaNpcInfo[0]);           //Llamamos para mostrar la informacion

                //Cambuamos la opacidad y el cursos del boton para mostrar que son utilizables.
                FlexaAdelante.Opacity = 1;
                FlexaAdelante.Cursor = Cursors.Hand;
            }
            else
            {
                //Error
            }            
        }

    }
}