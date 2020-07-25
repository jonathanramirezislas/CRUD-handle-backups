namespace Horario_bds
{
    partial class ModificarSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarSalon));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCalveSalon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxsillas = new System.Windows.Forms.TextBox();
            this.textBoxdesripcion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxProyector = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCalveSalon
            // 
            this.comboBoxCalveSalon.FormattingEnabled = true;
            this.comboBoxCalveSalon.Location = new System.Drawing.Point(211, 47);
            this.comboBoxCalveSalon.Name = "comboBoxCalveSalon";
            this.comboBoxCalveSalon.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCalveSalon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "#Sillas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Proyector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 121);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxsillas
            // 
            this.textBoxsillas.Location = new System.Drawing.Point(100, 166);
            this.textBoxsillas.Name = "textBoxsillas";
            this.textBoxsillas.Size = new System.Drawing.Size(100, 22);
            this.textBoxsillas.TabIndex = 8;
            // 
            // textBoxdesripcion
            // 
            this.textBoxdesripcion.Location = new System.Drawing.Point(100, 263);
            this.textBoxdesripcion.Name = "textBoxdesripcion";
            this.textBoxdesripcion.Size = new System.Drawing.Size(197, 22);
            this.textBoxdesripcion.TabIndex = 10;
            this.textBoxdesripcion.Text = "\"Sin descripcion\"";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Guardar Cambios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxProyector
            // 
            this.comboBoxProyector.FormattingEnabled = true;
            this.comboBoxProyector.Location = new System.Drawing.Point(100, 212);
            this.comboBoxProyector.Name = "comboBoxProyector";
            this.comboBoxProyector.Size = new System.Drawing.Size(97, 24);
            this.comboBoxProyector.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(328, 289);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(113, 38);
            this.buttonSalir.TabIndex = 38;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // ModificarSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 339);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxProyector);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxdesripcion);
            this.Controls.Add(this.textBoxsillas);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCalveSalon);
            this.Controls.Add(this.button1);
            this.Name = "ModificarSalon";
            this.Text = "ModificarSalon";
            this.Load += new System.EventHandler(this.ModificarSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCalveSalon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxsillas;
        private System.Windows.Forms.TextBox textBoxdesripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxProyector;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSalir;
    }
}