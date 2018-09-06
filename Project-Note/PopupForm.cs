using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Note
{
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }

        private void listViewpopup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listProcess(Process process)
        {
            listViewpopup.Clear();
            ListViewItem item = new ListViewItem(process.ProcessName);
            item.SubItems.Add(String.Format("{0:0.00}", GetProcessRamUsage(process)));
            listViewpopup.Items.Add(item);
        }

        float GetProcessRamUsage(Process process)
        {
            float memsize = 0; // memsize in Megabyte
            PerformanceCounter PC = new PerformanceCounter();
            PC.CategoryName = "Process";
            PC.CounterName = "Working Set - Private";
            PC.InstanceName = process.ProcessName;
            memsize = Convert.ToInt32(PC.NextValue()) / 1024;
            PC.Close();
            PC.Dispose();

            return memsize / 1024;
        }
    }
}
