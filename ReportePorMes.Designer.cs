namespace SistMensaSUNARP
{
    partial class ReportePorMes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_ListarCargosNoRetornadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReportes = new SistMensaSUNARP.DataSetReportes();
            this.sp_CantEnviosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_CantCargosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_CantCargosNoRetornadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ListarCargosNoRetornadosTableAdapter = new SistMensaSUNARP.DataSetReportesTableAdapters.sp_ListarCargosNoRetornadosTableAdapter();
            this.sp_BusquedaEnvioInternoImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BusquedaEnvioInternoImpTableAdapter = new SistMensaSUNARP.DataSetReportesTableAdapters.sp_BusquedaEnvioInternoImpTableAdapter();
            this.sp_CantEnviosTableAdapter = new SistMensaSUNARP.DataSetReportesTableAdapters.sp_CantEnviosTableAdapter();
            this.sp_CantCargosTableAdapter = new SistMensaSUNARP.DataSetReportesTableAdapters.sp_CantCargosTableAdapter();
            this.sp_CantCargosNoRetornadosTableAdapter = new SistMensaSUNARP.DataSetReportesTableAdapters.sp_CantCargosNoRetornadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ListarCargosNoRetornadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CantEnviosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CantCargosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CantCargosNoRetornadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BusquedaEnvioInternoImpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ListarCargosNoRetornadosBindingSource
            // 
            this.sp_ListarCargosNoRetornadosBindingSource.DataMember = "sp_ListarCargosNoRetornados";
            this.sp_ListarCargosNoRetornadosBindingSource.DataSource = this.DataSetReportes;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_CantEnviosBindingSource
            // 
            this.sp_CantEnviosBindingSource.DataMember = "sp_CantEnvios";
            this.sp_CantEnviosBindingSource.DataSource = this.DataSetReportes;
            // 
            // sp_CantCargosBindingSource
            // 
            this.sp_CantCargosBindingSource.DataMember = "sp_CantCargos";
            this.sp_CantCargosBindingSource.DataSource = this.DataSetReportes;
            // 
            // sp_CantCargosNoRetornadosBindingSource
            // 
            this.sp_CantCargosNoRetornadosBindingSource.DataMember = "sp_CantCargosNoRetornados";
            this.sp_CantCargosNoRetornadosBindingSource.DataSource = this.DataSetReportes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_ListarCargosNoRetornadosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.sp_CantEnviosBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.sp_CantCargosBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.sp_CantCargosNoRetornadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistMensaSUNARP.ReportePorMes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(990, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ListarCargosNoRetornadosTableAdapter
            // 
            this.sp_ListarCargosNoRetornadosTableAdapter.ClearBeforeFill = true;
            // 
            // sp_BusquedaEnvioInternoImpBindingSource
            // 
            this.sp_BusquedaEnvioInternoImpBindingSource.DataMember = "sp_BusquedaEnvioInternoImp";
            this.sp_BusquedaEnvioInternoImpBindingSource.DataSource = this.DataSetReportes;
            // 
            // sp_BusquedaEnvioInternoImpTableAdapter
            // 
            this.sp_BusquedaEnvioInternoImpTableAdapter.ClearBeforeFill = true;
            // 
            // sp_CantEnviosTableAdapter
            // 
            this.sp_CantEnviosTableAdapter.ClearBeforeFill = true;
            // 
            // sp_CantCargosTableAdapter
            // 
            this.sp_CantCargosTableAdapter.ClearBeforeFill = true;
            // 
            // sp_CantCargosNoRetornadosTableAdapter
            // 
            this.sp_CantCargosNoRetornadosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 441);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePorMes";
            this.Load += new System.EventHandler(this.ReportePorMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ListarCargosNoRetornadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CantEnviosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CantCargosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_CantCargosNoRetornadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BusquedaEnvioInternoImpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ListarCargosNoRetornadosBindingSource;
        private DataSetReportes DataSetReportes;
        private DataSetReportesTableAdapters.sp_ListarCargosNoRetornadosTableAdapter sp_ListarCargosNoRetornadosTableAdapter;
        private System.Windows.Forms.BindingSource sp_BusquedaEnvioInternoImpBindingSource;
        private DataSetReportesTableAdapters.sp_BusquedaEnvioInternoImpTableAdapter sp_BusquedaEnvioInternoImpTableAdapter;
        private System.Windows.Forms.BindingSource sp_CantEnviosBindingSource;
        private System.Windows.Forms.BindingSource sp_CantCargosBindingSource;
        private System.Windows.Forms.BindingSource sp_CantCargosNoRetornadosBindingSource;
        private DataSetReportesTableAdapters.sp_CantEnviosTableAdapter sp_CantEnviosTableAdapter;
        private DataSetReportesTableAdapters.sp_CantCargosTableAdapter sp_CantCargosTableAdapter;
        private DataSetReportesTableAdapters.sp_CantCargosNoRetornadosTableAdapter sp_CantCargosNoRetornadosTableAdapter;
    }
}