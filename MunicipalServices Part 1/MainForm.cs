using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MunicipalServices_Part_1.Services.MunicipalServicesApplication.Services;


namespace MunicipalServices_Part_1
{



    
        public partial class MainForm : Form
        {
            private readonly IDataService _dataService;

            public MainForm()
            {
                InitializeComponent();
                _dataService = new DataService();
            }

            private void MainForm_Load(object sender, EventArgs e)
            {
                // Disable the buttons that are not yet implemented
                btnEvents.Enabled = false;
                btnStatus.Enabled = false;

                // Make sure the report button is enabled
                btnReport.Enabled = true;
            }

            private void btnReport_Click(object sender, EventArgs e)
            {
                // Open the Report Issues form
                ReportForm reportForm = new ReportForm(_dataService);
                reportForm.Show();
                this.Hide(); // Hide the main form
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
    }


