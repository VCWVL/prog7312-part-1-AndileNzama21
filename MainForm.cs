using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minicipal_Services
{
    using System;
    using System.Windows.Forms;

   
        public partial class MainForm : Form
        {
            public MainForm()
            {
                InitializeComponent();
            }

            private void MainForm_Load(object sender, EventArgs e)
            {
                btnEvents.Enabled = false;
                btnStatus.Enabled = false;
                btnReport.Enabled = true;
            }

            private void btnReport_Click(object sender, EventArgs e)
            {
                ReportForm reportForm = new ReportForm();
                reportForm.Show();
                this.Hide();
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
    }