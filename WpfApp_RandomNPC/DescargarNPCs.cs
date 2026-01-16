using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
            int position = 1;
            //Recorremos cada uno de los elementos NPC para ir cojiendo toda la informacion.
            foreach (NPC npc in npcInfo)
            {
                textoFinal = textoFinal +
                    //Inicio de tabla
                    "======================================================\n" +
                    "Personaje " + position + "\n" +
                    "======================================================\n\n\n" +
                    "<table><tbody>\n" +
                    "\t<tr>\n" +
                    //Primera linea
                    "\t\t<td><strong>Edad</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getEdad() + "</td>\n" +
                    "\t\t<td><strong>Raza:</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getRaza() + "</td>\n" +
                    "\t\t<td><strong>Criatura:</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getCriatura() + "</td>\n" +
                    "\t</tr>\n" +
                    //Segunda linea
                    "\t<tr>\n" +
                    "\t\t<td><strong>Altura</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getAltura() + "</td>\n" +
                    "\t\t<td colspan=\"8\"></td>\n" +
                    "\t</tr>\n" +
                    //Tercera linea
                    "\t<tr>\n" +
                    "\t\t<td colspan=\"12\"></td>\n" +
                    "\t</tr>" +
                    //Quarta linea
                    "\t<tr>\n" +
                    "\t\t<td><strong>Piel</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getColorPiel() + "</td>\n" +
                    "\t\t<td><strong>Sezualidad:</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getSexualidad() + "</td>\n" +
                    "\t\t<td><strong>Alineación:</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getAlineamiento() + "</td>\n" +
                    "\t</tr>\n" +
                    //Quina linea
                    "\t<tr>\n" +
                    "\t\t<td><strong>Pelo:</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getColorCabello() + "</td>\n" +
                    "\t\t<td><strong>Género:</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getGenero() + "</td>\n" +
                    "\t\t<td><strong>Tamaño:</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getTamaño() + "</td>\n" +
                    "\t</tr>\n" +
                    //Sexta linea
                    "\t<tr>\n" +
                    "\t\t<td><strong>Ojos:</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getColorOjos() + "</td>\n" +
                    "\t\t<td><strong>Lenguajes:</strong></td>\n" +
                    "\t\t<td colspan=\"7\">" + string.Join(", ", npc.getLenguaje()) + "</td>\n" +
                    "\t</tr>\n" +
                    //Septima linea
                    "\t<tr>\n" +
                    "\t\t<td><strong>Const:</strong></td>\n" +
                    "\t\t<td colspan=\"3\">" + npc.getComplexión() + "</td>\n" +
                    "\t\t<td><strong>Rasgos Esp:</strong></td>\n" +
                    "\t\t<td colspan=\"7\">" + string.Join(", ", npc.getRasgoEspecial()) + "</td>\n" +
                    "\t</tr>\n" +
                    "</tbody></table>\n\n\n";

                position++;
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
