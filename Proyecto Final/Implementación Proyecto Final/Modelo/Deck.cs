using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDeEstrategiaFinal.Modelo
{
    public class Deck
    {
        private List<Carta> Cartas { get; set; }
        private int puntos_de_vida { get; set; }
        private int daño { get; set; }
        private int ataque { get; set; }
        private int defensa { get; set; }
        private int sinergia { get; set; }
        private int balance { get; set; }
        private int nombre { get; set; }

        public Deck(List<Carta> Cartas,int puntos_de_vida, int daño,int ataque, int defensa, int sinergia, int balance, int nombre)
        {
            this.Cartas = Cartas;
            this.puntos_de_vida=puntos_de_vida;
            this.daño = daño;
            this. ataque = ataque;
            this.defensa = defensa;
            this.sinergia = sinergia;
            this.balance = balance;
            this.nombre = nombre;

        }

        public Deck( int nombre)
        {
            this.nombre = nombre;

        }
        public Deck()
        {
            

        }




    }
}
