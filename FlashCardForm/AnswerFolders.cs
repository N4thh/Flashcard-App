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

namespace Flashcard_app
{
    public partial class Form_AnswerFolders : Form
    {
        public Form_AnswerFolders()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void bt_ListQuestion_Click_1(object sender, EventArgs e)
        {
            Form_StudyMode study = new Form_StudyMode();
            study.StartPosition = FormStartPosition.Manual;
            study.Location = this.Location;
            study.Show();
            this.Close();
        }



        private void bt_Home_Click(object sender, EventArgs e)
        {
            Form_Main main = new Form_Main();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = this.Location;
            main.Show();
            this.Close();
        }

        private void bt_Category_Click(object sender, EventArgs e)
        {
            Form_ListQuestion question = new Form_ListQuestion();
            question.StartPosition = FormStartPosition.Manual;
            question.Location = this.Location;
            this.Close();
            question.Show();


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void lb_NameFolder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        private void grBox_Menu_Enter(object sender, EventArgs e)
        {

        }
        private void bt_ListQuestion_Click(object sender, EventArgs e)
        {

        }

        
    }
}
