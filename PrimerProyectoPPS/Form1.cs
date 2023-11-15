namespace PrimerProyectoPPS
{
    public partial class Form1 : Form
    {

        List<Personaje> personajesOnePiece = new List<Personaje>();
        List<Personaje> personajesNaruto = new List<Personaje>();
        List<Personaje> personajesDragonBall = new List<Personaje>();
        List<Personaje> personajesBokuNoHero = new List<Personaje>();

        Dictionary<int, List<Personaje>> miDiccionario = new Dictionary<int, List<Personaje>>();
        List<List<Personaje>>[] listaListas = new List<List<Personaje>>[3];
        


        static public int indice = 0;
        public Form1()
        {
            InitializeComponent();
            insertarElementosListaAnimes();
            iniciarDiccionario();
            mostrarDatos();
            

        }

        public void iniciarDiccionario()
        {
            personajesOnePiece.Add(new Personaje("Luffy", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesOnePiece.Add(new Personaje("Zoro", "One Piece", 21, 181, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
    "Roronoa Zoro es uno de los principales personajes en \"One Piece\". Es el espadach�n del sombrero de paja y el espadach�n principal del equipo de Luffy. Zoro es conocido por su habilidad con las tres espadas y su determinaci�n inquebrantable en convertirse en el mejor espadach�n del mundo."));

            personajesOnePiece.Add(new Personaje("Sanji", "One Piece", 21, 180, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Vinsmoke Sanji, tambi�n conocido como Black Leg, es el cocinero de la tripulaci�n del sombrero de paja. Sanji es experto en el arte marcial del Black Leg Style y utiliza t�cnicas de piernas en combate. Aunque a veces se presenta como un mujeriego, Sanji es un valioso miembro de la tripulaci�n de Luffy."));

            personajesOnePiece.Add(new Personaje("Nami", "One Piece", 20, 170, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Nami es la navegante del sombrero de paja y una talentosa cart�grafa. Su sue�o es trazar un mapa completo del mundo. Inicialmente, Nami se une a la tripulaci�n de Luffy con la esperanza de reunir suficiente dinero para comprar la libertad de su aldea natal. A lo largo de la serie, se convierte en una leal amiga y miembro indispensable de la tripulaci�n."));

            personajesOnePiece.Add(new Personaje("Usopp", "One Piece", 20, 176, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Usopp es el tirador de la tripulaci�n del sombrero de paja y un h�bil francotirador. Su sue�o es convertirse en un valiente guerrero de los mares y crear un mapa del mundo de los mares del norte. Usopp es conocido por sus historias exageradas y su habilidad para fabricar inventos sorprendentes. A pesar de su tendencia a mentir, es un miembro querido de la tripulaci�n."));

            personajesNaruto.Add(new Personaje("naruto", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesNaruto.Add(new Personaje("omg", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesNaruto.Add(new Personaje("peter", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesNaruto.Add(new Personaje("willy", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));

            personajesDragonBall.Add(new Personaje("Luffy", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesDragonBall.Add(new Personaje("omg", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesDragonBall.Add(new Personaje("peter", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesDragonBall.Add(new Personaje("willy", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));

            personajesBokuNoHero.Add(new Personaje("Midoriya", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesBokuNoHero.Add(new Personaje("omg", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesBokuNoHero.Add(new Personaje("peter", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            personajesBokuNoHero.Add(new Personaje("willy", "One Piece", 19, 175, Image.FromFile("C:\\Users\\ConoMaster\\source\\repos\\PrimerProyectoPPS\\PrimerProyectoPPS\\Imagenes\\Luffy.jpg"),
                "Monkey D. Luffy es el carism�tico protagonista del manga y anime \"One Piece\", creado por Eiichiro Oda. Luffy es un joven intr�pido y so�ador que busca convertirse en el Rey de los Piratas. Su personalidad es alegre, valiente y un tanto ingenua, pero posee una determinaci�n inquebrantable."));
            /*foreach (Personaje personaje in personajesOnePiece)
            {
                listaPersonajes.Items.Add(personaje.ToString);
            }*/
            /*
            listaListas[0].Add(personajesOnePiece);
            listaListas[1].Add(personajesNaruto);
            listaListas[2].Add(personajesDragonBall);
            listaListas[3].Add(personajesBokuNoHero);*/
        }

        public void insertarElementosListaAnimes()
        {
            /*
            listaAnimes.Items.Add("One Piece");
            listaAnimes.Items.Add("Naruto");
            listaAnimes.Items.Add("Dragon Ball");
            listaAnimes.Items.Add("Boku no hero");
            */
            listaAnimes.Items.Add(personajesOnePiece);
            listaAnimes.Items.Add(personajesNaruto);
            listaAnimes.Items.Add(personajesDragonBall);
            listaAnimes.Items.Add(personajesBokuNoHero);

            
        }

        public void mostrarDatos()
        {
            if(indice == 0)
            {
                botonRetroceder.Enabled = false;
            }
            if(listaAnimes.SelectedItem == null)
            {
                NombreField.Text = "";
                EdadField.Text = "";
                AnimeField.Text = "";
                AlturaField.Text = "";
                DescripcionField.Text = "";
            }
            else
            {
                List<Personaje> aux = (List<Personaje>)listaAnimes.SelectedItem;
                NombreField.Text = aux[indice].Nombre;
                pictureBox.Image = aux[indice].Imagen;
                EdadField.Text = "" + aux[indice].Edad;
                AnimeField.Text = aux[indice].Anime;
                AlturaField.Text = "" + aux[indice].Altura + " cm";
                DescripcionField.Text = aux[indice].Descripcion;
            }
            
        }

        public void avanzar()
        {
            
            botonRetroceder.Enabled = true;
            indice++;
            List<Personaje> aux = (List<Personaje>)listaAnimes.SelectedItem;
            if (indice == aux.Count - 1)
            {
                botonAvanzar.Enabled = false;    
            }
            mostrarDatos();
        }

        public void retroceder()
        {
            botonAvanzar.Enabled = true;
            indice--;
            if (indice == 0)
            {
                botonRetroceder.Enabled = false;
            }
            mostrarDatos();

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NombreField_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnimeField_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaAnimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = 0;
            mostrarDatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            avanzar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retroceder();
        }
    }
}