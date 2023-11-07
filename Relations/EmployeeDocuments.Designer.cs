namespace SSU
{
    partial class EmployeeDocuments
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
            System.Windows.Forms.Label collaboratorNameLabel;
            System.Windows.Forms.Label documentNameLabel;
            System.Windows.Forms.Label collabDocumIDLabel;
            System.Windows.Forms.Label collabDocumDateOfEndLabel;
            System.Windows.Forms.Label collabDocumDateOfStartLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.collabDocumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityServiceOfUkraineDataSet = new SSU.SecurityServiceOfUkraineDataSet();
            this.collaboratorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collabDocumDateOfStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.collabDocumDateOfEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collabDocumIDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.collaboratorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollaboratorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collaboratorsTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.CollaboratorsTableAdapter();
            this.tableAdapterManager = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager();
            this.collabDocumTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.CollabDocumTableAdapter();
            this.documentTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.DocumentTableAdapter();
            collaboratorNameLabel = new System.Windows.Forms.Label();
            documentNameLabel = new System.Windows.Forms.Label();
            collabDocumIDLabel = new System.Windows.Forms.Label();
            collabDocumDateOfEndLabel = new System.Windows.Forms.Label();
            collabDocumDateOfStartLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collabDocumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collaboratorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaboratorsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // collaboratorNameLabel
            // 
            collaboratorNameLabel.AutoSize = true;
            collaboratorNameLabel.Location = new System.Drawing.Point(23, 91);
            collaboratorNameLabel.Name = "collaboratorNameLabel";
            collaboratorNameLabel.Size = new System.Drawing.Size(223, 29);
            collaboratorNameLabel.TabIndex = 7;
            collaboratorNameLabel.Text = "Collaborator Name:";
            // 
            // documentNameLabel
            // 
            documentNameLabel.AutoSize = true;
            documentNameLabel.Location = new System.Drawing.Point(24, 143);
            documentNameLabel.Name = "documentNameLabel";
            documentNameLabel.Size = new System.Drawing.Size(199, 29);
            documentNameLabel.TabIndex = 8;
            documentNameLabel.Text = "Document Name:";
            // 
            // collabDocumIDLabel
            // 
            collabDocumIDLabel.AutoSize = true;
            collabDocumIDLabel.Location = new System.Drawing.Point(23, 36);
            collabDocumIDLabel.Name = "collabDocumIDLabel";
            collabDocumIDLabel.Size = new System.Drawing.Size(200, 29);
            collabDocumIDLabel.TabIndex = 8;
            collabDocumIDLabel.Text = "Collab Docum ID:";
            // 
            // collabDocumDateOfEndLabel
            // 
            collabDocumDateOfEndLabel.AutoSize = true;
            collabDocumDateOfEndLabel.Location = new System.Drawing.Point(572, 160);
            collabDocumDateOfEndLabel.Name = "collabDocumDateOfEndLabel";
            collabDocumDateOfEndLabel.Size = new System.Drawing.Size(307, 29);
            collabDocumDateOfEndLabel.TabIndex = 13;
            collabDocumDateOfEndLabel.Text = "Collab Docum Date Of End:";
            // 
            // collabDocumDateOfStartLabel
            // 
            collabDocumDateOfStartLabel.AutoSize = true;
            collabDocumDateOfStartLabel.Location = new System.Drawing.Point(572, 91);
            collabDocumDateOfStartLabel.Name = "collabDocumDateOfStartLabel";
            collabDocumDateOfStartLabel.Size = new System.Drawing.Size(313, 29);
            collabDocumDateOfStartLabel.TabIndex = 14;
            collabDocumDateOfStartLabel.Text = "Collab Docum Date Of Start:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(12, 521);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 56);
            this.panel3.TabIndex = 9;
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
            this.panel4.Location = new System.Drawing.Point(873, 521);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 56);
            this.panel4.TabIndex = 10;
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
            this.groupBox1.Controls.Add(collabDocumDateOfStartLabel);
            this.groupBox1.Controls.Add(this.collabDocumDateOfStartDateTimePicker);
            this.groupBox1.Controls.Add(collabDocumDateOfEndLabel);
            this.groupBox1.Controls.Add(this.collabDocumDateOfEndDateTimePicker);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(collabDocumIDLabel);
            this.groupBox1.Controls.Add(this.collabDocumIDTextBox);
            this.groupBox1.Controls.Add(documentNameLabel);
            this.groupBox1.Controls.Add(collaboratorNameLabel);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 210);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Document for Employee";
            this.groupBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.collabDocumBindingSource, "CollaboratorID", true));
            this.comboBox1.DataSource = this.collaboratorsBindingSource1;
            this.comboBox1.DisplayMember = "CollaboratorName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 37);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "CollaboratorID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // collabDocumBindingSource
            // 
            this.collabDocumBindingSource.DataMember = "CollabDocum";
            this.collabDocumBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // securityServiceOfUkraineDataSet
            // 
            this.securityServiceOfUkraineDataSet.DataSetName = "SecurityServiceOfUkraineDataSet";
            this.securityServiceOfUkraineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collaboratorsBindingSource1
            // 
            this.collaboratorsBindingSource1.DataMember = "Collaborators";
            this.collaboratorsBindingSource1.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // collabDocumDateOfStartDateTimePicker
            // 
            this.collabDocumDateOfStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.collabDocumBindingSource, "CollabDocumDateOfStart", true));
            this.collabDocumDateOfStartDateTimePicker.Location = new System.Drawing.Point(891, 87);
            this.collabDocumDateOfStartDateTimePicker.Name = "collabDocumDateOfStartDateTimePicker";
            this.collabDocumDateOfStartDateTimePicker.Size = new System.Drawing.Size(194, 34);
            this.collabDocumDateOfStartDateTimePicker.TabIndex = 15;
            // 
            // collabDocumDateOfEndDateTimePicker
            // 
            this.collabDocumDateOfEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.collabDocumBindingSource, "CollabDocumDateOfEnd", true));
            this.collabDocumDateOfEndDateTimePicker.Location = new System.Drawing.Point(885, 156);
            this.collabDocumDateOfEndDateTimePicker.Name = "collabDocumDateOfEndDateTimePicker";
            this.collabDocumDateOfEndDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.collabDocumDateOfEndDateTimePicker.TabIndex = 14;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(472, 149);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 40);
            this.button11.TabIndex = 13;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(472, 88);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 41);
            this.button10.TabIndex = 12;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.collabDocumBindingSource, "DocumentID", true));
            this.comboBox2.DataSource = this.documentBindingSource;
            this.comboBox2.DisplayMember = "DocumentName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(252, 146);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 37);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "DocumentID";
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "Document";
            this.documentBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // collabDocumIDTextBox
            // 
            this.collabDocumIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.collabDocumBindingSource, "CollabDocumID", true));
            this.collabDocumIDTextBox.Location = new System.Drawing.Point(229, 33);
            this.collabDocumIDTextBox.Name = "collabDocumIDTextBox";
            this.collabDocumIDTextBox.ReadOnly = true;
            this.collabDocumIDTextBox.Size = new System.Drawing.Size(100, 34);
            this.collabDocumIDTextBox.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(1101, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 132);
            this.panel2.TabIndex = 7;
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
            // collaboratorsBindingSource
            // 
            this.collaboratorsBindingSource.DataMember = "Collaborators";
            this.collaboratorsBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1165, 287);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees Documents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CollaboratorName,
            this.DocumentName,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // CollaboratorName
            // 
            this.CollaboratorName.HeaderText = "Employee Name";
            this.CollaboratorName.MinimumWidth = 6;
            this.CollaboratorName.Name = "CollaboratorName";
            this.CollaboratorName.ReadOnly = true;
            this.CollaboratorName.Width = 175;
            // 
            // DocumentName
            // 
            this.DocumentName.HeaderText = "DocumentName";
            this.DocumentName.MinimumWidth = 6;
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.ReadOnly = true;
            this.DocumentName.Width = 175;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DateOfStart";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DateOfEnd";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // collaboratorsTableAdapter
            // 
            this.collaboratorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CollabDocumTableAdapter = this.collabDocumTableAdapter;
            this.tableAdapterManager.CollaboratorsTableAdapter = this.collaboratorsTableAdapter;
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
            // collabDocumTableAdapter
            // 
            this.collabDocumTableAdapter.ClearBeforeFill = true;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeDocuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDocuments";
            this.Load += new System.EventHandler(this.EmployeeDocuments_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collabDocumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collaboratorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collaboratorsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollaboratorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private SecurityServiceOfUkraineDataSet securityServiceOfUkraineDataSet;
        private System.Windows.Forms.BindingSource collaboratorsBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.CollaboratorsTableAdapter collaboratorsTableAdapter;
        private SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SecurityServiceOfUkraineDataSetTableAdapters.DocumentTableAdapter documentTableAdapter;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.CollabDocumTableAdapter collabDocumTableAdapter;
        private System.Windows.Forms.BindingSource collabDocumBindingSource;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox collabDocumIDTextBox;
        private System.Windows.Forms.DateTimePicker collabDocumDateOfStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker collabDocumDateOfEndDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource collaboratorsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}