using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using AutoUpdaterDotNET;

namespace eHospital
{
    public partial class FrmMain : Form
    {
        #region Biến
        public static string mconnectionstring = "server=.;database=eHospital;uid=sa;pwd=123";
        private string msql = "";
        private int titleHeight = 0;
        private int menuHeight = 0;
        private FrmMenu _FrmMenu = null;
        #endregion


        public FrmMain()
        {
            InitializeComponent();
            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            titleHeight = screenRectangle.Top - this.Top;
            menuHeight = this.msMain.Height;
        }


        #region Hàm
        public void fSetSizeform(Form Con, Form Chinh)
        {

            Con.WindowState = FormWindowState.Normal;
            Con.StartPosition = FormStartPosition.Manual;
            Con.Location = new System.Drawing.Point(0, 0);
            Rectangle screenRectangle = RectangleToScreen(Con.ClientRectangle);
            int titleHeightCon = screenRectangle.Top - Con.Top;
            Con.Height = Chinh.Height - (titleHeight + menuHeight) - titleHeightCon - ssMain.Height;
            Con.Width = Chinh.Width - (titleHeightCon);
            Con.MdiParent = Chinh;
            Con.Show();
        }
        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.IsUpdateAvailable)
            {
                DialogResult dialogResult;
                dialogResult =
                        MessageBox.Show(
                            $@"Bạn ơi, phần mềm của bạn có phiên bản mới {args.CurrentVersion}. Phiên bản bạn đang sử dụng hiện tại  {args.InstalledVersion}. Bạn có muốn cập nhật phần mềm không?", @"Cập nhật phần mềm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                {
                    try
                    {
                        if (AutoUpdater.DownloadUpdate(args))
                        {
                            Application.Exit();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Phiên bản bạn đang sử dụng đã được cập nhật mới nhất.", @"Cập nhật phần mềm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void ShowMenuForm()
        {
            _FrmMenu = new FrmMenu();
            fSetSizeform(_FrmMenu, this);
        }


        #endregion

              
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            string version = fvi.FileVersion;
            lblPhienBan.Text = "Phiên bản: " + version;
            AutoUpdater.DownloadPath = "update";
            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 15 * 60 * 1000,
                SynchronizingObject = this
            };
            timer.Elapsed += delegate
            {
                AutoUpdater.Start("http://localhost/update.xml");
            };
            timer.Start();
        }

        

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiKiemTraPhienBanMoiCapNhat_Click(object sender, EventArgs e)
        {
            AutoUpdater.Start("http://localhost/update.xml");
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            ShowMenuForm();
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ShowMenuForm();
            }
        }
    }
}
