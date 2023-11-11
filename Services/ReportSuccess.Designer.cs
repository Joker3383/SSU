namespace SSU.Services
{
    partial class ReportSuccess
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.securityServiceOfUkraineDataSet = new SSU.SecurityServiceOfUkraineDataSet();
            this.getEmployeePerformanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmployeePerformanceTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.GetEmployeePerformanceTableAdapter();
            this.tableAdapterManager = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeePerformanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getEmployeePerformanceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSU.Services.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1434, 681);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // securityServiceOfUkraineDataSet
            // 
            this.securityServiceOfUkraineDataSet.DataSetName = "SecurityServiceOfUkraineDataSet";
            this.securityServiceOfUkraineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEmployeePerformanceBindingSource
            // 
            this.getEmployeePerformanceBindingSource.DataMember = "GetEmployeePerformance";
            this.getEmployeePerformanceBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // getEmployeePerformanceTableAdapter
            // 
            this.getEmployeePerformanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CollabDocumTableAdapter = null;
            this.tableAdapterManager.CollaboratorsTableAdapter = null;
            this.tableAdapterManager.CollabPosadaTableAdapter = null;
            this.tableAdapterManager.CollabSecLevelTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DocumentTableAdapter = null;
            this.tableAdapterManager.DocumSecSecretTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.OperationTableAdapter = null;
            this.tableAdapterManager.PosadaTableAdapter = null;
            this.tableAdapterManager.SecLevelSecSecretTableAdapter = null;
            this.tableAdapterManager.SecretCaseTableAdapter = null;
            this.tableAdapterManager.SecurityLevelTableAdapter = null;
            this.tableAdapterManager.SecuritySecretTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ReportSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 932);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportSuccess";
            this.Text = "ReportSuccess";
            this.Load += new System.EventHandler(this.ReportSuccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeePerformanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SecurityServiceOfUkraineDataSet securityServiceOfUkraineDataSet;
        private System.Windows.Forms.BindingSource getEmployeePerformanceBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.GetEmployeePerformanceTableAdapter getEmployeePerformanceTableAdapter;
        private SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}