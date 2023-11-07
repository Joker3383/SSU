using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SSU
{
    public partial class Employees : Form
    {
        int flag = 0;
        public Employees()
        {
            InitializeComponent();
        }

        private void collaboratorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.collaboratorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.CollabPosada' table. You can move, or remove it, as needed.
            this.collabPosadaTableAdapter.Fill(this.securityServiceOfUkraineDataSet.CollabPosada);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Posada' table. You can move, or remove it, as needed.
            this.posadaTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Posada);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Collaborators' table. You can move, or remove it, as needed.
            this.collaboratorsTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Collaborators);

        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            collaboratorsBindingSource.AddNew();
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
        public void SelectCollaborators()
        {
            int i = 0;
            string sqlExpression = "SELECT * from Collaborators";
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
            
            if ((flag == 2 || flag == 1) && (collaboratorNameTextBox.Text == "" || collaboratorSurnameTextBox.Text == "" ||  collaboratorsDateOfBitthDateTimePicker.Text == default ))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flag == 3) collaboratorsBindingSource.RemoveCurrent();

            collaboratorsBindingNavigatorSaveItem_Click(sender, e);
            SelectCollaborators();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) collaboratorsBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //<<
        private void button9_Click(object sender, EventArgs e)
        {
            collaboratorsBindingSource.MoveFirst();
        }
        //<
        private void button6_Click(object sender, EventArgs e)
        {
            collaboratorsBindingSource.MovePrevious();
        }
        //>
        private void button8_Click(object sender, EventArgs e)
        {
            collaboratorsBindingSource.MoveNext();
        }
        //>>
        private void button7_Click(object sender, EventArgs e)
        {
            collaboratorsBindingSource.MoveLast();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
