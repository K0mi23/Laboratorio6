using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboratorio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void verificarLineasRepetidas()
        {
            string[] lines = File.ReadAllLines(@"InformacionCliente.txt");
            File.WriteAllLines(@"InformacionCliente.txt", lines.Distinct().ToArray());
            string[] lines1 = File.ReadAllLines(@"InformacionAutomoviles.txt");
            File.WriteAllLines(@"InformacionAutomoviles.txt", lines1.Distinct().ToArray()); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonGuardarEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
