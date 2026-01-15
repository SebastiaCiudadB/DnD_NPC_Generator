using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp_RandomNPC
{
    public class DescargarNPCs
    {
        public string CrearTexto(List<NPC> npcInfo)
        {
            //Creamos la variable que va a contener todo el texto que queremos escribir.
            string textoFinal = "";
            //Recorremos cada uno de los elementos NPC para ir cojiendo toda la informacion.
            foreach (NPC npc in npcInfo)
            {
                textoFinal = textoFinal + npc.getRaza() + "\n";
            }
            return textoFinal;
        }
        public void guardarInfoEnDocumento(string contenido)
        {
            //Genera la ruta para guardar el documento en la carpeta de Documentos del Ordenador.
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"DatosNPC.txt");

            //Escribe la informacion que hemos enviado en el documento especificado.
            File.WriteAllText(ruta, contenido);

            MessageBox.Show(
                "NPC guardado correctamente en Documentos\nDatosNPC.txt",
                "Información",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }


    }
}
