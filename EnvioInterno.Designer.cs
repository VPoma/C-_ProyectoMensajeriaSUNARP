namespace SistMensaSUNARP
{
    partial class EnvioInterno
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNotificador = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dtgEnvioInterno = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtpFechaEnvioInterno = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEnvioInterno)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(657, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "Notificador";
            // 
            // cmbNotificador
            // 
            this.cmbNotificador.FormattingEnabled = true;
            this.cmbNotificador.Location = new System.Drawing.Point(762, 123);
            this.cmbNotificador.Name = "cmbNotificador";
            this.cmbNotificador.Size = new System.Drawing.Size(154, 21);
            this.cmbNotificador.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(351, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 46);
            this.label8.TabIndex = 62;
            this.label8.Text = "Envio Interno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistMensaSUNARP.Properties.Resources.NuevologoSunarp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(664, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 44);
            this.button4.TabIndex = 123;
            this.button4.Text = "Imprimir Reporte";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(774, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 44);
            this.button6.TabIndex = 122;
            this.button6.Text = "Añadir Notificador";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(884, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 44);
            this.button5.TabIndex = 121;
            this.button5.Text = "Regresar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtgEnvioInterno
            // 
            this.dtgEnvioInterno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEnvioInterno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtgEnvioInterno.Location = new System.Drawing.Point(25, 150);
            this.dtgEnvioInterno.Name = "dtgEnvioInterno";
            this.dtgEnvioInterno.Size = new System.Drawing.Size(944, 213);
            this.dtgEnvioInterno.TabIndex = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seleccionar";
            this.Column1.Name = "Column1";
            // 
            // dtpFechaEnvioInterno
            // 
            this.dtpFechaEnvioInterno.Location = new System.Drawing.Point(77, 124);
            this.dtpFechaEnvioInterno.Name = "dtpFechaEnvioInterno";
            this.dtpFechaEnvioInterno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEnvioInterno.TabIndex = 126;
            this.dtpFechaEnvioInterno.ValueChanged += new System.EventHandler(this.dtpFechaEnvioInterno_ValueChanged);
            // 
            // EnvioInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 438);
            this.Controls.Add(this.dtpFechaEnvioInterno);
            this.Controls.Add(this.dtgEnvioInterno);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbNotificador);
            this.Controls.Add(this.label4);
            this.Name = "EnvioInterno";
            this.Load += new System.EventHandler(this.EnvioInterno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEnvioInterno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNotificador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dtgEnvioInterno;
        private System.Windows.Forms.DateTimePicker dtpFechaEnvioInterno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}