namespace SistMensaSUNARP
{
    partial class RegCargosC
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
            this.button7 = new System.Windows.Forms.Button();
            this.dtgCargaCargos = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTdoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaFillRegCargo = new System.Windows.Forms.DateTimePicker();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgCargaEnvios = new System.Windows.Forms.DataGridView();
            this.txtRemito = new System.Windows.Forms.TextBox();
            this.txtpaquete = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.dtpFechaRetorno = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargaCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargaEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(893, 629);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 26);
            this.button7.TabIndex = 79;
            this.button7.Text = "Modificar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dtgCargaCargos
            // 
            this.dtgCargaCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCargaCargos.Location = new System.Drawing.Point(30, 476);
            this.dtgCargaCargos.Name = "dtgCargaCargos";
            this.dtgCargaCargos.Size = new System.Drawing.Size(1061, 147);
            this.dtgCargaCargos.TabIndex = 78;
            this.dtgCargaCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCargaCargos_CellContentClick);
            this.dtgCargaCargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCargaCargos_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(174, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 24);
            this.label15.TabIndex = 95;
            this.label15.Text = "N° Paquete";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(315, 369);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 24);
            this.label16.TabIndex = 96;
            this.label16.Text = "Fecha de Retorno";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(549, 369);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 24);
            this.label17.TabIndex = 98;
            this.label17.Text = "Fecha de Entrega";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(769, 369);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 24);
            this.label18.TabIndex = 99;
            this.label18.Text = "Dif Días";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(860, 369);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 24);
            this.label21.TabIndex = 102;
            this.label21.Text = "N° Remito";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(995, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 103;
            this.button1.Text = "Quitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 46);
            this.label1.TabIndex = 104;
            this.label1.Text = "Registro de Cargos Externos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistMensaSUNARP.Properties.Resources.NuevologoSunarp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNumDoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbTdoc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpFechaFillRegCargo);
            this.panel1.Controls.Add(this.txtDestino);
            this.panel1.Controls.Add(this.txtSalida);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(270, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 122);
            this.panel1.TabIndex = 133;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(452, 62);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(61, 20);
            this.txtNumDoc.TabIndex = 153;
            this.txtNumDoc.TextChanged += new System.EventHandler(this.txtNumDoc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(359, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 152;
            this.label3.Text = "Tipo Doc";
            // 
            // cmbTdoc
            // 
            this.cmbTdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTdoc.FormattingEnabled = true;
            this.cmbTdoc.Location = new System.Drawing.Point(452, 32);
            this.cmbTdoc.Name = "cmbTdoc";
            this.cmbTdoc.Size = new System.Drawing.Size(103, 24);
            this.cmbTdoc.TabIndex = 151;
            this.cmbTdoc.SelectedIndexChanged += new System.EventHandler(this.cmbTdoc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(377, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 150;
            this.label8.Text = "N° Doc";
            // 
            // dtpFechaFillRegCargo
            // 
            this.dtpFechaFillRegCargo.Location = new System.Drawing.Point(139, 62);
            this.dtpFechaFillRegCargo.Name = "dtpFechaFillRegCargo";
            this.dtpFechaFillRegCargo.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaFillRegCargo.TabIndex = 149;
            this.dtpFechaFillRegCargo.ValueChanged += new System.EventHandler(this.dtpFechaFillRegCargo_ValueChanged);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(240, 95);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(113, 20);
            this.txtDestino.TabIndex = 146;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(139, 32);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(60, 20);
            this.txtSalida.TabIndex = 145;
            this.txtSalida.TextChanged += new System.EventHandler(this.txtSalida_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 143;
            this.label2.Text = "Opciones de Busqueda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(52, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 136;
            this.label7.Text = "N° Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(69, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 135;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(161, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 134;
            this.label4.Text = "Destino";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 26);
            this.button2.TabIndex = 134;
            this.button2.Text = "Registrar Cargos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgCargaEnvios
            // 
            this.dtgCargaEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCargaEnvios.Location = new System.Drawing.Point(180, 210);
            this.dtgCargaEnvios.Name = "dtgCargaEnvios";
            this.dtgCargaEnvios.Size = new System.Drawing.Size(761, 133);
            this.dtgCargaEnvios.TabIndex = 135;
            this.dtgCargaEnvios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCargaEnvios_CellContentClick);
            this.dtgCargaEnvios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCargaEnvios_CellContentClick);
            // 
            // txtRemito
            // 
            this.txtRemito.Location = new System.Drawing.Point(874, 400);
            this.txtRemito.Name = "txtRemito";
            this.txtRemito.Size = new System.Drawing.Size(60, 20);
            this.txtRemito.TabIndex = 149;
            // 
            // txtpaquete
            // 
            this.txtpaquete.Location = new System.Drawing.Point(196, 400);
            this.txtpaquete.Name = "txtpaquete";
            this.txtpaquete.Size = new System.Drawing.Size(60, 20);
            this.txtpaquete.TabIndex = 150;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(773, 400);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(60, 20);
            this.txtDias.TabIndex = 151;
            // 
            // dtpFechaRetorno
            // 
            this.dtpFechaRetorno.Location = new System.Drawing.Point(301, 400);
            this.dtpFechaRetorno.Name = "dtpFechaRetorno";
            this.dtpFechaRetorno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRetorno.TabIndex = 152;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(539, 400);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEntrega.TabIndex = 153;
            this.dtpFechaEntrega.ValueChanged += new System.EventHandler(this.dtpFechaEntrega_ValueChanged);
            // 
            // RegCargosC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 671);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.dtpFechaRetorno);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtRemito);
            this.Controls.Add(this.txtpaquete);
            this.Controls.Add(this.dtgCargaEnvios);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dtgCargaCargos);
            this.Name = "RegCargosC";
            this.Load += new System.EventHandler(this.RegCargosC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargaCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargaEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dtgCargaCargos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgCargaEnvios;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtRemito;
        private System.Windows.Forms.TextBox txtpaquete;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.DateTimePicker dtpFechaFillRegCargo;
        private System.Windows.Forms.DateTimePicker dtpFechaRetorno;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTdoc;
        private System.Windows.Forms.Label label8;
    }
}