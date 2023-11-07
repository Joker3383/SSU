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
    public partial class Equipment : Form
    {
        int flag = 0;
        public Equipment()
        {
            InitializeComponent();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void equipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Equipment);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //delete
        private void button5_Click(object sender, EventArgs e)
        {
            flag = 3;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1 .Visible = true;
            groupBox1.Text = "Delete Info";
        }
        //get
        public void SelectEquipment()
        {
            int i = 0;
            string sqlExpression = "SELECT * FROM Equipment";
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
            if ((flag == 2 || flag == 1) && (nameEquipTextBox.Text == "" || descriptionEquipTextBox.Text == "" || statusEquipTextBox.Text == ""))
            {
                MessageBox.Show("Not all fields are set");
                return;
            }
            if (flag == 3) equipmentBindingSource.RemoveCurrent();

            equipmentBindingNavigatorSaveItem_Click(sender, e);
            SelectEquipment();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }

        private void statusEquipTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            groupBox1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = true;
            equipmentBindingSource.AddNew();
        }
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) equipmentBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //update
        private void button4_Click(object sender, EventArgs e)
        {
            flag = 2;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            groupBox1.Text = "Change info";
        }

        //<<
        private void button9_Click(object sender, EventArgs e)
        {
            equipmentBindingSource.MoveFirst();
        }
        //<
        private void button6_Click(object sender, EventArgs e)
        {
            equipmentBindingSource.MovePrevious();
        }
        //>
        private void button8_Click(object sender, EventArgs e)
        {
            equipmentBindingSource.MoveNext();
        }
        //>>
        private void button7_Click(object sender, EventArgs e)
        {
            equipmentBindingSource.MoveLast();
        }

        private void Equipment_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
