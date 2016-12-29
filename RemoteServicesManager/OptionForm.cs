using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteServicesManager
{
    public partial class OptionForm : Form
    {
        public string StartMode
        {
            get { return this.comboBox1.SelectedItem.ToString(); }
            set { startMode = value; }
        }
        private string startMode;

        public OptionForm(string startMode)
        {
            InitializeComponent();
            this.StartMode = startMode;
            this.comboBox1.DataSource = Enum.GetNames(typeof(System.ServiceProcess.ServiceStartMode));
            this.comboBox1.SelectedIndex = this.comboBox1.FindString(startMode);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == this.comboBox1.FindString(startMode))
            {
                btnOK.Enabled = false;
            }
            else
            {
                btnOK.Enabled = true;
            }
        }
    }
}
