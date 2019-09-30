using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_QueensOfRock
{
    public partial class Form1 : Form
    {
        public delegate void LoadApplicationsHandler(string name);
        public event LoadApplicationsHandler Application;
        public Form1()
        {
            InitializeComponent();
            Application += new LoadApplicationsHandler(LoadData);
        }

        private void btCamping_Click(object sender, EventArgs e)
        {
            Application?.Invoke("Camping_App");
        }

        private void tbInfo_Click(object sender, EventArgs e)
        {
            Application?.Invoke("Event_Information_Application");
        }

        private void btLeave_Click(object sender, EventArgs e)
        {
            Application?.Invoke("Leave_Event");
        }

        private void btManager_Click(object sender, EventArgs e)
        {
            Application?.Invoke("ManagerApplication");            
        }

        private void btShop_Click(object sender, EventArgs e)
        {
            Application?.Invoke("TheShop");
        }

        private void btBorrow_Click(object sender, EventArgs e)
        {
            Application?.Invoke("Manager_Loan_Items_Application");
        }

        private void LoadData(string name)
        {
            string AssemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            string fullPath = Regex.Split(AssemblyPath, "prop")[0] + $@"prop\Final_Deliverables\GUI\{name}\{name}.exe";
            System.Diagnostics.Process.Start(fullPath);
        }
    }
}
