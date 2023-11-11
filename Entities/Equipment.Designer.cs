namespace SSU
{
    partial class Equipment
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
            System.Windows.Forms.Label equipmentIDLabel;
            System.Windows.Forms.Label nameEquipLabel;
            System.Windows.Forms.Label statusEquipLabel;
            System.Windows.Forms.Label descriptionEquipLabel;
            System.Windows.Forms.Label quantityLabel;
            this.securityServiceOfUkraineDataSet = new SSU.SecurityServiceOfUkraineDataSet();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableAdapter = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.EquipmentTableAdapter();
            this.tableAdapterManager = new SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.descriptionEquipTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.statusEquipTextBox = new System.Windows.Forms.TextBox();
            this.equipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.nameEquipTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEquipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionEquipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusEquipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            equipmentIDLabel = new System.Windows.Forms.Label();
            nameEquipLabel = new System.Windows.Forms.Label();
            statusEquipLabel = new System.Windows.Forms.Label();
            descriptionEquipLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentIDLabel
            // 
            equipmentIDLabel.AutoSize = true;
            equipmentIDLabel.Location = new System.Drawing.Point(18, 36);
            equipmentIDLabel.Name = "equipmentIDLabel";
            equipmentIDLabel.Size = new System.Drawing.Size(164, 29);
            equipmentIDLabel.TabIndex = 4;
            equipmentIDLabel.Text = "Equipment ID:";
            // 
            // nameEquipLabel
            // 
            nameEquipLabel.AutoSize = true;
            nameEquipLabel.Location = new System.Drawing.Point(20, 88);
            nameEquipLabel.Name = "nameEquipLabel";
            nameEquipLabel.Size = new System.Drawing.Size(153, 29);
            nameEquipLabel.TabIndex = 5;
            nameEquipLabel.Text = "Name Equip:";
            // 
            // statusEquipLabel
            // 
            statusEquipLabel.AutoSize = true;
            statusEquipLabel.Location = new System.Drawing.Point(20, 136);
            statusEquipLabel.Name = "statusEquipLabel";
            statusEquipLabel.Size = new System.Drawing.Size(154, 29);
            statusEquipLabel.TabIndex = 6;
            statusEquipLabel.Text = "Status Equip:";
            // 
            // descriptionEquipLabel
            // 
            descriptionEquipLabel.AutoSize = true;
            descriptionEquipLabel.Location = new System.Drawing.Point(18, 172);
            descriptionEquipLabel.Name = "descriptionEquipLabel";
            descriptionEquipLabel.Size = new System.Drawing.Size(210, 29);
            descriptionEquipLabel.TabIndex = 7;
            descriptionEquipLabel.Text = "Description Equip:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(341, 33);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(106, 29);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "Quantity:";
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
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EquipmentTableAdapter = this.equipmentTableAdapter;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.OperationTableAdapter = null;
            this.tableAdapterManager.PosadaTableAdapter = null;
            this.tableAdapterManager.SecLevelSecSecretTableAdapter = null;
            this.tableAdapterManager.SecretCaseTableAdapter = null;
            this.tableAdapterManager.SecurityLevelTableAdapter = null;
            this.tableAdapterManager.SecuritySecretTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SSU.SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(quantityLabel);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.descriptionEquipTextBox);
            this.groupBox1.Controls.Add(descriptionEquipLabel);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(equipmentIDLabel);
            this.groupBox1.Controls.Add(this.statusEquipTextBox);
            this.groupBox1.Controls.Add(statusEquipLabel);
            this.groupBox1.Controls.Add(this.equipmentIDTextBox);
            this.groupBox1.Controls.Add(this.nameEquipTextBox);
            this.groupBox1.Controls.Add(nameEquipLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add equip";
            this.groupBox1.Visible = false;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(444, 33);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 34);
            this.quantityTextBox.TabIndex = 10;
            // 
            // descriptionEquipTextBox
            // 
            this.descriptionEquipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "DescriptionEquip", true));
            this.descriptionEquipTextBox.Location = new System.Drawing.Point(234, 169);
            this.descriptionEquipTextBox.Name = "descriptionEquipTextBox";
            this.descriptionEquipTextBox.Size = new System.Drawing.Size(131, 34);
            this.descriptionEquipTextBox.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(808, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 128);
            this.panel2.TabIndex = 4;
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
            // statusEquipTextBox
            // 
            this.statusEquipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "StatusEquip", true));
            this.statusEquipTextBox.Location = new System.Drawing.Point(188, 129);
            this.statusEquipTextBox.Name = "statusEquipTextBox";
            this.statusEquipTextBox.Size = new System.Drawing.Size(143, 34);
            this.statusEquipTextBox.TabIndex = 7;
            this.statusEquipTextBox.TextChanged += new System.EventHandler(this.statusEquipTextBox_TextChanged);
            // 
            // equipmentIDTextBox
            // 
            this.equipmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "EquipmentID", true));
            this.equipmentIDTextBox.Location = new System.Drawing.Point(188, 33);
            this.equipmentIDTextBox.Name = "equipmentIDTextBox";
            this.equipmentIDTextBox.ReadOnly = true;
            this.equipmentIDTextBox.Size = new System.Drawing.Size(131, 34);
            this.equipmentIDTextBox.TabIndex = 5;
            // 
            // nameEquipTextBox
            // 
            this.nameEquipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "NameEquip", true));
            this.nameEquipTextBox.Location = new System.Drawing.Point(188, 88);
            this.nameEquipTextBox.Name = "nameEquipTextBox";
            this.nameEquipTextBox.Size = new System.Drawing.Size(142, 34);
            this.nameEquipTextBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(18, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 243);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipment";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentIDDataGridViewTextBoxColumn,
            this.nameEquipDataGridViewTextBoxColumn,
            this.descriptionEquipDataGridViewTextBoxColumn,
            this.statusEquipDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(857, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // equipmentIDDataGridViewTextBoxColumn
            // 
            this.equipmentIDDataGridViewTextBoxColumn.DataPropertyName = "EquipmentID";
            this.equipmentIDDataGridViewTextBoxColumn.HeaderText = "EquipmentID";
            this.equipmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.equipmentIDDataGridViewTextBoxColumn.Name = "equipmentIDDataGridViewTextBoxColumn";
            this.equipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipmentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameEquipDataGridViewTextBoxColumn
            // 
            this.nameEquipDataGridViewTextBoxColumn.DataPropertyName = "NameEquip";
            this.nameEquipDataGridViewTextBoxColumn.HeaderText = "NameEquip";
            this.nameEquipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameEquipDataGridViewTextBoxColumn.Name = "nameEquipDataGridViewTextBoxColumn";
            this.nameEquipDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameEquipDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionEquipDataGridViewTextBoxColumn
            // 
            this.descriptionEquipDataGridViewTextBoxColumn.DataPropertyName = "DescriptionEquip";
            this.descriptionEquipDataGridViewTextBoxColumn.HeaderText = "DescriptionEquip";
            this.descriptionEquipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionEquipDataGridViewTextBoxColumn.Name = "descriptionEquipDataGridViewTextBoxColumn";
            this.descriptionEquipDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionEquipDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusEquipDataGridViewTextBoxColumn
            // 
            this.statusEquipDataGridViewTextBoxColumn.DataPropertyName = "StatusEquip";
            this.statusEquipDataGridViewTextBoxColumn.HeaderText = "StatusEquip";
            this.statusEquipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusEquipDataGridViewTextBoxColumn.Name = "statusEquipDataGridViewTextBoxColumn";
            this.statusEquipDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusEquipDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(15, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 76);
            this.panel3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(157, 16);
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
            this.panel4.Location = new System.Drawing.Point(577, 481);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 76);
            this.panel4.TabIndex = 5;
            this.panel4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Decline";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 566);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.securityServiceOfUkraineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SecurityServiceOfUkraineDataSet securityServiceOfUkraineDataSet;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private SecurityServiceOfUkraineDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private SecurityServiceOfUkraineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox descriptionEquipTextBox;
        private System.Windows.Forms.TextBox statusEquipTextBox;
        private System.Windows.Forms.TextBox nameEquipTextBox;
        private System.Windows.Forms.TextBox equipmentIDTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEquipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionEquipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusEquipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}