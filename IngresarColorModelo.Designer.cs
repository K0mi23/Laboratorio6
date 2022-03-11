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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.informacionAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(63, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 32);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ingreso nuevo Modelo y Color";
            // 
            // ModeloAutomovil
            // 
            this.ModeloAutomovil.Location = new System.Drawing.Point(188, 143);
            this.ModeloAutomovil.MaxLength = 4;
            this.ModeloAutomovil.Name = "ModeloAutomovil";
            this.ModeloAutomovil.Size = new System.Drawing.Size(129, 20);
            this.ModeloAutomovil.TabIndex = 41;
            // 
            // MarcaAutomovil
            // 
            this.MarcaAutomovil.Location = new System.Drawing.Point(188, 117);
            this.MarcaAutomovil.MaxLength = 20;
            this.MarcaAutomovil.Name = "MarcaAutomovil";
            this.MarcaAutomovil.Size = new System.Drawing.Size(129, 20);
            this.MarcaAutomovil.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "Marca";
            // 
            // ColorAutomovil
            // 
            this.ColorAutomovil.Location = new System.Drawing.Point(188, 169);
            this.ColorAutomovil.Name = "ColorAutomovil";
            this.ColorAutomovil.Size = new System.Drawing.Size(129, 20);
            this.ColorAutomovil.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 42;
            this.label1.Text = "Color";
            // 
            // informacionAutos
            // 
            this.informacionAutos.BackgroundColor = System.Drawing.Color.Silver;
            this.informacionAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacionAutos.Location = new System.Drawing.Point(86, 284);
            this.informacionAutos.Name = "informacionAutos";
            this.informacionAutos.Size = new System.Drawing.Size(331, 165);
            this.informacionAutos.TabIndex = 58;
            // 
            // botonGuardarNuevoAuto
            // 
            this.botonGuardarNuevoAuto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardarNuevoAuto.Location = new System.Drawing.Point(188, 195);
            this.botonGuardarNuevoAuto.Name = "botonGuardarNuevoAuto";
            this.botonGuardarNuevoAuto.Size = new System.Drawing.Size(129, 39);
            this.botonGuardarNuevoAuto.TabIndex = 59;
            this.botonGuardarNuevoAuto.Text = "GUARDAR";
            this.botonGuardarNuevoAuto.UseVisualStyleBackColor = true;
            this.botonGuardarNuevoAuto.Click += new System.EventHandler(this.botonGuardarNuevoAuto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 14);
            this.label4.TabIndex = 60;
            this.label4.Text = "Si solo desea agregar  Color deje las otras ventanas de texto vacias";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 61;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IngresarColorModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(523, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}