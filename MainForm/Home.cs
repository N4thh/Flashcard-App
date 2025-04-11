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
    public partial class Home : Form
    {
        private Form f ; 
        public Home()
        {
            InitializeComponent();
            
        }

        private void FormAnsOpen_DoubleClick(object sender, EventArgs e)
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




        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void pn_Folder_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
