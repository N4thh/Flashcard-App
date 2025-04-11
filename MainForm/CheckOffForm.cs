using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard_app
{
    public partial class Form_CheckOffForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form_CheckOffForm()
        {
            InitializeComponent();

            //khởi tạo border
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.Controls.Add(leftBorderBtn);    
            //Khởi tạo Active khi chạy form        
             
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(250, 250, 250);
            public static Color color2 = Color.FromArgb(232, 241, 245);
            public static Color color3 = Color.FromArgb(0, 86, 145);
            public static Color color4 = Color.FromArgb(0, 74, 124);
        }

       
        
        private void bt_Home_Click(object sender, EventArgs e)
        {
            Form_Main main = new Form_Main();
            main.Show();
            this.Close();
            
        }

        private void bt_checkOFF_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_disCard_Click(object sender, EventArgs e)
        {
            
        }
    }
}
