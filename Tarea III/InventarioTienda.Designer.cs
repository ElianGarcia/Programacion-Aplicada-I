namespace Tarea_III.Tarea_III
{
    partial class InventarioTienda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbGastos = new System.Windows.Forms.TextBox();
            this.tbImpuesto = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Vendida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gastos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Impuestos:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(124, 18);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(109, 20);
            this.tbCantidad.TabIndex = 4;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(124, 40);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(109, 20);
            this.tbPrecio.TabIndex = 5;
            // 
            // tbGastos
            // 
            this.tbGastos.Location = new System.Drawing.Point(124, 63);
            this.tbGastos.Name = "tbGastos";
            this.tbGastos.Size = new System.Drawing.Size(109, 20);
            this.tbGastos.TabIndex = 6;
            // 
            // tbImpuesto
            // 
            this.tbImpuesto.Location = new System.Drawing.Point(124, 85);
            this.tbImpuesto.Name = "tbImpuesto";
            this.tbImpuesto.Size = new System.Drawing.Size(109, 20);
            this.tbImpuesto.TabIndex = 7;
            // 
            // btGuardar
            // 
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Location = new System.Drawing.Point(16, 114);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(217, 23);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // InventarioTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 149);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbImpuesto);
            this.Controls.Add(this.tbGastos);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InventarioTienda";
            this.Text = "InventarioTienda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbGastos;
        private System.Windows.Forms.TextBox tbImpuesto;
        private System.Windows.Forms.Button btGuardar;
    }
}