using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SSU
{
    public partial class EmployeeDocuments : Form
    {
        int flag = 0;

        private Employees employees;
        private Documents documents;

        public EmployeeDocuments()
        {
            InitializeComponent();
        }

        private void collabDocumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.collabDocumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void EmployeeDocuments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.CollabDocum' table. You can move, or remove it, as needed.
            this.collabDocumTableAdapter.Fill(this.securityServiceOfUkraineDataSet.CollabDocum);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Document);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Collaborators' table. You can move, or remove it, as needed.
            this.collaboratorsTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Collaborators);
            SelectData();
        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            collabDocumBindingSource.AddNew();
            collabDocumDateOfStartDateTimePicker.Enabled = true;
        }
        //edit
        private void button4_Click(object sender, EventArgs e)
        {
            flag = 2;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
            groupBox1.Text = "Change info";
            collabDocumDateOfStartDateTimePicker.Enabled = false;
            collabDocumDateOfStartDateTimePicker.Value = DateTime.Now;
        }
        //delete
        private void button5_Click(object sender, EventArgs e)
        {
            flag = 3;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            groupBox1.Text = "Delete info";
            collabDocumDateOfStartDateTimePicker.Enabled = false;
            collabDocumDateOfEndDateTimePicker.Value = DateTime.Now;
        }

        //select data
        public void SelectData()
        {
            int i = 0;
            string sqlExpression = "select CollabDocum.CollabDocumID, Collaborators.CollaboratorName, Document.DocumentName, CollabDocum.CollabDocumDateOfStart, CollabDocum.CollabDocumDateOfEnd " +
                "from CollabDocum join Collaborators on CollabDocum.CollaboratorID = Collaborators.CollaboratorID " +
                "join Document on CollabDocum.DocumentID = Document.DocumentID";

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
            if ((flag == 2 || flag == 1) &&
                (comboBox1.Text == "" || comboBox2.Text == ""))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }

            collabDocumBindingNavigatorSaveItem_Click(sender, e);
            SelectData();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) collabDocumBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //<<
        private void button9_Click(object sender, EventArgs e)
        {
            collabDocumBindingSource.MoveFirst();
        }
        //<
        private void button6_Click(object sender, EventArgs e)
        {
            collabDocumBindingSource.MovePrevious();
        }
        //>
        private void button8_Click(object sender, EventArgs e)
        {
            collabDocumBindingSource.MoveNext();
        }
        //>>
        private void button7_Click(object sender, EventArgs e)
        {
            collabDocumBindingSource.MoveLast();
        }
        //view Collaborators
        private void button10_Click(object sender, EventArgs e)
        {
            employees = new Employees();
            employees.Show();
        }
        //view Documents
        private void button11_Click(object sender, EventArgs e)
        {
            documents = new Documents();
            documents.Show();
        }

     

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void collaboratorsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
