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
        List<Dato> datosClientes = new List<Dato>();
        private void verificarLineasRepetidas()
        {
            string[] lines = File.ReadAllLines(@"InformacionCliente.txt");
            File.WriteAllLines(@"InformacionCliente.txt", lines.Distinct().ToArray());
            
        }
        
        private void limpiarTexti()
        {
            verificarLineasRepetidas();
            NITcliente.Text = "";
            nombreCompletoCliente.Text = "";
            DireccionCliente.Text = "";
        }

        private void GuardarenArchivo()
        {
            TextWriter writer = new StreamWriter(@"InformacionCliente.txt");
            for (int i = 0; i < informacionCliente.Rows.Count; i++)
            {
                for (int j = 0; j < informacionCliente.Columns.Count - 2; j++)
                {
                    writer.Write("\t" + informacionCliente.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
        }
        private void visualizar()
        {
            informacionCliente.DataSource = null;
            informacionCliente.Refresh();
            informacionCliente.DataSource = datosClientes;
            informacionCliente.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void botonGuardarClientes_Click(object sender, EventArgs e)
        {
            if (NITcliente.Text == "" && nombreCompletoCliente.Text == "" && DireccionCliente.Text == "")
            {
                MessageBox.Show("Porfavor completar la información!");
            }
            else
            {  
                Dato datosCliente = new Dato();
                datosCliente.NitCliente = Convert.ToInt16(NITcliente.Text);
                datosCliente.nombreCliente = nombreCompletoCliente.Text;
                datosCliente.direccionCliente = DireccionCliente.Text;
                datosCliente.fechaAlquiler = fechaAlquilerVehiculo.Value;
                datosCliente.fechaDevolucion = fechaDevolucionVehiculo.Value;
                datosClientes.Add(datosCliente);
                visualizar();
                GuardarenArchivo();

            }
        }
    }
}
