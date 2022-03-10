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
            this.BotonListaEmpleados = new System.Windows.Forms.Button();
            this.informacionEmpleado = new System.Windows.Forms.DataGridView();
            this.botonGuardarEmpleado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MarcaAutomovil = new System.Windows.Forms.ComboBox();
            this.DireccionCliente = new System.Windows.Forms.TextBox();
            this.nombreCompletoCliente = new System.Windows.Forms.TextBox();
            this.NITcliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlacaAutomovil = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.informacionEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonListaEmpleados
            // 
            this.BotonListaEmpleados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonListaEmpleados.Location = new System.Drawing.Point(210, 551);
            this.BotonListaEmpleados.Name = "BotonListaEmpleados";
            this.BotonListaEmpleados.Size = new System.Drawing.Size(104, 39);
            this.BotonListaEmpleados.TabIndex = 33;
            this.BotonListaEmpleados.Text = "Lista Empleados";
            this.BotonListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // informacionEmpleado
            // 
            this.informacionEmpleado.BackgroundColor = System.Drawing.Color.LightGray;
            this.informacionEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacionEmpleado.Location = new System.Drawing.Point(94, 326);
            this.informacionEmpleado.Name = "informacionEmpleado";
            this.informacionEmpleado.Size = new System.Drawing.Size(347, 165);
            this.informacionEmpleado.TabIndex = 31;
            // 
            // botonGuardarEmpleado
            // 
            this.botonGuardarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardarEmpleado.Location = new System.Drawing.Point(210, 506);
            this.botonGuardarEmpleado.Name = "botonGuardarEmpleado";
            this.botonGuardarEmpleado.Size = new System.Drawing.Size(104, 39);
            this.botonGuardarEmpleado.TabIndex = 29;
            this.botonGuardarEmpleado.Text = "GUARDAR";
            this.botonGuardarEmpleado.UseVisualStyleBackColor = true;
            this.botonGuardarEmpleado.Click += new System.EventHandler(this.botonGuardarEmpleado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 28;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "NIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ingreso Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(111, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Auto Venta La bendición";
            // 
            // MarcaAutomovil
            // 
            this.MarcaAutomovil.BackColor = System.Drawing.Color.White;
            this.MarcaAutomovil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaAutomovil.FormattingEnabled = true;
            this.MarcaAutomovil.Items.AddRange(new object[] {
            "Audi",
            "Acura",
            "BMW",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Dodge",
            "Fiat",
            "Ford",
            "GMD",
            "Genesis",
            "Honda",
            "Hyundai",
            "Inifniti",
            "Jaguar",
            "Jeep",
            "Kia",
            "Land Rover",
            "Lexus",
            "Lincoln",
            "Mazda",
            "Mercedes Benz",
            "Mini",
            "Mitsubishi",
            "Nissan",
            "Pontiac",
            "Porsche",
            "Ford",
            "Saab",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.MarcaAutomovil.Location = new System.Drawing.Point(210, 241);
            this.MarcaAutomovil.Name = "MarcaAutomovil";
            this.MarcaAutomovil.Size = new System.Drawing.Size(129, 21);
            this.MarcaAutomovil.TabIndex = 40;
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.Location = new System.Drawing.Point(210, 187);
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.Size = new System.Drawing.Size(231, 20);
            this.DireccionCliente.TabIndex = 38;
            // 
            // nombreCompletoCliente
            // 
            this.nombreCompletoCliente.Location = new System.Drawing.Point(210, 161);
            this.nombreCompletoCliente.Name = "nombreCompletoCliente";
            this.nombreCompletoCliente.Size = new System.Drawing.Size(231, 20);
            this.nombreCompletoCliente.TabIndex = 37;
            // 
            // NITcliente
            // 
            this.NITcliente.Location = new System.Drawing.Point(210, 135);
            this.NITcliente.Name = "NITcliente";
            this.NITcliente.Size = new System.Drawing.Size(129, 20);
            this.NITcliente.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 41;
            this.label5.Text = "Placa";
            // 
            // PlacaAutomovil
            // 
            this.PlacaAutomovil.Location = new System.Drawing.Point(210, 212);
            this.PlacaAutomovil.Name = "PlacaAutomovil";
            this.PlacaAutomovil.Size = new System.Drawing.Size(129, 20);
            this.PlacaAutomovil.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 43;
            this.label7.Text = "Marca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 612);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlacaAutomovil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MarcaAutomovil);
            this.Controls.Add(this.DireccionCliente);
            this.Controls.Add(this.nombreCompletoCliente);
            this.Controls.Add(this.NITcliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonListaEmpleados);
            this.Controls.Add(this.informacionEmpleado);
            this.Controls.Add(this.botonGuardarEmpleado);
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
            ((System.ComponentModel.ISupportInitialize)(this.informacionEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonListaEmpleados;
        private System.Windows.Forms.DataGridView informacionEmpleado;
        private System.Windows.Forms.Button botonGuardarEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MarcaAutomovil;
        private System.Windows.Forms.TextBox DireccionCliente;
        private System.Windows.Forms.TextBox nombreCompletoCliente;
        private System.Windows.Forms.TextBox NITcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlacaAutomovil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}

