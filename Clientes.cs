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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => this.Close();
            form.ShowDialog();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            table.Columns.Add("NIT", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Dirección", typeof (string));
            table.Columns.Add("Renta", typeof(string));
            table.Columns.Add("Devolución" ,typeof(string));
            table.Columns.Add("Marca", typeof(string));
            table.Columns.Add ("Placa", typeof(string));

            table2.Columns.Add("Placa", typeof(string));
            table2.Columns.Add ("Marca", typeof (string));
            table2.Columns.Add("Modelo",typeof(string));
            table2.Columns.Add("Color", typeof(string));
            table2.Columns.Add("Pago x Km", typeof(decimal));

            dataGridView1.DataSource = table;
            dataGridView2.DataSource = table2;

            leerArchivo();
            leerArchivo2();

        }

        private void leerArchivo()
        {
            StreamReader Archivo1 = new StreamReader(@"InformacionCliente.txt");
            string linea;
            while ((linea = Archivo1.ReadLine()) != null)
            {
                DataRow dr = table.NewRow();
                string[] valores = linea.Split('|');
                for (int i = 0; i < 3; i++)
                {
                    dr[i] = valores[i];

                    for (int l = 3; l < 7; l++)
                    {
                        dr[l] = valores[l];
                    }
                }
                table.Rows.Add(dr);
            }
            Archivo1.Close();
            dataGridView1.DataSource = table;
        }

        private void leerArchivo2()
        {
            StreamReader Archivo1 = new StreamReader(@"InformacionAutomoviles.txt");
            string linea;
            while ((linea = Archivo1.ReadLine()) != null)
            {
                DataRow dr = table2.NewRow();
                string[] valores = linea.Split('|');
                for (int i = 0; i < 5; i++)
                {
                    dr[i] = valores[i];
                }
                table2.Rows.Add(dr);
            }
            Archivo1.Close();

        }
        int i; decimal TotalaPagar = 0;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i= e.RowIndex;
            try
            {
                DataGridViewRow LineaSeleccionada = dataGridView2.Rows[i];
                DataGridViewRow LineaSeleccionada2 = dataGridView1.Rows[i];
                PlacaAutomovil.Text = LineaSeleccionada.Cells[0].Value.ToString(); //Placa Automovil
                nombreCompletoCliente.Text = LineaSeleccionada2.Cells[1].Value.ToString(); //Nombre
                marcaAutomovil.Text = LineaSeleccionada.Cells[1].Value.ToString(); //Marca
                DireccionCliente.Text = LineaSeleccionada2.Cells[2].Value.ToString(); //Direccion
                NITcliente.Text = LineaSeleccionada2.Cells[0].Value.ToString(); //NIT
                modeloAutomovil.Text = LineaSeleccionada.Cells[2].Value.ToString(); //Modelo
                colorAutomovil.Text = LineaSeleccionada.Cells[3].Value.ToString(); //Color
                precioxKm.Text = LineaSeleccionada.Cells[4].Value.ToString(); //Precio x Kilometro
            }
            catch (Exception ex) { MessageBox.Show("Error!\n\n Por favor seleccionar un empleado valido!"); }


        }

        private void calcularTOTAL_Click(object sender, EventArgs e)
        {
            decimal precioxKM = Convert.ToDecimal(precioxKm.Text);
            decimal KilometrosRecorridos = Convert.ToDecimal(KmRecorridos.Text);

            TotalaPagar = precioxKM * KilometrosRecorridos;
            TOTAL.Text = TotalaPagar.ToString();
        }
    }
}
