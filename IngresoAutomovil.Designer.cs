﻿namespace Laboratorio6
{
    partial class IngresoAutomovil
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
            this.label9 = new System.Windows.Forms.Label();
            this.precioxKilometro = new System.Windows.Forms.NumericUpDown();
            this.colorAutomovil = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlacaAutomovil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MarcaAutomovil = new System.Windows.Forms.ComboBox();
            this.informacionEmpleado = new System.Windows.Forms.DataGridView();
            this.BotonListaEmpleados = new System.Windows.Forms.Button();
            this.botonGuardarEmpleado = new System.Windows.Forms.Button();
            this.modeloAutomovil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.precioxKilometro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(115, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 32);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ingreso Automóviles";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 14);
            this.label9.TabIndex = 56;
            this.label9.Text = "Precio x Kilómetro";
            // 
            // precioxKilometro
            // 
            this.precioxKilometro.Location = new System.Drawing.Point(215, 186);
            this.precioxKilometro.Name = "precioxKilometro";
            this.precioxKilometro.Size = new System.Drawing.Size(129, 20);
            this.precioxKilometro.TabIndex = 55;
            // 
            // colorAutomovil
            // 
            this.colorAutomovil.BackColor = System.Drawing.Color.White;
            this.colorAutomovil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorAutomovil.FormattingEnabled = true;
            this.colorAutomovil.Items.AddRange(new object[] {
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
            this.colorAutomovil.Location = new System.Drawing.Point(215, 158);
            this.colorAutomovil.Name = "colorAutomovil";
            this.colorAutomovil.Size = new System.Drawing.Size(129, 21);
            this.colorAutomovil.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 53;
            this.label8.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 52;
            this.label7.Text = "Marca";
            // 
            // PlacaAutomovil
            // 
            this.PlacaAutomovil.Location = new System.Drawing.Point(215, 77);
            this.PlacaAutomovil.Name = "PlacaAutomovil";
            this.PlacaAutomovil.Size = new System.Drawing.Size(129, 20);
            this.PlacaAutomovil.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 50;
            this.label5.Text = "Placa";
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
            this.MarcaAutomovil.Location = new System.Drawing.Point(215, 106);
            this.MarcaAutomovil.Name = "MarcaAutomovil";
            this.MarcaAutomovil.Size = new System.Drawing.Size(129, 21);
            this.MarcaAutomovil.TabIndex = 49;
            // 
            // informacionEmpleado
            // 
            this.informacionEmpleado.BackgroundColor = System.Drawing.Color.Silver;
            this.informacionEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacionEmpleado.Location = new System.Drawing.Point(99, 266);
            this.informacionEmpleado.Name = "informacionEmpleado";
            this.informacionEmpleado.Size = new System.Drawing.Size(347, 165);
            this.informacionEmpleado.TabIndex = 57;
            // 
            // BotonListaEmpleados
            // 
            this.BotonListaEmpleados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonListaEmpleados.Location = new System.Drawing.Point(99, 439);
            this.BotonListaEmpleados.Name = "BotonListaEmpleados";
            this.BotonListaEmpleados.Size = new System.Drawing.Size(154, 39);
            this.BotonListaEmpleados.TabIndex = 59;
            this.BotonListaEmpleados.Text = "Lista Vehiculos";
            this.BotonListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // botonGuardarEmpleado
            // 
            this.botonGuardarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardarEmpleado.Location = new System.Drawing.Point(215, 212);
            this.botonGuardarEmpleado.Name = "botonGuardarEmpleado";
            this.botonGuardarEmpleado.Size = new System.Drawing.Size(129, 39);
            this.botonGuardarEmpleado.TabIndex = 58;
            this.botonGuardarEmpleado.Text = "GUARDAR";
            this.botonGuardarEmpleado.UseVisualStyleBackColor = true;
            this.botonGuardarEmpleado.Click += new System.EventHandler(this.botonGuardarEmpleado_Click);
            // 
            // modeloAutomovil
            // 
            this.modeloAutomovil.Location = new System.Drawing.Point(215, 132);
            this.modeloAutomovil.Name = "modeloAutomovil";
            this.modeloAutomovil.Size = new System.Drawing.Size(129, 20);
            this.modeloAutomovil.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 60;
            this.label1.Text = "Modelo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 39);
            this.button1.TabIndex = 62;
            this.button1.Text = "Ingresar nuevo Modelo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IngresoAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(523, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modeloAutomovil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonListaEmpleados);
            this.Controls.Add(this.botonGuardarEmpleado);
            this.Controls.Add(this.informacionEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.precioxKilometro);
            this.Controls.Add(this.colorAutomovil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlacaAutomovil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MarcaAutomovil);
            this.Controls.Add(this.label6);
            this.Name = "IngresoAutomovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresoAutomovil";
            ((System.ComponentModel.ISupportInitialize)(this.precioxKilometro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown precioxKilometro;
        private System.Windows.Forms.ComboBox colorAutomovil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PlacaAutomovil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MarcaAutomovil;
        private System.Windows.Forms.DataGridView informacionEmpleado;
        private System.Windows.Forms.Button BotonListaEmpleados;
        private System.Windows.Forms.Button botonGuardarEmpleado;
        private System.Windows.Forms.TextBox modeloAutomovil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}