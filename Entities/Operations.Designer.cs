namespace SSU
{
    partial class Operations
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
            System.Windows.Forms.Label operationIDLabel;
            System.Windows.Forms.Label secretCaseIDLabel;
            System.Windows.Forms.Label equipmentIDLabel;
            System.Windows.Forms.Label locationIDLabel;
            System.Windows.Forms.Label collaboratorIDLabel;
            System.Windows.Forms.Label operationDescriptionLabel;
            System.Windows.Forms.Label operationDateOfStartLabel;
            System.Windows.Forms.Label operationDateOfEndLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityServiceOfUkraineDataSet = new SSU.SecurityServiceOfUkraineDataSet();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.secretCaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.collaboratorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.operationDateOfEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.operationDateOfStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.operationIDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.OperationTableAdapter();
            this.tableAdapterManager = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager();
            this.collaboratorsTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.CollaboratorsTableAdapter();
            this.equipmentTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.EquipmentTableAdapter();
            this.locationTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.LocationTableAdapter();
            this.secretCaseTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.SecretCaseTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            operationIDLabel = new System.Windows.Forms.Label();
            secretCaseIDLabel = new System.Windows.Forms.Label();
            equipmentIDLabel = new System.Windows.Forms.Label();
            locationIDLabel = new System.Windows.Forms.Label();
            collaboratorIDLabel = new System.Windows.Forms.Label();
            operationDescriptionLabel = new System.Windows.Forms.Label();
            operationDateOfStartLabel = new System.Windows.Forms.Label();
            operationDateOfEndLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretCaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collaboratorsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // operationIDLabel
            // 
            operationIDLabel.AutoSize = true;
            operationIDLabel.Location = new System.Drawing.Point(6, 33);
            operationIDLabel.Name = "operationIDLabel";
            operationIDLabel.Size = new System.Drawing.Size(155, 29);
            operationIDLabel.TabIndex = 7;
            operationIDLabel.Text = "Operation ID:";
            // 
            // secretCaseIDLabel
            // 
            secretCaseIDLabel.AutoSize = true;
            secretCaseIDLabel.Location = new System.Drawing.Point(6, 81);
            secretCaseIDLabel.Name = "secretCaseIDLabel";
            secretCaseIDLabel.Size = new System.Drawing.Size(180, 29);
            secretCaseIDLabel.TabIndex = 8;
            secretCaseIDLabel.Text = "Secret Case ID:";
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(6, 183);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(164, 29);
            equipmentIDLabel.TabIndex = 9;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // locationIDLabel
            // 
            locationIDLabel.AutoSize = true;
            locationIDLabel.Location = new System.Drawing.Point(6, 129);
            locationIDLabel.Name = "locationIDLabel";
            locationIDLabel.Size = new System.Drawing.Size(139, 29);
            locationIDLabel.TabIndex = 10;
            locationIDLabel.Text = "Location ID:";
            // 
            // collaboratorIDLabel
            // 
            collaboratorIDLabel.AutoSize = true;
            collaboratorIDLabel.Location = new System.Drawing.Point(780, 36);
            collaboratorIDLabel.Name = "collaboratorIDLabel";
            collaboratorIDLabel.Size = new System.Drawing.Size(181, 29);
            collaboratorIDLabel.TabIndex = 11;
            collaboratorIDLabel.Text = "Collaborator ID:";
            // 
            // operationDescriptionLabel
            // 
            operationDescriptionLabel.AutoSize = true;
            operationDescriptionLabel.Location = new System.Drawing.Point(314, 180);
            operationDescriptionLabel.Name = "operationDescriptionLabel";
            operationDescriptionLabel.Size = new System.Drawing.Size(254, 29);
            operationDescriptionLabel.TabIndex = 12;
            operationDescriptionLabel.Text = "Operation Description:";
            // 
            // operationDateOfStartLabel
            // 
            operationDateOfStartLabel.AutoSize = true;
            operationDateOfStartLabel.Location = new System.Drawing.Point(300, 33);
            operationDateOfStartLabel.Name = "operationDateOfStartLabel";
            operationDateOfStartLabel.Size = new System.Drawing.Size(268, 29);
            operationDateOfStartLabel.TabIndex = 13;
            operationDateOfStartLabel.Text = "Operation Date Of Start:";
            // 
            // operationDateOfEndLabel
            // 
            operationDateOfEndLabel.AutoSize = true;
            operationDateOfEndLabel.Location = new System.Drawing.Point(306, 81);
            operationDateOfEndLabel.Name = "operationDateOfEndLabel";
            operationDateOfEndLabel.Size = new System.Drawing.Size(262, 29);
            operationDateOfEndLabel.TabIndex = 15;
            operationDateOfEndLabel.Text = "Operation Date Of End:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(12, 641);
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
            this.panel4.Location = new System.Drawing.Point(865, 641);
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
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.operationDescriptionTextBox);
            this.groupBox1.Controls.Add(operationDescriptionLabel);
            this.groupBox1.Controls.Add(operationDateOfEndLabel);
            this.groupBox1.Controls.Add(this.operationDateOfEndDateTimePicker);
            this.groupBox1.Controls.Add(operationDateOfStartLabel);
            this.groupBox1.Controls.Add(this.operationDateOfStartDateTimePicker);
            this.groupBox1.Controls.Add(collaboratorIDLabel);
            this.groupBox1.Controls.Add(locationIDLabel);
            this.groupBox1.Controls.Add(equipmentIDLabel);
            this.groupBox1.Controls.Add(secretCaseIDLabel);
            this.groupBox1.Controls.Add(operationIDLabel);
            this.groupBox1.Controls.Add(this.operationIDTextBox);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1167, 237);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Operation";
            this.groupBox1.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.operationBindingSource, "EquipmentID", true));
            this.comboBox4.DataSource = this.equipmentBindingSource;
            this.comboBox4.DisplayMember = "NameEquip";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(171, 177);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(129, 37);
            this.comboBox4.TabIndex = 20;
            this.comboBox4.ValueMember = "EquipmentID";
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataMember = "Operation";
            this.operationBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // securityServiceOfUkraineDataSet
            // 
            this.securityServiceOfUkraineDataSet.DataSetName = "SecurityServiceOfUkraineDataSet";
            this.securityServiceOfUkraineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.operationBindingSource, "SecretCaseID", true));
            this.comboBox3.DataSource = this.secretCaseBindingSource;
            this.comboBox3.DisplayMember = "SecretCaseName";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(179, 78);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 37);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.ValueMember = "SecretCaseID";
            // 
            // secretCaseBindingSource
            // 
            this.secretCaseBindingSource.DataMember = "SecretCase";
            this.secretCaseBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.operationBindingSource, "LocationID", true));
            this.comboBox2.DataSource = this.locationBindingSource;
            this.comboBox2.DisplayMember = "Adress";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(156, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 37);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.ValueMember = "LocationID";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.operationBindingSource, "CollaboratorID", true));
            this.comboBox1.DataSource = this.collaboratorsBindingSource;
            this.comboBox1.DisplayMember = "CollaboratorName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(966, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "CollaboratorID";
            // 
            // collaboratorsBindingSource
            // 
            this.collaboratorsBindingSource.DataMember = "Collaborators";
            this.collaboratorsBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // operationDescriptionTextBox
            // 
            this.operationDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "OperationDescription", true));
            this.operationDescriptionTextBox.Location = new System.Drawing.Point(574, 180);
            this.operationDescriptionTextBox.Name = "operationDescriptionTextBox";
            this.operationDescriptionTextBox.Size = new System.Drawing.Size(493, 34);
            this.operationDescriptionTextBox.TabIndex = 13;
            // 
            // operationDateOfEndDateTimePicker
            // 
            this.operationDateOfEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.operationBindingSource, "OperationDateOfEnd", true));
            this.operationDateOfEndDateTimePicker.Location = new System.Drawing.Point(574, 81);
            this.operationDateOfEndDateTimePicker.Name = "operationDateOfEndDateTimePicker";
            this.operationDateOfEndDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.operationDateOfEndDateTimePicker.TabIndex = 16;
            // 
            // operationDateOfStartDateTimePicker
            // 
            this.operationDateOfStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.operationBindingSource, "OperationDateOfStart", true));
            this.operationDateOfStartDateTimePicker.Location = new System.Drawing.Point(574, 33);
            this.operationDateOfStartDateTimePicker.Name = "operationDateOfStartDateTimePicker";
            this.operationDateOfStartDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.operationDateOfStartDateTimePicker.TabIndex = 14;
            // 
            // operationIDTextBox
            // 
            this.operationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "OperationID", true));
            this.operationIDTextBox.Location = new System.Drawing.Point(172, 33);
            this.operationIDTextBox.Name = "operationIDTextBox";
            this.operationIDTextBox.ReadOnly = true;
            this.operationIDTextBox.Size = new System.Drawing.Size(120, 34);
            this.operationIDTextBox.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(1093, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 184);
            this.panel2.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(14, 14);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 35);
            this.button9.TabIndex = 3;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 35);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 30);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 35);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1157, 374);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // operationTableAdapter
            // 
            this.operationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CollabDocumTableAdapter = null;
            this.tableAdapterManager.CollaboratorsTableAdapter = this.collaboratorsTableAdapter;
            this.tableAdapterManager.CollabPosadaTableAdapter = null;
            this.tableAdapterManager.CollabSecLevelTableAdapter = null;
            this.tableAdapterManager.DocumentTableAdapter = null;
            this.tableAdapterManager.DocumSecSecretTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = this.equipmentTableAdapter;
            this.tableAdapterManager.LocationTableAdapter = this.locationTableAdapter;
            this.tableAdapterManager.OperationTableAdapter = this.operationTableAdapter;
            this.tableAdapterManager.PosadaTableAdapter = null;
            this.tableAdapterManager.SecLevelSecSecretTableAdapter = null;
            this.tableAdapterManager.SecretCaseTableAdapter = this.secretCaseTableAdapter;
            this.tableAdapterManager.SecurityLevelTableAdapter = null;
            this.tableAdapterManager.SecuritySecretTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // collaboratorsTableAdapter
            // 
            this.collaboratorsTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // secretCaseTableAdapter
            // 
            this.secretCaseTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CaseID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "EquipID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LocationID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "EmployeeID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 135;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 135;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date Of Start";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date Of End";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 707);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Operations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.Operations_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretCaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collaboratorsBindingSource)).EndInit();
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
        private SecurityServiceOfUkraineDataSet securityServiceOfUkraineDataSet;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.OperationTableAdapter operationTableAdapter;
        private SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker operationDateOfEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker operationDateOfStartDateTimePicker;
        private System.Windows.Forms.TextBox operationDescriptionTextBox;
        private System.Windows.Forms.TextBox operationIDTextBox;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SecurityServiceOfUkraineDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.SecretCaseTableAdapter secretCaseTableAdapter;
        private System.Windows.Forms.BindingSource secretCaseBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.CollaboratorsTableAdapter collaboratorsTableAdapter;
        private System.Windows.Forms.BindingSource collaboratorsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}