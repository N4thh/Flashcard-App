using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard_app.MainForm.Home_Form
{
    public partial class Form_AddFolder : Form
    {
        public Form_AddFolder()
        {
            InitializeComponent();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void tb_EditName_TextChanged(object sender, EventArgs e)
        {                    
        }

        //Text Behind

        private void tb_EditName_Enter(object sender, EventArgs e)
        {
            if (tb_EditName.Text == "Edit Name")
            {
                tb_EditName.Text = "";
                tb_EditName.ForeColor = Color.Black;
            }
        }

        private void tb_EditName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_EditName.Text))
            {
                tb_EditName.Text = "Edit Name";
                tb_EditName.ForeColor = Color.Gray;
            }
        }

        private void tb_EditType_Enter(object sender, EventArgs e)
        {
            if (tb_EditType.Text == "Edit Type")
            {
                tb_EditType.Text = "";
                tb_EditType.ForeColor = Color.Black; 
            }
        }

        private void tb_EditType_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_EditType.Text))
            {
                tb_EditType.Text = "Edit Type"; 
                tb_EditType.ForeColor = Color.Gray;
            }
        }

        private void tb_EditNote_Enter(object sender, EventArgs e)
        {
            if (tb_EditNote.Text == "Add Description")
            {
                tb_EditNote.Text = "";
                tb_EditNote.ForeColor = Color.Black;
            }
        }

        private void tb_EditNote_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_EditNote.Text))
            {
                tb_EditNote.Text = "Add Description";
                tb_EditNote.ForeColor = Color.Gray;
            }
        }
    }
}
