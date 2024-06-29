namespace SistMensaSUNARP
{
    partial class ImpEtiquetaConsolidado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_BuscarEnvioConslImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportes = new SistMensaSUNARP.DataSetReportes();
            this.sp_BuscarEnvioConslDocImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_BuscarEnvioConslImpTableAdapter = new SistMensaSUNARP.DataSetReportesTableAdapters.sp_BuscarEnvioConslImpTableAdapter();
            this.sp_BuscarEnvioConslDocImpTableAdapter = new SistMensaSUNARP.DataSetReportesTableAdapters.sp_BuscarEnvioConslDocImpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BuscarEnvioConslImpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BuscarEnvioConslDocImpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_BuscarEnvioConslImpBindingSource
            // 
            this.sp_BuscarEnvioConslImpBindingSource.DataMember = "sp_BuscarEnvioConslImp";
            this.sp_BuscarEnvioConslImpBindingSource.DataSource = this.DataSetReportes;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_BuscarEnvioConslDocImpBindingSource
            // 
            this.sp_BuscarEnvioConslDocImpBindingSource.DataMember = "sp_BuscarEnvioConslDocImp";
            this.sp_BuscarEnvioConslDocImpBindingSource.DataSource = this.DataSetReportes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_BuscarEnvioConslImpBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.sp_BuscarEnvioConslDocImpBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistMensaSUNARP.EtiquetaConsolidado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 402);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_BuscarEnvioConslImpTableAdapter
            // 
            this.sp_BuscarEnvioConslImpTableAdapter.ClearBeforeFill = true;
            // 
            // sp_BuscarEnvioConslDocImpTableAdapter
            // 
            this.sp_BuscarEnvioConslDocImpTableAdapter.ClearBeforeFill = true;
            // 
            // ImpEtiquetaConsolidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 402);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImpEtiquetaConsolidado";
            this.Load += new System.EventHandler(this.ImpEtiquetaConsolidado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_BuscarEnvioConslImpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BuscarEnvioConslDocImpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_BuscarEnvioConslImpBindingSource;
        private DataSetReportes DataSetReportes;
        private System.Windows.Forms.BindingSource sp_BuscarEnvioConslDocImpBindingSource;
        private DataSetReportesTableAdapters.sp_BuscarEnvioConslImpTableAdapter sp_BuscarEnvioConslImpTableAdapter;
        private DataSetReportesTableAdapters.sp_BuscarEnvioConslDocImpTableAdapter sp_BuscarEnvioConslDocImpTableAdapter;
    }
}