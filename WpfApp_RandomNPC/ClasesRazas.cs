using System;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WpfApp_RandomNPC
{
    //===================================================================================================
    //Esto es una classe padre que contendra todos los datos basicos para crear un personaje,
    public class NPC
    {
        //------------------------------------------------------------------------
        //Definimos unos rangos basicos para todas las caracteristicas
        protected List<int> rangoEdad = new List<int> { 15, 80 };
        protected List<float> rangoAltura = new List<float> { 1.5f, 2.0f };

        protected List<string> posiblesColoresPielBasicas = new List<string> { "Clara", "Oscura", "Morena", "Pálida", "Bronceada" };
        protected List<string> posiblesColoresOjosBasicas = new List<string> { "Marrones", "Azules", "Verdes", "Grises", "Negro", "Amarillo" };
        protected List<string> posiblesColoresCabelloBasicas = new List<string> { "Negro", "Castaño", "Rubio", "Pelirrojo", "Blanco", "Verde" };
        protected List<string> posiblesComplexionesBasicas = new List<string> { "Delgada", "Chupada", "Atlética", "Corpulenta", "Robusta", "Gordo", "Obeso" };

        protected List<string> posiblesSexualidades = new List<string> { "Heterosexual", "Bisexual", "Homosexual", "Asexual" };
        protected Dictionary<string, double> posiblesGeneros = new Dictionary<string, double>
        {
            {"Hombre", 0.46 },
            {"Hombre Trans", 0.04 },
            {"Mujer Trans", 0.04 },
            {"Mujer", 0.46 }
        };

        protected List<string> Caracter = new List<string> { "Lawful", "Neutral", "Chaotic" };
        protected List<string> Alineacion = new List<string> { "Good", "Neutral", "Evil" };

        //Lista de todos los rasgos especiales que puede tener.
        //La lista consiste en el nombre del rasgo especial y la posibilidad que tiene de salir.
        protected Dictionary<string, double> posibleRasgoEspecial = new Dictionary<string, double>
        {
            {"Nada", 0.35},
            {"Tatuajes visibles",0.15},
            {"Pircings", 0.15},
            {"Le falta un mano", 0.02},
            {"Le falta un brazo", 0.02},
            {"Le falta una pierna", 0.02},
            {"Cicatriz notable", 0.02},
            {"Ciego", 0.03},
            {"Sordo", 0.03},
            {"Mudo", 0.03},
            {"Paralitico",  0.01},
            {"Calvo", 0.05},
            {"Enanismo",  0.01},
            {"Albino",  0.01},
            {"ETS",  0.05},
            {"Visión reducida (usa gafas)", 0.05 },
            //{"Dislexico", ?},
            //{"Daltonico", ?},
            //{"Autista", ?},
        };

        //------------------------------------------------------------------------
        //Definimos las variables que necesitamos.
        protected string raza;
        protected string criatura;
        protected int edad;
        protected float altura;

        protected string colorPiel;
        protected string colorCabello;
        protected string colorOjos;
        protected string complexion;

        protected string sexualidad;
        protected string genero;

        protected string tamaño;
        protected string alineamiento;
        protected List<string> rasgoEspecial = new List<string>();
        protected List<string> lenguaje = new List<string>();
        protected List<string> habilidades = new List<string>();

        //------------------------------------------------------------------------
        //Creamos todas las funciones get() para poder acceder a las variables.

        public string getRaza()
        {
            return raza;
        }
        public string getCriatura()
        {
            return criatura;
        }
        public int getEdad()
        {
            return edad;
        }
        public float getAltura()
        {
            return altura;
        }
        public string getComplexión()
        {
            return complexion;
        }
        public string getColorPiel()
        {
            return colorPiel;
        }
        public string getColorCabello()
        {
            return colorCabello;
        }
        public string getColorOjos()
        {
            return colorOjos;
        }
        public string getSexualidad()
        {
            return sexualidad;
        }
        public string getGenero()
        {
            return genero;
        }
        public string getTamaño()
        {
            return tamaño;
        }
        public string getAlineamiento()
        {
            return alineamiento;
        }
        public List<string> getRasgoEspecial()
        {
            return rasgoEspecial;
        }
        public List<string> getLenguaje()
        {
            return lenguaje;
        }
        public List<string> getHabilidades()
        {
            return habilidades;
        }

        //------------------------------------------------------------------------
        //Creamos todas la funcion constructor y las funciones necesarias para este.
        public NPC()
        {
            raza = "";
            criatura = "";
            edad = 0;
            altura = 0f;

            colorPiel = "";
            colorOjos = "";
            colorCabello = "";
            complexion = "";

            sexualidad = "";
            genero = "";

            tamaño = "";
            alineamiento = "";

            randomAtributos();

        }

        protected void randomAtributos()
        {
            Random rand = new Random();
            rasgoEspecial.Clear();

            // Asigna la edad y la altura de manera aleatoria.
            edad = rand.Next(rangoEdad[0], rangoEdad[1]);
            altura = (float)(rand.NextDouble() * (rangoAltura[1] - rangoAltura[0]) + rangoAltura[0]);

            // Asigna las características físicas de manera aleatoria.
            int indiceAux = rand.Next(posiblesColoresPielBasicas.Count);
            colorPiel = posiblesColoresPielBasicas[indiceAux];

            indiceAux = rand.Next(posiblesColoresOjosBasicas.Count);
            colorOjos = posiblesColoresOjosBasicas[indiceAux];

            indiceAux = rand.Next(posiblesColoresCabelloBasicas.Count);
            colorCabello = posiblesColoresCabelloBasicas[indiceAux];

            indiceAux = rand.Next(posiblesComplexionesBasicas.Count);
            complexion = posiblesComplexionesBasicas[indiceAux];

            // Asignamos la sexualidad y genero de manera aleatoria
            indiceAux = rand.Next(posiblesSexualidades.Count);
            sexualidad = posiblesSexualidades[indiceAux];

            indiceAux = rand.Next(posiblesGeneros.Count);
            //Asignamos el genero segun las posibilidades
            rand = new Random();
            double valorRandom = rand.NextDouble(); //Elegimos un numero aleatorio entre 0 y 1
            double acumulado = 0.0;                 //Variable que acumulara los valore de los rasgos

            //Recorremos cada uno de los rasgos de la lista
            foreach (var item in posiblesGeneros)
            {
                acumulado += item.Value;
                if (valorRandom < acumulado)        //Si el valor random es mas pequeño, es el indicado
                {
                    genero = item.Key;
                    break;
                }
            }

            // Asignar rasgo especial basado en probabilidades
            // Primero veremos si tiene uno o dos rasgos especiales
            int numRansgosEsp = rand.Next(1, 3);        //Elige un numero entre 1 y 2

            //La funcion pare elgir rasgos esp. se repetira una o dos veces
            for (int i = 0; i < numRansgosEsp; i++)
            {
                valorRandom = rand.NextDouble(); //Volvemos a elegir un numero aleatorio entre 0 y 1
                acumulado = 0.0;                 //Devolvemos la variable a 0 para usarla otra vez

                //Recorremos cada uno de los rasgos de la lista
                foreach (var item in posibleRasgoEspecial)
                {
                    acumulado += item.Value;
                    if (valorRandom < acumulado)        //Si el valor random es mas pequeño, es el indicado
                    {
                        rasgoEspecial.Add(item.Key);
                        break;
                    }
                }
            }
        }

    }

    //============================================================================================
    //Una clase para crear NPCs humanos, esta hereda de la clase NPC.
    public class Aarakocra : NPC
    {
        public Aarakocra()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Aarakocra";

            criatura = "Humanoide";

            colorOjos = "Amarillo";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Aarakocra");
            lenguaje.Add("Auran");

            habilidades.Add("Volar");

            //Elegimos la alineacion aleatoriamente porque puede tener varias.
            Random rand = new Random();
            int numCaracter = rand.Next(0, 2) == 0 ? 0 : 2; //Elige entre el numero 0 o 2.

            alineamiento = Caracter[numCaracter] + " " + Alineacion[0];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 3;
            rangoEdad[1] = 30;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.4f;
            rangoAltura[1] = 1.7f;
        }

    }

    public class Aasmir : NPC
    {
        private List<string> rasgosCelestiales = new List<string> {
            "Pecas de color metalico, blanco o carbon",
            "Ojos metalicos, luminosos u oscuros",
            "Pelo de color muy vivido",
            "Sombra de tono muy inusual",
            "Alo fantasmal en la cabeza",
            "Piel con brillo arcoiris"
        };
        public Aasmir()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Aasmir";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Celestial");

            habilidades.Add("Vision Nocturna");
            habilidades.Add("Manos curadoras");
            habilidades.Add("Resistencia a daño necrotico y radiante");

            //Añadimos un ransgo especial de los Aasmir
            Random rand = new Random();
            var rasgoCelestial = rasgosCelestiales[rand.Next(rasgosCelestiales.Count)];
            rasgoEspecial.Add(rasgoCelestial);

            //Elegimos la alineacion aleatoriamente porque puede tener varias.
            rand = new Random();
            int numCaracter = rand.Next(0, 3); //Elige entre 0 y 2.

            alineamiento = Caracter[numCaracter] + " " + Alineacion[0];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 160;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.8f;
        }
    }

    public class Bugbear : NPC
    {
        public Bugbear()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Bugbear";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Goblin");

            habilidades.Add("Vision Nocturna");
            habilidades.Add("Sigiloso");
            habilidades.Add("Fey Ancestry");

            //Añadimos un rasgo especial caracteristico de la raza.
            rasgoEspecial.Add("Brazos largos");

            //Elegimos la alineacion

            alineamiento = Caracter[2] + " " + Alineacion[2];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 16;
            rangoEdad[1] = 80;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.8f;
            rangoAltura[1] = 2.4f;

            //Cambiamos colores de pelo
            posiblesColoresCabelloBasicas = posiblesColoresCabelloBasicas.Take(3).ToList();

            posiblesColoresCabelloBasicas[0] = "Marron";
            posiblesColoresCabelloBasicas[1] = "Negro";
            posiblesColoresCabelloBasicas[2] = "Gris";
        }
    }

    public class Centaur : NPC
    {
        public Centaur()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Centaur";

            criatura = "Hada";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Sylvan");

            habilidades.Add("Superviviente");

            //Añadimos un rasgo especial caracteristico de la raza.
            rasgoEspecial.Add("Cuerpo de caballo");

            //Elegimos la alineacion
            Random rand = new Random();
            int posCaracter = rand.Next(0, 3);

            alineamiento = Caracter[posCaracter] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 80;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.8f;
            rangoAltura[1] = 2.1f;
        }
    }

    public class Changeling : NPC
    {
        public Changeling()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Changeling";

            criatura = "Hada";

            Random rand = new Random();
            int aux = rand.Next(0, 1);

            tamaño = aux == 0 ? "Pequeño" : "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Otro");

            habilidades.Add("Cambiaformas");

            //Cuando no estan transformados son ebeltos.
            complexion = "Esbelto";

            //Elegimos la alineacion
            int numCaracter = rand.Next(0, 3);
            int numAlienacion = rand.Next(1, 3);

            alineamiento = Caracter[numCaracter] + " " + Alineacion[numAlienacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 13;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.8f;
        }
    }

    public class DeepGnome : NPC
    {
        public DeepGnome()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Deep Gnome";

            criatura = "Humanoide";

            tamaño = "Pequeño";

            lenguaje.Add("Gnomo");
            lenguaje.Add("Terranio");
            lenguaje.Add("Comun profundo");

            habilidades.Add("Vision en la Oscuridad");
            habilidades.Add("Resistencia Magica Gnoma");
            habilidades.Add("Don de los Svirfneblins");

            colorPiel = "Marron Grisacio";

            //Cambiamos su peinado segun su genero;
            if (genero == "Hombre" || genero == "Hombre Trans")
            {
                colorCabello = "Calvo";
            }
            else
            {
                colorCabello = "Gris";
            }

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[0];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 250;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 0.9f;
            rangoAltura[1] = 1.1f;
        }
    }

    public class Dragonborn : NPC
    {
        public Dragonborn()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Dragonborn";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Draconico");

            habilidades.Add("Superviviente");

            colorCabello = "No tiene";

            //Vamos a determinar el color de las escamas del dragons y su aliento
            List<string> colorEscamas = new List<string> { "Negro", "Azul", "Laton", "Bronze", "Cobre", "Oro", "Verde", "Rojo", "Plata", "Blanco" };
            List<string> elementoAliento = new List<string> { "Acido", "Rayo", "Fuego", "Rayo", "Acido", "Fuego", "Veneno", "Fuego", "Hielo", "Hielo" };

            Random rand = new Random();
            int aux = rand.Next(colorEscamas.Count);    //Usaremos el mismo indice para el color de las escamas y su aliento

            colorPiel = colorEscamas[aux];
            rasgoEspecial.Add("Aliento de " + elementoAliento[aux]);

            //Elegimos la alineacion
            rand = new Random();
            int numCaracter = rand.Next(0, 2) == 0 ? 0 : 2; //Elige entre el numero 0 o 2.
            int numAlineacion = rand.Next(0, 2) == 0 ? 0 : 2; //Elige entre el numero 0 o 2.

            alineamiento = Caracter[numCaracter] + " " + Alineacion[numAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 15;
            rangoEdad[1] = 80;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.9f;
            rangoAltura[1] = 2.0f;
        }
    }

    public class Duergar : NPC
    {
        public Duergar()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Duergar";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Enano");
            lenguaje.Add("Comun profundo");

            habilidades.Add("Resistencia Duergar");
            habilidades.Add("Magia Duergar");
            habilidades.Add("Vision en la oscuridad superior");

            colorPiel = "Gris ceniza";

            //Cambiamos su peinado segun su genero;
            if (genero == "Hombre" || genero == "Hombre Trans")
            {
                colorCabello = "Calvo";
            }
            else
            {
                colorCabello = "Gris";
            }

            //Elegimos la alineacion
            alineamiento = Caracter[0] + " " + Alineacion[2];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 50;
            rangoEdad[1] = 350;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.2f;
            rangoAltura[1] = 1.4f;
        }
    }

    public class Dwarf : NPC
    {
        public Dwarf()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Dwarf";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Enano");
            lenguaje.Add("Comun");

            habilidades.Add("Resistencia Enana");
            habilidades.Add("Vision en la oscuridad");

            //Elegimos la alineacion
            Random rand = new Random();
            int numAlineacion = rand.Next(0, 3);
            alineamiento = Caracter[0] + " " + Alineacion[numAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 50;
            rangoEdad[1] = 350;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.2f;
            rangoAltura[1] = 1.4f;
        }
    }

    public class Elf : NPC
    {
        public Elf()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Elf";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Elfico");
            lenguaje.Add("Comun");

            habilidades.Add("Linaje Feerico");
            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Trance");

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[0];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 100;
            rangoEdad[1] = 750;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.8f;
        }
    }

    public class Eladin : NPC
    {
        public Eladin()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Eladin";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Elfico");
            lenguaje.Add("Comun");
            lenguaje.Add("Sylvan");

            habilidades.Add("Linaje Feerico");
            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Trance");
            habilidades.Add("Fey Step");

            //Caracteristicas especificas de Eladins
            List<string> estaciones = new List<string> { "Invierno", "Primavera", "Verano", "Otoño" };

            Random rand = new Random();
            int posEstacion = rand.Next(estaciones.Count);    //Usaremos el mismo indice para el color de las escamas y su aliento
            string estacion = estaciones[posEstacion];

            switch (estacion)
            {
                case "Invierno":
                    colorCabello = "Azul";
                    colorOjos = "Azul";
                    colorPiel = "Azul";
                    break;

                case "Primavera":
                    colorCabello = "Verde";
                    colorOjos = "Verde";
                    colorPiel = "Verde";
                    break;

                case "Verano":
                    colorCabello = "Amarillo";
                    colorOjos = "Amarillo";
                    colorPiel = "Amarillo";
                    break;

                case "Otoño":
                    colorCabello = "Naranja";
                    colorOjos = "Naranja";
                    colorPiel = "Naranja";
                    break;
            }

            //Elegimos la alineacion
            int numAlineacion = rand.Next(0, 3);
            alineamiento = Caracter[2] + " " + Alineacion[numAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 100;
            rangoEdad[1] = 750;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.8f;
        }
    }

    public class Fairy : NPC
    {
        public Fairy()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Fairy";

            criatura = "Humanoide";

            tamaño = "Pequeño";

            lenguaje.Add("Comun");
            lenguaje.Add("Sylvan");

            habilidades.Add("Linaje Feerico");
            habilidades.Add("Magia de Hada");
            habilidades.Add("Vuela");

            //Caracteristicas especificas de Hadas
            List<string> caracteristicasHadas = new List<string>
            {
                "Alas como las de un pajaro",
                "Piel multicolor reluciente",
                "Orejas muy grandes",
                "Niebla brillante alrededor",
                "Pequeño cuerno fantasmal en la frente",
                "Piernas de insecto",
                "Olor a brownie",
                "Frescor a tu alrrededor"
            };

            Random rand = new Random();
            int posCaracHada = rand.Next(caracteristicasHadas.Count);
            string caracteristicaHada = caracteristicasHadas[posCaracHada];

            //Añadimos la nueva caracteristica a la lista de rasgos especiales
            rasgoEspecial.Add(caracteristicaHada);

            //Elegimos la alineacion
            int numAlineacion = rand.Next(0, 3);
            alineamiento = Caracter[2] + " " + Alineacion[numAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 10;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 0.9f;
            rangoAltura[1] = 1.2f;
        }
    }

    public class Firbolg : NPC
    {
        public Firbolg()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Firbolg";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Gigante");

            habilidades.Add("Paso Oculto");
            habilidades.Add("Magia de Firbolg");
            habilidades.Add("Constitucion poderosa");

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[0];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 30;
            rangoEdad[1] = 500;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 2.1f;
            rangoAltura[1] = 2.4f;
        }
    }

    public class GenasiFuego : NPC
    {
        public GenasiFuego()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Genasi de Fuego";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Primordial");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Resistencia al fuego");
            habilidades.Add("Constitucion poderosa");

            //Rasgos fisicos caracteristicos
            List<string> pielGenasiFu = new List<string> { "Rojico", "Anaranjado", "Bronce incandescente", "Carbon Oscuro" };
            List<string> ojosGenasiFu = new List<string> { "Dorados", "Amarillos", "Completamente Blancos" };
            List<string> peloGenasiFu = new List<string> { "Rojo", "Amarillo", "Naranja", "Brasas" };

            Random rand = new Random();
            int aux = rand.Next(pielGenasiFu.Count);
            colorPiel = pielGenasiFu[aux];

            aux = rand.Next(ojosGenasiFu.Count);
            colorOjos = ojosGenasiFu[aux];

            aux = rand.Next(peloGenasiFu.Count);
            colorCabello = peloGenasiFu[aux];

            //Elegimos la alineacion
            int posAlineacion = rand.Next(0, 3);
            alineamiento = Caracter[2] + " " + Alineacion[posAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class GenasiAire : NPC
    {
        public GenasiAire()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Genasi de Aire";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Primordial");

            habilidades.Add("Respiracion indefinida");
            habilidades.Add("Resistencia al rayo");
            habilidades.Add("Mezclarse con el viento");

            //Rasgos fisicos caracteristicos
            List<string> pielGenasiAi = new List<string> { "Azul Claro", "Gris Palido", "Blanco Nacarado" };
            List<string> ojosGenasiAi = new List<string> { "Azul Claro", "Celeste", "Plateado", "Completamente Blancos" };
            List<string> peloGenasiAi = new List<string> { "Blanco", "Plateado", "Gris Palido", "Translúcido" };

            Random rand = new Random();
            int aux = rand.Next(pielGenasiAi.Count);
            colorPiel = pielGenasiAi[aux];

            aux = rand.Next(ojosGenasiAi.Count);
            colorOjos = ojosGenasiAi[aux];

            aux = rand.Next(peloGenasiAi.Count);
            colorCabello = peloGenasiAi[aux];

            //Elegimos la alineacion
            int numCaracter = rand.Next(0, 2) == 0 ? 1 : 2; //Elige entre el numero 1 o 2.
            int posAlineacion = rand.Next(0, 3);
            alineamiento = Caracter[numCaracter] + " " + Alineacion[posAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class GenasiTierra : NPC
    {
        public GenasiTierra()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Genasi de Tierra";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Primordial");

            habilidades.Add("Caminar en tierra");
            habilidades.Add("Pasar sin rastro");
            habilidades.Add("Fusion con piedra");

            //Rasgos fisicos caracteristicos
            List<string> pielGenasiAi = new List<string> { "Tono Marron", "Ocre", "Arena", "Arcilla", "Gris Piedra" };
            List<string> ojosGenasiAi = new List<string> { "Marron Profundo", "Ambar", "Dorado Apagado", "Verde Musgo" };
            List<string> peloGenasiAi = new List<string> { "Negro", "Castaño", "Gris", "Blanco Petreo" };

            Random rand = new Random();
            int aux = rand.Next(pielGenasiAi.Count);
            colorPiel = pielGenasiAi[aux];

            aux = rand.Next(ojosGenasiAi.Count);
            colorOjos = ojosGenasiAi[aux];

            aux = rand.Next(peloGenasiAi.Count);
            colorCabello = peloGenasiAi[aux];

            //Elegimos la alineacion
            int posAlineacion = rand.Next(0, 2) == 0 ? 1 : 2; //Elige entre el numero 1 o 2.
            alineamiento = Caracter[1] + " " + Alineacion[posAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 2.0f;
        }
    }

    public class GenasiAgua : NPC
    {
        public GenasiAgua()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Genasi de Agua";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Primordial");

            habilidades.Add("Anfibio");
            habilidades.Add("Nado Rapido");
            habilidades.Add("Resistencia al Acido");
            habilidades.Add("Llamada a la Ola");

            //Rasgos fisicos caracteristicos
            List<string> pielGenasiAi = new List<string> { "Azul Profundo", "Turquesa", "Verde Marino", "Gris Oscuro" };
            List<string> ojosGenasiAi = new List<string> { "Azul Intenso", "Verde Oceano", "Plateado Liquido", "Completamente Negros" };
            List<string> peloGenasiAi = new List<string> { "Azul Oscuro", "Verde", "Negro Azul", "Blanco Espumoso" };

            Random rand = new Random();
            int aux = rand.Next(pielGenasiAi.Count);
            colorPiel = pielGenasiAi[aux];

            aux = rand.Next(ojosGenasiAi.Count);
            colorOjos = ojosGenasiAi[aux];

            aux = rand.Next(peloGenasiAi.Count);
            colorCabello = peloGenasiAi[aux];

            //Elegimos la alineacion
            int posAlineacion = rand.Next(0, 2) == 0 ? 1 : 2; //Elige entre el numero 1 o 2.
            alineamiento = Caracter[1] + " " + Alineacion[posAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Githyanki : NPC
    {
        public Githyanki()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Githyanki";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Gith");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Githyanki Psionics");
            habilidades.Add("Conocimiento Astral");

            //Rasgos fisicos caracteristicos
            List<string> pielGith = new List<string> { "Amarillo Palido", "Verdoso Apagado", "Oliva", "Mostaza" };
            List<string> ojosGith = new List<string> { "Amarillos", "Ambar", "Dorados", "Rojizos" };
            List<string> peloGith = new List<string> { "Negro", "Castaño oscuro", "Gris", "Calvo" };

            Random rand = new Random();
            int aux = rand.Next(pielGith.Count);
            colorPiel = pielGith[aux];

            aux = rand.Next(ojosGith.Count);
            colorOjos = ojosGith[aux];

            aux = rand.Next(peloGith.Count);
            colorCabello = peloGith[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[0] + " " + Alineacion[2];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Githzerai : NPC
    {
        public Githzerai()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Githzerai";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Gith");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Githyanki Psionics");
            habilidades.Add("Conocimiento Astral");

            //Rasgos fisicos caracteristicos
            List<string> pielGith = new List<string> { "Gris Palido", "Amarillo Apagado", "Arena", "Beige" };
            List<string> ojosGith = new List<string> { "Marron Oscuro", "Ambar Apagado", "Gris", "Dorado" };
            List<string> peloGith = new List<string> { "Negro", "Gris Oscuro", "Rapado" };

            Random rand = new Random();
            int aux = rand.Next(pielGith.Count);
            colorPiel = pielGith[aux];

            aux = rand.Next(ojosGith.Count);
            colorOjos = ojosGith[aux];

            aux = rand.Next(peloGith.Count);
            colorCabello = peloGith[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[0] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Gnome : NPC
    {
        public Gnome()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Gnome";

            criatura = "Humanoide";

            tamaño = "Pequeño";

            lenguaje.Add("Comun");
            lenguaje.Add("Gnómico");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Cunning Gnomo");

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[0];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 40;
            rangoEdad[1] = 500;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 0.9f;
            rangoAltura[1] = 1.2f;
        }
    }

    public class Goblin : NPC
    {
        public Goblin()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Goblin";

            criatura = "Humanoide";

            tamaño = "Pequeño";

            lenguaje.Add("Comun");
            lenguaje.Add("Goblin");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Nimble Escape");
            habilidades.Add("Furia de lo Pequeño");

            //Rasgos fisicos caracteristicos
            List<string> pielGoblin = new List<string> { "Verde Oliva Claro", "Verde Oliva Oscuro", "Verde Oscuro", "Amarillo Verdoso" };
            List<string> ojosGoblin = new List<string> { "Amarillos", "Rojos", "Naranjas", "Marron Oscuro" };
            List<string> peloGoblin = new List<string> { "Negro", "Castaño Oscuro", "Gris" };

            Random rand = new Random();
            int aux = rand.Next(pielGoblin.Count);
            colorPiel = pielGoblin[aux];

            aux = rand.Next(ojosGoblin.Count);
            colorOjos = ojosGoblin[aux];

            aux = rand.Next(peloGoblin.Count);
            colorCabello = peloGoblin[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[2];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 9;
            rangoEdad[1] = 60;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 0.9f;
            rangoAltura[1] = 1.2f;
        }
    }

    public class Goliath : NPC
    {
        public Goliath()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Goliath";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Gigante");

            habilidades.Add("Resistencia de Piedra");
            habilidades.Add("Constitucion Poderosa");
            habilidades.Add("Nacido de la montaña");

            //Rasgos fisicos caracteristicos
            List<string> pielGoblin = new List<string> { "Gris Claro", "Gris Oscuro", "Azulada", "Blanquinosa" };

            Random rand = new Random();
            int aux = rand.Next(pielGoblin.Count);
            colorPiel = pielGoblin[aux];

            //Elegimos la alineacion
            int posAlineacion = rand.Next(0, 3);
            alineamiento = Caracter[1] + " " + Alineacion[posAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 2.1f;
            rangoAltura[1] = 2.7f;
        }
    }

    public class Grug : NPC
    {
        public Grug()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Grung";

            criatura = "Humanoide";

            tamaño = "Pequeño";

            lenguaje.Add("Grung");

            habilidades.Add("Anfibio");
            habilidades.Add("Inmunidad al veneno");
            habilidades.Add("Piel venenosa");
            habilidades.Add("Dependencia del agua");
            habilidades.Add("Gran salto de pie");

            //Rasgos fisicos caracteristicos
            List<string> pielGrung = new List<string> { "Verde", "Azul", "Purpura", "Rojo", "Naranja", "Dorado" };
            List<string> estatusGrug = new List<string> { "Guerrero", "Artesano", "Lider", "Elite", "Casta especifica", "Lider Verdadero"};
            List<string> ojosGrung = new List<string> { "Negros", "Dorado", "Mismo color que piel" };

            Random rand = new Random();
            int aux = rand.Next(pielGrung.Count);
            colorPiel = pielGrung[aux];

            //Añadimos la nueva caracteristica a la lista de rasgos especiales
            rasgoEspecial.Add(estatusGrug[aux]);

            aux = rand.Next(ojosGrung.Count);
            colorOjos = ojosGrung[aux];

            colorCabello = "No tiene";

            //Elegimos la alineacion
            alineamiento = Caracter[0] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 9;
            rangoEdad[1] = 60;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 0.7f;
            rangoAltura[1] = 1.1f;
        }
    }

    public class Harengon : NPC
    {
        public Harengon()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Haregon";

            criatura = "Humanoide";

            //Elegimos un tamaño entre mediano o pequeño
            Random rand = new Random();
            tamaño = rand.Next(0, 2) == 0 ? "Mediano" : "Pequeño"; //Elegimos un tamaño entre los dos

            lenguaje.Add("Comun");
            lenguaje.Add("Silvano");

            habilidades.Add("Hare-Trigger");
            habilidades.Add("Leporine Senses");
            habilidades.Add("Lucky Footwork");
            habilidades.Add("Rabbit Hop");

            //Rasgos fisicos caracteristicos
            List<string> peloGrug = new List<string> { "Blanco", "Gris", "Marron", "Beige", "Negro", "Moteado" };

            int aux = rand.Next(peloGrug.Count);
            colorCabello = peloGrug[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.2f;
            rangoAltura[1] = 1.8f;
        }
    }

    public class HalfElf : NPC
    {
        public HalfElf()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Half-Elf";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Elfico");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Ancestro Feerico");

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 20;
            rangoEdad[1] = 200;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.6f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Halfling : NPC
    {
        public Halfling()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Halfling";

            criatura = "Humanoide";

            tamaño = "Pequeño";

            lenguaje.Add("Comun");
            lenguaje.Add("Halfling");

            habilidades.Add("Suertudo");
            habilidades.Add("Valiente");
            habilidades.Add("Agilidad Halfling");

            //Elegimos la alineacion
            Random rand = new Random();
            int posCaracter = rand.Next(0, 2);
            alineamiento = Caracter[posCaracter] + " " + Alineacion[0];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 20;
            rangoEdad[1] = 190;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 0.9f;
            rangoAltura[1] = 1.2f;
        }
    }

    public class HalfOrc : NPC
    {
        public HalfOrc()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Half-Orc";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Orco");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Amenazante");
            habilidades.Add("Resistencia Implacable");
            habilidades.Add("Ataques Salvajes");

            //Rasgos fisicos caracteristicos
            List<string> pielHOrc = new List<string> { "Verde Oliva", "Verdosa", "Verde Grisacio", "Marron Verdoso" };
            List<string> ojosHOrc = new List<string> { "Marron Oscuro", "Rojos", "Ambar", "Rojo Oscuro", "Amarillo" };
            List<string> peloHOrc = new List<string> { "Negro", "Castaño Oscuro", "Gris" };

            Random rand = new Random();
            int aux = rand.Next(pielHOrc.Count);
            colorPiel = pielHOrc[aux];

            aux = rand.Next(ojosHOrc.Count);
            colorOjos = ojosHOrc[aux];

            aux = rand.Next(peloHOrc.Count);
            colorCabello = peloHOrc[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 14;
            rangoEdad[1] = 75;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.7f;
            rangoAltura[1] = 2.0f;
        }
    }

    public class Hobgoblin : NPC
    {
        public Hobgoblin()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Hobgobiln";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Goblin");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Regalo Feerico");
            habilidades.Add("Furia de Muchos");

            //Rasgos fisicos caracteristicos
            List<string> pielHobgoblin = new List<string> { "Rojo Oscuro", "Cobrizo", "Gris Ladrillo", "Marron Rojizo" };
            List<string> ojosHobgoblin = new List<string> { "Marron Oscuro", "Rojos", "Ambar", "Rojo Oscuro", "Amarillo" };
            List<string> peloHobgoblin = new List<string> { "Negro", "Castaño Oscuro", "Gris" };

            Random rand = new Random();
            int aux = rand.Next(pielHobgoblin.Count);
            colorPiel = pielHobgoblin[aux];

            aux = rand.Next(ojosHobgoblin.Count);
            colorOjos = ojosHobgoblin[aux];

            aux = rand.Next(peloHobgoblin.Count);
            colorCabello = peloHobgoblin[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[0] + " " + Alineacion[2];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 15;
            rangoEdad[1] = 95;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.6f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Human : NPC
    {
        public Human()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Human";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");

            //Elegimos la alineacion
            Random rand = new Random();
            int posCaracter = rand.Next(0, 3);
            int posAlineacion = rand.Next(0, 3);
            alineamiento = Caracter[posCaracter] + " " + Alineacion[posAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 95;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Kenku : NPC
    {
        public Kenku()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Kenku";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Auran");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Experto en Falsificacion");
            habilidades.Add("Memoria de Kenku");
            habilidades.Add("Imitacion");

            //Rasgos fisicos caracteristicos
            List<string> ojosKenku = new List<string> { "Negro", "Ambar Oscuro", "Rojizos" };
            List<string> peloKenku = new List<string> { "Negro", "Gris Oscuro", "Azul Oscuro" };

            Random rand = new Random();
            int aux = rand.Next(ojosKenku.Count);
            colorOjos = ojosKenku[aux];

            aux = rand.Next(peloKenku.Count);
            colorCabello = peloKenku[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 12;
            rangoEdad[1] = 75;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.4f;
            rangoAltura[1] = 1.7f;
        }
    }

    public class Kobold : NPC
    {
        public Kobold()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Kobold";

            criatura = "Humanoide";

            tamaño = "Pequeño";

            lenguaje.Add("Comun");
            lenguaje.Add("Draconico");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Lloro Draconico");
            habilidades.Add("Legado Kobold");

            //Rasgos fisicos caracteristicos
            List<string> ojosKobold = new List<string> { "Amarillos", "Naranjas", "Rojos", "Negros" };
            List<string> pielKobold = new List<string> { "Marron", "Rojo Apagado", "Naranja", "Verde", "Azule", "Negro", "Gris" };

            Random rand = new Random();
            int aux = rand.Next(ojosKobold.Count);
            colorOjos = ojosKobold[aux];

            aux = rand.Next(pielKobold.Count);
            colorPiel = pielKobold[aux];

            colorCabello = "No tiene";

            //Elegimos la alineacion
            alineamiento = Caracter[0] + " " + Alineacion[2];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 7;
            rangoEdad[1] = 115;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 0.7f;
            rangoAltura[1] = 1.0f;
        }
    }

    public class Lizardfolk : NPC
    {
        public Lizardfolk()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Lizardfolk";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Draconico");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Nimble Escape");
            habilidades.Add("Furia de lo Pequeño");

            //Rasgos fisicos caracteristicos
            List<string> ojosLizardfolk = new List<string> { "Amarillos", "Verdes", "Ambar", "Marron Oscuros" };
            List<string> pielLizardfolk = new List<string> { "Verde", "Verde Oscuro", "Marron", "Oliva", "Gris", "Arena" };

            Random rand = new Random();
            int aux = rand.Next(ojosLizardfolk.Count);
            colorOjos = ojosLizardfolk[aux];

            aux = rand.Next(pielLizardfolk.Count);
            colorPiel = pielLizardfolk[aux];

            colorCabello = "No tiene";

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 14;
            rangoEdad[1] = 80;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.6f;
            rangoAltura[1] = 2.1f;
        }
    }

    public class Locathah : NPC
    {
        public Locathah()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Locathah";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Aquan");

            habilidades.Add("Amfibio");
            habilidades.Add("Armadura Natural");
            habilidades.Add("Dependencia del Agua");
            habilidades.Add("Voluntad del leviatan");

            //Rasgos fisicos caracteristicos
            List<string> ojosLocathah = new List<string> { "Negros", "Azul Oscuro", "Plateados", "Verdes" };
            List<string> pielLocathah = new List<string> { "Azul", "Verde Marino", "Turquesa", "Gris Plateado" };

            Random rand = new Random();
            int aux = rand.Next(ojosLocathah.Count);
            colorOjos = ojosLocathah[aux];

            aux = rand.Next(pielLocathah.Count);
            colorPiel = pielLocathah[aux];

            colorCabello = "No tiene";

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 11;
            rangoEdad[1] = 95;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.2f;
            rangoAltura[1] = 1.5f;
        }
    }

    public class Minotaur : NPC
    {
        public Minotaur()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Minotaur";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Minotauro");

            habilidades.Add("Cuernos Martillo");
            habilidades.Add("Goring Rush");
            habilidades.Add("Recuerdo Laberintico");

            //Rasgos fisicos caracteristicos
            List<string> ojosMinotaur = new List<string> { "Negros", "Marron Oscuro", "Ambar", "Rojo Oscuros" };
            List<string> pielMinotaur = new List<string> { "Marron", "Negro", "Rojizo", "Gris", "Arena" };
            List<string> peloMinotaur = new List<string> { "Marron", "Negro", "Rojizo", "Gris", "Arena" };

            Random rand = new Random();
            int aux = rand.Next(ojosMinotaur.Count);
            colorOjos = ojosMinotaur[aux];

            aux = rand.Next(pielMinotaur.Count);
            colorPiel = pielMinotaur[aux];
            colorCabello = peloMinotaur[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 2.1f;
            rangoAltura[1] = 2.5f;
        }
    }

    public class Orc : NPC
    {
        public Orc()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Orc";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Orco");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Agresivo");
            habilidades.Add("Constitucion poderosa");
            habilidades.Add("Chute de adrenalina");   

            //Rasgos fisicos caracteristicos
            List<string> ojosOrc = new List<string> { "Rojos", "Marron Oscuro", "Ambar", "Amarillos" };
            List<string> pielOrc = new List<string> { "Verde Oscura", "Verde Grisacia", "Oliva", "Marron Verdosa", "Gris Ceniza" };
            List<string> peloOrc = new List<string> { "Castaño Oscuro", "Negro",  "Gris"};

            Random rand = new Random();
            int aux = rand.Next(ojosOrc.Count);
            colorOjos = ojosOrc[aux];

            aux = rand.Next(pielOrc.Count);
            colorPiel = pielOrc[aux];

            aux = rand.Next(peloOrc.Count);
            colorCabello = peloOrc[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[2];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 12;
            rangoEdad[1] = 60;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.8f;
            rangoAltura[1] = 2.2f;
        }
    }

    public class Owil : NPC
    {
        public Owil()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Owil";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Vuela");
            habilidades.Add("Plumaje silencioso");

            //Rasgos fisicos caracteristicos
            List<string> ojosOwil = new List<string> { "Dorados", "Naranjas", "Ambar", "Marron Oscuros", "Negros" };
            List<string> peloOwil = new List<string> { "Blanco", "Gris", "Marron", "Negro", "Beige" };

            Random rand = new Random();
            int aux = rand.Next(ojosOwil.Count);
            colorOjos = ojosOwil[aux];

            aux = rand.Next(peloOwil.Count);
            colorCabello = peloOwil[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 95;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.5f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Satyr : NPC
    {
        public Satyr()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Satyr";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Silvano");

            habilidades.Add("Antepasado Feerico");
            habilidades.Add("Resistencia Magica");
            habilidades.Add("Saltos Alegres");

            //Rasgos fisicos caracteristicos
            List<string> ojosSatyr = new List<string> { "Verdes", "Marron", "Ambar", "Dorados" };

            Random rand = new Random();
            int aux = rand.Next(ojosSatyr.Count);
            colorOjos = ojosSatyr[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 120;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.6f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class SeaElf : NPC
    {
        public SeaElf()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Sea Elf";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Elfico");
            lenguaje.Add("Aquatico");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Hijo del Mar");
            habilidades.Add("Amigo del Mar");

            //Rasgos fisicos caracteristicos
            List<string> ojosSeaElf = new List<string> { "Azul Profundo", "Verde Oceano", "Plateado", "Negro Brillante" };
            List<string> pielSeaElf = new List<string> { "Azulado", "Verde Marino", "Turquesa", "Plateado", "Gris Perla" };
            List<string> peloSeaElf = new List<string> { "Verde Alga", "Azul Oscuro", "Negro Azul", "Plateado", "Blanco Espumoso" };

            Random rand = new Random();
            int aux = rand.Next(ojosSeaElf.Count);
            colorOjos = ojosSeaElf[aux];

            aux = rand.Next(pielSeaElf.Count);
            colorPiel = pielSeaElf[aux];

            aux = rand.Next(peloSeaElf.Count);
            colorCabello = peloSeaElf[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[0];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 20;
            rangoEdad[1] = 750;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.55f;
            rangoAltura[1] = 1.85f;
        }
    }

    public class Shadar_Kai : NPC
    {
        public Shadar_Kai()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Shadar Kai";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Elfico");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Bendicion de la Reina Cuervo");
            habilidades.Add("Resistencia daño Necrotico");

            //Rasgos fisicos caracteristicos
            List<string> ojosShadar_Kai = new List<string> { "Grises", "Plateados", "Violetas Oscuros", "Negros" };
            List<string> pielShadar_Kai = new List<string> { "Palido", "Blanco Mortecino", "Negro Ahumado", "Gris Ceniza" };
            List<string> peloShadar_Kai = new List<string> { "Blanco", "Negro", "Gris Plateado" };

            Random rand = new Random();
            int aux = rand.Next(ojosShadar_Kai.Count);
            colorOjos = ojosShadar_Kai[aux];

            aux = rand.Next(pielShadar_Kai.Count);
            colorPiel = pielShadar_Kai[aux];

            aux = rand.Next(peloShadar_Kai.Count);
            colorCabello = peloShadar_Kai[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 20;
            rangoEdad[1] = 750;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.55f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Shifter : NPC
    {
        public Shifter()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Shifter";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Cambiar Forma");

            //Rasgos fisicos caracteristicos
            List<string> ojosOrc = new List<string> { "Verde Intenso", "Marron Oscuro", "Ambar", "Dorados" };

            Random rand = new Random();
            int aux = rand.Next(ojosOrc.Count);
            colorOjos = ojosOrc[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 90;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.55f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Tabaxi : NPC
    {
        public Tabaxi()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Tabaxi";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Felino");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Agilidad Felina");
            habilidades.Add("Garras de Gato");

            //Rasgos fisicos caracteristicos
            List<string> ojosTabaxi = new List<string> { "Verdes", "Dorados", "Ambar", "Amarillos", "Azules" };
            List<string> peloTabaxi = new List<string> { 
                "Negro Solido", "Gris Solido", "Marron Solido", "Arena Solido", "Blanco Solido", "Naranja Solido",
                "Negro Atigrado", "Gris Atigrado", "Marron Atigrado", "Arena Atigrado", "Blanco Atigrado", "Naranja Atigrado",
                "Negro Moteado", "Gris Moteado", "Marron Moteado", "Arena Moteado", "Blanco Moteado", "Naranja Moteado",};

            Random rand = new Random();
            int aux = rand.Next(ojosTabaxi.Count);
            colorOjos = ojosTabaxi[aux];

            aux = rand.Next(peloTabaxi.Count);
            colorCabello = peloTabaxi[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 90;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.6f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Tiefling : NPC
    {
        public Tiefling()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Tiefling";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Infernal");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Resistencia Infernal");
            habilidades.Add("Legado Infernal");

            //Rasgos fisicos caracteristicos
            List<string> ojosTiefling = new List<string> { "Dorados", "Rojos", "Negros", "Amarillos" };
            List<string> pielTiefling = new List<string> { "Rojiza", "Granate", "Carmesi", "Azul", "Purpura", "Gris Ceniza" }; 
            List<string> peloTiefling = new List<string> { "Castaño Oscuro", "Negro", "Rojo", "Blanco" };

            Random rand = new Random();
            int aux = rand.Next(ojosTiefling.Count);
            colorOjos = ojosTiefling[aux];

            aux = rand.Next(pielTiefling.Count);
            colorPiel = pielTiefling[aux];

            aux = rand.Next(peloTiefling.Count);
            colorCabello = peloTiefling[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 90;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.6f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Tortle : NPC
    {
        public Tortle()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Tortle";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Aquatico");

            habilidades.Add("Armadura Natural");
            habilidades.Add("Defensa de Caparazon");
            habilidades.Add("Aguantar Respiracion");

            //Rasgos fisicos caracteristicos
            List<string> ojosTortle = new List<string> { "Negros", "Marron Oscuro", "Ambar", "Verde Apagados" };
            List<string> pielTortle = new List<string> { "Verde oliva", "Verde Musgo", "Gris Piedra" };

            Random rand = new Random();
            int aux = rand.Next(ojosTortle.Count);
            colorOjos = ojosTortle[aux];

            aux = rand.Next(pielTortle.Count);
            colorPiel = pielTortle[aux];

            colorCabello = "No tiene";

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 15;
            rangoEdad[1] = 60;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.6f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Triton : NPC
    {
        public Triton()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Triton";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Primordial");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Anfibio");
            habilidades.Add("Control Aire y Agua");
            habilidades.Add("Resistencia al Frio");

            //Rasgos fisicos caracteristicos
            List<string> ojosTriton = new List<string> { "Azul Intenso", "Verde Oceano", "Dorado Palido", "Plateado" };
            List<string> pielTriton = new List<string> { "Azul Profundo", "Verde Marino", "Turquesa", "Plateado", "Gris Perla" };
            List<string> peloTriton = new List<string> { "Azul Oscuro", "Verde Alga", "Plateado", "Blanco Espumoso" };

            Random rand = new Random();
            int aux = rand.Next(ojosTriton.Count);
            colorOjos = ojosTriton[aux];

            aux = rand.Next(pielTriton.Count);
            colorPiel = pielTriton[aux];

            aux = rand.Next(peloTriton.Count);
            colorCabello = peloTriton[aux];

            //Elegimos la alineacion
            int numAlineacion = rand.Next(0, 1);
            alineamiento = Caracter[0] + " " + Alineacion[numAlineacion];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 200;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.65f;
            rangoAltura[1] = 1.95f;
        }
    }

    public class Verdan : NPC
    {
        public Verdan()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Verdan";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Goblin");

            habilidades.Add("Telepatia Limitada");
            habilidades.Add("Ventaja Telepatica");
            habilidades.Add("Curacion de Sangre Negra");

            //Rasgos fisicos caracteristicos
            List<string> ojosVerdan = new List<string> { "Negros", "Violeta Oscuro", "Verde" };
            List<string> pielVerdan = new List<string> { "Verde Brillante", "Verde Azulado", "Verde Grisacio" };
            List<string> peloVerdan = new List<string> { "Calvo", "Negro", "Gris Oscuro" };

            Random rand = new Random();
            int aux = rand.Next(ojosVerdan.Count);
            colorOjos = ojosVerdan[aux];

            aux = rand.Next(pielVerdan.Count);
            colorPiel = pielVerdan[aux];

            aux = rand.Next(peloVerdan.Count);
            colorCabello = peloVerdan[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[2] + " " + Alineacion[1];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 100;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.4f;
            rangoAltura[1] = 1.9f;
        }
    }

    public class Yuan_ti : NPC
    {
        public Yuan_ti()
        {
            //Definimos los elementos que se generan de manera aleatoria
            definirRangos();        //Definimos los rangos de las caracteristicas
            randomAtributos();      //Generamos los atributos aleatorios

            //Ahora definimos los atributos que no son aleatorios.
            raza = "Yuan-ti";

            criatura = "Humanoide";

            tamaño = "Mediano";

            lenguaje.Add("Comun");
            lenguaje.Add("Abisal");
            lenguaje.Add("Draconico");

            habilidades.Add("Vision en la oscuridad");
            habilidades.Add("Inmunidad al veneno");
            habilidades.Add("Resistencia Magica");

            //Rasgos fisicos caracteristicos
            List<string> ojosOrc = new List<string> { "Dorados", "Negros", "Verdes Brillantes", "Amarillos" };
            List<string> pielOrc = new List<string> { "Verde Oscura", "Verde", "Oliva", "Marron", "Dorado Apagado"};
            List<string> peloOrc = new List<string> { "Castaño Oscuro", "Negro", "Calvo" };

            Random rand = new Random();
            int aux = rand.Next(ojosOrc.Count);
            colorOjos = ojosOrc[aux];

            aux = rand.Next(pielOrc.Count);
            colorPiel = pielOrc[aux];

            aux = rand.Next(peloOrc.Count);
            colorCabello = peloOrc[aux];

            //Elegimos la alineacion
            alineamiento = Caracter[1] + " " + Alineacion[2];
        }

        private void definirRangos()
        {
            //Definimos el rango de edad para los Aarakocras
            rangoEdad[0] = 18;
            rangoEdad[1] = 150;
            //Definimos el rango de altura para los Aarakocras
            rangoAltura[0] = 1.6f;
            rangoAltura[1] = 1.9f;
        }
    }
}