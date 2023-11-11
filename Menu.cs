using System;
using System.Windows.Forms;

namespace SSU
{
    public partial class Menu : Form
    {

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

        public Menu(int flag)
        {
            InitializeComponent();
            if (flag == 1)
            {
                adminAccessToolStripMenuItem.Visible = false;
                systemAdminAccessToolStripMenuItem.Visible = false;
            }
            else if (flag == 2)
            {
                systemAdminAccessToolStripMenuItem.Visible = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void equipmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            equip = new Equipment();
            equip.Show();
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            location = new Location();
            location.Show();
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archive = new Archive();
            archive.Show();
        }

        private void positionOfEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionsOfEmployees = new PositionsOfEmployees();
            positionsOfEmployees.Show();
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documents = new Documents();
            documents.Show();
        }

        private void documentsOfEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeDocuments = new EmployeeDocuments();
            employeeDocuments.Show();
        }

        private void secretCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cases = new Cases();
            cases.Show();
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operations = new Operations();
            operations.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees = new Employees();
            employees.Show();
        }

        private void securityLevelForSecuritySecretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            secLevelSecSecret = new SecLevelSecSecret();
            secLevelSecSecret.Show();
        }

        private void securityLevelForEmpoyeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeSecLevel = new EmployeeSecLevel();
            employeeSecLevel.Show();
        }

        private void securirySecretForDocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            documentsSecSecret = new DocumentsSecSecret();
            documentsSecSecret.Show();
        }
    }
}
