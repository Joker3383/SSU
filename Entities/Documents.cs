using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SSU
{
    public partial class Documents : Form
    {
        int flag = 0;
        public Documents()
        {
            InitializeComponent();
        }

        private void documentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }
        private void Documents_Load(object sender, EventArgs e)
        {
            SelectDocuments();
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Document);

        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            documentBindingSource.AddNew();
        }

        //get
        private void SelectDocuments()
        {
            int i = 0;
            string sqlExpression = "SELECT * FROM Document ";
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

        //edit
        private void button4_Click_1(object sender, EventArgs e)
        {
            flag = 2;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Change info";
        }
        //delete
        private void button5_Click_1(object sender, EventArgs e)
        {
            flag = 3;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Delete info";
        }
        //save
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (
            (flag == 2 || flag == 1)
            &&
            (documentNameTextBox.Text == "" || documentDescriptionTextBox.Text == ""))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flag == 3) documentBindingSource.RemoveCurrent();

            documentBindingNavigatorSaveItem_Click(sender, e);
            SelectDocuments();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //<<
        private void button9_Click_1(object sender, EventArgs e)
        {
            documentBindingSource.MoveFirst();
        }
        //<
        private void button6_Click_1(object sender, EventArgs e)
        {
            documentBindingSource.MovePrevious();
        }
        //>
        private void button8_Click_1(object sender, EventArgs e)
        {
            documentBindingSource.MoveNext();
        }
        //>>
        private void button7_Click_1(object sender, EventArgs e)
        {
            documentBindingSource.MoveLast();
        }
        //decline
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) documentBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
    }
}
