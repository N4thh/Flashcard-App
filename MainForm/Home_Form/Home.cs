using Flashcard_app.MainForm.Home_Form;
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
using Microsoft.Data.SqlClient;
using FontAwesome.Sharp;
using System.Xml;

namespace Flashcard_app
{
    public partial class Home : Form
    {
        private Form f;
        public Home()
        {
            InitializeComponent();


        }
        private void Home_Load(object sender, EventArgs e)
        {
            LoadFoldersFromDatabase();
        }

       
        private void PanelFolder_DoubleClick(object sender, EventArgs e)
        {
            Form_AnswerFolders folder = new Form_AnswerFolders();
            folder.StartPosition = FormStartPosition.Manual;

            if (Form_Main.Instance != null)          //Nếu form Main đang được mở thì tắt, và lấy vị trí của nó 
            {
                folder.Location = Form_Main.Instance.Location;
                Form_Main.Instance.Hide();
            }
            else
            {
                folder.Location = new Point(100, 100); // fallback nếu Instance null
                                                       // nếu không lấy được vị trí cũ của main thì lấy đại ví trí đâu đó :)
            }

            folder.Show();
        }

        private void bt_AddMain_Click(object sender, EventArgs e)
        {
            Form_AddFolder addfolder = new Form_AddFolder();
            addfolder.Size = new Size(440, 300);

            //Postion of button 
            Point buttonScreenPoint = bt_AddMain.PointToScreen(Point.Empty);
            int x = buttonScreenPoint.X;
            int y = buttonScreenPoint.Y + bt_AddMain.Width + 5;

            addfolder.StartPosition = FormStartPosition.Manual;
            addfolder.Location = new Point(x, y);


            addfolder.FormBorderStyle = FormBorderStyle.FixedToolWindow; // hoặc None
            if (addfolder.ShowDialog() == DialogResult.OK) // dùng OK để reload
            {
                LoadFoldersFromDatabase();
            }

        }


        //LoadNewFolder

        private void LoadFoldersFromDatabase()
        {
     
            using (SqlConnection conn = new SqlConnection(@"Data Source=NHATANH;Initial Catalog=""App Flashcard"";Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                string query = "SELECT folderid, foldername, Note, PanelColor FROM Folder";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    //Remove the old panel when refresh
                    for (int i = flowLayout_Main.Controls.Count - 1; i >= 0; i--)  //duyệt ngược
                    {
                        Control ctrl = flowLayout_Main.Controls[i];
                        if (ctrl is FlowLayoutPanel)
                        {
                            flowLayout_Main.Controls.RemoveAt(i);
                        }
                    }
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Create folder panel (FlowLayoutPanel)
                        FlowLayoutPanel panelFolder = new FlowLayoutPanel()
                        {
                            Height = 210,
                            Width = 200,
                            FlowDirection = FlowDirection.TopDown,
                            WrapContents = false,
                            AutoScroll = false,
                            Margin = new Padding(30, 3, 3, 3),
                            //Color.FromArgb(232, 241, 245),
                            Tag = reader["folderid"],

                        };
                        IconButton iconButton = new IconButton()
                        {
                            Height = 94,
                            Width = 197,                                                    
                            IconChar = IconChar.FolderBlank,
                            IconSize = 100,
                            Dock = DockStyle.Top,
                            IconFont = IconFont.Solid,
                            FlatStyle = FlatStyle.Flat,
                        };
                        iconButton.FlatAppearance.BorderSize = 0;       
                        iconButton.Click += PanelFolder_DoubleClick;

                        //if Panel color not null -> get color  // else is set df color
                        if (!reader.IsDBNull(reader.GetOrdinal("PanelColor")))
                        {
                            iconButton.IconColor = Color.FromName(reader["PanelColor"].ToString());
                        }
                        else
                        {
                            iconButton.IconColor = Color.FromArgb(0, 86, 145); // fallback màu mặc định
                        }
                        // Create label (folder name)
                        Label labelFolder = new Label()
                        {
                            Text = reader["foldername"].ToString(),
                            Font = new Font("Sans Serif Collection", 11, FontStyle.Regular),
                            ForeColor = Color.FromArgb(0, 86, 145),
                            TextAlign = ContentAlignment.MiddleCenter,
                            AutoSize = false,
                            Width = 190,
                            Height = 30,
                            Margin = new Padding(5, 5, 5, 5),
                            Dock = DockStyle.Top
                        };

                        // Create icon button (menu) positioned at top-right
                        IconButton iconSetting = new IconButton()
                        {
                            Size = new Size(20, 20),
                            IconColor = Color.FromArgb(0, 86, 145),
                            IconSize = 20,
                            IconChar = IconChar.EllipsisH,
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.Transparent,
                            Anchor = AnchorStyles.Top | AnchorStyles.Right,
                            Margin = new Padding(160, 5, 5, 5) 
                        };

                        iconSetting.FlatAppearance.BorderSize = 0;

                        // Add to container
                        panelFolder.Controls.Add(iconSetting);
                        panelFolder.Controls.Add(iconButton);
                        panelFolder.Controls.Add(labelFolder);   

                        flowLayout_Main.Controls.Add(panelFolder);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading folder: " + ex.Message);
                }
            }
        }







        private void pn_Folder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_Folder_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
