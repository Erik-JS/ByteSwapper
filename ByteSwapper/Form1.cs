using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteSwapper
{
    public partial class Form1 : Form
    {

        [DllImport("uxtheme.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        public static Form1 mainForm;

        public static ProgressBar pBar;

        public static int swapchoice = -1;

        public static RadioButton[] opt;

        public static int[] swapvalues = new int[] { 2, 4, 8 };

        public static string[] examplemsg = new string[] { "01 00 03 02 05 04 07 06", "03 02 01 00 07 06 05 04", "07 06 05 04 03 02 01 00" };

        public Form1()
        {
            InitializeComponent();
            SetWindowTheme(progressBar1.Handle, "", "");
            mainForm = this;
            pBar = progressBar1;
            opt = new RadioButton[] { optSwap2, optSwap4, optSwap8 };
            for (int i = 0; i < opt.Length; i++)
            {
                opt[i].Click += OptionButton_Click;
                opt[i].Tag = i;
            }
                
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            var thisOpt = (RadioButton)sender;
            swapchoice = (int)thisOpt.Tag;
            pictureBox1.Refresh();
            btnSwap.Enabled = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (swapchoice == -1)
                return;
            var font = new Font("Consolas", 14);
            e.Graphics.DrawString("Before: 00 01 02 03 04 05 06 07", font, Brushes.Black, new Point(15, 2));
            e.Graphics.DrawString("After:  " + examplemsg[swapchoice], font, Brushes.Black, new Point(15, 25));
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "All files|*.*|BIN|*.bin|DAT|*.dat";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            lblInput.Text = ofd.FileName;
            CheckInputFile();
        }

        private void CheckInputFile()
        {
            var fi = new System.IO.FileInfo(lblInput.Text);
            optSwap2.Enabled = (fi.Length % 2 == 0);
            optSwap2.Checked = false;
            optSwap4.Enabled = (fi.Length % 4 == 0);
            optSwap4.Checked = false;
            optSwap8.Enabled = (fi.Length % 8 == 0);
            optSwap8.Checked = false;
            swapchoice = -1;
            pictureBox1.Refresh();
            btnSwap.Enabled = false;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (droppedFiles.Length > 1)
            {
                MessageBox.Show("You must drag and drop only 1 file.", "Drag and drop");
                return;
            }
            lblInput.Text = droppedFiles[0];
            CheckInputFile();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private static void ChangeVisibility()
        {
            mainForm.Invoke((MethodInvoker)delegate
            {

                mainForm.btnInput.Visible = !mainForm.btnInput.Visible;
                mainForm.btnSwap.Visible = !mainForm.btnSwap.Visible;
                foreach (var o in opt)
                    o.Visible = !o.Visible;
            });
        }

        public static void SetProgress(int value)
        {
            // only update the progressbar if really needs to be updated
            if (value == pBar.Value)
                return;
            mainForm.Invoke((MethodInvoker)delegate
            {
                pBar.Value = value;
            });
        }

        public static void MsgBoxForm(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            mainForm.Invoke((MethodInvoker)delegate
            {
                MessageBox.Show(message, title, buttons, icon);
            });
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string targetfile = lblInput.Text;
            var msg = "Do you want to create a new file?\n\nSelect 'No' to overwrite the input file.";
            if(MessageBox.Show(msg, "Swap bytes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var sfd = new SaveFileDialog();
                sfd.Filter = "All files|*.*|BIN|*.bin|DAT|*.dat";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                targetfile = sfd.FileName;
            }

            ChangeVisibility();
            mainForm.UseWaitCursor = true;
            // launch thread
            var swapParam = new StartSwapParam { inputfile = lblInput.Text, outputfile = targetfile };
            new Thread(StartSwapThread).Start(swapParam);

        }

        public struct StartSwapParam
        {
            public string inputfile;
            public string outputfile;
        }

        public static void StartSwapThread(object param)
        {
            var ssp = (StartSwapParam)param;
            
            try
            {
                var originalbytes = File.ReadAllBytes(ssp.inputfile);
                byte[] swappedbytes = null;
                swappedbytes = ByteSwapper.ByteSwap(originalbytes, swapvalues[swapchoice]);
                File.WriteAllBytes(ssp.outputfile, swappedbytes);
                MsgBoxForm("Done.", "Swap bytes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MsgBoxForm(ex.ToString(), "StartSwapThread", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ChangeVisibility();
                SetProgress(0);
                mainForm.UseWaitCursor = false;
            }
        }

    }
}
