namespace SSU
{
    partial class SecLevelSecSecret
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
            System.Windows.Forms.Label secLevelSecSecretIDLabel;
            System.Windows.Forms.Label securiryLevelLabel;
            System.Windows.Forms.Label securitySecretLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.secLevelSecSecretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityServiceOfUkraineDataSet = new SSU.SecurityServiceOfUkraineDataSet();
            this.securitySecretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.securityLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secLevelSecSecretIDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.secLevelSecSecretTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.SecLevelSecSecretTableAdapter();
            this.tableAdapterManager = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager();
            this.securityLevelTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.SecurityLevelTableAdapter();
            this.securitySecretTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.SecuritySecretTableAdapter();
            secLevelSecSecretIDLabel = new System.Windows.Forms.Label();
            securiryLevelLabel = new System.Windows.Forms.Label();
            securitySecretLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secLevelSecSecretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securitySecretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityLevelBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // secLevelSecSecretIDLabel
            // 
            secLevelSecSecretIDLabel.AutoSize = true;
            secLevelSecSecretIDLabel.Location = new System.Drawing.Point(6, 34);
            secLevelSecSecretIDLabel.Name = "secLevelSecSecretIDLabel";
            secLevelSecSecretIDLabel.Size = new System.Drawing.Size(278, 29);
            secLevelSecSecretIDLabel.TabIndex = 8;
            secLevelSecSecretIDLabel.Text = "Sec Level Sec Secret ID:";
            // 
            // securiryLevelLabel
            // 
            securiryLevelLabel.AutoSize = true;
            securiryLevelLabel.Location = new System.Drawing.Point(6, 75);
            securiryLevelLabel.Name = "securiryLevelLabel";
            securiryLevelLabel.Size = new System.Drawing.Size(171, 29);
            securiryLevelLabel.TabIndex = 9;
            securiryLevelLabel.Text = "Securiry Level:";
            // 
            // securitySecretLabel
            // 
            securitySecretLabel.AutoSize = true;
            securitySecretLabel.Location = new System.Drawing.Point(6, 118);
            securitySecretLabel.Name = "securitySecretLabel";
            securitySecretLabel.Size = new System.Drawing.Size(181, 29);
            securitySecretLabel.TabIndex = 9;
            securitySecretLabel.Text = "Security Secret:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(securitySecretLabel);
            this.groupBox1.Controls.Add(securiryLevelLabel);
            this.groupBox1.Controls.Add(secLevelSecSecretIDLabel);
            this.groupBox1.Controls.Add(this.secLevelSecSecretIDTextBox);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Correspondense between Security Level and Secutity Secret";
            this.groupBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.secLevelSecSecretBindingSource, "SecuritySecretID", true));
            this.comboBox2.DataSource = this.securitySecretBindingSource;
            this.comboBox2.DisplayMember = "SecuritySecret";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(183, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 37);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "SecuritySecretID";
            // 
            // secLevelSecSecretBindingSource
            // 
            this.secLevelSecSecretBindingSource.DataMember = "SecLevelSecSecret";
            this.secLevelSecSecretBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // securityServiceOfUkraineDataSet
            // 
            this.securityServiceOfUkraineDataSet.DataSetName = "SecurityServiceOfUkraineDataSet";
            this.securityServiceOfUkraineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // securitySecretBindingSource
            // 
            this.securitySecretBindingSource.DataMember = "SecuritySecret";
            this.securitySecretBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.secLevelSecSecretBindingSource, "SecurityLevelID", true));
            this.comboBox1.DataSource = this.securityLevelBindingSource;
            this.comboBox1.DisplayMember = "SecuriryLevel";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 37);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "SecurityLevelID";
            // 
            // securityLevelBindingSource
            // 
            this.securityLevelBindingSource.DataMember = "SecurityLevel";
            this.securityLevelBindingSource.DataSource = this.securityServiceOfUkraineDataSet;
            // 
            // secLevelSecSecretIDTextBox
            // 
            this.secLevelSecSecretIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.secLevelSecSecretBindingSource, "SecLevelSecSecretID", true));
            this.secLevelSecSecretIDTextBox.Location = new System.Drawing.Point(290, 31);
            this.secLevelSecSecretIDTextBox.Name = "secLevelSecSecretIDTextBox";
            this.secLevelSecSecretIDTextBox.Size = new System.Drawing.Size(100, 34);
            this.secLevelSecSecretIDTextBox.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(927, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 132);
            this.panel2.TabIndex = 8;
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
            this.groupBox2.Size = new System.Drawing.Size(989, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Security Level Security Secret";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(11, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(972, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Security Level";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Security Secret";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(12, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 67);
            this.panel3.TabIndex = 10;
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
            this.panel4.Location = new System.Drawing.Point(697, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 56);
            this.panel4.TabIndex = 11;
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
            // secLevelSecSecretTableAdapter
            // 
            this.secLevelSecSecretTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SecLevelSecSecretTableAdapter = this.secLevelSecSecretTableAdapter;
            this.tableAdapterManager.SecretCaseTableAdapter = null;
            this.tableAdapterManager.SecurityLevelTableAdapter = this.securityLevelTableAdapter;
            this.tableAdapterManager.SecuritySecretTableAdapter = this.securitySecretTableAdapter;
            this.tableAdapterManager.UpdateOrder = SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // securityLevelTableAdapter
            // 
            this.securityLevelTableAdapter.ClearBeforeFill = true;
            // 
            // securitySecretTableAdapter
            // 
            this.securitySecretTableAdapter.ClearBeforeFill = true;
            // 
            // SecLevelSecSecret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 543);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecLevelSecSecret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecLevelSecSecret";
            this.Load += new System.EventHandler(this.SecLevelSecSecret_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secLevelSecSecretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securitySecretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityLevelBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private SecurityServiceOfUkraineDataSet securityServiceOfUkraineDataSet;
        private System.Windows.Forms.BindingSource secLevelSecSecretBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.SecLevelSecSecretTableAdapter secLevelSecSecretTableAdapter;
        private SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox secLevelSecSecretIDTextBox;
        private SecurityServiceOfUkraineDataSetTableAdapters.SecurityLevelTableAdapter securityLevelTableAdapter;
        private System.Windows.Forms.BindingSource securityLevelBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.SecuritySecretTableAdapter securitySecretTableAdapter;
        private System.Windows.Forms.BindingSource securitySecretBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}