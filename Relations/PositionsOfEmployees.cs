using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SSU
{
    public partial class PositionsOfEmployees : Form
    {
        int flag = 0;
        int flagP = 0;

        Employees employees;

        public PositionsOfEmployees()
        {
            InitializeComponent();
        }
        private void collabPosadaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.collabPosadaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }
        private void posadaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.posadaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void PositionsOfEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.CollabPosada' table. You can move, or remove it, as needed.
            this.collabPosadaTableAdapter.Fill(this.securityServiceOfUkraineDataSet.CollabPosada);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.CollabPosada' table. You can move, or remove it, as needed.
            this.collabPosadaTableAdapter.Fill(this.securityServiceOfUkraineDataSet.CollabPosada);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Posada' table. You can move, or remove it, as needed.
            this.posadaTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Posada);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Collaborators' table. You can move, or remove it, as needed.
            this.collaboratorsTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Collaborators);
            SelectData();
        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;

            collabPosadaDateOfStartDateTimePicker.Enabled = true;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            collabPosadaBindingSource.AddNew();
        }
        //edit
        private void button4_Click(object sender, EventArgs e)
        {
            flag = 2;
            collabPosadaDateOfStartDateTimePicker.Enabled = false;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
            collabPosadaDateOfStartDateTimePicker.Value = DateTime.Now;
            groupBox1.Text = "Change Position of Employee!";
        }
        //delete
        private void button5_Click(object sender, EventArgs e)
        {
            flag = 3;
            collabPosadaDateOfStartDateTimePicker.Enabled = false;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            groupBox1.Text = "Fire Employee!";
            collabPosadaDateOfEndDateTimePicker.Value = DateTime.Now;
        }
        //selectData
        public void SelectData()
        {
            int i = 0;
            string sqlExpression = "select CollabPosada.CollabPosadaID, Collaborators.CollaboratorSurname,\r\nPosada.Posada, CollabPosada.CollabPosadaDateOfStart, CollabPosada.CollabPosadaDateOfEnd \r\nfrom CollabPosada \r\njoin Collaborators on CollabPosada.CollaboratorID = Collaborators.CollaboratorID \r\njoin Posada on CollabPosada.PosadaID = Posada.PosadaID";


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
                (
                comboBox1.Text == null ||
                comboBox2.Text == null
                )
               )
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }

            collabPosadaBindingNavigatorSaveItem_Click(sender, e);
            SelectData();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) collabPosadaBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //<<
        private void button9_Click(object sender, EventArgs e)
        {
            collabPosadaBindingSource.MoveFirst();
        }
        //<
        private void button6_Click(object sender, EventArgs e)
        {
            collabPosadaBindingSource.MovePrevious();
        }
        //>
        private void button8_Click(object sender, EventArgs e)
        {
            collabPosadaBindingSource.MoveNext();
        }
        //>>
        private void button7_Click(object sender, EventArgs e)
        {
            collabPosadaBindingSource.MoveLast();
        }

        //P
        private void button19_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }
        //P add
        private void button14_Click(object sender, EventArgs e)
        {
            flagP = 1;
            panel5.Visible = false;
            panel6.Visible = true;
            groupBox3.Visible = true;
            posadaBindingSource.AddNew();
        }
        //P edit
        private void button16_Click(object sender, EventArgs e)
        {
            flagP = 2;
            panel5.Visible = false;
            panel6.Visible = true;
            groupBox3.Visible = true;
            groupBox3.Text = "Change Position paramiters";
        }
        //P delete
        private void button15_Click(object sender, EventArgs e)
        {
            flagP = 3;
            panel5.Visible = false;
            panel6.Visible = true;
            groupBox3.Visible = true;
            groupBox3.Text = "Delete Position";

        }
        //P Save
        private void button17_Click(object sender, EventArgs e)
        {
            if (
                (flag == 2 || flag == 1)
                &&
                (posadaTextBox.Text == "")
                )
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flag == 3) posadaBindingSource.RemoveCurrent();

            posadaBindingNavigatorSaveItem_Click(sender, e);
            panel5.Visible = true;
            panel6.Visible = false;
            groupBox3.Visible = false;
        }
        //P Decline
        private void button18_Click(object sender, EventArgs e)
        {
            if (flagP == 1 || flagP == 2) posadaBindingSource.CancelEdit();
            panel5.Visible = true;
            panel6.Visible = false;
            groupBox3.Visible = false;
        }
        //P <<
        private void button10_Click(object sender, EventArgs e)
        {
            posadaBindingSource.MoveFirst();
        }
        // P <
        private void button13_Click(object sender, EventArgs e)
        {
            posadaBindingSource.MovePrevious();
        }
        // P >
        private void button12_Click(object sender, EventArgs e)
        {
            posadaBindingSource.MoveNext();
        }
        //P >>
        private void button11_Click(object sender, EventArgs e)
        {
            posadaBindingSource.MoveLast();
        }

        private void collabPosadaDateOfStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            employees = new Employees();
            employees.Show();
        }

        private void collabPosadaDateOfEndLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
