using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Resources;
using System.Runtime.InteropServices;

namespace System_Manager
{
    public partial class Manager : Form
    {
        Process_Info Process_Info;
        public Process Choosen_Process;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Manager()
        {
            InitializeComponent();

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            pictureBox__Icon.Image = new Bitmap(Properties.Resources.Icon);
            button__Minimize.BackgroundImage = new Bitmap(Properties.Resources.minimizeWhite);
            button__Maximize.BackgroundImage = new Bitmap(Properties.Resources.maximizeWhite);
            button__Close.BackgroundImage = new Bitmap(Properties.Resources.closeWhite);

            dataGridView__Manager = ManagerFunctions.GetSystemProcesses(dataGridView__Manager, Process.GetProcesses());
        }

        #region Form Title Bar

        private void panel__TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button__Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button__Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                button__Maximize.BackgroundImage = new Bitmap(Properties.Resources.shrinkWhite);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                button__Maximize.BackgroundImage = new Bitmap(Properties.Resources.maximizeWhite);
            }
        }

        private void button__Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private void timer__Refresh_Tick(object sender, EventArgs e)
        {
            ManagerFunctions.Refresh(dataGridView__Manager, Process.GetProcesses());
        }

        private void dataGridView__Manager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView__Manager = sender as DataGridView;
            Choosen_Process = Process.GetProcesses()[dataGridView__Manager.CurrentCell.RowIndex];
            Process_Info = new Process_Info();
            Process_Info.Owner = this;
            Process_Info.Show();
        }
    }
}
