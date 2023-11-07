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
    public partial class DocumentsSecSecret : Form
    {
        int flag = 0;
        public DocumentsSecSecret()
        {
            InitializeComponent();
        }


        private void documSecSecretBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documSecSecretBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void securitySecretBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.securitySecretBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityServiceOfUkraineDataSet);

        }

        private void DocumentsSecSecret_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.Document' table. You can move, or remove it, as needed.
            this.documentTableAdapter.Fill(this.securityServiceOfUkraineDataSet.Document);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.DocumSecSecret' table. You can move, or remove it, as needed.
            this.documSecSecretTableAdapter.Fill(this.securityServiceOfUkraineDataSet.DocumSecSecret);
            // TODO: This line of code loads data into the 'securityServiceOfUkraineDataSet.SecuritySecret' table. You can move, or remove it, as needed.
            this.securitySecretTableAdapter.Fill(this.securityServiceOfUkraineDataSet.SecuritySecret);
            SelectData();
        }
        //add
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel3.Visible = false;
            panel4.Visible = true;
            groupBox1.Visible = true;
            documSecSecretBindingSource.AddNew();
        }
        //selectData
        public void SelectData()
        {
            int i = 0;
            string sqlExpression = "select DocumSecSecret.DocumSecSecretID, Document.DocumentName, SecuritySecret.SecuritySecret, DocumSecSecret.DocumSecSecretDateOfStart, DocumSecSecret.DocumSecSecretDateOfEnd " +
                "from DocumSecSecret " +
                "join Document on DocumSecSecret.DocumentID = Document.DocumentID " +
                "join SecuritySecret on DocumSecSecret.SecuritySecretID = SecuritySecret.SecuritySecretID";

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
                comboBox2.Text == null ||
                documSecSecretDateOfEndDateTimePicker == null ||
                documSecSecretDateOfStartDateTimePicker == null 
                ))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flag == 3) documSecSecretBindingSource.RemoveCurrent();

            documSecSecretBindingNavigatorSaveItem_Click(sender, e);
            SelectData();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
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
        //decline
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2) documSecSecretBindingSource.CancelEdit();
            panel3.Visible = true;
            panel4.Visible = false;
            groupBox1.Visible = false;
        }
        //<<
        private void button11_Click(object sender, EventArgs e)
        {
            documSecSecretBindingSource.MoveFirst();
        }
        //<
        private void button14_Click(object sender, EventArgs e)
        {
            documSecSecretBindingSource.MovePrevious();
        }
        //>
        private void button13_Click(object sender, EventArgs e)
        {
            documSecSecretBindingSource.MoveNext();
        }
        //>>
        private void button12_Click(object sender, EventArgs e)
        {
            documSecSecretBindingSource.MoveLast();
        }
        //SS
        private void button19_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Visible = true;
        }

        //ss add
        int flagSS = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            flagSS = 1;
            panel1.Visible = false;
            panel2.Visible = true;
            groupBox3.Visible = true;
            securitySecretBindingSource.AddNew();
        }
        //ss edit
        private void button8_Click(object sender, EventArgs e)
        {
            flagSS = 2;
            panel1.Visible = false;
            panel2.Visible = true;
            groupBox3.Visible = true;
            groupBox3.Text = "Change Security Secret";
        }
        //ss delete
        private void button7_Click(object sender, EventArgs e)
        {
            flagSS = 3;
            panel1.Visible = false;
            panel2.Visible = true;
            groupBox3.Visible = true;
            groupBox3.Text = "Delete Security Secret";
        }
        //ss save
        private void button9_Click(object sender, EventArgs e)
        {
            if (
               (flagSS == 2 || flagSS == 1)
               &&
               (
               securitySecretDescriptionTextBox.Text == "" || securitySecretTextBox.Text == "" 
               ))
            {
                MessageBox.Show("Not all required fields are set");
                return;
            }
            if (flagSS == 3) securitySecretBindingSource.RemoveCurrent();

            securitySecretBindingNavigatorSaveItem_Click(sender, e);
            SelectData();
            panel1.Visible = false;
            panel2.Visible = false;
            groupBox3.Visible = false;
        }
        // ss decline
        private void button10_Click(object sender, EventArgs e)
        {
            if (flagSS == 1 || flagSS == 2) securitySecretBindingSource.CancelEdit();
            panel1.Visible = false;
            panel2.Visible = false;
            groupBox3.Visible = false;
        }
        //ss <<
        private void button15_Click(object sender, EventArgs e)
        {
            securitySecretBindingSource.MoveFirst();
        }
        //ss <
        private void button18_Click(object sender, EventArgs e)
        {
            securitySecretBindingSource.MovePrevious();
        }
        // ss >
        private void button17_Click(object sender, EventArgs e)
        {
            securitySecretBindingSource.MoveNext();
        }
        // ss >>
        private void button16_Click(object sender, EventArgs e)
        {
            securitySecretBindingSource.MoveLast();
        }
    }
}
