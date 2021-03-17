using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Manager
{
    public partial class Process_Info : Form
    {
        Manager Manager;
        public Process_Info()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Process_Info_Load(object sender, EventArgs e)
        {
            Manager = this.Owner as Manager;

            pictureBox__Icon.Image = new Bitmap(Properties.Resources.Icon);
            button__Minimize.BackgroundImage = new Bitmap(Properties.Resources.minimizeWhite);
            button__Maximize.BackgroundImage = new Bitmap(Properties.Resources.maximizeWhite);
            button__Close.BackgroundImage = new Bitmap(Properties.Resources.closeWhite);

            dataGridView__Process = ManagerFunctions.GetProcessInfo(dataGridView__Process, Manager.Choosen_Process);
        }

        #region Form Title Bar

        private void panel__TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button__Close_Click(object sender, EventArgs e)
        {
            Close();
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
            ManagerFunctions.Refresh(dataGridView__Process, Manager.Choosen_Process);
        }
    }
}
