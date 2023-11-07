using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SSU
{
    public partial class Archive : Form
    {
        int flag = 0;
        public Archive()
        {
            InitializeComponent();
        }

        private void archiveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.archiveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void Archive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.SecretCase' table. You can move, or remove it, as needed.
            this.secretCaseTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecretCase);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Archive' table. You can move, or remove it, as needed.
            this.archiveTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Archive);

        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            archiveBindingSource.AddNew();
        }
        //edit
        private void button4_Click(object sender, EventArgs e)
        {
            flag = 2;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Change info";
        }
        //delete
        private void button5_Click(object sender, EventArgs e)
        {
            flag = 3;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Delete info";
        }
        //save
        private void button3_Click(object sender, EventArgs e)
        {
            if ((flag == 2 || flag == 1) && (archiveDescriptionTextBox.Text == "" || archiveDateDateTimePicker.Text == "" || comboBox1.Items == null))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flag == 3) secretCaseBindingSource.RemoveCurrent();

            archiveBindingNavigatorSaveItem_Click(sender, e);
            SelectArchive();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            //if (flag == 1 || flag == 2)
            secretCaseBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //<<
        private void button9_Click(object sender, EventArgs e)
        {
            archiveBindingSource.MoveFirst();
        }
        //<
        private void button6_Click(object sender, EventArgs e)
        {
            archiveBindingSource.MovePrevious();
        }
        //>
        private void button8_Click(object sender, EventArgs e)
        {
            archiveBindingSource.MoveNext();
        }
        //>>
        private void button7_Click(object sender, EventArgs e)
        {
            archiveBindingSource.MoveLast();
        }
        //get
        private void SelectArchive()
        {
            int i = 0;
            string sqlExpression = "SELECT * FROM Archive ";
            using (SqlConnection connection = new SqlConnection(ConnectionString.Value))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = null;

                }
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = reader.GetValue(0);
                        dataGridView1.Rows[i].Cells[1].Value = reader.GetValue(1);
                        dataGridView1.Rows[i].Cells[2].Value = reader.GetValue(2);    
                        i++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.secretCaseTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecretCase);
        }

        private void archiveDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Archive_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
