namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.table = new System.Windows.Forms.TabControl();
            this.tablero = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.bucle = new System.Windows.Forms.Timer(this.components);
            this.gasolina = new System.Windows.Forms.Timer(this.components);
            this.point = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.table.SuspendLayout();
            this.tablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.Controls.Add(this.tablero);
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.SelectedIndex = 0;
            this.table.Size = new System.Drawing.Size(1061, 425);
            this.table.TabIndex = 0;
            this.table.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Table_KeyDown);
            // 
            // tablero
            // 
            this.tablero.Controls.Add(this.label3);
            this.tablero.Location = new System.Drawing.Point(4, 25);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(1053, 396);
            this.tablero.TabIndex = 0;
            this.tablero.Click += new System.EventHandler(this.Tablero_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "GASOLINA";
            // 
            // bucle
            // 
            this.bucle.Enabled = true;
            this.bucle.Interval = 30;
            this.bucle.Tick += new System.EventHandler(this.Bucle_Tick);
            // 
            // gasolina
            // 
            this.gasolina.Interval = 500;
            this.gasolina.Tick += new System.EventHandler(this.Gasolina_Tick);
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(222, 454);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(41, 44);
            this.point.TabIndex = 1;
            this.point.Text = "0";
            this.point.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(14, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "PUNTAJE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.point);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.table.ResumeLayout(false);
            this.tablero.ResumeLayout(false);
            this.tablero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl table;
        private System.Windows.Forms.TabPage tablero;
        private System.Windows.Forms.Timer bucle;
        private System.Windows.Forms.Timer gasolina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Label label2;
    }
}

