namespace SSU
{
    partial class Cases
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
            System.Windows.Forms.Label secretCaseNameLabel;
            System.Windows.Forms.Label secretCaseStatusLabel;
            System.Windows.Forms.Label secretCaseDescriptionLabel;
            System.Windows.Forms.Label secretCaseDateStartLabel;
            System.Windows.Forms.Label secretCaseDateEndLabel;
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secretCaseDateEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.secretCaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityServiceOfUkraineDataSet = new SSU.SecurityServiceOfUkraineDataSet();
            this.secretCaseDateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.secretCaseDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.secretCaseStatusTextBox = new System.Windows.Forms.TextBox();
            this.secretCaseNameTextBox = new System.Windows.Forms.TextBox();
            this.secretCaseIDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.secretCaseTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.SecretCaseTableAdapter();
            this.tableAdapterManager = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            secretCaseIDLabel = new System.Windows.Forms.Label();
            secretCaseNameLabel = new System.Windows.Forms.Label();
            secretCaseStatusLabel = new System.Windows.Forms.Label();
            secretCaseDescriptionLabel = new System.Windows.Forms.Label();
            secretCaseDateStartLabel = new System.Windows.Forms.Label();
            secretCaseDateEndLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretCaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // secretCaseIDLabel
            // 
            secretCaseIDLabel.AutoSize = true;
            secretCaseIDLabel.Location = new System.Drawing.Point(6, 30);
            secretCaseIDLabel.Name = "secretCaseIDLabel";
            secretCaseIDLabel.Size = new System.Drawing.Size(180, 29);
            secretCaseIDLabel.TabIndex = 5;
            secretCaseIDLabel.Text = "Secret Case ID:";
            // 
            // secretCaseNameLabel
            // 
            secretCaseNameLabel.AutoSize = true;
            secretCaseNameLabel.Location = new System.Drawing.Point(6, 79);
            secretCaseNameLabel.Name = "secretCaseNameLabel";
            secretCaseNameLabel.Size = new System.Drawing.Size(222, 29);
            secretCaseNameLabel.TabIndex = 6;
            secretCaseNameLabel.Text = "Secret Case Name:";
            // 
            // secretCaseStatusLabel
            // 
            secretCaseStatusLabel.AutoSize = true;
            secretCaseStatusLabel.Location = new System.Drawing.Point(6, 127);
            secretCaseStatusLabel.Name = "secretCaseStatusLabel";
            secretCaseStatusLabel.Size = new System.Drawing.Size(223, 29);
            secretCaseStatusLabel.TabIndex = 7;
            secretCaseStatusLabel.Text = "Secret Case Status:";
            // 
            // secretCaseDescriptionLabel
            // 
            secretCaseDescriptionLabel.AutoSize = true;
            secretCaseDescriptionLabel.Location = new System.Drawing.Point(354, 27);
            secretCaseDescriptionLabel.Name = "secretCaseDescriptionLabel";
            secretCaseDescriptionLabel.Size = new System.Drawing.Size(279, 29);
            secretCaseDescriptionLabel.TabIndex = 8;
            secretCaseDescriptionLabel.Text = "Secret Case Description:";
            // 
            // secretCaseDateStartLabel
            // 
            secretCaseDateStartLabel.AutoSize = true;
            secretCaseDateStartLabel.Location = new System.Drawing.Point(477, 108);
            secretCaseDateStartLabel.Name = "secretCaseDateStartLabel";
            secretCaseDateStartLabel.Size = new System.Drawing.Size(262, 29);
            secretCaseDateStartLabel.TabIndex = 9;
            secretCaseDateStartLabel.Text = "Secret Case Date Start:";
            // 
            // secretCaseDateEndLabel
            // 
            secretCaseDateEndLabel.AutoSize = true;
            secretCaseDateEndLabel.Location = new System.Drawing.Point(483, 150);
            secretCaseDateEndLabel.Name = "secretCaseDateEndLabel";
            secretCaseDateEndLabel.Size = new System.Drawing.Size(256, 29);
            secretCaseDateEndLabel.TabIndex = 11;
            secretCaseDateEndLabel.Text = "Secret Case Date End:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(12, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 56);
            this.panel3.TabIndex = 7;
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
            this.panel4.Location = new System.Drawing.Point(731, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 45);
            this.panel4.TabIndex = 8;
            this.panel4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Decline";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(secretCaseDateEndLabel);
            this.groupBox1.Controls.Add(this.secretCaseDateEndDateTimePicker);
            this.groupBox1.Controls.Add(secretCaseDateStartLabel);
            this.groupBox1.Controls.Add(this.secretCaseDateStartDateTimePicker);
            this.groupBox1.Controls.Add(secretCaseDescriptionLabel);
            this.groupBox1.Controls.Add(this.secretCaseDescriptionTextBox);
            this.groupBox1.Controls.Add(secretCaseStatusLabel);
            this.groupBox1.Controls.Add(this.secretCaseStatusTextBox);
            this.groupBox1.Controls.Add(secretCaseNameLabel);
            this.groupBox1.Controls.Add(this.secretCaseNameTextBox);
            this.groupBox1.Controls.Add(secretCaseIDLabel);
            this.groupBox1.Controls.Add(this.secretCaseIDTextBox);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 196);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add case ";
            this.groupBox1.Visible = false;
            // 
            // secretCaseDateEndDateTimePicker
            // 
            this.secretCaseDateEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.secretCaseBindingSource, "SecretCaseDateEnd", true));
            this.secretCaseDateEndDateTimePicker.Enabled = false;
            this.secretCaseDateEndDateTimePicker.Location = new System.Drawing.Point(745, 146);
            this.secretCaseDateEndDateTimePicker.Name = "secretCaseDateEndDateTimePicker";
            this.secretCaseDateEndDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.secretCaseDateEndDateTimePicker.TabIndex = 12;
            // 
            // secretCaseBindingSource
            // 
            this.secretCaseBindingSource.DataMember = "SecretCase";
            this.secretCaseBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // securityServiceOfUkraineDataSet
            // 
            this.securityServiceOfUkraineDataSet.DataSetName = "SecurityServiceOfUkraineDataSet";
            this.securityServiceOfUkraineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // secretCaseDateStartDateTimePicker
            // 
            this.secretCaseDateStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.secretCaseBindingSource, "SecretCaseDateStart", true));
            this.secretCaseDateStartDateTimePicker.Enabled = false;
            this.secretCaseDateStartDateTimePicker.Location = new System.Drawing.Point(745, 103);
            this.secretCaseDateStartDateTimePicker.Name = "secretCaseDateStartDateTimePicker";
            this.secretCaseDateStartDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.secretCaseDateStartDateTimePicker.TabIndex = 10;
            // 
            // secretCaseDescriptionTextBox
            // 
            this.secretCaseDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.secretCaseBindingSource, "SecretCaseDescription", true));
            this.secretCaseDescriptionTextBox.Location = new System.Drawing.Point(639, 24);
            this.secretCaseDescriptionTextBox.Name = "secretCaseDescriptionTextBox";
            this.secretCaseDescriptionTextBox.Size = new System.Drawing.Size(306, 34);
            this.secretCaseDescriptionTextBox.TabIndex = 9;
            // 
            // secretCaseStatusTextBox
            // 
            this.secretCaseStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.secretCaseBindingSource, "SecretCaseStatus", true));
            this.secretCaseStatusTextBox.Location = new System.Drawing.Point(235, 124);
            this.secretCaseStatusTextBox.Name = "secretCaseStatusTextBox";
            this.secretCaseStatusTextBox.Size = new System.Drawing.Size(178, 34);
            this.secretCaseStatusTextBox.TabIndex = 8;
            // 
            // secretCaseNameTextBox
            // 
            this.secretCaseNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.secretCaseBindingSource, "SecretCaseName", true));
            this.secretCaseNameTextBox.Location = new System.Drawing.Point(234, 76);
            this.secretCaseNameTextBox.Name = "secretCaseNameTextBox";
            this.secretCaseNameTextBox.Size = new System.Drawing.Size(179, 34);
            this.secretCaseNameTextBox.TabIndex = 7;
            // 
            // secretCaseIDTextBox
            // 
            this.secretCaseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.secretCaseBindingSource, "SecretCaseID", true));
            this.secretCaseIDTextBox.Location = new System.Drawing.Point(192, 27);
            this.secretCaseIDTextBox.Name = "secretCaseIDTextBox";
            this.secretCaseIDTextBox.ReadOnly = true;
            this.secretCaseIDTextBox.Size = new System.Drawing.Size(100, 34);
            this.secretCaseIDTextBox.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(961, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 132);
            this.panel2.TabIndex = 5;
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
            this.groupBox2.Size = new System.Drawing.Size(1023, 252);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cases";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // secretCaseTableAdapter
            // 
            this.secretCaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveTableAdapter = null;
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
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CaseName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Of Start";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date Of End";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cases";
            this.Load += new System.EventHandler(this.Cases_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretCaseBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private SecurityServiceOfUkraineDataSet securityServiceOfUkraineDataSet;
        private System.Windows.Forms.BindingSource secretCaseBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.SecretCaseTableAdapter secretCaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn secretCaseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker secretCaseDateEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker secretCaseDateStartDateTimePicker;
        private System.Windows.Forms.TextBox secretCaseDescriptionTextBox;
        private System.Windows.Forms.TextBox secretCaseStatusTextBox;
        private System.Windows.Forms.TextBox secretCaseNameTextBox;
        private System.Windows.Forms.TextBox secretCaseIDTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}