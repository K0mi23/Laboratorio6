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
    public partial class IngresoAutomovil : Form
    {
        public IngresoAutomovil()
        {
            InitializeComponent();
        }
        List<Dato> datosVehiculos = new List<Dato>();
        private void botonGuardarEmpleado_Click(object sender, EventArgs e)
        {
            string[] lines1 = File.ReadAllLines(@"InformacionAutomoviles.txt");
            File.WriteAllLines(@"InformacionAutomoviles.txt", lines1.Distinct().ToArray());
        }
    }
}
