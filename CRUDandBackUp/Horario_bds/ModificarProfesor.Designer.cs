namespace Horario_bds
{
    partial class ModificarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProfesor));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxClaveProfesor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDepartamenot = new System.Windows.Forms.ComboBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxappelido = new System.Windows.Forms.TextBox();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.textBoxtelefono = new System.Windows.Forms.TextBox();
            this.textBoxedad = new System.Windows.Forms.TextBox();
            this.FechaNacdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxClaveProfesor
            // 
            this.comboBoxClaveProfesor.FormattingEnabled = true;
            this.comboBoxClaveProfesor.Location = new System.Drawing.Point(172, 70);
            this.comboBoxClaveProfesor.Name = "comboBoxClaveProfesor";
            this.comboBoxClaveProfesor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClaveProfesor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clave_P";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "Guardar cambios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de NAC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Edad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Departamento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBoxDepartamenot
            // 
            this.comboBoxDepartamenot.FormattingEnabled = true;
            this.comboBoxDepartamenot.Location = new System.Drawing.Point(172, 376);
            this.comboBoxDepartamenot.Name = "comboBoxDepartamenot";
            this.comboBoxDepartamenot.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDepartamenot.TabIndex = 11;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(172, 153);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 22);
            this.textBoxname.TabIndex = 12;
            // 
            // textBoxappelido
            // 
            this.textBoxappelido.Location = new System.Drawing.Point(181, 196);
            this.textBoxappelido.Name = "textBoxappelido";
            this.textBoxappelido.Size = new System.Drawing.Size(100, 22);
            this.textBoxappelido.TabIndex = 13;
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(181, 270);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(100, 22);
            this.textBoxdireccion.TabIndex = 15;
            // 
            // textBoxtelefono
            // 
            this.textBoxtelefono.Location = new System.Drawing.Point(181, 303);
            this.textBoxtelefono.Name = "textBoxtelefono";
            this.textBoxtelefono.Size = new System.Drawing.Size(100, 22);
            this.textBoxtelefono.TabIndex = 16;
            // 
            // textBoxedad
            // 
            this.textBoxedad.Location = new System.Drawing.Point(181, 340);
            this.textBoxedad.Name = "textBoxedad";
            this.textBoxedad.Size = new System.Drawing.Size(100, 22);
            this.textBoxedad.TabIndex = 17;
            // 
            // FechaNacdateTimePicker
            // 
            this.FechaNacdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacdateTimePicker.Location = new System.Drawing.Point(181, 235);
            this.FechaNacdateTimePicker.Name = "FechaNacdateTimePicker";
            this.FechaNacdateTimePicker.Size = new System.Drawing.Size(156, 22);
            this.FechaNacdateTimePicker.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(449, 429);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(113, 38);
            this.buttonSalir.TabIndex = 39;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // ModificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 494);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FechaNacdateTimePicker);
            this.Controls.Add(this.textBoxedad);
            this.Controls.Add(this.textBoxtelefono);
            this.Controls.Add(this.textBoxdireccion);
            this.Controls.Add(this.textBoxappelido);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.comboBoxDepartamenot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClaveProfesor);
            this.Controls.Add(this.button1);
            this.Name = "ModificarProfesor";
            this.Text = "ModificarProfesor";
            this.Load += new System.EventHandler(this.ModificarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxClaveProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDepartamenot;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxappelido;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.TextBox textBoxtelefono;
        private System.Windows.Forms.TextBox textBoxedad;
        private System.Windows.Forms.DateTimePicker FechaNacdateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSalir;
    }
}