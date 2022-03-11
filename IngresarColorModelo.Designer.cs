namespace Laboratorio6
{
    partial class IngresarColorModelo
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
            this.label6 = new System.Windows.Forms.Label();
            this.ModeloAutomovil = new System.Windows.Forms.TextBox();
            this.MarcaAutomovil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorAutomovil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.informacionAutos = new System.Windows.Forms.DataGridView();
            this.botonGuardarNuevoAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informacionAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(51, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 32);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ingreso nuevo Modelo y Color";
            // 
            // ModeloAutomovil
            // 
            this.ModeloAutomovil.Location = new System.Drawing.Point(201, 185);
            this.ModeloAutomovil.MaxLength = 4;
            this.ModeloAutomovil.Name = "ModeloAutomovil";
            this.ModeloAutomovil.Size = new System.Drawing.Size(129, 20);
            this.ModeloAutomovil.TabIndex = 41;
            // 
            // MarcaAutomovil
            // 
            this.MarcaAutomovil.Location = new System.Drawing.Point(201, 159);
            this.MarcaAutomovil.MaxLength = 9;
            this.MarcaAutomovil.Name = "MarcaAutomovil";
            this.MarcaAutomovil.Size = new System.Drawing.Size(129, 20);
            this.MarcaAutomovil.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "Marca";
            // 
            // ColorAutomovil
            // 
            this.ColorAutomovil.Location = new System.Drawing.Point(201, 211);
            this.ColorAutomovil.Name = "ColorAutomovil";
            this.ColorAutomovil.Size = new System.Drawing.Size(129, 20);
            this.ColorAutomovil.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 42;
            this.label1.Text = "Color";
            // 
            // informacionAutos
            // 
            this.informacionAutos.BackgroundColor = System.Drawing.Color.Silver;
            this.informacionAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacionAutos.Location = new System.Drawing.Point(93, 309);
            this.informacionAutos.Name = "informacionAutos";
            this.informacionAutos.Size = new System.Drawing.Size(331, 165);
            this.informacionAutos.TabIndex = 58;
            // 
            // botonGuardarNuevoAuto
            // 
            this.botonGuardarNuevoAuto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardarNuevoAuto.Location = new System.Drawing.Point(201, 237);
            this.botonGuardarNuevoAuto.Name = "botonGuardarNuevoAuto";
            this.botonGuardarNuevoAuto.Size = new System.Drawing.Size(129, 39);
            this.botonGuardarNuevoAuto.TabIndex = 59;
            this.botonGuardarNuevoAuto.Text = "GUARDAR";
            this.botonGuardarNuevoAuto.UseVisualStyleBackColor = true;
            this.botonGuardarNuevoAuto.Click += new System.EventHandler(this.botonGuardarNuevoAuto_Click);
            // 
            // IngresarColorModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(523, 534);
            this.Controls.Add(this.botonGuardarNuevoAuto);
            this.Controls.Add(this.informacionAutos);
            this.Controls.Add(this.ColorAutomovil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModeloAutomovil);
            this.Controls.Add(this.MarcaAutomovil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IngresarColorModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarColorModelo";
            this.Load += new System.EventHandler(this.IngresarColorModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informacionAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ModeloAutomovil;
        private System.Windows.Forms.TextBox MarcaAutomovil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ColorAutomovil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView informacionAutos;
        private System.Windows.Forms.Button botonGuardarNuevoAuto;
    }
}