using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

using BrightIdeasSoftware;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace RemoteServicesManager
{
    
    public partial class Form1 : Form
    {
        private void ShowMessage(ToolStripLabel sender, string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { this.ShowMessage(sender, msg); });
                return;
            }
            sender.Text = msg;
        }

        private void ShowMessage(Control sender, string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { this.ShowMessage(sender, msg); });
                return;
            }
            sender.Text = msg;
        }

        private void SetEmptyListMsgOverlayStyle(ObjectListView olv)
        {
            TextOverlay textOverlay = olv.EmptyListMsgOverlay as TextOverlay;
            textOverlay.TextColor = Color.Firebrick;
            textOverlay.BackColor = Color.AntiqueWhite;
            textOverlay.BorderColor = Color.DarkRed;
            textOverlay.BorderWidth = 4.0f;
            textOverlay.Font = new Font("Chiller", 36);
            textOverlay.Rotation = -5;
        }

        public Form1()
        {
            InitializeComponent();
            SetEmptyListMsgOverlayStyle(this.olvServices);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckToolStatus(this.olvServices);
            this.toolStripStatusLabel2.Text = "Copyright (c) 2013.";
            this.openFileDialog1.InitialDirectory = Application.StartupPath;
            this.saveFileDialog1.InitialDirectory = Application.StartupPath;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Refresh_Click(this, EventArgs.Empty);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ObjectListView olv = this.olvServices;
            if (olv.Enabled)
            {
                this.BeginBackgroundWorkControlStatus();             
                this.refresh = true;
                this.backgroundWorker1.Dispose();
                this.backgroundWorker1.RunWorkerAsync(this.computers);
            }
        }

        private string msgTip;
        private void ShowAttention(ToolTipIcon icon, string title)
        {
            this.toolTip1.ToolTipIcon = icon;
            this.toolTip1.ToolTipTitle = title;
            this.toolTip1.SetToolTip(this.toolStrip2, msgTip);
        }

        private void ErrortoolStrip_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.Active = true;
        }

        private void ErrortoolStrip_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Active = false;
        }

        private void ErrortoolStrip_MouseDown(object sender, MouseEventArgs e)
        {
            this.contextMenuStrip3.Show(this.toolStrip2, e.Location);
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch ((string)e.ClickedItem.Text)
            {
                case "Copy to Clipboard":
                    Clipboard.SetDataObject(msgTip);
                    ShowMessage(this.MsgtoolStrip, "Copied alerts to clipboard");
                    break;
                case "Clear Alerts":
                    ResetErrorStatus();
                    break;
            }
        }

        private void CanceltoolStripBtn_Click(object sender, EventArgs e)
        {
            this.MsgtoolStrip.Text = "Canceling...";
            this.backgroundWorker1.CancelAsync();
            this.backgroundWorker2.CancelAsync();
            this.backgroundWorker3.CancelAsync();
        }

        private void textComputers_TextChanged(object sender, EventArgs e)
        {
            if (this.textComputers.Text.Trim() != "")
            {
                this.buttonSearch.Enabled = true;
            }
            else
            {
                this.buttonSearch.Enabled = false;
            }
        }

        private void buttonComputers_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Text Documents (*.txt)|*.txt";
            this.openFileDialog1.DefaultExt = ".txt";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.openFileDialog1.FileName;
                StreamReader objReader = File.OpenText(fileName);
                string str;
                ArrayList arrComputers = new ArrayList();
                while ((str = objReader.ReadLine()) != null)
                {
                    arrComputers.Add(str.Trim());
                }
                this.textComputers.Text = string.Join(",", arrComputers.ToArray());
            }
            this.textComputers.Focus();
            this.textComputers.SelectionStart = this.textComputers.Text.Length;
        }

        private ArrayList computers = new ArrayList();
        private string searchType = "DisplayName";
        private string searchContent;
        private bool refresh;
        private Log logger = new Log(Path.ChangeExtension(Application.ExecutablePath, ".log"));

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.BeginBackgroundWorkControlStatus();
            ArrayList computers = new ArrayList(this.textComputers.Text.Trim().Split(','));
            this.searchContent = this.textSearch.Text.Trim();
            this.refresh = false;
            this.backgroundWorker1.Dispose();
            this.backgroundWorker1.RunWorkerAsync(computers);
        }

        private void BeginBackgroundWorkControlStatus()
        {
            this.textComputers.Enabled = false;
            this.buttonComputers.Enabled = false;
            this.textSearch.Enabled = false;
            this.buttonSearch.Enabled = false;
            this.textFilter.Enabled = false;
            this.olvServices.Enabled = false;
            this.toolStripBtnStart.Enabled = false;
            this.toolStripBtnStop.Enabled = false;
            this.toolStripBtnPause.Enabled = false;
            this.toolStripBtnResume.Enabled = false;
            this.toolStripBtnRestart.Enabled = false;
            this.toolStripBtnStartMode.Enabled = false;
            this.toolStripBtnLogOn.Enabled = false;
            this.toolStripBtnTXT.Enabled = false;
            this.toolStripBtnEXCEL.Enabled = false;
            this.toolStripBtnHTML.Enabled = false;
            this.ResetErrorStatus();
            this.ResetProcessBar();
        }

        private void AfterBackgroundWorkControlStatus()
        {
            this.textComputers.Enabled = true;
            this.buttonComputers.Enabled = true;
            this.textSearch.Enabled = true;
            this.buttonSearch.Enabled = true;
            this.textFilter.Enabled = true;
            this.olvServices.Enabled = true;
            this.CanceltoolStripBtn.Visible = false;
            this.toolStripProgressBar1.Visible = false;
            CheckToolStatus(this.olvServices);
        }

        private void ResetErrorStatus()
        {
            this.msgTip = "";
            this.ErrortoolStrip.Image = null;
            this.ErrortoolStrip.Text = "";
        }

        private void ResetProcessBar()
        {
            this.CanceltoolStripBtn.Enabled = true;
            this.CanceltoolStripBtn.Visible = true;
            this.toolStripProgressBar1.Value = 0;
            this.toolStripProgressBar1.Visible = true;
            this.MsgtoolStrip.Text = "";
        }

        private void CheckToolStatus(ObjectListView listView)
        {
            if (listView.Items.Count > 0)
            {
                if (listView.SelectedIndices.Count > 0)
                {
                    ManagementObject service = (ManagementObject)listView.SelectedObject;
                    if (service == null)
                    {
                        this.toolStripBtnStart.Enabled = true;
                        this.toolStripBtnStop.Enabled = true;
                        this.toolStripBtnPause.Enabled = true;
                        this.toolStripBtnResume.Enabled = true;
                        this.toolStripBtnRestart.Enabled = true;
                    }
                    else
                    {
                        if ((string)service["StartMode"] == "Disabled")
                        {
                            this.toolStripBtnStart.Enabled = false;
                            this.toolStripBtnStop.Enabled = false;
                            this.toolStripBtnPause.Enabled = false;
                            this.toolStripBtnResume.Enabled = false;
                            this.toolStripBtnRestart.Enabled = false;
                        }
                        else
                        {
                            if ((string)service["State"] == "Stopped")
                            {
                                this.toolStripBtnStart.Enabled = true;
                                this.toolStripBtnStop.Enabled = false;
                                this.toolStripBtnPause.Enabled = false;
                                this.toolStripBtnResume.Enabled = false;
                                this.toolStripBtnRestart.Enabled = false;
                            }
                            else if ((string)service["State"] == "Paused")
                            {
                                this.toolStripBtnStart.Enabled = false;
                                this.toolStripBtnStop.Enabled = (bool)service["AcceptStop"];
                                this.toolStripBtnPause.Enabled = false;
                                this.toolStripBtnResume.Enabled = true;
                                this.toolStripBtnRestart.Enabled = true;
                            }
                            else if ((string)service["State"] == "Running")
                            {
                                this.toolStripBtnStart.Enabled = false;
                                this.toolStripBtnStop.Enabled = (bool)service["AcceptStop"];
                                this.toolStripBtnPause.Enabled = (bool)service["AcceptPause"];
                                this.toolStripBtnResume.Enabled = false;
                                this.toolStripBtnRestart.Enabled = true;
                                
                            }
                            else
                            {
                                this.toolStripBtnRestart.Enabled = false;
                                this.toolStripBtnStart.Enabled = false;
                                this.toolStripBtnStop.Enabled = false;
                                this.toolStripBtnPause.Enabled = false;
                            }
                        }
                    }
                    this.toolStripBtnStartMode.Enabled = true;
                    this.toolStripBtnLogOn.Enabled = true;
                }
                else
                {
                    this.toolStripBtnStart.Enabled = false;
                    this.toolStripBtnStop.Enabled = false;
                    this.toolStripBtnPause.Enabled = false;
                    this.toolStripBtnResume.Enabled = false;
                    this.toolStripBtnRestart.Enabled = false;
                    this.toolStripBtnStartMode.Enabled = false;
                    this.toolStripBtnLogOn.Enabled = false;
                }
                this.toolStripBtnTXT.Enabled = true;
                this.toolStripBtnHTML.Enabled = true;
                this.toolStripBtnEXCEL.Enabled = true;
            }
            else
            {
                this.toolStripBtnStart.Enabled = false;
                this.toolStripBtnStop.Enabled = false;
                this.toolStripBtnPause.Enabled = false;
                this.toolStripBtnResume.Enabled = false;
                this.toolStripBtnRestart.Enabled = false;
                this.toolStripBtnStartMode.Enabled = false;
                this.toolStripBtnLogOn.Enabled = false;
                this.toolStripBtnTXT.Enabled = false;
                this.toolStripBtnHTML.Enabled = false;
                this.toolStripBtnEXCEL.Enabled = false;
            }
        }

        Stopwatch stopWatch;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            stopWatch = new Stopwatch();
            stopWatch.Start();
            e.Result = GetServices((ArrayList)e.Argument, worker, e);
        }

        private List<ManagementObject> GetServices(ArrayList computers, BackgroundWorker worker, DoWorkEventArgs e)
        {
            List<ManagementObject> services = new List<ManagementObject>();
            int totalCount = computers.Count;
            int errorCount = 0;
            this.computers = new ArrayList();
            for (int i = 0; i < totalCount; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return null;
                }
                else
                {
                    try
                    {
                        ShowMessage(this.MsgtoolStrip, string.Format("({0}/{1}) {2}ing services on '{3}' ...", i + 1, totalCount, this.refresh ? "Refresh" : "Search", computers[i]));
                        ConnectionOptions connectionOptions = new ConnectionOptions();
                        ManagementScope managementScope = new ManagementScope("\\\\" + computers[i] + "\\root\\cimv2:Win32_Service", connectionOptions);
                        ObjectQuery query = new ObjectQuery(string.Format("SELECT * FROM Win32_Service WHERE {0} like '%{1}%'", this.searchType, this.searchContent));
                        ManagementObjectSearcher searcher = new ManagementObjectSearcher(managementScope, query);
                        foreach (ManagementObject service in searcher.Get())
                        {
                            services.Add(service);
                        }
                        this.computers.Add(computers[i]);
                    }
                    catch (Exception ex)
                    {
                        errorCount = errorCount + 1;
                        msgTip += string.Format("{0}. '{1}': {2}\r\n", errorCount, computers[i], ex.Message);
                        ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Warning" : " Warnings"));
                    }
                    int percentComplete = (int)((i + 1) * 100 / totalCount);
                    worker.ReportProgress(percentComplete);
                }
            }
            return services;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripProgressBar1.Value = e.ProgressPercentage;
            ShowAttention(ToolTipIcon.Warning, "Attention");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Cancelled)
            {
                ResetErrorStatus();
                this.MsgtoolStrip.Text = string.Format("{0}ing Services Canceled.", this.refresh ? "Refresh" : "Search");
            }
            else
            {
                if (this.ErrortoolStrip.Text != "")
                {
                    this.ErrortoolStrip.Image = RemoteServicesManager.Properties.Resources.Attention;
                }
                InitializeServiceList((List<ManagementObject>)e.Result);
                stopWatch.Stop();
                this.MsgtoolStrip.Text = String.Format("{0}ing Services Completed. ({1} services in {2}ms)",
                   this.refresh ? "Refresh" : "Search", this.olvServices.Items.Count, stopWatch.ElapsedMilliseconds);
            }
            AfterBackgroundWorkControlStatus();
            GC.Collect();
        }

        private void InitializeServiceList(List<ManagementObject> services)
        {
            Cursor.Current = Cursors.WaitCursor;
            TypedObjectListView<ManagementObject> tlist = new TypedObjectListView<ManagementObject>(this.olvServices);
            tlist.GetColumn(0).AspectGetter = delegate(ManagementObject x) { return x["SystemName"]; };
            tlist.GetColumn(1).AspectGetter = delegate(ManagementObject x) { return x["Name"]; };
            tlist.GetColumn(1).AspectGetter = delegate(ManagementObject x) { return x["DisplayName"]; };
            tlist.GetColumn(2).AspectGetter = delegate(ManagementObject x) { return x["Description"]; };
            tlist.GetColumn(3).AspectGetter = delegate(ManagementObject x) { return x["State"]; };
            tlist.GetColumn(4).AspectGetter = delegate(ManagementObject x) { return x["StartMode"]; };
            tlist.GetColumn(5).AspectGetter = delegate(ManagementObject x) { return x["PathName"]; };
            tlist.GetColumn(5).AspectGetter = delegate(ManagementObject x) { return x["StartName"]; };
            this.computerColumn.ImageGetter = delegate(object row)
            {
                string state = ((ManagementObject)row)["State"].ToString();
                switch (state)
                {
                    case "Running":
                        return "running";
                    case "Stopped":
                        return "stopped";
                    case "Paused":
                        return "paused";
                    case "Start Pending":
                        return "starting";
                    case "Stop Pending":
                        return "stopping";
                    case "Restart Pending":
                        return "restarting";
                    case "Pause Pending":
                        return "pausing";
                    case "Resume Pending":
                        return "resuming";
                    default:
                        return null;
                }
            };
            this.olvServices.SetObjects(services);
        }

        private void textFilter_TextChanged(object sender, EventArgs e)
        {
            TimedFilter(this.olvServices, this.textFilter.Text, 0);
            CheckToolStatus(this.olvServices);
        }

        private void TimedFilter(ObjectListView olv, string txt, int matchKind)
        {
            TextMatchFilter filter = null;
            if (!String.IsNullOrEmpty(txt))
            {
                switch (matchKind)
                {
                    case 0:
                    default:
                        filter = TextMatchFilter.Contains(olv, txt);
                        break;
                    case 1:
                        filter = TextMatchFilter.Prefix(olv, txt);
                        break;
                    case 2:
                        filter = TextMatchFilter.Regex(olv, txt);
                        break;
                }
            }
            // Setup a default renderer to draw the filter matches
            if (filter == null)
                olv.DefaultRenderer = null;
            else
            {
                olv.DefaultRenderer = new HighlightTextRenderer(filter);

                // Uncomment this line to see how the GDI+ rendering looks
                //olv.DefaultRenderer = new HighlightTextRenderer { Filter = filter, UseGdiTextRendering = false };
            }

            // Some lists have renderers already installed
            HighlightTextRenderer highlightingRenderer = olv.GetColumn(0).Renderer as HighlightTextRenderer;
            if (highlightingRenderer != null)
                highlightingRenderer.Filter = filter;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            olv.AdditionalFilter = filter;
            //olv.Invalidate();
            stopWatch.Stop();

            IList objects = olv.Objects as IList;
            if (objects == null)
                ShowMessage(this.MsgtoolStrip, String.Format("Filtered services in {0}ms", stopWatch.ElapsedMilliseconds));
            else
                ShowMessage(this.MsgtoolStrip, String.Format("Filtered {0} services down to {1} in {2}ms", objects.Count, olv.Items.Count, stopWatch.ElapsedMilliseconds));
        }

        private void olvServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectListView olv = this.olvServices;
            ManagementObject service = (ManagementObject)olv.SelectedObject;
            if (service == null)
            {
                ShowMessage(this.MsgtoolStrip, string.Format("Selected {0} of {1} services", olv.SelectedIndices.Count, olv.Items.Count));
            }
            else
            {
                ShowMessage(this.MsgtoolStrip, string.Format("Selected '{0}' service of {1} services", service["DisplayName"], olv.Items.Count));
            }
            CheckToolStatus(olv);
        }

        private void olvServices_CellRightClick(object sender, CellRightClickEventArgs e)
        {
            ObjectListView olv = e.ListView;
            if (olv.GetItemCount() > 0)
            {
                if (olv.SelectedIndices.Count > 0)
                {
                    CheckMenuStripStatus(olv);
                    SetJumpToGroupMenuStrip(olv, this.JumpToGroupMenuItem);
                    e.MenuStrip = this.contextMenuStrip1;
                }
                else
                {
                    SetJumpToGroupMenuStrip(olv,this.JumpToGroupMenuItem2);
                    e.MenuStrip = this.contextMenuStrip2;
                }
            }
        }

        private void SetJumpToGroupMenuStrip(ObjectListView listView, ToolStripMenuItem ms)
        {
            ms.DropDownItems.Clear();
            if (listView.ShowGroups)
            {
                foreach (ListViewGroup lvg in listView.Groups)
                {
                    ToolStripMenuItem mi = new ToolStripMenuItem(String.Format("{0}", lvg.Header));
                    mi.Tag = lvg;
                    ms.DropDownItems.Add(mi);
                }
                ms.Text = "Jump to group";
                ms.Enabled = true;
            }
            else
            {
                ms.Text = "Turn on 'Show Groups' to see this context menu in action";
                ms.Enabled = false;
            }
        }

        private void CheckMenuStripStatus(ObjectListView listView)
        {
            ManagementObject service = (ManagementObject)listView.SelectedObject;
            if (service == null)
            {
                this.StartMenuItem.Enabled = true;
                this.StopMenuItem.Enabled = true;
                this.PauseMenuItem.Enabled = true;
                this.ResumeMenuItem.Enabled = true;
                this.RestartMenuItem.Enabled = true;
            }
            else
            {
                if ((string)service["StartMode"] == "Disabled")
                {
                    this.StartMenuItem.Enabled = false;
                    this.StopMenuItem.Enabled = false;
                    this.PauseMenuItem.Enabled = false;
                    this.ResumeMenuItem.Enabled = false;
                    this.RestartMenuItem.Enabled = false;
                }
                else
                {
                    if ((string)service["State"] == "Stopped")
                    {
                        this.StartMenuItem.Enabled = true;
                        this.StopMenuItem.Enabled = false;
                        this.PauseMenuItem.Enabled = false;
                        this.ResumeMenuItem.Enabled = false;
                        this.RestartMenuItem.Enabled = false;
                    }
                    else if ((string)service["State"] == "Paused")
                    {
                        this.StartMenuItem.Enabled = false;
                        this.StopMenuItem.Enabled = (bool)service["AcceptStop"];
                        this.PauseMenuItem.Enabled = false;
                        this.ResumeMenuItem.Enabled = true;
                        this.RestartMenuItem.Enabled = true;
                    }
                    else if ((string)service["State"] == "Running")
                    {
                        this.StartMenuItem.Enabled = false;
                        this.StopMenuItem.Enabled = (bool)service["AcceptStop"];
                        this.PauseMenuItem.Enabled = (bool)service["AcceptPause"];
                        this.ResumeMenuItem.Enabled = false;
                        this.RestartMenuItem.Enabled = true;
                    }
                    else
                    {
                        this.StartMenuItem.Enabled = false;
                        this.StopMenuItem.Enabled = false;
                        this.PauseMenuItem.Enabled = false;
                        this.ResumeMenuItem.Enabled = false;
                        this.RestartMenuItem.Enabled = false;
                    }
                }
            }
            this.SetStartModeMenuItem.Enabled = true;
            this.SetLogonAccountMenuItem.Enabled = true;
        }

        private void olvServices_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.Control) && (e.KeyCode == Keys.C))
            {
                CopyMenuItem_Click(this, EventArgs.Empty);
            }
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            this.olvServices.CopySelectionToClipboard();
            ManagementObject service = (ManagementObject)this.olvServices.SelectedObject;
            if (service == null)
            {
                ShowMessage(this.MsgtoolStrip, string.Format("Copied {0} services to clipboard", this.olvServices.SelectedIndices.Count));
            }
            else
            {
                ShowMessage(this.MsgtoolStrip, string.Format("Copied '{0}' service to clipboard", service["DisplayName"]));
            }
        }

        private void JumpToGroupMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)e.ClickedItem;
            ListViewGroup lvg = (ListViewGroup)mi.Tag;
            ObjectListView olv = (ObjectListView)lvg.ListView;
            olv.EnsureGroupVisible(lvg);
        }

        private string actionType;
        private string startMode;
        private ProcessForm processForm;
        private void ActionsMenuItem_Clicked(object sender, EventArgs e)
        {
            DoServiceAction(this.olvServices.SelectedObjects, ((ToolStripMenuItem)sender).Text);
        }

        private void toolStripBtnActions_Click(object sender, EventArgs e)
        {
            DoServiceAction(this.olvServices.SelectedObjects, ((ToolStripButton)sender).Text);
        }

        private void DoServiceAction(IList services, string actionType)
        {
            ResetErrorStatus();
            this.actionType = actionType;
            if (actionType == "Set start mode...")
            {
                if (services.Count > 1)
                {
                    startMode = null;
                }
                else
                {
                    startMode = ((ManagementObject)services[0])["StartMode"].ToString();
                }
                OptionForm optionForm = new OptionForm(startMode);
                if (optionForm.ShowDialog() == DialogResult.OK)
                {
                    startMode = optionForm.StartMode;
                    processForm = new ProcessForm(this.backgroundWorker2);
                    this.backgroundWorker2.Dispose();
                    this.backgroundWorker2.RunWorkerAsync(services);
                    processForm.ShowDialog(this);
                }
            }
            else if (actionType == "Set logon account...")
            {
                if (services.Count > 1)
                {
                    string userName = null;
                }
                else
                {
                    string userName = ((ManagementObject)services[0])["StartName"].ToString();
                }
                LogonForm logonForm = new LogonForm();
                if (logonForm.ShowDialog() == DialogResult.OK)
                {
                    //userName = logonForm.UserName;
                    processForm = new ProcessForm(this.backgroundWorker2);
                    this.backgroundWorker2.Dispose();
                    this.backgroundWorker2.RunWorkerAsync(services);
                    processForm.ShowDialog(this);
                }
            }
            else
            {
                processForm = new ProcessForm(this.backgroundWorker2);
                this.backgroundWorker2.Dispose();
                this.backgroundWorker2.RunWorkerAsync(services);
                processForm.ShowDialog(this);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            stopWatch = new Stopwatch();
            stopWatch.Start();
            switch (actionType)
            {
                case "Start":
                    e.Result = StartServices((IList)e.Argument, worker, e);
                    break;
                case "Stop":
                    e.Result = StopServices((IList)e.Argument, worker, e);
                    break;
                case "Pause":
                    e.Result = PauseServices((IList)e.Argument, worker, e);
                    break;
                case "Resume":
                    e.Result = ResumeServices((IList)e.Argument, worker, e);
                    break;
                case "Restart":
                    e.Result = RestartServices((IList)e.Argument, worker, e);
                    break;
                case "Set start mode...":
                    e.Result = SetStartMode((IList)e.Argument, worker, e);
                    break;
            }
        }

        private void CheckServiceException(int result)
        {
            if (result != 0)
            {
                string errorMessage;
                switch (result)
                {
                    case 1:
                        errorMessage = "Not Supported";
                        break;
                    case 2:
                        errorMessage = "Access Denied";
                        break;
                    case 3:
                        errorMessage = "Dependent Services Running";
                        break;
                    case 4:
                        errorMessage = "Invalid Service Control";
                        break;
                    case 5:
                        errorMessage = "Service Cannot Accept Control";
                        break;
                    case 6:
                        errorMessage = "Service Not Active";
                        break;
                    case 7:
                        errorMessage = "Service Request Timeout";
                        break;
                    case 8:
                        errorMessage = "Unknown Failure";
                        break;
                    case 9:
                        errorMessage = "Path Not Found";
                        break;
                    case 10:
                        errorMessage = "Service Already Running";
                        break;
                    case 11:
                        errorMessage = "Service Database Locked";
                        break;
                    case 12:
                        errorMessage = "Service Dependency Deleted";
                        break;
                    case 13:
                        errorMessage = "Service Dependency Failure";
                        break;
                    case 14:
                        errorMessage = "Service Disabled";
                        break;
                    case 15:
                        errorMessage = "Service Logon Failed";
                        break;
                    case 16:
                        errorMessage = "Service Marked For Deletion";
                        break;
                    case 17:
                        errorMessage = "Service No Thread";
                        break;
                    case 18:
                        errorMessage = "Status Circular Dependency";
                        break;
                    case 19:
                        errorMessage = "Status Duplicate Name";
                        break;
                    case 20:
                        errorMessage = "Status Invalid Name";
                        break;
                    case 21:
                        errorMessage = "Status Invalid Parameter";
                        break;
                    case 22:
                        errorMessage = "Status Invalid Service Account";
                        break;
                    case 23:
                        errorMessage = "Status Service Exists";
                        break;
                    case 24:
                        errorMessage = "Service Already Paused";
                        break;
                    default:
                        errorMessage = "Unknown";
                        break;
                }
                throw new ManagementException(errorMessage);
            }
        }

        private void CheckServiceStatus(ManagementObject service, string state, int j, int n, int timeout, BackgroundWorker worker)
        {
            int i = 0;
            while((string)service["state"] != state)
            {
                if (i >= timeout)
                {
                    throw new ManagementException("Service Operation Timeout");
                }
                i++;
                Thread.Sleep(1000);
                int percentComplete = (int)((((float)i / timeout) + j) * 100 / n);
                worker.ReportProgress(percentComplete);
                service.Get();
                this.olvServices.RefreshObject(service);
            }
        }

        private void CheckServiceStartMode(ManagementObject service, string startMode, int j, int n, int timeout, BackgroundWorker worker)
        {
            int i = 0;
            while ((string)service["StartMode"] != (startMode == "Automatic" ? "Auto" : startMode))
            {
                if (i >= timeout)
                {
                    throw new ManagementException("Service Operation Timeout");
                }
                i++;
                Thread.Sleep(1000);
                int percentComplete = (int)((((float)i / timeout) + j) * 100 / n);
                worker.ReportProgress(percentComplete);
                service.Get();
                this.olvServices.RefreshObject(service);
            }
        }

        private IList StartServices(IList services, BackgroundWorker worker, DoWorkEventArgs e)
        {
            int totalCount = services.Count;
            int errorCount = 0;
            for (int i = 0; i < totalCount; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return null;
                }
                else
                {
                    ManagementObject service = (ManagementObject)services[i];
                    try
                    {
                        logger.log(string.Format("Starting '{0}' service on '{1}' ...", service["DisplayName"], service["SystemName"]));
                        ShowMessage(processForm.label1, string.Format("Attempting to start the following service on '{0}'...\r\n\r\n({2}/{3}) {1}", service["SystemName"], service["DisplayName"], i + 1, totalCount));
                        object result = service.InvokeMethod("StartService", null);
                        CheckServiceException(int.Parse(result.ToString()));
                        CheckServiceStatus(service, "Running", i, totalCount, 10, worker);
                        logger.log(string.Format("({0}) '{1}': Service has been started successful", service["SystemName"], service["DisplayName"]));
                        logger.log(new string('-', 200));
                    }
                    catch (Exception ex)
                    {
                        errorCount = errorCount + 1;
                        msgTip += string.Format("{0}. ({1}) '{2}': Service cannot be started because {3}\r\n", errorCount, service["SystemName"], service["DisplayName"], ex.Message);
                        ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Error" : " Errors"));
                        logger.log(string.Format("({0}) '{1}': Service cannot be started because {2}", service["SystemName"], service["DisplayName"], ex.Message));
                        logger.log(new string('-', 200));
                    }
                    int percentComplete = (int)((i + 1) * 100 / totalCount);
                    worker.ReportProgress(percentComplete);
                }
            }
            return services;
        }

        private IList StopServices(IList services, BackgroundWorker worker, DoWorkEventArgs e)
        {
            int totalCount = services.Count;
            int errorCount = 0;
            for (int i = 0; i < totalCount; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return null;
                }
                else
                {
                    ManagementObject service = (ManagementObject)services[i];
                    try
                    {
                        logger.log(string.Format("Stopping '{0}' service on '{1}' ...", service["DisplayName"], service["SystemName"]));
                        ShowMessage(processForm.label1, string.Format("Attempting to stop the following service on '{0}'...\r\n\r\n({2}/{3}) {1}", service["SystemName"], service["DisplayName"], i + 1, totalCount));
                        object result = service.InvokeMethod("StopService", null);
                        CheckServiceException(int.Parse(result.ToString()));
                        CheckServiceStatus(service, "Stopped", i, totalCount, 10, worker);
                        logger.log(string.Format("({0}) '{1}': Service has been stopped successful", service["SystemName"], service["DisplayName"]));
                        logger.log(new string('-', 200));
                    }
                    catch (Exception ex)
                    {
                        errorCount = errorCount + 1;
                        msgTip += string.Format("{0}. ({1}) '{2}': Service cannot be stopped because {3}\r\n", errorCount, service["SystemName"], service["DisplayName"], ex.Message);
                        ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Error" : " Errors"));
                        logger.log(string.Format("({0}) '{1}': Service cannot be stopped because {2}", service["SystemName"], service["DisplayName"], ex.Message));
                        logger.log(new string('-', 200));
                    }
                    int percentComplete = (int)((i + 1) * 100 / totalCount);
                    worker.ReportProgress(percentComplete);
                }
            }
            return services;
        }

        private IList PauseServices(IList services, BackgroundWorker worker, DoWorkEventArgs e)
        {
            int totalCount = services.Count;
            int errorCount = 0;
            for (int i = 0; i < totalCount; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return null;
                }
                else
                {
                    ManagementObject service = (ManagementObject)services[i];
                    try
                    {
                        logger.log(string.Format("Pausing '{0}' service on '{1}' ...", service["DisplayName"], service["SystemName"]));
                        ShowMessage(processForm.label1, string.Format("Attempting to pause the following service on '{0}'...\r\n\r\n({2}/{3}) {1}", service["SystemName"], service["DisplayName"], i + 1, totalCount));
                        object result = service.InvokeMethod("PauseService", null);
                        CheckServiceException(int.Parse(result.ToString()));
                        CheckServiceStatus(service, "Paused", i, totalCount, 10, worker);
                        logger.log(string.Format("({0}) '{1}': Service has been paused successful", service["SystemName"], service["DisplayName"]));
                        logger.log(new string('-', 200));
                    }
                    catch (Exception ex)
                    {
                        errorCount = errorCount + 1;
                        msgTip += string.Format("{0}. ({1}) '{2}': Service cannot be paused because {3}\r\n", errorCount, service["SystemName"], service["DisplayName"], ex.Message);
                        ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Error" : " Errors"));
                        logger.log(string.Format("({0}) '{1}': Service cannot be paused because {2}", service["SystemName"], service["DisplayName"], ex.Message));
                        logger.log(new string('-', 200));
                    }
                    int percentComplete = (int)((i + 1) * 100 / totalCount);
                    worker.ReportProgress(percentComplete);
                }
            }
            return services;
        }

        private IList ResumeServices(IList services, BackgroundWorker worker, DoWorkEventArgs e)
        {
            int totalCount = services.Count;
            int errorCount = 0;
            for (int i = 0; i < totalCount; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return null;
                }
                else
                {
                    ManagementObject service = (ManagementObject)services[i];
                    try
                    {
                        logger.log(string.Format("Resuming '{0}' service on '{1}' ...", service["DisplayName"], service["SystemName"]));
                        ShowMessage(processForm.label1, string.Format("Attempting to resume the following service on '{0}'...\r\n\r\n({2}/{3}) {1}", service["SystemName"], service["DisplayName"], i + 1, totalCount));
                        object result = service.InvokeMethod("ResumeService", null);
                        CheckServiceException(int.Parse(result.ToString()));
                        CheckServiceStatus(service, "Running", i, totalCount, 10, worker);
                        logger.log(string.Format("({0}) '{1}': Service has been resumed successful", service["SystemName"], service["DisplayName"]));
                        logger.log(new string('-', 200));
                    }
                    catch (Exception ex)
                    {
                        errorCount = errorCount + 1;
                        msgTip += string.Format("{0}. ({1}) '{2}': Service cannot be resumed because {3}\r\n", errorCount, service["SystemName"], service["DisplayName"], ex.Message);
                        ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Error" : " Errors"));
                        logger.log(string.Format("({0}) '{1}': Service cannot be resumed because {2}", service["SystemName"], service["DisplayName"], ex.Message));
                        logger.log(new string('-', 200));
                    }
                    int percentComplete = (int)((i + 1) * 100 / totalCount);
                    worker.ReportProgress(percentComplete);
                }
            }
            return services;
        }

        private IList RestartServices(IList services, BackgroundWorker worker, DoWorkEventArgs e)
        {
            int totalCount = services.Count;
            int errorCount = 0;
            for (int i = 0; i < totalCount; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return null;
                }
                else
                {
                    ManagementObject service = (ManagementObject)services[i];
                    try
                    {
                        logger.log(string.Format("Restarting '{0}' service on '{1}' ...", service["DisplayName"], service["SystemName"]));
                        ShowMessage(processForm.label1, string.Format("Attempting to stop the following service on '{0}'...\r\n\r\n({2}/{3}) {1}", service["SystemName"], service["DisplayName"], i + 1, totalCount));
                        object result = service.InvokeMethod("StopService", null);
                        CheckServiceException(int.Parse(result.ToString()));
                        CheckServiceStatus(service, "Stopped", i, totalCount, 10, worker);
                        ShowMessage(processForm.label1, string.Format("Attempting to start the following service on '{0}'...\r\n\r\n({2}/{3}) {1}", service["SystemName"], service["DisplayName"], i + 1, totalCount));
                        result = service.InvokeMethod("StartService", null);
                        CheckServiceException(int.Parse(result.ToString()));
                        CheckServiceStatus(service, "Running", i, totalCount, 10, worker);
                        logger.log(string.Format("({0}) '{1}': Service has been restarted successful", service["SystemName"], service["DisplayName"]));
                        logger.log(new string('-', 200));
                    }
                    catch (Exception ex)
                    {
                        errorCount = errorCount + 1;
                        msgTip += string.Format("{0}. ({1}) '{2}': Service cannot be restarted because {3}\r\n", errorCount, service["SystemName"], service["DisplayName"], ex.Message);
                        ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Error" : " Errors"));
                        logger.log(string.Format("({0}) '{1}': Service cannot be restarted because {2}", service["SystemName"], service["DisplayName"], ex.Message));
                        logger.log(new string('-', 200));
                    }
                    int percentComplete = (int)((i + 1) * 100 / totalCount);
                    worker.ReportProgress(percentComplete);
                }
            }
            return services;
        }

        private IList SetStartMode(IList services, BackgroundWorker worker, DoWorkEventArgs e)
        {
            int totalCount = services.Count;
            int errorCount = 0;
            for (int i = 0; i < totalCount; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return null;
                }
                else
                {
                    ManagementObject service = (ManagementObject)services[i];
                    try
                    {
                        logger.log(string.Format("Setting start mode from '{0}' to '{1}' of '{2}' service on '{3}' ...", service["StartMode"].ToString() == "Auto" ? "Automatic" : service["StartMode"], this.startMode, service["DisplayName"], service["SystemName"]));
                        ShowMessage(processForm.label1, string.Format("Attempting to set start mode of the following service on '{0}'...\r\n\r\n({2}/{3}) {1}", service["SystemName"], service["DisplayName"], i + 1, totalCount));
                        object result = service.InvokeMethod("ChangeStartMode", new object[] { this.startMode });
                        CheckServiceException(int.Parse(result.ToString()));
                        CheckServiceStartMode(service, this.startMode, i, totalCount, 10, worker);
                        logger.log(string.Format("({0}) '{1}': Service start mode has been changed successful", service["SystemName"], service["DisplayName"]));
                        logger.log(new string('-', 200));
                    }
                    catch (Exception ex)
                    {
                        errorCount = errorCount + 1;
                        msgTip += string.Format("{0}. ({1}) '{2}': Service start mode cannot be changed because {3}\r\n", errorCount, service["SystemName"], service["DisplayName"], ex.Message);
                        ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Error" : " Errors"));
                        logger.log(string.Format("({0}) '{1}': Service start mode cannot be changed because {2}", service["SystemName"], service["DisplayName"], ex.Message));
                        logger.log(new string('-', 200));
                    }
                    int percentComplete = (int)((i + 1) * 100 / totalCount);
                    worker.ReportProgress(percentComplete);
                }
            }
            return services;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Cancelled)
            {
                ResetErrorStatus();
                if (this.actionType == "Set start mode...")
                {
                    this.MsgtoolStrip.Text = "Setting start mode Canceled.";
                }
                else
                {
                    this.MsgtoolStrip.Text = string.Format("{0}ing Service Canceled.", this.actionType);
                }
            }
            else
            {
                if (this.ErrortoolStrip.Text != "")
                {
                    this.ErrortoolStrip.Image = RemoteServicesManager.Properties.Resources.Attention;
                    ShowAttention(ToolTipIcon.Warning, "Attention");
                }
                stopWatch.Stop();
                if (this.actionType == "Set start mode...")
                {
                    this.MsgtoolStrip.Text = string.Format("Setting start mode Completed. ({0} services in {1}ms)", ((IList)e.Result).Count, stopWatch.ElapsedMilliseconds);
                }
                else
                {
                    this.MsgtoolStrip.Text = string.Format("{0}ing Service Completed. ({1} services in {2}ms)", this.actionType, ((IList)e.Result).Count, stopWatch.ElapsedMilliseconds);
                }
            }
            AfterBackgroundWorkControlStatus();
            GC.Collect();
        }

        private string ExportType;
        private void toolStripBtnExport_Click(object sender, EventArgs e)
        {
            this.BeginBackgroundWorkControlStatus();
            this.ExportType = ((ToolStripButton)sender).Text;
            this.backgroundWorker3.Dispose();
            this.backgroundWorker3.RunWorkerAsync(this.olvServices);
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            switch (this.ExportType)
            {
                case "Export to TXT...":
                    e.Result = CreateTXT((ObjectListView)e.Argument, worker, e);
                    break;
                case "Export to EXCEL...":
                    e.Result = CreateExcel((ObjectListView)e.Argument, worker, e);
                    break;
                case "Export to HTML...":
                    e.Result = CreateHtml((ObjectListView)e.Argument, worker, e);
                    break;
            }
        }

        private string CreateTXT(ObjectListView olv, BackgroundWorker worker, DoWorkEventArgs e)
        {
            IList<OLVColumn> columns = olv.IncludeHiddenColumnsInDataTransfer ? olv.AllColumns : olv.ColumnsInDisplayOrder;
            StringBuilder sbText = new StringBuilder();
            int totalCount = olv.Items.Count;
            int rowRead = 0;
            int errorCount = 0;
            if (olv.ShowGroups)
            {
                foreach (ListViewGroup lvg in olv.Groups)
                {
                    sbText.AppendLine("\r\n\r\n\t" + lvg + "\r\n");
                    foreach (OLVColumn col in columns)
                    {
                        if (col != columns[0])
                        {
                            sbText.Append("\t");
                        }
                        string strValue = col.Text;
                        sbText.Append(strValue);
                    }
                    sbText.AppendLine();
                    foreach (OLVColumn col in columns)
                    {
                        if (col != columns[0])
                        {
                            sbText.Append("\t");
                        }
                        string strValue = new string('-', col.Text.Length);
                        sbText.Append(strValue);
                    }
                    sbText.AppendLine();

                    for (int i = 0; i < lvg.Items.Count; i++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return null;
                        }
                        else
                        {
                            OLVListItem service = lvg.Items[i] as OLVListItem;
                            try
                            {
                                rowRead++;
                                ShowMessage(this.MsgtoolStrip, string.Format("({0}/{1}) Outputing services to TXT format file ...", rowRead, totalCount));
                                foreach (OLVColumn col in columns)
                                {
                                    if (col != columns[0])
                                    {
                                        sbText.Append("\t");
                                    }
                                    string strValue = col.GetStringValue(service.RowObject);
                                    sbText.Append(strValue);
                                }
                                sbText.AppendLine();
                            }
                            catch (Exception ex)
                            {
                                errorCount = errorCount + 1;
                                msgTip += string.Format("{0}. Name '{1}' on '{2}': {3}\r\n", errorCount, ((ManagementObject)service.RowObject)["Name"], ((ManagementObject)service.RowObject)["SystemName"], ex.Message);
                                ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Error" : " Errors"));
                            }
                            int percentComplete = (int)(rowRead * 100 / totalCount);
                            worker.ReportProgress(percentComplete);
                        }
                    }
                }
            }
            return sbText.ToString();
        }

        private Excel.Application xlApp;
        private Excel.Workbook CreateExcel(ObjectListView olv, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (xlApp == null)
            {
                xlApp = new Excel.Application();
            }
            if (xlApp == null)
            {
                MessageBox.Show("Can't create Excel object，maybe your computer not install Excel!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            xlApp.DisplayAlerts = false;
            Excel.Workbooks workbooks = xlApp.Workbooks;
            Excel.Workbook workbook = workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
            Excel.Range range = null;
            worksheet.Cells.Font.Size = 11;
            worksheet.Cells.NumberFormat = "@";
            IList<OLVColumn> columns = olv.IncludeHiddenColumnsInDataTransfer ? olv.AllColumns : olv.ColumnsInDisplayOrder;
            int totalCount = olv.Items.Count;
            int rowRead = 0;
            int rowIndex = 0;
            int errorCount = 0;
            if (olv.ShowGroups)
            {
                for (int g = 0; g < olv.Groups.Count; g++)
                {
                    ++rowIndex;
                    ListViewGroup lvg = olv.Groups[g];
                    worksheet.Cells[rowIndex, 1] = lvg.ToString();
                    range = worksheet.get_Range(worksheet.Cells[rowIndex, 1], worksheet.Cells[rowIndex, columns.Count]);
                    range.Merge(range.MergeCells);
                    range.Font.Size = 14;
                    range.Font.Bold = true;
                    range.RowHeight = 26;
                    ++rowIndex;
                    for (int i = 0; i < columns.Count; i++)
                    {
                        worksheet.Cells[rowIndex, i + 1] = columns[i].Text;
                        range = (Excel.Range)worksheet.Cells[rowIndex, i + 1];
                        range.Font.Size = 12;
                        range.Font.Bold = true;
                        range.ColumnWidth = 16;
                        range.Font.Color = ColorTranslator.ToOle(Color.White);
                        range.Interior.Color = ColorTranslator.ToOle(Color.RoyalBlue);
                        range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }
                    ++rowIndex;
                    for (int r = 0; r < lvg.Items.Count; r++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return null;
                        }
                        else
                        {
                            OLVListItem service = lvg.Items[r] as OLVListItem;
                            try
                            {
                                rowRead++;
                                ShowMessage(this.MsgtoolStrip, string.Format("({0}/{1}) Outputing services to EXCEL format file ...", rowRead, totalCount));
                                for (int i = 0; i < columns.Count; i++)
                                {
                                    worksheet.Cells[r + rowIndex, i + 1] = columns[i].GetStringValue(service.RowObject);
                                    if ((r + 1) % 2 == 0)
                                    {
                                        range = worksheet.get_Range(worksheet.Cells[r + rowIndex, 1], worksheet.Cells[r + rowIndex, columns.Count]);
                                        range.Interior.Color = ColorTranslator.ToOle(Color.Gainsboro);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                errorCount = errorCount + 1;
                                msgTip += string.Format("{0}. Name '{1}' on '{2}': {3}\r\n", errorCount, ((ManagementObject)service.RowObject)["Name"], ((ManagementObject)service.RowObject)["SystemName"], ex.Message);
                                ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Error" : " Errors"));
                            }
                            int percentComplete = (int)(rowRead * 100 / totalCount);
                            worker.ReportProgress(percentComplete);
                        }
                    }
                    rowIndex = (g + 1) * 3 + rowRead;
                    range = worksheet.get_Range(worksheet.Cells[rowIndex - lvg.Items.Count - 1, 1], worksheet.Cells[rowIndex - 1, columns.Count]);
                    range.RowHeight = 16;
                    range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    range.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, null);
                    //range.Borders[Excel.XlBordersIndex.xlInsideHorizontal].ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
                    //range.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                    //range.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = Excel.XlBorderWeight.xlHairline;
                    //range.Borders[Excel.XlBordersIndex.xlInsideVertical].ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
                    //range.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
                    //range.Borders[Excel.XlBordersIndex.xlInsideVertical].Weight = Excel.XlBorderWeight.xlHairline;
                }
            }
            return workbook;
        }

        private string CreateHtml(ObjectListView olv, BackgroundWorker worker, DoWorkEventArgs e)
        {
            IList<OLVColumn> columns = olv.IncludeHiddenColumnsInDataTransfer ? olv.AllColumns : olv.ColumnsInDisplayOrder;
            StringBuilder sbHTML = new StringBuilder("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">\r\n");
            int totalCount = olv.Items.Count;
            int rowRead = 0;
            int errorCount = 0;
            sbHTML.Append(string.Format("<HTML>\r\n<HEAD>\r\n" +
                "<style>\r\n" +
                "body {{ background-color:#CCFFFF; font-family:Tahoma; font-size:12pt; }}\r\n" +
                "td, th {{ border:1px solid #000033; border-collapse:collapse; }}\r\n" +
                "th {{ color:white; background-color:#000033; }}\r\n" +
                "table, tr, td, th {{ padding:2px; margin:0px }}\r\n" +
                "table {{ margin-left:50px; }}\r\n" +
                "</style>\r\n" +
                "<Title>{0}</Title>\r\n" +
                "</HEAD>\r\n<BODY>\r\n" +
                "<H1>{0}</H1>\r\n<H4>{1}</H4>\r\n<br>", "Service Report", DateTime.Now.Date.ToString() ));
            if (olv.ShowGroups)
            {
                foreach (ListViewGroup lvg in olv.Groups)
                {
                    sbHTML.Append(string.Format("<a href=\"#{0}\">{0}</a>&nbsp;&nbsp;&nbsp;&nbsp;", lvg.Header.Substring(0, lvg.Header.IndexOf("(") - 1)));
                }
                sbHTML.Append("<br><br><hr>\r\n");
                foreach (ListViewGroup lvg in olv.Groups)
                {
                    sbHTML.Append(string.Format("<H2><a name=\"{0}\">{1}</a></H2>\r\n<table>\r\n<tr>\r\n<th>", lvg.Header.Substring(0, lvg.Header.IndexOf("(") - 1), lvg.Header));
                    foreach (OLVColumn col in columns)
                    {
                        if (col != columns[0])
                        {
                            sbHTML.Append("</th>\r\n<th>");
                        }
                        string strValue = col.Text;
                        sbHTML.Append(strValue);
                    }
                    sbHTML.AppendLine("</th>\r\n</tr>");
                    for (int i = 0; i < lvg.Items.Count; i++)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return null;
                        }
                        else
                        {
                            OLVListItem service = lvg.Items[i] as OLVListItem;
                            try
                            {
                                rowRead++;
                                ShowMessage(this.MsgtoolStrip, string.Format("({0}/{1}) Outputing services to HTML format file ...", rowRead, totalCount));
                                sbHTML.Append("<tr>\r\n<td>");
                                foreach (OLVColumn col in columns)
                                {
                                    if (col != columns[0])
                                    {
                                        sbHTML.Append("</td>\r\n<td>");
                                    }
                                    string strValue = col.GetStringValue(service.RowObject);
                                    sbHTML.Append(strValue);
                                }
                                sbHTML.AppendLine("</td>\r\n</tr>");
                            }
                            catch (Exception ex)
                            {
                                errorCount = errorCount + 1;
                                msgTip += string.Format("{0}. Name '{1}' on '{2}': {3}\r\n", errorCount, ((ManagementObject)service.RowObject)["Name"], ((ManagementObject)service.RowObject)["SystemName"], ex.Message);
                                ShowMessage(this.ErrortoolStrip, errorCount + (errorCount == 1 ? " Error" : " Errors"));
                            }
                            int percentComplete = (int)(rowRead * 100 / totalCount);
                            worker.ReportProgress(percentComplete);
                        }
                    }
                    sbHTML.AppendLine("</table>");
                }
            }
            sbHTML.AppendLine("</BODY>\r\n</HTML>");
            return sbHTML.ToString();
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripProgressBar1.Value = e.ProgressPercentage;
            ShowAttention(ToolTipIcon.Warning, "Attention");
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Cancelled)
            {
                ResetErrorStatus();
                this.MsgtoolStrip.Text = "Exporting File Canceled.";
            }
            else
            {
                if (this.ErrortoolStrip.Text != "")
                {
                    this.ErrortoolStrip.Image = RemoteServicesManager.Properties.Resources.Attention;
                }
                switch (ExportType)
                {
                    case "Export to TXT...":
                        this.MsgtoolStrip.Text = "Creating TXT Format File Completed.";
                        this.saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt";
                        this.saveFileDialog1.DefaultExt = ".txt";
                        this.saveFileDialog1.FileName = "Services.txt";
                        if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = this.saveFileDialog1.FileName;
                            File.WriteAllText(fileName, (string)e.Result, Encoding.UTF8);
                            this.MsgtoolStrip.Text = string.Format("Saved File to '{0}' Successfully.", fileName);
                        }
                        else
                        {
                            this.MsgtoolStrip.Text = string.Format("Saving File Canceled.");
                        }
                        break;
                    case "Export to EXCEL...":
                        if (e.Result == null)
                        {
                            this.MsgtoolStrip.Text = string.Format("Creating EXCEL Format File Failed.");
                        }
                        else
                        {
                            this.MsgtoolStrip.Text = "Creating EXCEL Format File Completed.";
                            this.saveFileDialog1.Filter = "Excel Documents (*.xls)|*.xls";
                            this.saveFileDialog1.DefaultExt = ".xls";
                            this.saveFileDialog1.FileName = "Services.xls";
                            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                string fileName = this.saveFileDialog1.FileName;
                                try
                                {
                                    ((Excel.Workbook)e.Result).SaveAs(fileName, Excel.XlFileFormat.xlExcel8, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                                    this.MsgtoolStrip.Text = string.Format("Saved File to '{0}' Successfully.", fileName);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.MsgtoolStrip.Text = "Saving File Failed.";
                                }
                            }
                            else
                            {
                                this.MsgtoolStrip.Text = string.Format("Saving File Canceled.");
                            }
                        }
                        break;
                    case "Export to HTML...":
                        this.MsgtoolStrip.Text = "Creating HTML Format File Completed.";
                        this.saveFileDialog1.Filter = "HTML Documents (*.html)|*.html";
                        this.saveFileDialog1.DefaultExt = ".html";
                        this.saveFileDialog1.FileName = "Services.html";
                        if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = this.saveFileDialog1.FileName;
                            File.WriteAllText(fileName, (string)e.Result, Encoding.UTF8);
                            this.MsgtoolStrip.Text = string.Format("Saved File to '{0}' Successfully.", fileName);
                        }
                        else
                        {
                            this.MsgtoolStrip.Text = string.Format("Saving File Canceled.");
                        }
                        break;
                }
            }
            AfterBackgroundWorkControlStatus();
            xlApp.Application.Workbooks.Close();
            GC.Collect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xlApp != null)
            {
                xlApp.Quit();
            }
            GC.Collect();
        }

    }

    public class Log
    {
        private string logFile;
        private StreamWriter writer;
        private FileStream fileStream = null;

        public Log(string fileName)
        {
            logFile = fileName;
            CreateDirectory(logFile);
        }
        //使用
        //Log log = new Log(AppDomain.CurrentDomain.BaseDirectory + @"/log/Log.txt");
        //log.log(basePath);
        public void log(string info)
        {
            try
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(logFile);
                if (!fileInfo.Exists)
                {
                    fileStream = fileInfo.Create();
                    writer = new StreamWriter(fileStream);
                }
                else
                {
                    fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write);
                    writer = new StreamWriter(fileStream);
                }
                writer.WriteLine(DateTime.Now + ": " + info);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                    fileStream.Close();
                    fileStream.Dispose();
                }
            }
        }

        public void CreateDirectory(string infoPath)
        {
            DirectoryInfo directoryInfo = Directory.GetParent(infoPath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }
    }
}
