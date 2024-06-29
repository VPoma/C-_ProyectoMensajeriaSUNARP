namespace SistMensaSUNARP
{
    partial class BusquedaCargosRet
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgBuscarCargo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.cmbTdoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtNumPaquete = new System.Windows.Forms.TextBox();
            this.dtpFechaBuscarCargo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(511, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 86;
            this.label8.Text = "N° Paquete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(856, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 80;
            this.label6.Text = "Lugar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(282, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 46);
            this.label1.TabIndex = 79;
            this.label1.Text = "Busqueda De Cargos Retornados";
            // 
            // dtgBuscarCargo
            // 
            this.dtgBuscarCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarCargo.Location = new System.Drawing.Point(32, 213);
            this.dtgBuscarCargo.Name = "dtgBuscarCargo";
            this.dtgBuscarCargo.Size = new System.Drawing.Size(1163, 191);
            this.dtgBuscarCargo.TabIndex = 88;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistMensaSUNARP.Properties.Resources.NuevologoSunarp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(931, 112);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(61, 20);
            this.txtNumDoc.TabIndex = 158;
            this.txtNumDoc.TextChanged += new System.EventHandler(this.txtNumDoc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(529, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 157;
            this.label3.Text = "Tipo Doc";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(633, 145);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(113, 20);
            this.txtDestino.TabIndex = 156;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(294, 112);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(60, 20);
            this.txtSalida.TabIndex = 155;
            this.txtSalida.TextChanged += new System.EventHandler(this.txtSalida_TextChanged);
            // 
            // cmbTdoc
            // 
            this.cmbTdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTdoc.FormattingEnabled = true;
            this.cmbTdoc.Items.AddRange(new object[] {
            "Elija"});
            this.cmbTdoc.Location = new System.Drawing.Point(633, 110);
            this.cmbTdoc.Name = "cmbTdoc";
            this.cmbTdoc.Size = new System.Drawing.Size(103, 24);
            this.cmbTdoc.TabIndex = 153;
            this.cmbTdoc.SelectedIndexChanged += new System.EventHandler(this.cmbTdoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(845, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 152;
            this.label2.Text = "N° Doc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(193, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 151;
            this.label4.Text = "N° Salida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(132, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 24);
            this.label10.TabIndex = 150;
            this.label10.Text = "Fecha de Salida";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(543, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 24);
            this.label11.TabIndex = 149;
            this.label11.Text = "Destino";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(931, 145);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(113, 20);
            this.txtLugar.TabIndex = 159;
            this.txtLugar.TextChanged += new System.EventHandler(this.txtLugar_TextChanged);
            // 
            // txtNumPaquete
            // 
            this.txtNumPaquete.Location = new System.Drawing.Point(632, 178);
            this.txtNumPaquete.Name = "txtNumPaquete";
            this.txtNumPaquete.Size = new System.Drawing.Size(60, 20);
            this.txtNumPaquete.TabIndex = 160;
            this.txtNumPaquete.TextChanged += new System.EventHandler(this.txtNumPaquete_TextChanged);
            // 
            // dtpFechaBuscarCargo
            // 
            this.dtpFechaBuscarCargo.Location = new System.Drawing.Point(294, 145);
            this.dtpFechaBuscarCargo.Name = "dtpFechaBuscarCargo";
            this.dtpFechaBuscarCargo.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaBuscarCargo.TabIndex = 161;
            this.dtpFechaBuscarCargo.ValueChanged += new System.EventHandler(this.dtpFechaBuscarCargo_ValueChanged);
            // 
            // BusquedaCargosRet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 427);
            this.Controls.Add(this.dtpFechaBuscarCargo);
            this.Controls.Add(this.txtNumPaquete);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.cmbTdoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgBuscarCargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "BusquedaCargosRet";
            this.Load += new System.EventHandler(this.BusquedaCargosRet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgBuscarCargo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.ComboBox cmbTdoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtNumPaquete;
        private System.Windows.Forms.DateTimePicker dtpFechaBuscarCargo;
    }
}