using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidadorDeEstrategiaFinal.Modelo;

namespace ValidadorDeEstrategiaFinal
{
    public partial class Carta_Form : Form
    {
        
        public Carta_Form()
        {
            InitializeComponent();
        }
        List<Carta> list = new List<Carta>();

        private void button1_Click(object sender, EventArgs e)
        {
            Carta carta1 = new Modelo.Carta(nombre_carta.Text, int.Parse(puntos_vida_carta.Text), int.Parse(daño_carta.Text));
            list.Add(carta1);
            dataGridViewCarta.DataSource = null;    
            dataGridViewCarta.DataSource = list;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
