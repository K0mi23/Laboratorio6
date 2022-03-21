namespace Laboratorio6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.informacionCliente = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DireccionCliente = new System.Windows.Forms.TextBox();
            this.nombreCompletoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonGuardarClientes = new System.Windows.Forms.Button();
            this.fechaAlquilerVehiculo = new System.Windows.Forms.DateTimePicker();
            this.fechaDevolucionVehiculo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NITcliente = new System.Windows.Forms.TextBox();
            this.formAutomovil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.MarcaAutomovil = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PlacaAutomoviles = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informacionCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // informacionCliente
            // 
            this.informacionCliente.BackgroundColor = System.Drawing.Color.Silver;
            this.informacionCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacionCliente.Location = new System.Drawing.Point(41, 321);
            this.informacionCliente.Name = "informacionCliente";
            this.informacionCliente.Size = new System.Drawing.Size(442, 165);
            this.informacionCliente.TabIndex = 31;
            this.informacionCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.informacionCliente_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 28;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "NIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(98, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Auto Venta La bendición";
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.Location = new System.Drawing.Point(187, 146);
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.Size = new System.Drawing.Size(227, 20);
            this.DireccionCliente.TabIndex = 38;
            // 
            // nombreCompletoCliente
            // 
            this.nombreCompletoCliente.Location = new System.Drawing.Point(187, 120);
            this.nombreCompletoCliente.Name = "nombreCompletoCliente";
            this.nombreCompletoCliente.Size = new System.Drawing.Size(227, 20);
            this.nombreCompletoCliente.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(143, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ingreso Clientes";
            // 
            // botonGuardarClientes
            // 
            this.botonGuardarClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardarClientes.Location = new System.Drawing.Point(187, 279);
            this.botonGuardarClientes.Name = "botonGuardarClientes";
            this.botonGuardarClientes.Size = new System.Drawing.Size(129, 29);
            this.botonGuardarClientes.TabIndex = 40;
            this.botonGuardarClientes.Text = "GUARDAR";
            this.botonGuardarClientes.UseVisualStyleBackColor = true;
            this.botonGuardarClientes.Click += new System.EventHandler(this.botonGuardarClientes_Click);
            // 
            // fechaAlquilerVehiculo
            // 
            this.fechaAlquilerVehiculo.Location = new System.Drawing.Point(187, 227);
            this.fechaAlquilerVehiculo.Name = "fechaAlquilerVehiculo";
            this.fechaAlquilerVehiculo.Size = new System.Drawing.Size(227, 20);
            this.fechaAlquilerVehiculo.TabIndex = 41;
            // 
            // fechaDevolucionVehiculo
            // 
            this.fechaDevolucionVehiculo.Location = new System.Drawing.Point(187, 253);
            this.fechaDevolucionVehiculo.Name = "fechaDevolucionVehiculo";
            this.fechaDevolucionVehiculo.Size = new System.Drawing.Size(227, 20);
            this.fechaDevolucionVehiculo.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 43;
            this.label5.Text = "Alquiler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 14);
            this.label7.TabIndex = 44;
            this.label7.Text = "Devolución";
            // 
            // NITcliente
            // 
            this.NITcliente.Location = new System.Drawing.Point(187, 94);
            this.NITcliente.MaxLength = 9;
            this.NITcliente.Name = "NITcliente";
            this.NITcliente.Size = new System.Drawing.Size(129, 20);
            this.NITcliente.TabIndex = 36;
            // 
            // formAutomovil
            // 
            this.formAutomovil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formAutomovil.Location = new System.Drawing.Point(41, 492);
            this.formAutomovil.Name = "formAutomovil";
            this.formAutomovil.Size = new System.Drawing.Size(129, 29);
            this.formAutomovil.TabIndex = 45;
            this.formAutomovil.Text = "Automoviles";
            this.formAutomovil.UseVisualStyleBackColor = true;
            this.formAutomovil.Click += new System.EventHandler(this.formAutomovil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(138, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 14);
            this.label10.TabIndex = 63;
            this.label10.Text = "Marca";
            // 
            // MarcaAutomovil
            // 
            this.MarcaAutomovil.BackColor = System.Drawing.Color.White;
            this.MarcaAutomovil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaAutomovil.FormattingEnabled = true;
            this.MarcaAutomovil.Location = new System.Drawing.Point(187, 200);
            this.MarcaAutomovil.Name = "MarcaAutomovil";
            this.MarcaAutomovil.Size = new System.Drawing.Size(129, 21);
            this.MarcaAutomovil.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 14);
            this.label11.TabIndex = 68;
            this.label11.Text = "Placa";
            // 
            // PlacaAutomoviles
            // 
            this.PlacaAutomoviles.BackColor = System.Drawing.Color.White;
            this.PlacaAutomoviles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlacaAutomoviles.FormattingEnabled = true;
            this.PlacaAutomoviles.Location = new System.Drawing.Point(187, 173);
            this.PlacaAutomoviles.Name = "PlacaAutomoviles";
            this.PlacaAutomoviles.Size = new System.Drawing.Size(129, 21);
            this.PlacaAutomoviles.TabIndex = 70;
            this.PlacaAutomoviles.SelectedIndexChanged += new System.EventHandler(this.PlacaAutomoviles_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(176, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 71;
            this.button1.Text = "Listado Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlacaAutomoviles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MarcaAutomovil);
            this.Controls.Add(this.formAutomovil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaDevolucionVehiculo);
            this.Controls.Add(this.fechaAlquilerVehiculo);
            this.Controls.Add(this.botonGuardarClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DireccionCliente);
            this.Controls.Add(this.nombreCompletoCliente);
            this.Controls.Add(this.NITcliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.informacionCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informacionCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView informacionCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DireccionCliente;
        private System.Windows.Forms.TextBox nombreCompletoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonGuardarClientes;
        private System.Windows.Forms.DateTimePicker fechaAlquilerVehiculo;
        private System.Windows.Forms.DateTimePicker fechaDevolucionVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NITcliente;
        private System.Windows.Forms.Button formAutomovil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox MarcaAutomovil;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox PlacaAutomoviles;
        private System.Windows.Forms.Button button1;
    }
}

