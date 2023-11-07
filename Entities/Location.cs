using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SSU
{
    public partial class Location : Form
    {
        int flag = 0;
        public Location()
        {
            InitializeComponent();
        }
        //delete
        private void button5_Click(object sender, EventArgs e)
        {
            flag = 3;
            panel2.Visible = false;
            panel1.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Delete Info";
        }

        private void locationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            this.locationTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Location);

        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel2.Visible = false;
            panel1.Visible = true;
            groupBox1.Visible = true;
            locationBindingSource.AddNew();

        }
        //edit
        private void button4_Click(object sender, EventArgs e)
        {
            flag = 2;
            panel2.Visible = false;
            panel1.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Change info";

        }
        //get
        public void SelectLocations()
        {
            int i = 0;
            string sqlExpression = "SELECT * FROM Location";
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
            if ((flag == 2 || flag == 1) && (adressTextBox.Text == "" || locationTypeTextBox.Text == ""))
            {
                MessageBox.Show("Not all fields are set");
                return;
            }
            if (flag == 3) locationBindingSource.RemoveCurrent();

            locationBindingNavigatorSaveItem_Click(sender, e);
            SelectLocations();
            panel2.Visible = true;
            panel1.Visible = false;
            groupBox1.Visible = false;
        }
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) locationBindingSource.CancelEdit();
            panel2.Visible = true;
            panel1.Visible = false;
            groupBox1.Visible = false;
        }

        private void locationTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //<<
        private void button6_Click(object sender, EventArgs e)
        {
            locationBindingSource.MoveFirst();
        }
        //<
        private void button7_Click(object sender, EventArgs e)
        {
            locationBindingSource.MovePrevious();
        }
        //>

        private void button8_Click(object sender, EventArgs e)
        {
            locationBindingSource.MoveNext();
        }
        //>>
        private void button9_Click(object sender, EventArgs e)
        {
            locationBindingSource.MoveLast();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void locationIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
