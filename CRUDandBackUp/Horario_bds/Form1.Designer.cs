namespace Horario_bds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttoniniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttoniniciar
            // 
            this.buttoniniciar.BackColor = System.Drawing.Color.Cyan;
            this.buttoniniciar.Location = new System.Drawing.Point(106, 164);
            this.buttoniniciar.Name = "buttoniniciar";
            this.buttoniniciar.Size = new System.Drawing.Size(75, 23);
            this.buttoniniciar.TabIndex = 0;
            this.buttoniniciar.Text = "Iniciar";
            this.buttoniniciar.UseVisualStyleBackColor = false;
            this.buttoniniciar.Click += new System.EventHandler(this.buttoniniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point(106, 88);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.Color.White;
            this.textBoxContraseña.Location = new System.Drawing.Point(106, 124);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(100, 22);
            this.textBoxContraseña.TabIndex = 5;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(107, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Administrador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoniniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoniniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label3;
    }
}

