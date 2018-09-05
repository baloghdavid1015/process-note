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
    public partial class ProcessNote : Form
    {
        public ProcessNote()
        {
            InitializeComponent();
        }

        Process[] proc;

        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            listBox.Items.Clear();
            foreach(Process p in proc)
            {
                listBox.Items.Add(p.ProcessName);
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ProcessNote_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
