using System;
using System.Windows.Forms;

namespace SSU.Services
{
    public partial class EmployeeSuccess : Form
    {
        private Employees employees;
        private Cases cases;
        private Location location;
        private Equipment equipment;
        private ReportSuccess report;

        string surname = "%";
        string caseName = "%";
        string locationName = "%";
        string equipmentName = "%";
        public EmployeeSuccess()
        {
            InitializeComponent();
        }
        private void EmployeeSuccess_Load(object sender, EventArgs e)
        {
            this.getEmployeePerformanceTableAdapter.Fill(this.securityServiceOfUkraineDataSet.GetEmployeePerformance, "%", "%", "%", "%");
        }
        private void SelectSuccess()
        {
            if (checkBox1.Checked) surname = textBox1.Text + "%";
            else surname = "%";
            if (checkBox2.Checked) caseName = textBox2.Text + "%";
            else caseName = "%";
            if (checkBox3.Checked) locationName = textBox3.Text + "%";
            else locationName = "%";
            if (checkBox4.Checked) equipmentName = textBox4.Text + "%";
            else equipmentName = "%";

            this.getEmployeePerformanceTableAdapter.Fill(this.securityServiceOfUkraineDataSet.GetEmployeePerformance, surname, caseName, locationName, equipmentName);
        }
        //surname
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                button1.Visible = false;
            }
            SelectSuccess();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            employees = new Employees();
            employees.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SelectSuccess();
        }
        //secret case
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                button3.Visible = false;
            }
            SelectSuccess();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cases = new Cases();
            cases.Show();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SelectSuccess();
        }
        //location
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                button4.Visible = false;
            }
            SelectSuccess();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            location = new Location();
            location.Show();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SelectSuccess();
        }
        //equip
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Visible = true;
                button5.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
                button5.Visible = false;
            }
            SelectSuccess();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            equipment = new Equipment();
            equipment.Show();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SelectSuccess();
        }

        //report
        private void button2_Click(object sender, EventArgs e)
        {
            report = new ReportSuccess(surname,caseName, equipmentName, locationName);
            report.Show();
        }
    }
}
