namespace Horario_bds
{
    partial class Mostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttontablas = new System.Windows.Forms.Button();
            this.comboBoxAgregar = new System.Windows.Forms.ComboBox();
            this.comboBoxModificar = new System.Windows.Forms.ComboBox();
            this.comboBoxEliminar = new System.Windows.Forms.ComboBox();
            this.buttonEjecutarAgregar = new System.Windows.Forms.Button();
            this.buttonEjecutarModificar = new System.Windows.Forms.Button();
            this.buttonEjecutarEliminar = new System.Windows.Forms.Button();
            this.comboBoxTablas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Cyan;
            this.dataGridView1.Location = new System.Drawing.Point(5, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(875, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttontablas
            // 
            this.buttontablas.BackColor = System.Drawing.Color.Lime;
            this.buttontablas.ForeColor = System.Drawing.Color.Black;
            this.buttontablas.Location = new System.Drawing.Point(56, 71);
            this.buttontablas.Name = "buttontablas";
            this.buttontablas.Size = new System.Drawing.Size(121, 64);
            this.buttontablas.TabIndex = 1;
            this.buttontablas.Text = "Ejecutar ";
            this.buttontablas.UseVisualStyleBackColor = false;
            this.buttontablas.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxAgregar
            // 
            this.comboBoxAgregar.BackColor = System.Drawing.Color.Yellow;
            this.comboBoxAgregar.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAgregar.FormattingEnabled = true;
            this.comboBoxAgregar.Location = new System.Drawing.Point(694, 14);
            this.comboBoxAgregar.Name = "comboBoxAgregar";
            this.comboBoxAgregar.Size = new System.Drawing.Size(121, 26);
            this.comboBoxAgregar.TabIndex = 6;
            this.comboBoxAgregar.Text = "Agregar";
            this.comboBoxAgregar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxModificar
            // 
            this.comboBoxModificar.BackColor = System.Drawing.Color.Aqua;
            this.comboBoxModificar.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModificar.FormattingEnabled = true;
            this.comboBoxModificar.Location = new System.Drawing.Point(694, 60);
            this.comboBoxModificar.Name = "comboBoxModificar";
            this.comboBoxModificar.Size = new System.Drawing.Size(121, 26);
            this.comboBoxModificar.TabIndex = 7;
            this.comboBoxModificar.Text = "Modificar";
            // 
            // comboBoxEliminar
            // 
            this.comboBoxEliminar.BackColor = System.Drawing.Color.Pink;
            this.comboBoxEliminar.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEliminar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxEliminar.FormattingEnabled = true;
            this.comboBoxEliminar.Location = new System.Drawing.Point(694, 96);
            this.comboBoxEliminar.Name = "comboBoxEliminar";
            this.comboBoxEliminar.Size = new System.Drawing.Size(121, 26);
            this.comboBoxEliminar.TabIndex = 8;
            this.comboBoxEliminar.Text = "Eliminar";
            this.comboBoxEliminar.SelectedIndexChanged += new System.EventHandler(this.comboBoxEliminar_SelectedIndexChanged);
            // 
            // buttonEjecutarAgregar
            // 
            this.buttonEjecutarAgregar.BackColor = System.Drawing.Color.Yellow;
            this.buttonEjecutarAgregar.Location = new System.Drawing.Point(833, 12);
            this.buttonEjecutarAgregar.Name = "buttonEjecutarAgregar";
            this.buttonEjecutarAgregar.Size = new System.Drawing.Size(84, 34);
            this.buttonEjecutarAgregar.TabIndex = 9;
            this.buttonEjecutarAgregar.Text = "Ejecutar ";
            this.buttonEjecutarAgregar.UseVisualStyleBackColor = false;
            this.buttonEjecutarAgregar.Click += new System.EventHandler(this.buttonEjecutar_Click);
            // 
            // buttonEjecutarModificar
            // 
            this.buttonEjecutarModificar.BackColor = System.Drawing.Color.Aqua;
            this.buttonEjecutarModificar.Location = new System.Drawing.Point(833, 57);
            this.buttonEjecutarModificar.Name = "buttonEjecutarModificar";
            this.buttonEjecutarModificar.Size = new System.Drawing.Size(96, 29);
            this.buttonEjecutarModificar.TabIndex = 10;
            this.buttonEjecutarModificar.Text = "Ejecutar ";
            this.buttonEjecutarModificar.UseVisualStyleBackColor = false;
            this.buttonEjecutarModificar.Click += new System.EventHandler(this.buttonEjecutarModificar_Click);
            // 
            // buttonEjecutarEliminar
            // 
            this.buttonEjecutarEliminar.BackColor = System.Drawing.Color.Pink;
            this.buttonEjecutarEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEjecutarEliminar.Location = new System.Drawing.Point(833, 89);
            this.buttonEjecutarEliminar.Name = "buttonEjecutarEliminar";
            this.buttonEjecutarEliminar.Size = new System.Drawing.Size(96, 33);
            this.buttonEjecutarEliminar.TabIndex = 11;
            this.buttonEjecutarEliminar.Text = "Ejecutar";
            this.buttonEjecutarEliminar.UseVisualStyleBackColor = false;
            this.buttonEjecutarEliminar.Click += new System.EventHandler(this.buttonEjecutarEliminar_Click);
            // 
            // comboBoxTablas
            // 
            this.comboBoxTablas.BackColor = System.Drawing.Color.Lime;
            this.comboBoxTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTablas.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTablas.FormattingEnabled = true;
            this.comboBoxTablas.Location = new System.Drawing.Point(56, 40);
            this.comboBoxTablas.Name = "comboBoxTablas";
            this.comboBoxTablas.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTablas.TabIndex = 12;
            this.comboBoxTablas.Text = "Tablas";
            this.comboBoxTablas.SelectedIndexChanged += new System.EventHandler(this.comboBoxTablas_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(415, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hacer Respaldo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkViolet;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(539, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "Restaurar Ultimo Respaldo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(199, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 45);
            this.button3.TabIndex = 15;
            this.button3.Text = "BUSQUEDA EXHAUSTIVA ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 385);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxTablas);
            this.Controls.Add(this.buttonEjecutarEliminar);
            this.Controls.Add(this.buttonEjecutarModificar);
            this.Controls.Add(this.buttonEjecutarAgregar);
            this.Controls.Add(this.comboBoxEliminar);
            this.Controls.Add(this.comboBoxModificar);
            this.Controls.Add(this.comboBoxAgregar);
            this.Controls.Add(this.buttontablas);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttontablas;
        private System.Windows.Forms.ComboBox comboBoxAgregar;
        private System.Windows.Forms.ComboBox comboBoxModificar;
        private System.Windows.Forms.ComboBox comboBoxEliminar;
        private System.Windows.Forms.Button buttonEjecutarAgregar;
        private System.Windows.Forms.Button buttonEjecutarModificar;
        private System.Windows.Forms.Button buttonEjecutarEliminar;
        private System.Windows.Forms.ComboBox comboBoxTablas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}