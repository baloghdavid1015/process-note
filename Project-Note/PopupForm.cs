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
        Process process;
        ProcessNote pn;
        Timer _timer = new Timer();
        PerformanceCounter pc;
        bool is_open = true;

        public PopupForm(ProcessNote pn, Process process)
        {
            this.pn = pn;
            this.pc = new PerformanceCounter("Process", "% Processor Time", process.ProcessName, true);
            this.process = process;
            InitializeComponent();
            listView1.Text = process.ProcessName;
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Interval = 1000;
            _timer.Enabled = true;
            _timer.Start();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            listView1.Items[0].SubItems[1].Text = String.Format("{0:0.00}", GetProcessRamUsage(process));
            listView1.Items[0].SubItems[2].Text = String.Format("{0:0.00}", GetCpuUsage(process));
        }

        private void listViewpopup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listProcess()
        {
            ListViewItem item = new ListViewItem(process.ProcessName);
            item.SubItems.Add(String.Format("{0:0.00}", GetProcessRamUsage(process)));
            item.SubItems.Add(String.Format("{0:0.00}", GetCpuUsage(process)));
            listView1.Items.Add(item);
        }

        private float GetCpuUsage(Process process)
        {
            return pc.NextValue();
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

        private void button1_Click(object sender, EventArgs e)
        {
            pn.DeletFromList(process);
            process.Kill();
            this.Close();
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {

        }

        private void PopupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Enabled = false;
            _timer.Stop();
        }
    }
}
