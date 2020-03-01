namespace Test_WinForms_RDLC
{
    partial class Form1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CicloTableAdapter = new Test_WinForms_RDLC.dbControlNotasDataSetTableAdapters.CicloTableAdapter();
            this.CicloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbControlNotasDataSet = new Test_WinForms_RDLC.dbControlNotasDataSet();
            this.dbControlNotasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CicloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControlNotasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControlNotasDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Ciclo";
            reportDataSource1.Value = this.CicloBindingSource;
            reportDataSource2.Name = "DataSet_PersonaObject";
            reportDataSource2.Value = this.dbControlNotasDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Test_WinForms_RDLC.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(62, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(668, 353);
            this.reportViewer1.TabIndex = 0;
            // 
            // CicloTableAdapter
            // 
            this.CicloTableAdapter.ClearBeforeFill = true;
            // 
            // CicloBindingSource
            // 
            this.CicloBindingSource.DataMember = "Ciclo";
            this.CicloBindingSource.DataSource = this.dbControlNotasDataSet;
            // 
            // dbControlNotasDataSet
            // 
            this.dbControlNotasDataSet.DataSetName = "dbControlNotasDataSet";
            this.dbControlNotasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbControlNotasDataSetBindingSource
            // 
            this.dbControlNotasDataSetBindingSource.DataSource = this.dbControlNotasDataSet;
            this.dbControlNotasDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CicloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControlNotasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControlNotasDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CicloBindingSource;
        private dbControlNotasDataSet dbControlNotasDataSet;
        private dbControlNotasDataSetTableAdapters.CicloTableAdapter CicloTableAdapter;
        private System.Windows.Forms.BindingSource dbControlNotasDataSetBindingSource;
    }
}