using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDeEstrategiaFinal.Modelo
{
    public class Carta
    {

        public string Nombre { get; set; }
        public int puntos_de_vida { get; set; }
        public int daño { get; set; }

        public Carta(string Nombre,int puntos_de_vida,int daño)
        {
            this.Nombre = Nombre;
            this.puntos_de_vida = puntos_de_vida;
            this.daño = daño;
        }
        public Carta()
        {

        }
    }
}
