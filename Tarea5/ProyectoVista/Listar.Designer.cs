using System.Windows.Forms;

namespace Biblioteca.Vista
{
    partial class Listar
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
            this.dataGridAlumno = new System.Windows.Forms.DataGridView();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAlumno
            // 
            this.dataGridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumno.Location = new System.Drawing.Point(67, 40);
            this.dataGridAlumno.Name = "dataGridAlumno";
            this.dataGridAlumno.Size = new System.Drawing.Size(560, 419);
            this.dataGridAlumno.TabIndex = 0;
            this.dataGridAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAlumno_CellContentClick);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(67, 480);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(102, 23);
            this.buttonAnterior.TabIndex = 1;
            this.buttonAnterior.Text = "Ventana anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(552, 480);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 515);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.dataGridAlumno);
            this.Name = "Listar";
            this.Text = "Listar todos los Alumnos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Listar_FormClosing);
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAlumno;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonSalir;
    }
}