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
        Process[] proc;

        public ProcessNote()
        {
            InitializeComponent();
        }
                
        void GetAllProcess()
        {
            
            proc = Process.GetProcesses();
            listView.Items.Clear();
            foreach(Process p in proc)
            {
                ListViewItem item = new ListViewItem(p.ProcessName);
                item.SubItems.Add(p.Id.ToString());
                listView.Items.Add(item);
               
            }
        }

        private void ProcessNote_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }


        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            try
            {
                proc[listView.SelectedItems[0].Index].Kill();
                listView.SelectedItems[0].Remove();
                GetAllProcess();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "oopss", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
