namespace SSU
{
    partial class Archive
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
            System.Windows.Forms.Label secretCaseIDLabel;
            System.Windows.Forms.Label archiveDescriptionLabel;
            System.Windows.Forms.Label archiveDateLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.archiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityServiceOfUkraineDataSet = new SSU.SecurityServiceOfUkraineDataSet();
            this.secretCaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archiveDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.archiveDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.archiveTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.ArchiveTableAdapter();
            this.tableAdapterManager = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager();
            this.secretCaseTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.SecretCaseTableAdapter();
            this.CaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArchiveDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArchiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            secretCaseIDLabel = new System.Windows.Forms.Label();
            archiveDescriptionLabel = new System.Windows.Forms.Label();
            archiveDateLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretCaseBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // secretCaseIDLabel
            // 
            secretCaseIDLabel.AutoSize = true;
            secretCaseIDLabel.Location = new System.Drawing.Point(396, 116);
            secretCaseIDLabel.Name = "secretCaseIDLabel";
            secretCaseIDLabel.Size = new System.Drawing.Size(180, 29);
            secretCaseIDLabel.TabIndex = 6;
            secretCaseIDLabel.Text = "Secret Case ID:";
            // 
            // archiveDescriptionLabel
            // 
            archiveDescriptionLabel.AutoSize = true;
            archiveDescriptionLabel.Location = new System.Drawing.Point(23, 49);
            archiveDescriptionLabel.Name = "archiveDescriptionLabel";
            archiveDescriptionLabel.Size = new System.Drawing.Size(226, 29);
            archiveDescriptionLabel.TabIndex = 7;
            archiveDescriptionLabel.Text = "Archive Description:";
            // 
            // archiveDateLabel
            // 
            archiveDateLabel.AutoSize = true;
            archiveDateLabel.Location = new System.Drawing.Point(23, 116);
            archiveDateLabel.Name = "archiveDateLabel";
            archiveDateLabel.Size = new System.Drawing.Size(154, 29);
            archiveDateLabel.TabIndex = 8;
            archiveDateLabel.Text = "Archive Date:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(12, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 56);
            this.panel3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(659, 513);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 56);
            this.panel4.TabIndex = 9;
            this.panel4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Decline";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(archiveDateLabel);
            this.groupBox1.Controls.Add(this.archiveDateDateTimePicker);
            this.groupBox1.Controls.Add(archiveDescriptionLabel);
            this.groupBox1.Controls.Add(this.archiveDescriptionTextBox);
            this.groupBox1.Controls.Add(secretCaseIDLabel);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 175);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change cases";
            this.groupBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.archiveBindingSource, "SecretCaseID", true));
            this.comboBox1.DataSource = this.secretCaseBindingSource;
            this.comboBox1.DisplayMember = "SecretCaseName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(582, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 37);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "SecretCaseID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // archiveBindingSource
            // 
            this.archiveBindingSource.DataMember = "Archive";
            this.archiveBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // securityServiceOfUkraineDataSet
            // 
            this.securityServiceOfUkraineDataSet.DataSetName = "SecurityServiceOfUkraineDataSet";
            this.securityServiceOfUkraineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // secretCaseBindingSource
            // 
            this.secretCaseBindingSource.DataMember = "SecretCase";
            this.secretCaseBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // archiveDateDateTimePicker
            // 
            this.archiveDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.archiveBindingSource, "ArchiveDate", true));
            this.archiveDateDateTimePicker.Location = new System.Drawing.Point(183, 113);
            this.archiveDateDateTimePicker.Name = "archiveDateDateTimePicker";
            this.archiveDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.archiveDateDateTimePicker.TabIndex = 9;
            // 
            // archiveDescriptionTextBox
            // 
            this.archiveDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archiveBindingSource, "ArchiveDescription", true));
            this.archiveDescriptionTextBox.Location = new System.Drawing.Point(269, 49);
            this.archiveDescriptionTextBox.Name = "archiveDescriptionTextBox";
            this.archiveDescriptionTextBox.Size = new System.Drawing.Size(587, 34);
            this.archiveDescriptionTextBox.TabIndex = 8;
            this.archiveDescriptionTextBox.TextChanged += new System.EventHandler(this.archiveDescriptionTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(879, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 132);
            this.panel2.TabIndex = 6;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(14, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 23);
            this.button9.TabIndex = 3;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 23);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 23);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 317);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archive";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CaseID,
            this.ArchiveDescription,
            this.ArchiveDate});
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // archiveTableAdapter
            // 
            this.archiveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveTableAdapter = this.archiveTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CollabDocumTableAdapter = null;
            this.tableAdapterManager.CollaboratorsTableAdapter = null;
            this.tableAdapterManager.CollabPosadaTableAdapter = null;
            this.tableAdapterManager.CollabSecLevelTableAdapter = null;
            this.tableAdapterManager.DocumentTableAdapter = null;
            this.tableAdapterManager.DocumSecSecretTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.OperationTableAdapter = null;
            this.tableAdapterManager.PosadaTableAdapter = null;
            this.tableAdapterManager.SecLevelSecSecretTableAdapter = null;
            this.tableAdapterManager.SecretCaseTableAdapter = this.secretCaseTableAdapter;
            this.tableAdapterManager.SecurityLevelTableAdapter = null;
            this.tableAdapterManager.SecuritySecretTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // secretCaseTableAdapter
            // 
            this.secretCaseTableAdapter.ClearBeforeFill = true;
            // 
            // CaseID
            // 
            this.CaseID.HeaderText = "CaseID";
            this.CaseID.MinimumWidth = 6;
            this.CaseID.Name = "CaseID";
            this.CaseID.ReadOnly = true;
            this.CaseID.Width = 125;
            // 
            // ArchiveDescription
            // 
            this.ArchiveDescription.HeaderText = "Archive Description";
            this.ArchiveDescription.MinimumWidth = 6;
            this.ArchiveDescription.Name = "ArchiveDescription";
            this.ArchiveDescription.ReadOnly = true;
            this.ArchiveDescription.Width = 250;
            // 
            // ArchiveDate
            // 
            this.ArchiveDate.HeaderText = "Date Of Archiving ";
            this.ArchiveDate.MinimumWidth = 6;
            this.ArchiveDate.Name = "ArchiveDate";
            this.ArchiveDate.ReadOnly = true;
            this.ArchiveDate.Width = 240;
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretCaseBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SecurityServiceOfUkraineDataSet securityServiceOfUkraineDataSet;
        private System.Windows.Forms.BindingSource archiveBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.ArchiveTableAdapter archiveTableAdapter;
        private SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker archiveDateDateTimePicker;
        private System.Windows.Forms.TextBox archiveDescriptionTextBox;
        private SecurityServiceOfUkraineDataSetTableAdapters.SecretCaseTableAdapter secretCaseTableAdapter;
        private System.Windows.Forms.BindingSource secretCaseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArchiveDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArchiveDate;
    }
}