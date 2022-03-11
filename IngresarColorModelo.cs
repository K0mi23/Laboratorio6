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
    public partial class IngresarColorModelo : Form
    {
        public IngresarColorModelo()
        {
            InitializeComponent();
            #region VerificarLineasRepetidas
            verificarLineasRepetidas();
            verificarLineasRepetidas1();
            verificarLineasRepetidas2();
            #endregion     
        }

        List<AgregarAutoNuevo> datosVehiculos = new List<AgregarAutoNuevo>();
        private void limpiarTexto()
        {
            MarcaAutomovil.Text = "";
            ModeloAutomovil.Text = "";
            ColorAutomovil.Text = "";
            MarcaAutomovil.Focus();
        }
        private void verificarLineasRepetidas()
        {
            string[] lines1 = File.ReadAllLines(@"ListaMARCA.txt");
            File.WriteAllLines(@"ListaMARCA.txt", lines1.Distinct().ToArray().Where(line => !line.Contains("		|")));

        }
        private void verificarLineasRepetidas1()
        {
            string[] lines1 = File.ReadAllLines(@"ListaMODELO.txt");
            File.WriteAllLines(@"ListaMODELO.txt", lines1.Distinct().ToArray().Where(line => !line.Contains("		|")));

        }
        private void verificarLineasRepetidas2()
        {
            string[] lines1 = File.ReadAllLines(@"ListaCOLORES.txt");
            File.WriteAllLines(@"ListaCOLORES.txt", lines1.Distinct().ToArray().Where(line => !line.Contains("		|")));

        }

        string Archivo = File.ReadAllText(@"ListaMARCA.txt");
        string Archivo1 = File.ReadAllText(@"ListaMODELO.txt");
        string Archivo2 = File.ReadAllText(@"ListaCOLORES.txt");
        private void botonGuardarNuevoAuto_Click(object sender, EventArgs e)
        {
            

            if (Archivo.Contains(MarcaAutomovil.Text)&&Archivo1.Contains(ModeloAutomovil.Text)&&Archivo2.Contains(ColorAutomovil.Text))
            {
                MessageBox.Show("Este Auto ya ha sido registrado en el sistema");
            }
            else
            {
                AgregarAutoNuevo datosAutomovil = new AgregarAutoNuevo();
                if (MarcaAutomovil.Text=="" && ModeloAutomovil.Text=="")
                {
                    datosAutomovil.colorAuto = ColorAutomovil.Text;
                    datosAutomovil.marcaAuto = "";
                    datosAutomovil.modeloAuto = "";
                    datosVehiculos.Add(datosAutomovil);
                    visualizar();
                    GuardarenArchivoMARCA();
                    GuardarenArchivoMODELO();
                    GuardarenArchivoCOLOR();
                }
                else if(ModeloAutomovil.Text=="" && ColorAutomovil.Text=="")
                {
                    datosAutomovil.marcaAuto = MarcaAutomovil.Text;
                    datosAutomovil.modeloAuto = "";
                    datosAutomovil.colorAuto = "";
                    datosVehiculos.Add(datosAutomovil);
                    visualizar();
                    GuardarenArchivoMARCA();
                    GuardarenArchivoMODELO();
                    GuardarenArchivoCOLOR();
                }
                else if(MarcaAutomovil.Text=="" && ColorAutomovil.Text=="")
                {
                    datosAutomovil.modeloAuto = ModeloAutomovil.Text;
                    datosAutomovil.marcaAuto = "";
                    datosAutomovil.colorAuto = "";
                    datosVehiculos.Add(datosAutomovil);
                    visualizar();
                    GuardarenArchivoMARCA();
                    GuardarenArchivoMODELO();
                    GuardarenArchivoCOLOR();
                }
                else
                {
                    datosAutomovil.marcaAuto = MarcaAutomovil.Text;
                    datosAutomovil.modeloAuto = ModeloAutomovil.Text;
                    datosAutomovil.colorAuto = ColorAutomovil.Text;
                    datosVehiculos.Add(datosAutomovil);
                    visualizar();
                    GuardarenArchivoMARCA();
                    GuardarenArchivoMODELO();
                    GuardarenArchivoCOLOR();
                }
                
             
            }
            limpiarTexto();
            #region VerificarLineasRepetidas
            verificarLineasRepetidas();
            verificarLineasRepetidas1();
            verificarLineasRepetidas2();
            #endregion


        }
        private void GuardarenArchivoMARCA()
        {
            TextWriter writer = new StreamWriter(@"ListaMARCA.txt",true);
            for (int i = 0; i < informacionAutos.Rows.Count; i++)
            {
                for (int j = 0; j <1; j++)
                {
                    writer.Write("\t" + informacionAutos.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
        }

        private void GuardarenArchivoMODELO()
        {
            TextWriter writer = new StreamWriter(@"ListaMODELO.txt",true);
            for (int i = 0; i < informacionAutos.Rows.Count; i++)
            {
                for (int j = 1; j < 2; j++)
                {
                    writer.Write("\t" + informacionAutos.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
        }

        private void GuardarenArchivoCOLOR()
        {
            TextWriter writer = new StreamWriter(@"ListaCOLORES.txt",true);
            for (int i = 0; i < informacionAutos.Rows.Count; i++)
            {
                for (int j = 2; j < 3; j++)
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

        private void IngresarColorModelo_Load(object sender, EventArgs e)
        {
            #region VerificarLineasRepetidas
            verificarLineasRepetidas();
            verificarLineasRepetidas1();
            verificarLineasRepetidas2();
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresoAutomovil formAutomoviles = new IngresoAutomovil();
            formAutomoviles.Closed += (s, args) => this.Close();
            formAutomoviles.ShowDialog();
        }
    }
}
