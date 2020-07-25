namespace Horario_bds
{
    partial class AgregarMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMateria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCreditos = new System.Windows.Forms.TextBox();
            this.textBoxSem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creditos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora Terminacion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Semestre_correspodiente";
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(141, 39);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(100, 22);
            this.textBoxClave.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(141, 76);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxCreditos
            // 
            this.textBoxCreditos.Location = new System.Drawing.Point(141, 106);
            this.textBoxCreditos.Name = "textBoxCreditos";
            this.textBoxCreditos.Size = new System.Drawing.Size(100, 22);
            this.textBoxCreditos.TabIndex = 8;
            // 
            // textBoxSem
            // 
            this.textBoxSem.Location = new System.Drawing.Point(202, 150);
            this.textBoxSem.Name = "textBoxSem";
            this.textBoxSem.Size = new System.Drawing.Size(39, 22);
            this.textBoxSem.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(479, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rango de horas consejables para dar esta materia";
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(89, 200);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.ShowUpDown = true;
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(110, 22);
            this.dateTimePickerHoraInicio.TabIndex = 15;
            this.dateTimePickerHoraInicio.Value = new System.DateTime(2017, 11, 15, 7, 0, 0, 0);
            // 
            // dateTimePickerHoraFinal
            // 
            this.dateTimePickerHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraFinal.Location = new System.Drawing.Point(323, 200);
            this.dateTimePickerHoraFinal.Name = "dateTimePickerHoraFinal";
            this.dateTimePickerHoraFinal.ShowUpDown = true;
            this.dateTimePickerHoraFinal.Size = new System.Drawing.Size(126, 22);
            this.dateTimePickerHoraFinal.TabIndex = 16;
            this.dateTimePickerHoraFinal.Value = new System.DateTime(2017, 11, 15, 8, 0, 0, 0);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(151, 295);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(113, 38);
            this.buttonSalir.TabIndex = 38;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // AgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(693, 369);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dateTimePickerHoraFinal);
            this.Controls.Add(this.dateTimePickerHoraInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSem);
            this.Controls.Add(this.textBoxCreditos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarMateria";
            this.Text = "AgregarMateria";
            this.Load += new System.EventHandler(this.AgregarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCreditos;
        private System.Windows.Forms.TextBox textBoxSem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFinal;
        private System.Windows.Forms.Button buttonSalir;
    }
}