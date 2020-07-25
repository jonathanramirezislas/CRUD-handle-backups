namespace Respaldo
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
            this.buttonBuscar1 = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonBuscar2 = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuscar1
            // 
            this.buttonBuscar1.Location = new System.Drawing.Point(100, 145);
            this.buttonBuscar1.Name = "buttonBuscar1";
            this.buttonBuscar1.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar1.TabIndex = 1;
            this.buttonBuscar1.Text = "button";
            this.buttonBuscar1.UseVisualStyleBackColor = true;
            this.buttonBuscar1.Click += new System.EventHandler(this.buttonBuscar1_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(275, 145);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBackup.TabIndex = 2;
            this.buttonBackup.Text = "button2";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // buttonBuscar2
            // 
            this.buttonBuscar2.Location = new System.Drawing.Point(78, 244);
            this.buttonBuscar2.Name = "buttonBuscar2";
            this.buttonBuscar2.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar2.TabIndex = 5;
            this.buttonBuscar2.Text = "button3";
            this.buttonBuscar2.UseVisualStyleBackColor = true;
            this.buttonBuscar2.Click += new System.EventHandler(this.buttonBuscar2_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(290, 244);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(75, 23);
            this.buttonRestore.TabIndex = 6;
            this.buttonRestore.Text = "button4";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 332);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonBuscar2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonBuscar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar1;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonBuscar2;
        private System.Windows.Forms.Button buttonRestore;
    }
}

