using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU
{
    public partial class EmployeeSecLevel : Form
    {

        int flag = 0;
        int flagSL = 0;
        public EmployeeSecLevel()
        {
            InitializeComponent();
        }

        private void securityLevelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.securityLevelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void collabSecLevelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.collabSecLevelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);
        }

        private void EmployeeSecLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Collaborators' table. You can move, or remove it, as needed.
            this.collaboratorsTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Collaborators);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.CollabSecLevel' table. You can move, or remove it, as needed.
            this.collabSecLevelTableAdapter.Fill(this.securityServiceOfUkraineDataSet.CollabSecLevel);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.SecurityLevel' table. You can move, or remove it, as needed.
            this.securityLevelTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecurityLevel);
            SelectData();
        }
        //selectData
        public void SelectData()
        {
            int i = 0;
            string sqlExpression = "select CollabSecLevel.CollabSecLevelID, Collaborators.CollaboratorSurname, SecurityLevel.SecuriryLevel, CollabSecLevel.CollabSecLevelDateOfStart, CollabSecLevel.CollabSecLevelDateOfStart " +
                "from CollabSecLevel " +
                "join Collaborators on CollabSecLevel.CollaboratorID = Collaborators.CollaboratorID " +
                "join SecurityLevel on CollabSecLevel.SecurityLevelID = SecurityLevel.SecuriryLevel";

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

        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            collabSecLevelBindingSource.AddNew();

        }
        //edit
        private void button4_Click(object sender, EventArgs e)
        {
            flag = 2;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Change Securiry Level for Employee";
        }
        //delete
        private void button5_Click(object sender, EventArgs e)
        {
            flag = 3;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Delete Securiry Level for Employee";
        }
        //save
        private void button3_Click(object sender, EventArgs e)
        {
            if ((flag == 2 || flag == 1) &&
               (
               comboBox1.Text == "" ||
               comboBox2.Text == "" ||
               collabSecLevelDateOfEndDateTimePicker == null ||
               collabSecLevelDateOfStartDateTimePicker == null
               ))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flag == 3) collabSecLevelBindingSource.RemoveCurrent();

            collabSecLevelBindingNavigatorSaveItem_Click(sender, e);
            SelectData();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) collabSecLevelBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //SL
        private void button19_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        //<<
        private void button11_Click(object sender, EventArgs e)
        {
            collabSecLevelBindingSource.MoveFirst();
        }
        //<
        private void button14_Click(object sender, EventArgs e)
        {
            collabSecLevelBindingSource.MovePrevious();
        }
        //>
        private void button13_Click(object sender, EventArgs e)
        {
            collabSecLevelBindingSource.MoveNext();
        }
        //>>
        private void button12_Click(object sender, EventArgs e)
        {
            collabSecLevelBindingSource.MoveLast();
        }
        //sl add
        private void button6_Click(object sender, EventArgs e)
        {
            flagSL = 1;
            panel1.Visible = false;
            panel2.Visible = true;
            groupBox3.Visible = true;
            securityLevelBindingSource.AddNew();
        }
        //sl edit
        private void button8_Click(object sender, EventArgs e)
        {
            flagSL = 2;
            panel1.Visible = false;
            panel2.Visible = true;
            groupBox3.Visible = true;
            groupBox3.Text = "Change Securiry Level";
        }
        //sl delete
        private void button7_Click(object sender, EventArgs e)
        {
            flagSL = 3;
            panel1.Visible = false;
            panel2.Visible = true;
            groupBox3.Visible = true;
            groupBox3.Text = "Delete Securiry Level";
        }
        //sl save
        private void button9_Click(object sender, EventArgs e)
        {
            if ((flagSL == 2 || flagSL == 1) &&
               (
               securiryLevelTextBox.Text == "" ||
               securityLevelDescriptionTextBox.Text == ""
               ))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flagSL == 3) securityLevelBindingSource.RemoveCurrent();

            securityLevelBindingNavigatorSaveItem_Click(sender, e);
            panel1.Visible = true;
            panel2.Visible = false;
            groupBox3.Visible = false;
        }
        //sl decline
        private void button10_Click(object sender, EventArgs e)
        {
            if (flagSL == 1 || flagSL == 2) securityLevelBindingSource.CancelEdit();
            panel1.Visible = true;
            panel2.Visible = false;
            groupBox3.Visible = false;
        }
        //sl <<
        private void button15_Click(object sender, EventArgs e)
        {
            securityLevelBindingSource.MoveFirst();
        }
        //sl <
        private void button18_Click(object sender, EventArgs e)
        {
            securityLevelBindingSource.MovePrevious();
        }
        //Sl >
        private void button17_Click(object sender, EventArgs e)
        {
            securityLevelBindingSource.MoveNext();
        }
        //sl >>
        private void button16_Click(object sender, EventArgs e)
        {
            securityLevelBindingSource.MoveLast();
        }
    }
}
