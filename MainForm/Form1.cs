using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System;
using System.Data;

namespace Flashcard_app
{
    public partial class Form_Main : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForml;
        public static Form_Main Instance;  //khai báo một Form tĩnh Instance để chỉ cho this(form_main) để có thể truy vấn nó ở form khác

        public Form_Main()
        {
            InitializeComponent();
            Instance = this;
            //khởi tạo border
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }



        private void OpenChildForm(Form chilForm)
        {
            if (currentChildForml != null)
            {
                currentChildForml.Close();
            }
            currentChildForml = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            pn_Desktop.Controls.Add(chilForm);
            pn_Desktop.BringToFront();
            chilForm.Show();
            Lb_Menu.Text = chilForm.Text;

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(250, 250, 250);
            public static Color color2 = Color.FromArgb(232, 241, 245);
            public static Color color3 = Color.FromArgb(0, 86, 145);
            public static Color color4 = Color.FromArgb(0, 74, 124);
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                if (senderBtn is IconButton btn)
                {
                    //Button
                    currentBtn = btn;
                    currentBtn.BackColor = Color.FromArgb(0, 86, 145);
                    currentBtn.ForeColor = Color.FromArgb(180, 210, 225);
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = Color.FromArgb(180, 210, 225);
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    //Left border button
                    leftBorderBtn.BackColor = Color.FromArgb(180, 210, 225);
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    //Current Child Form Icon
                    Lb_Menu.IconChar = currentBtn.IconChar;
                    Lb_Menu.IconColor = color;
                }
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 74, 124);
                currentBtn.ForeColor = Color.FromArgb(232, 241, 245);
                currentBtn.IconColor = Color.FromArgb(232, 241, 245);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;

            }
        }


        private void bt_Home_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Home());
        }

        private void bt_checkOFF_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Form_CheckOffForm());

        }

        private void bt_disCard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
        }

        //Move Bar

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pn_Trans_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }






        private void pn_Folder_Paint(object sender, PaintEventArgs e)
        {


        }
        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void Lb_Menu_Click(object sender, EventArgs e)
        {

        }

     
    }
}
