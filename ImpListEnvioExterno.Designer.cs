namespace SistMensaSUNARP
{
    partial class ImpListEnvioExterno
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
            this.sp_BusquedaEnvioExternoImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportes = new SistMensaSUNARP.DataSetReportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_BusquedaEnvioExternoImpTableAdapter = new SistMensaSUNARP.DataSetReportesTableAdapters.sp_BusquedaEnvioExternoImpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BusquedaEnvioExternoImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_BusquedaEnvioExternoImpBindingSource
            // 
            this.sp_BusquedaEnvioExternoImpBindingSource.DataMember = "sp_BusquedaEnvioExternoImp";
            this.sp_BusquedaEnvioExternoImpBindingSource.DataSource = this.DataSetReportes;
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
            reportDataSource1.Value = this.sp_BusquedaEnvioExternoImpBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistMensaSUNARP.ReporteListEnvioExterno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1004, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_BusquedaEnvioExternoImpTableAdapter
            // 
            this.sp_BusquedaEnvioExternoImpTableAdapter.ClearBeforeFill = true;
            // 
            // ImpListEnvioExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 432);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImpListEnvioExterno";
            this.Load += new System.EventHandler(this.ImpListEnvioExterno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_BusquedaEnvioExternoImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_BusquedaEnvioExternoImpBindingSource;
        private DataSetReportes DataSetReportes;
        private DataSetReportesTableAdapters.sp_BusquedaEnvioExternoImpTableAdapter sp_BusquedaEnvioExternoImpTableAdapter;
    }
}