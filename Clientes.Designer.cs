namespace Laboratorio6
{
    partial class Clientes
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DireccionCliente = new System.Windows.Forms.TextBox();
            this.nombreCompletoCliente = new System.Windows.Forms.TextBox();
            this.NITcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlacaAutomovil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.marcaAutomovil = new System.Windows.Forms.TextBox();
            this.modeloAutomovil = new System.Windows.Forms.TextBox();
            this.colorAutomovil = new System.Windows.Forms.TextBox();
            this.precioxKm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.KmRecorridos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.calcularTOTAL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 27);
            this.button2.TabIndex = 65;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(555, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 408);
            this.dataGridView1.TabIndex = 66;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(537, 408);
            this.dataGridView2.TabIndex = 67;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.Enabled = false;
            this.DireccionCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionCliente.Location = new System.Drawing.Point(125, 68);
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.Size = new System.Drawing.Size(227, 20);
            this.DireccionCliente.TabIndex = 73;
            // 
            // nombreCompletoCliente
            // 
            this.nombreCompletoCliente.Enabled = false;
            this.nombreCompletoCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCompletoCliente.Location = new System.Drawing.Point(125, 42);
            this.nombreCompletoCliente.Name = "nombreCompletoCliente";
            this.nombreCompletoCliente.Size = new System.Drawing.Size(227, 20);
            this.nombreCompletoCliente.TabIndex = 72;
            // 
            // NITcliente
            // 
            this.NITcliente.Enabled = false;
            this.NITcliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NITcliente.Location = new System.Drawing.Point(125, 16);
            this.NITcliente.MaxLength = 9;
            this.NITcliente.Name = "NITcliente";
            this.NITcliente.Size = new System.Drawing.Size(227, 20);
            this.NITcliente.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 70;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 14);
            this.label3.TabIndex = 69;
            this.label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 68;
            this.label2.Text = "NIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 80;
            this.label1.Text = "Modelo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 78;
            this.label8.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 77;
            this.label7.Text = "Marca";
            // 
            // PlacaAutomovil
            // 
            this.PlacaAutomovil.Enabled = false;
            this.PlacaAutomovil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacaAutomovil.Location = new System.Drawing.Point(427, 16);
            this.PlacaAutomovil.MaxLength = 7;
            this.PlacaAutomovil.Name = "PlacaAutomovil";
            this.PlacaAutomovil.Size = new System.Drawing.Size(249, 20);
            this.PlacaAutomovil.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 75;
            this.label5.Text = "Placa";
            // 
            // marcaAutomovil
            // 
            this.marcaAutomovil.Enabled = false;
            this.marcaAutomovil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaAutomovil.Location = new System.Drawing.Point(427, 45);
            this.marcaAutomovil.Name = "marcaAutomovil";
            this.marcaAutomovil.Size = new System.Drawing.Size(249, 20);
            this.marcaAutomovil.TabIndex = 81;
            // 
            // modeloAutomovil
            // 
            this.modeloAutomovil.Enabled = false;
            this.modeloAutomovil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloAutomovil.Location = new System.Drawing.Point(427, 72);
            this.modeloAutomovil.Name = "modeloAutomovil";
            this.modeloAutomovil.Size = new System.Drawing.Size(249, 20);
            this.modeloAutomovil.TabIndex = 82;
            // 
            // colorAutomovil
            // 
            this.colorAutomovil.Enabled = false;
            this.colorAutomovil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorAutomovil.Location = new System.Drawing.Point(427, 98);
            this.colorAutomovil.Name = "colorAutomovil";
            this.colorAutomovil.Size = new System.Drawing.Size(249, 20);
            this.colorAutomovil.TabIndex = 83;
            // 
            // precioxKm
            // 
            this.precioxKm.Enabled = false;
            this.precioxKm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioxKm.Location = new System.Drawing.Point(832, 13);
            this.precioxKm.Name = "precioxKm";
            this.precioxKm.Size = new System.Drawing.Size(170, 20);
            this.precioxKm.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(750, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 84;
            this.label6.Text = "Precio x Km";
            // 
            // TOTAL
            // 
            this.TOTAL.Enabled = false;
            this.TOTAL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(832, 89);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(170, 25);
            this.TOTAL.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(722, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 32);
            this.label9.TabIndex = 86;
            this.label9.Text = "TOTAL";
            // 
            // KmRecorridos
            // 
            this.KmRecorridos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KmRecorridos.Location = new System.Drawing.Point(832, 42);
            this.KmRecorridos.Name = "KmRecorridos";
            this.KmRecorridos.Size = new System.Drawing.Size(170, 20);
            this.KmRecorridos.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(692, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 14);
            this.label10.TabIndex = 88;
            this.label10.Text = "Kilometros recorridos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(370, 13);
            this.label11.TabIndex = 90;
            this.label11.Text = "Seleccione el Indice para saber el salario de cada empleado y su información";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 24);
            this.label12.TabIndex = 91;
            this.label12.Text = "🢃";
            // 
            // calcularTOTAL
            // 
            this.calcularTOTAL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularTOTAL.Location = new System.Drawing.Point(872, 120);
            this.calcularTOTAL.Name = "calcularTOTAL";
            this.calcularTOTAL.Size = new System.Drawing.Size(91, 27);
            this.calcularTOTAL.TabIndex = 92;
            this.calcularTOTAL.Text = "Calcular";
            this.calcularTOTAL.UseVisualStyleBackColor = true;
            this.calcularTOTAL.Click += new System.EventHandler(this.calcularTOTAL_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1162, 654);
            this.Controls.Add(this.calcularTOTAL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.KmRecorridos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.precioxKm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorAutomovil);
            this.Controls.Add(this.modeloAutomovil);
            this.Controls.Add(this.marcaAutomovil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlacaAutomovil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DireccionCliente);
            this.Controls.Add(this.nombreCompletoCliente);
            this.Controls.Add(this.NITcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox DireccionCliente;
        private System.Windows.Forms.TextBox nombreCompletoCliente;
        private System.Windows.Forms.TextBox NITcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PlacaAutomovil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox marcaAutomovil;
        private System.Windows.Forms.TextBox modeloAutomovil;
        private System.Windows.Forms.TextBox colorAutomovil;
        private System.Windows.Forms.TextBox precioxKm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TOTAL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox KmRecorridos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button calcularTOTAL;
    }
}