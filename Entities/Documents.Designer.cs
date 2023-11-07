namespace SSU
{
    partial class Documents
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
            System.Windows.Forms.Label documentIDLabel;
            System.Windows.Forms.Label documentNameLabel;
            System.Windows.Forms.Label documentDescriptionLabel;
            System.Windows.Forms.Label documentDateLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.documentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityServiceOfUkraineDataSet = new SSU.SecurityServiceOfUkraineDataSet();
            this.documentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.documentNameTextBox = new System.Windows.Forms.TextBox();
            this.documentIDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.documentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.DocumentTableAdapter();
            this.tableAdapterManager = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager();
            documentIDLabel = new System.Windows.Forms.Label();
            documentNameLabel = new System.Windows.Forms.Label();
            documentDescriptionLabel = new System.Windows.Forms.Label();
            documentDateLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentIDLabel
            // 
            documentIDLabel.AutoSize = true;
            documentIDLabel.Location = new System.Drawing.Point(6, 35);
            documentIDLabel.Name = "documentIDLabel";
            documentIDLabel.Size = new System.Drawing.Size(157, 29);
            documentIDLabel.TabIndex = 6;
            documentIDLabel.Text = "Document ID:";
            // 
            // documentNameLabel
            // 
            documentNameLabel.AutoSize = true;
            documentNameLabel.Location = new System.Drawing.Point(6, 78);
            documentNameLabel.Name = "documentNameLabel";
            documentNameLabel.Size = new System.Drawing.Size(199, 29);
            documentNameLabel.TabIndex = 7;
            documentNameLabel.Text = "Document Name:";
            // 
            // documentDescriptionLabel
            // 
            documentDescriptionLabel.AutoSize = true;
            documentDescriptionLabel.Location = new System.Drawing.Point(6, 135);
            documentDescriptionLabel.Name = "documentDescriptionLabel";
            documentDescriptionLabel.Size = new System.Drawing.Size(256, 29);
            documentDescriptionLabel.TabIndex = 8;
            documentDescriptionLabel.Text = "Document Description:";
            // 
            // documentDateLabel
            // 
            documentDateLabel.AutoSize = true;
            documentDateLabel.Location = new System.Drawing.Point(406, 37);
            documentDateLabel.Name = "documentDateLabel";
            documentDateLabel.Size = new System.Drawing.Size(184, 29);
            documentDateLabel.TabIndex = 9;
            documentDateLabel.Text = "Document Date:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(12, 482);
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
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(577, 482);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 56);
            this.panel4.TabIndex = 9;
            this.panel4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Decline";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(documentDateLabel);
            this.groupBox1.Controls.Add(this.documentDateDateTimePicker);
            this.groupBox1.Controls.Add(documentDescriptionLabel);
            this.groupBox1.Controls.Add(this.documentDescriptionTextBox);
            this.groupBox1.Controls.Add(documentNameLabel);
            this.groupBox1.Controls.Add(this.documentNameTextBox);
            this.groupBox1.Controls.Add(documentIDLabel);
            this.groupBox1.Controls.Add(this.documentIDTextBox);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 195);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Document";
            this.groupBox1.Visible = false;
            // 
            // documentDateDateTimePicker
            // 
            this.documentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documentBindingSource, "DocumentDate", true));
            this.documentDateDateTimePicker.Location = new System.Drawing.Point(596, 33);
            this.documentDateDateTimePicker.Name = "documentDateDateTimePicker";
            this.documentDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.documentDateDateTimePicker.TabIndex = 10;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "Document";
            this.documentBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // securityServiceOfUkraineDataSet
            // 
            this.securityServiceOfUkraineDataSet.DataSetName = "SecurityServiceOfUkraineDataSet";
            this.securityServiceOfUkraineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentDescriptionTextBox
            // 
            this.documentDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "DocumentDescription", true));
            this.documentDescriptionTextBox.Location = new System.Drawing.Point(275, 132);
            this.documentDescriptionTextBox.Name = "documentDescriptionTextBox";
            this.documentDescriptionTextBox.Size = new System.Drawing.Size(478, 34);
            this.documentDescriptionTextBox.TabIndex = 9;
            // 
            // documentNameTextBox
            // 
            this.documentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "DocumentName", true));
            this.documentNameTextBox.Location = new System.Drawing.Point(211, 75);
            this.documentNameTextBox.Name = "documentNameTextBox";
            this.documentNameTextBox.Size = new System.Drawing.Size(164, 34);
            this.documentNameTextBox.TabIndex = 8;
            // 
            // documentIDTextBox
            // 
            this.documentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSource, "DocumentID", true));
            this.documentIDTextBox.Location = new System.Drawing.Point(169, 32);
            this.documentIDTextBox.Name = "documentIDTextBox";
            this.documentIDTextBox.ReadOnly = true;
            this.documentIDTextBox.Size = new System.Drawing.Size(142, 34);
            this.documentIDTextBox.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(812, 32);
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
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 23);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 23);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 263);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentIDDataGridViewTextBoxColumn,
            this.documentNameDataGridViewTextBoxColumn,
            this.documentDescriptionDataGridViewTextBoxColumn,
            this.documentDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(862, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // documentIDDataGridViewTextBoxColumn
            // 
            this.documentIDDataGridViewTextBoxColumn.DataPropertyName = "DocumentID";
            this.documentIDDataGridViewTextBoxColumn.HeaderText = "DocumentID";
            this.documentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentIDDataGridViewTextBoxColumn.Name = "documentIDDataGridViewTextBoxColumn";
            this.documentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentNameDataGridViewTextBoxColumn
            // 
            this.documentNameDataGridViewTextBoxColumn.DataPropertyName = "DocumentName";
            this.documentNameDataGridViewTextBoxColumn.HeaderText = "DocumentName";
            this.documentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentNameDataGridViewTextBoxColumn.Name = "documentNameDataGridViewTextBoxColumn";
            this.documentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentDescriptionDataGridViewTextBoxColumn
            // 
            this.documentDescriptionDataGridViewTextBoxColumn.DataPropertyName = "DocumentDescription";
            this.documentDescriptionDataGridViewTextBoxColumn.HeaderText = "DocumentDescription";
            this.documentDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentDescriptionDataGridViewTextBoxColumn.Name = "documentDescriptionDataGridViewTextBoxColumn";
            this.documentDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentDateDataGridViewTextBoxColumn
            // 
            this.documentDateDataGridViewTextBoxColumn.DataPropertyName = "DocumentDate";
            this.documentDateDataGridViewTextBoxColumn.HeaderText = "DocumentDate";
            this.documentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentDateDataGridViewTextBoxColumn.Name = "documentDateDataGridViewTextBoxColumn";
            this.documentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CollabDocumTableAdapter = null;
            this.tableAdapterManager.CollaboratorsTableAdapter = null;
            this.tableAdapterManager.CollabPosadaTableAdapter = null;
            this.tableAdapterManager.CollabSecLevelTableAdapter = null;
            this.tableAdapterManager.DocumentTableAdapter = this.documentTableAdapter;
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
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Documents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documents";
            this.Load += new System.EventHandler(this.Documents_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource documentBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.DocumentTableAdapter documentTableAdapter;
        private System.Windows.Forms.DateTimePicker documentDateDateTimePicker;
        private System.Windows.Forms.TextBox documentDescriptionTextBox;
        private System.Windows.Forms.TextBox documentNameTextBox;
        private System.Windows.Forms.TextBox documentIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDateDataGridViewTextBoxColumn;
        private SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}