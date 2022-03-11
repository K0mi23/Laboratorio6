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
        
        private void limpiarTexto()
        {
            verificarLineasRepetidas();
            NITcliente.Text = "";
            nombreCompletoCliente.Text = "";
            DireccionCliente.Text = "";
            PlacaAutomovil.Text = "";
            MarcaAutomovil.SelectedIndex = -1;
            NITcliente.Focus();
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
                datosCliente.NitCliente = Int32.Parse(NITcliente.Text);
                datosCliente.nombreCliente = nombreCompletoCliente.Text;
                datosCliente.direccionCliente = DireccionCliente.Text;
                datosCliente.fechaAlquiler = fechaAlquilerVehiculo.Text;
                datosCliente.fechaDevolucion = fechaDevolucionVehiculo.Text;
                datosCliente.placaAuto = PlacaAutomovil.Text;
                datosCliente.marcaAuto = MarcaAutomovil.Text;
                datosClientes.Add(datosCliente);
                visualizar();
               GuardarenArchivo();

            }
            limpiarTexto();

        }

        private void GuardarenArchivo()
        {
            TextWriter writer = new StreamWriter(@"InformacionCliente.txt", true);
            for (int i = 0; i < informacionCliente.Rows.Count; i++)
            {
                for (int j = 0; j < informacionCliente.Columns.Count; j++)
                {
                    writer.Write("\t" + informacionCliente.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
        }

        private void formAutomovil_Click(object sender, EventArgs e)
        {
            verificarLineasRepetidas();
            IngresoAutomovil formAutomoviles = new IngresoAutomovil();
            formAutomoviles.ShowDialog();
        }

        private void informacionCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
