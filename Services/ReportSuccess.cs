using System;
using System.Windows.Forms;

namespace SSU.Services
{
    public partial class ReportSuccess : Form
    {
        string surname;
        string caseName;
        string equipName;
        string locationName;
        public ReportSuccess(string surname, string caseName, string equipName, string locationName)
        {
            InitializeComponent();
            this.surname = surname;
            this.caseName = caseName;
            this.equipName = equipName;
            this.locationName = locationName;
        }

        private void ReportSuccess_Load(object sender, EventArgs e)
        {
            this.getEmployeePerformanceTableAdapter.Fill(this.securityServiceOfUkraineDataSet.GetEmployeePerformance, surname, caseName, equipName, locationName);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
