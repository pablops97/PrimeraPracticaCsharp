using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoPPS
{
    internal class Personaje
    {
        public string Nombre {  get; set; }
        public string Anime {  get; set; }
        public int Edad {  get; set; }
        public int Altura {  get; set; }
        public Image Imagen { get; set; }

        public string Descripcion { get; set; }


        public Personaje(string nombre, string anime, int edad, int altura, Image imagen, string descripcion) { 
            
            this.Nombre = nombre;
            this.Anime = anime;
            this.Edad = edad;
            this.Altura = altura;
            this.Imagen = imagen;
            this.Descripcion = descripcion;
        }



    }
}
