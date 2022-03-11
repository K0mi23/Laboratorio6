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
            verificarLineasRepetidas();
        }

        private void limpiarTexto()
        {
            verificarLineasRepetidas();
            PlacaAutomovil.Text = "";
            MarcaAutomovil.SelectedIndex = -1;
            ModeloAutomovil.Text = "";
            colorAutomovil.SelectedIndex = -1;
            precioxKilometro.Value = 0;
            PlacaAutomovil.Focus();
        }
        private void verificarLineasRepetidas()
        {
            string[] lines1 = File.ReadAllLines(@"InformacionAutomoviles.txt");
            File.WriteAllLines(@"InformacionAutomoviles.txt", lines1.Distinct().ToArray());

        }
        List<DatoVehiculo> datosVehiculos = new List<DatoVehiculo>();
        string Archivo = File.ReadAllText(@"InformacionAutomoviles.txt");
        private void botonGuardarEmpleado_Click(object sender, EventArgs e)
        {
            verificarLineasRepetidas();
            if (PlacaAutomovil.Text == "" && MarcaAutomovil.Text == "" && ModeloAutomovil.Text == ""&& colorAutomovil.Text=="")
            {
                MessageBox.Show("Porfavor completar la información!");
            }
            else
            {
              
                if(Archivo.Contains(PlacaAutomovil.Text))
                {
                    MessageBox.Show("Esta placa ya ha sido registrada en otro vehiculo!");
                }
                else
                {
                    if (Archivo.Contains(PlacaAutomovil.Text) && Archivo.Contains(ModeloAutomovil.Text) && Archivo.Contains(MarcaAutomovil.Text) && Archivo.Contains(colorAutomovil.Text))
                    {
                        MessageBox.Show("Este Automovil ya ha sido registrado");
                    }
                    else
                    {
                        DatoVehiculo datosAutomovil = new DatoVehiculo();
                        datosAutomovil.placaAuto = PlacaAutomovil.Text;
                        datosAutomovil.marcaAuto = MarcaAutomovil.Text;
                        datosAutomovil.modeloAuto = ModeloAutomovil.Text;
                        datosAutomovil.colorAuto = colorAutomovil.Text;
                        datosAutomovil.precioxKilometro = Convert.ToDecimal(precioxKilometro.Value);
                        datosVehiculos.Add(datosAutomovil);
                        visualizar();
                        GuardarenArchivo();
                    }
                }
                


            }
            limpiarTexto();


        }

        private void GuardarenArchivo()
        {
            TextWriter writer = new StreamWriter(@"InformacionAutomoviles.txt", true);
            for (int i = 0; i < informacionAutos.Rows.Count; i++)
            {
                for (int j = 0; j < informacionAutos.Columns.Count; j++)
                {
                    writer.Write("\t" + informacionAutos.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
        }

        private void visualizar()
        {
            informacionAutos.DataSource = null;
            informacionAutos.Refresh();
            informacionAutos.DataSource = datosVehiculos;
            informacionAutos.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificarLineasRepetidas();
            this.Hide();
            IngresarColorModelo NuevoAuto = new IngresarColorModelo();
            NuevoAuto.Closed += (s, args) => this.Close();
            NuevoAuto.ShowDialog();
        }

        private void lecturaArchivoVehiculos()
        {
            string[] lineaArchivo = File.ReadAllLines(@"ListaMARCA.txt");
            foreach (var linea in lineaArchivo)
            {
                var marcaAuto = linea.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries)[0];
                
                MarcaAutomovil.Items.Add(marcaAuto);
            }

            string[] lineaArchivoCOLORES = File.ReadAllLines(@"ListaCOLORES.txt");
            foreach (var linea in lineaArchivoCOLORES)
            {
                var colorAuto = linea.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries)[0];

                colorAutomovil.Items.Add(colorAuto);
            }

            string[] lineaArchivoMODELO = File.ReadAllLines(@"ListaMODELO.txt");
            foreach (var linea in lineaArchivoMODELO)
            {
                var modeloAuto = linea.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries)[0];

                ModeloAutomovil.Items.Add(modeloAuto);
            }

        }

        private void IngresoAutomovil_Load(object sender, EventArgs e)
        {
            lecturaArchivoVehiculos();
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => this.Close();
            form.ShowDialog();
        }
    }

}
