using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace RemoteServicesManager
{
    public partial class ProcessForm : Form
    {
        public void ShowMessage(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { this.ShowMessage(msg); });
                return;
            }
            this.label1.Text = msg;
        }

        private BackgroundWorker backgroundWorker1;
        public ProcessForm(BackgroundWorker backgroundWorker1)
        {
            InitializeComponent();
            this.backgroundWorker1 = backgroundWorker1;
            this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
            this.cancelButton.Enabled = false;
        }
    }
}
