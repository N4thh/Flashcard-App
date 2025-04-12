using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace Flashcard_app.MainForm.Home_Form
{
    public partial class Form_AddFolder : Form
    {
        private string selectedColor = null;


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
        private void bt_Save_Click(object sender, EventArgs e)
        {
            int newFolderId = 1;
            using (SqlConnection conn = new SqlConnection(@"Data Source=NHATANH;Initial Catalog=""App Flashcard"";Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                try
                {
                    conn.Open();
                    string querry = "Insert into Folder(folderid ,foldername, Note, PanelColor, islearned, created)" +
                                    "Values(@folderid ,@foldername, @Note, @PanelColor, @islearned, @created)  ";
                    using (SqlCommand cmd = new SqlCommand(querry,conn ))
                    {
                        cmd.Parameters.AddWithValue("@folderid", newFolderId);
                        cmd.Parameters.AddWithValue("@foldername", string.IsNullOrWhiteSpace(tb_EditName.Text) ? DBNull.Value : (object)tb_EditName.Text);
                        cmd.Parameters.AddWithValue("@Note", string.IsNullOrWhiteSpace(tb_EditNote.Text) ? DBNull.Value : (object)tb_EditNote.Text);
                        cmd.Parameters.AddWithValue("@PanelColor", selectedColor ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@islearned", 0);
                        cmd.Parameters.AddWithValue("created", DateTime.Now );

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Add Success"); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder" + ex.Message);
                }
            }
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

     
        //Button colors 
        private void bt_Organe_Click(object sender, EventArgs e)
        {
            selectedColor = "Coral";
            
        }

        private void bt_Red_Click(object sender, EventArgs e)
        {
            selectedColor = "Red";
        }

        private void bt_Green_Click(object sender, EventArgs e)
        {
            selectedColor = "Lime";
        }

        private void bt_Blue_Click(object sender, EventArgs e)
        {
            selectedColor = "Turquoise";
        }

        private void bt_Purple_Click(object sender, EventArgs e)
        {
            selectedColor = "Violet";
        }


        private void tb_EditName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
