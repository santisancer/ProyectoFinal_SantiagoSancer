
namespace AplicacionCabañas_SantiagoSancer
{
    partial class ventanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonIngresar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.nombreInicio = new System.Windows.Forms.Label();
            this.boxHuesped = new System.Windows.Forms.CheckBox();
            this.boxAdministrador = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(284, 420);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(112, 34);
            this.botonIngresar.TabIndex = 0;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(63, 420);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(112, 34);
            this.botonSalir.TabIndex = 1;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // nombreInicio
            // 
            this.nombreInicio.AutoSize = true;
            this.nombreInicio.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreInicio.Location = new System.Drawing.Point(112, 64);
            this.nombreInicio.Name = "nombreInicio";
            this.nombreInicio.Size = new System.Drawing.Size(249, 40);
            this.nombreInicio.TabIndex = 2;
            this.nombreInicio.Text = "Iniciar Sesion";
            this.nombreInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxHuesped
            // 
            this.boxHuesped.AutoSize = true;
            this.boxHuesped.Location = new System.Drawing.Point(112, 276);
            this.boxHuesped.Name = "boxHuesped";
            this.boxHuesped.Size = new System.Drawing.Size(109, 29);
            this.boxHuesped.TabIndex = 3;
            this.boxHuesped.Text = "Huesped";
            this.boxHuesped.UseVisualStyleBackColor = true;
            this.boxHuesped.CheckedChanged += new System.EventHandler(this.boxHuesped_CheckedChanged);
            // 
            // boxAdministrador
            // 
            this.boxAdministrador.AutoSize = true;
            this.boxAdministrador.Location = new System.Drawing.Point(112, 198);
            this.boxAdministrador.Name = "boxAdministrador";
            this.boxAdministrador.Size = new System.Drawing.Size(152, 29);
            this.boxAdministrador.TabIndex = 4;
            this.boxAdministrador.Text = "Administrador";
            this.boxAdministrador.UseVisualStyleBackColor = true;
            this.boxAdministrador.CheckedChanged += new System.EventHandler(this.boxAdministrador_CheckedChanged);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.Controls.Add(this.boxAdministrador);
            this.Controls.Add(this.boxHuesped);
            this.Controls.Add(this.nombreInicio);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonIngresar);
            this.Name = "ventanaPrincipal";
            this.Text = "Cabañas Villa Loreto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label nombreInicio;
        private System.Windows.Forms.CheckBox boxHuesped;
        private System.Windows.Forms.CheckBox boxAdministrador;
    }
}

