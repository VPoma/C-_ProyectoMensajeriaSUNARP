namespace SistMensaSUNARP
{
    partial class ImpListEnvioInterno
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_BusquedaEnvioInternoImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportes = new SistMensaSUNARP.DataSetReportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_BusquedaEnvioInternoImpTableAdapter = new SistMensaSUNARP.DataSetReportesTableAdapters.sp_BusquedaEnvioInternoImpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BusquedaEnvioInternoImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_BusquedaEnvioInternoImpBindingSource
            // 
            this.sp_BusquedaEnvioInternoImpBindingSource.DataMember = "sp_BusquedaEnvioInternoImp";
            this.sp_BusquedaEnvioInternoImpBindingSource.DataSource = this.DataSetReportes;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_BusquedaEnvioInternoImpBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistMensaSUNARP.ReporteListEnvioInterno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(762, 427);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_BusquedaEnvioInternoImpTableAdapter
            // 
            this.sp_BusquedaEnvioInternoImpTableAdapter.ClearBeforeFill = true;
            // 
            // ImpListEnvioInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 427);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImpListEnvioInterno";
            this.Load += new System.EventHandler(this.ImpListEnvioInterno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_BusquedaEnvioInternoImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_BusquedaEnvioInternoImpBindingSource;
        private DataSetReportes DataSetReportes;
        private DataSetReportesTableAdapters.sp_BusquedaEnvioInternoImpTableAdapter sp_BusquedaEnvioInternoImpTableAdapter;
    }
}