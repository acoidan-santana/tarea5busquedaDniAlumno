namespace Biblioteca.Vista
{
    partial class Buscar
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
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApe1 = new System.Windows.Forms.TextBox();
            this.textBoxApe2 = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApe1 = new System.Windows.Forms.Label();
            this.labelApe2 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelDni = new System.Windows.Forms.Label();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(85, 169);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(106, 20);
            this.textBoxDni.TabIndex = 0;
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBoxDni_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(527, 107);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxApe1
            // 
            this.textBoxApe1.Location = new System.Drawing.Point(527, 156);
            this.textBoxApe1.Name = "textBoxApe1";
            this.textBoxApe1.Size = new System.Drawing.Size(100, 20);
            this.textBoxApe1.TabIndex = 2;
            this.textBoxApe1.TextChanged += new System.EventHandler(this.textBoxApe1_TextChanged);
            // 
            // textBoxApe2
            // 
            this.textBoxApe2.Location = new System.Drawing.Point(527, 205);
            this.textBoxApe2.Name = "textBoxApe2";
            this.textBoxApe2.Size = new System.Drawing.Size(100, 20);
            this.textBoxApe2.TabIndex = 3;
            this.textBoxApe2.TextChanged += new System.EventHandler(this.textBoxApe2_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(426, 107);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApe1
            // 
            this.labelApe1.AutoSize = true;
            this.labelApe1.Location = new System.Drawing.Point(426, 159);
            this.labelApe1.Name = "labelApe1";
            this.labelApe1.Size = new System.Drawing.Size(62, 13);
            this.labelApe1.TabIndex = 6;
            this.labelApe1.Text = "1er Apellido";
            // 
            // labelApe2
            // 
            this.labelApe2.AutoSize = true;
            this.labelApe2.Location = new System.Drawing.Point(429, 211);
            this.labelApe2.Name = "labelApe2";
            this.labelApe2.Size = new System.Drawing.Size(65, 13);
            this.labelApe2.TabIndex = 7;
            this.labelApe2.Text = "2do Apellido";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(225, 166);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(527, 295);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 23);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(12, 172);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(67, 13);
            this.labelDni.TabIndex = 10;
            this.labelDni.Text = "Dni a buscar";
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(88, 369);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(103, 23);
            this.buttonAnterior.TabIndex = 11;
            this.buttonAnterior.Text = "Ventana anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(540, 369);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 12;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 404);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelApe2);
            this.Controls.Add(this.labelApe1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxApe2);
            this.Controls.Add(this.textBoxApe1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDni);
            this.Name = "Buscar";
            this.Text = "Datos del Alumno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Buscar_FormClosing);
            this.Load += new System.EventHandler(this.Buscar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApe1;
        private System.Windows.Forms.TextBox textBoxApe2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApe1;
        private System.Windows.Forms.Label labelApe2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonSalir;
    }
}