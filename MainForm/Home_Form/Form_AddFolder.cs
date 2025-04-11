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
        private SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=NHATANH;Initial Catalog=AppFlashcard;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            return new SqlConnection(connectionString);
        }

        private void AddFolder()
        {
            using (SqlConnection conn = GetConnection())
            {
                if (string.IsNullOrWhiteSpace(tb_EditName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên folder!");
                    return;
                }
                    try
                    {
                    conn.Open();
                    string querry = "insert into Folder (foldername ,created, Note, PanelColor, islearned) values (@name, @date, @note, @colors ,0)";
                    SqlCommand cmd = new SqlCommand(querry, conn);

                    cmd.Parameters.AddWithValue("@name", tb_EditName.Text);
                    cmd.Parameters.AddWithValue("@created", DateTime.Now);
                    cmd.Parameters.AddWithValue("@note", string.IsNullOrWhiteSpace(tb_EditNote.Text) ? DBNull.Value : tb_EditNote.Text);
                    cmd.Parameters.AddWithValue("@colors", string.IsNullOrWhiteSpace(selectedColor) ? DBNull.Value : selectedColor);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm folder thành công!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating folder" + ex.Message);
                }
            }
        }

        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_Save_Click(object sender, EventArgs e)
        {
            AddFolder();
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

        private void tb_EditName_TextChanged(object sender, EventArgs e)
        {
        }

       
    }
}
