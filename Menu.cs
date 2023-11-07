using System;
using System.Windows.Forms;

namespace SSU
{
    public partial class Menu : Form
    {
        int flag = 0;

        private Location location;
        private Equipment equip;
        private Cases cases;
        private Archive archive;
        private Documents documents;
        private Operations operations;
        private Employees employees;
        private EmployeeDocuments employeeDocuments;
        private DocumentsSecSecret documentsSecSecret;
        private PositionsOfEmployees positionsOfEmployees;
        private SecLevelSecSecret secLevelSecSecret;
        private EmployeeSecLevel employeeSecLevel;

        public Menu()
        {
            InitializeComponent();
        }
        public Menu(int flag)
        {
            this.flag = flag;
            InitializeComponent();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            operations = new Operations();
            operations.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            location = new Location();
            location.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            equip = new Equipment();
            equip.Show();
        }

        private void casesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cases = new Cases();
            cases.Show();
        }

        private void archiveToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            archive = new Archive();
            archive.Show();
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            documents = new Documents();
            documents.Show();
        }

        private void operativesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees = new Employees();
            employees.Show();
        }


        private void documentSecretSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentsSecSecret = new DocumentsSecSecret();
            documentsSecSecret.Show();
        }

        private void positionOfEmpoyeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionsOfEmployees = new PositionsOfEmployees();
            positionsOfEmployees.Show();
        }

        private void employeesSecLvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeSecLevel = new EmployeeSecLevel();
            employeeSecLevel.Show();
        }

        private void secLevelSecSecretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secLevelSecSecret = new SecLevelSecSecret();
            secLevelSecSecret.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void employeesDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeDocuments = new EmployeeDocuments();
            employeeDocuments.Show();
        }
    }
}
