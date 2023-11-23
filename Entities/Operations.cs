using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SSU
{
    public partial class Operations : Form
    {
        int flag = 0;
        public Operations()
        {
            InitializeComponent();
        }

        private void operationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void Operations_Load(object sender, EventArgs e)
        {
            Selectoperations();
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Collaborators' table. You can move, or remove it, as needed.
            this.collaboratorsTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Collaborators);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.SecretCase' table. You can move, or remove it, as needed.
            this.secretCaseTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecretCase);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Location);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Equipment);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Operation' table. You can move, or remove it, as needed.
            this.operationTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Operation);

        }

        private void SubEquip(int EquipID)
        {
            var sqlExpression = $"update Equipment set Quantity = Quantity -1 where EquipmentID = {EquipID}";
            using (SqlConnection connection = new SqlConnection(ConnectionString.Value))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            SubEquip(Convert.ToInt32(comboBox4.SelectedValue));
            operationBindingSource.AddNew();
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
        //get
        private void Selectoperations()
        {
            int i = 0;
            string sqlExpression = "SELECT * FROM Operation ";
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
                        dataGridView1.Rows[i].Cells[3].Value = reader.GetValue(3);
                        dataGridView1.Rows[i].Cells[4].Value = reader.GetValue(4);
                        dataGridView1.Rows[i].Cells[5].Value = reader.GetValue(5);
                        dataGridView1.Rows[i].Cells[6].Value = reader.GetValue(6);
                        dataGridView1.Rows[i].Cells[7].Value = reader.GetValue(7);
                        i++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        //save
        private void button3_Click(object sender, EventArgs e)
        {
            if (
                (flag == 2 || flag == 1)
                &&
                (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == ""))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flag == 3) operationBindingSource.RemoveCurrent();

            operationBindingNavigatorSaveItem_Click(sender, e);
            Selectoperations();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) operationBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //<<
        private void button9_Click(object sender, EventArgs e)
        {
            operationBindingSource.MoveFirst();
        }
        //<
        private void button6_Click(object sender, EventArgs e)
        {
            operationBindingSource.MovePrevious();
        }
        //>
        private void button8_Click(object sender, EventArgs e)
        {
            operationBindingSource.MoveNext();
        }
        //>>
        private void button7_Click(object sender, EventArgs e)
        {
            operationBindingSource.MoveLast();
        }
    }
}
