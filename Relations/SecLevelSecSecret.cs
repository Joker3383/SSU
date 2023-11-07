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
    public partial class SecLevelSecSecret : Form
    {
        int flag = 0;
        public SecLevelSecSecret()
        {
            InitializeComponent();
        }

        private void secLevelSecSecretBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.secLevelSecSecretBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void SecLevelSecSecret_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.SecuritySecret' table. You can move, or remove it, as needed.
            this.securitySecretTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecuritySecret);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.SecuritySecret' table. You can move, or remove it, as needed.
            this.securitySecretTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecuritySecret);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.SecuritySecret' table. You can move, or remove it, as needed.
            this.securitySecretTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecuritySecret);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.SecurityLevel' table. You can move, or remove it, as needed.
            this.securityLevelTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecurityLevel);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.SecLevelSecSecret' table. You can move, or remove it, as needed.
            this.secLevelSecSecretTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecLevelSecSecret);
            SelectData();

        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            secLevelSecSecretBindingSource.AddNew();
        }
        //edit
        private void button4_Click(object sender, EventArgs e)
        {
            flag = 2;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Change SL == SS";
        }
        //delete
        private void button5_Click(object sender, EventArgs e)
        {
            flag = 3;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Delete SL == SS";
        }

        //selectData
        private void SelectData()
        {
            int i = 0;
            string sqlExpression = "SELECT SecLevelSecSecret.SecLevelSecSecretID, SecurityLevel.SecuriryLevel, SecuritySecret.SecuritySecret " +
                "from SecLevelSecSecret " +
                "join SecurityLevel on SecLevelSecSecret.SecurityLevelID = SecurityLevel.SecurityLevelID " +
                "join SecuritySecret on SecLevelSecSecret.SecuritySecretID = SecuritySecret.SecuritySecretID";

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
        //save
        private void button3_Click(object sender, EventArgs e)
        {
            if ((flag == 2 || flag == 1) &&
                (comboBox1.Text == "" || comboBox2.Text == ""))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flag == 3) secLevelSecSecretBindingSource.RemoveCurrent();

            secLevelSecSecretBindingNavigatorSaveItem_Click(sender, e);
            SelectData();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) secLevelSecSecretBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //<<
        private void button9_Click(object sender, EventArgs e)
        {
            secLevelSecSecretBindingSource.MoveFirst();
        }
        //<
        private void button6_Click(object sender, EventArgs e)
        {
            secLevelSecSecretBindingSource.MovePrevious();
        }
        //>
        private void button8_Click(object sender, EventArgs e)
        {
            secLevelSecSecretBindingSource.MoveNext();
        }
        //>>
        private void button7_Click(object sender, EventArgs e)
        {
            secLevelSecSecretBindingSource.MoveLast();
        }
    }
}
