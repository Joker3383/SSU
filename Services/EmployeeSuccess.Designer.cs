namespace SSU.Services
{
    partial class EmployeeSuccess
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.collaboratorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collaboratorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDateOfStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDateOfEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretCaseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getEmployeePerformanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityServiceOfUkraineDataSet = new SSU.SecurityServiceOfUkraineDataSet();
            this.getEmployeePerformanceTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.GetEmployeePerformanceTableAdapter();
            this.tableAdapterManager = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeePerformanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 323);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1362, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Parameter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1202, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(687, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 34);
            this.textBox4.TabIndex = 7;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(687, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 34);
            this.textBox3.TabIndex = 6;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 34);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(530, 110);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(151, 33);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Equipment";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(530, 51);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(126, 33);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Location";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 113);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(167, 33);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Secret Case";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(253, 33);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Surname Employee ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(14, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(1376, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Success Employees";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collaboratorNameDataGridViewTextBoxColumn,
            this.collaboratorSurnameDataGridViewTextBoxColumn,
            this.operationIDDataGridViewTextBoxColumn,
            this.operationDescriptionDataGridViewTextBoxColumn,
            this.operationDateOfStartDataGridViewTextBoxColumn,
            this.operationDateOfEndDataGridViewTextBoxColumn,
            this.secretCaseNameDataGridViewTextBoxColumn,
            this.locationAdressDataGridViewTextBoxColumn,
            this.equipmentNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getEmployeePerformanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1360, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1390, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "fillToolStrip";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 39);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 39);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(818, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 39);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(818, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 39);
            this.button5.TabIndex = 13;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // collaboratorNameDataGridViewTextBoxColumn
            // 
            this.collaboratorNameDataGridViewTextBoxColumn.DataPropertyName = "CollaboratorName";
            this.collaboratorNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.collaboratorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.collaboratorNameDataGridViewTextBoxColumn.Name = "collaboratorNameDataGridViewTextBoxColumn";
            this.collaboratorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // collaboratorSurnameDataGridViewTextBoxColumn
            // 
            this.collaboratorSurnameDataGridViewTextBoxColumn.DataPropertyName = "CollaboratorSurname";
            this.collaboratorSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.collaboratorSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.collaboratorSurnameDataGridViewTextBoxColumn.Name = "collaboratorSurnameDataGridViewTextBoxColumn";
            this.collaboratorSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // operationIDDataGridViewTextBoxColumn
            // 
            this.operationIDDataGridViewTextBoxColumn.DataPropertyName = "OperationID";
            this.operationIDDataGridViewTextBoxColumn.HeaderText = "OperationID";
            this.operationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationIDDataGridViewTextBoxColumn.Name = "operationIDDataGridViewTextBoxColumn";
            this.operationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.operationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // operationDescriptionDataGridViewTextBoxColumn
            // 
            this.operationDescriptionDataGridViewTextBoxColumn.DataPropertyName = "OperationDescription";
            this.operationDescriptionDataGridViewTextBoxColumn.HeaderText = "Operation Description";
            this.operationDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationDescriptionDataGridViewTextBoxColumn.Name = "operationDescriptionDataGridViewTextBoxColumn";
            this.operationDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // operationDateOfStartDataGridViewTextBoxColumn
            // 
            this.operationDateOfStartDataGridViewTextBoxColumn.DataPropertyName = "OperationDateOfStart";
            this.operationDateOfStartDataGridViewTextBoxColumn.HeaderText = "Operation Start";
            this.operationDateOfStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationDateOfStartDataGridViewTextBoxColumn.Name = "operationDateOfStartDataGridViewTextBoxColumn";
            this.operationDateOfStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // operationDateOfEndDataGridViewTextBoxColumn
            // 
            this.operationDateOfEndDataGridViewTextBoxColumn.DataPropertyName = "OperationDateOfEnd";
            this.operationDateOfEndDataGridViewTextBoxColumn.HeaderText = "Operation End";
            this.operationDateOfEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationDateOfEndDataGridViewTextBoxColumn.Name = "operationDateOfEndDataGridViewTextBoxColumn";
            this.operationDateOfEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // secretCaseNameDataGridViewTextBoxColumn
            // 
            this.secretCaseNameDataGridViewTextBoxColumn.DataPropertyName = "SecretCaseName";
            this.secretCaseNameDataGridViewTextBoxColumn.HeaderText = "Secret Case";
            this.secretCaseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secretCaseNameDataGridViewTextBoxColumn.Name = "secretCaseNameDataGridViewTextBoxColumn";
            this.secretCaseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationAdressDataGridViewTextBoxColumn
            // 
            this.locationAdressDataGridViewTextBoxColumn.DataPropertyName = "LocationAdress";
            this.locationAdressDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationAdressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationAdressDataGridViewTextBoxColumn.Name = "locationAdressDataGridViewTextBoxColumn";
            this.locationAdressDataGridViewTextBoxColumn.Width = 125;
            // 
            // equipmentNameDataGridViewTextBoxColumn
            // 
            this.equipmentNameDataGridViewTextBoxColumn.DataPropertyName = "EquipmentName";
            this.equipmentNameDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.equipmentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.equipmentNameDataGridViewTextBoxColumn.Name = "equipmentNameDataGridViewTextBoxColumn";
            this.equipmentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // getEmployeePerformanceBindingSource
            // 
            this.getEmployeePerformanceBindingSource.DataMember = "GetEmployeePerformance";
            this.getEmployeePerformanceBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // securityServiceOfUkraineDataSet
            // 
            this.securityServiceOfUkraineDataSet.DataSetName = "SecurityServiceOfUkraineDataSet";
            this.securityServiceOfUkraineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // EmployeeSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 514);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeSuccess";
            this.Text = "EmployeeSuccess";
            this.Load += new System.EventHandler(this.EmployeeSuccess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeePerformanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SecurityServiceOfUkraineDataSet securityServiceOfUkraineDataSet;
        private System.Windows.Forms.BindingSource getEmployeePerformanceBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.GetEmployeePerformanceTableAdapter getEmployeePerformanceTableAdapter;
        private SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn collaboratorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collaboratorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDateOfStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDateOfEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secretCaseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentNameDataGridViewTextBoxColumn;
    }
}