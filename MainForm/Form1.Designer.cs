namespace Flashcard_app
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
 

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pn_Menu = new Panel();
            bt_disCard = new FontAwesome.Sharp.IconButton();
            bt_checkOFF = new FontAwesome.Sharp.IconButton();
            bt_Home = new FontAwesome.Sharp.IconButton();
            pn_Logo = new Panel();
            pn_Trans = new Panel();
            panel2 = new Panel();
            Lb_Menu = new FontAwesome.Sharp.IconButton();
            pn_Desktop = new Panel();
            pn_Menu.SuspendLayout();
            pn_Trans.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Menu
            // 
            pn_Menu.BackColor = Color.FromArgb(0, 74, 124);
            pn_Menu.Controls.Add(bt_disCard);
            pn_Menu.Controls.Add(bt_checkOFF);
            pn_Menu.Controls.Add(bt_Home);
            pn_Menu.Controls.Add(pn_Logo);
            pn_Menu.Dock = DockStyle.Left;
            pn_Menu.Location = new Point(0, 0);
            pn_Menu.Name = "pn_Menu";
            pn_Menu.Size = new Size(220, 641);
            pn_Menu.TabIndex = 0;
            // 
            // bt_disCard
            // 
            bt_disCard.Dock = DockStyle.Top;
            bt_disCard.FlatAppearance.BorderSize = 0;
            bt_disCard.FlatStyle = FlatStyle.Flat;
            bt_disCard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_disCard.ForeColor = Color.FromArgb(232, 241, 245);
            bt_disCard.IconChar = FontAwesome.Sharp.IconChar.Trash;
            bt_disCard.IconColor = Color.FromArgb(232, 241, 245);
            bt_disCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_disCard.ImageAlign = ContentAlignment.MiddleLeft;
            bt_disCard.Location = new Point(0, 291);
            bt_disCard.Name = "bt_disCard";
            bt_disCard.Padding = new Padding(10, 0, 20, 0);
            bt_disCard.Size = new Size(220, 60);
            bt_disCard.TabIndex = 3;
            bt_disCard.Text = "DISCARD";
            bt_disCard.TextAlign = ContentAlignment.MiddleLeft;
            bt_disCard.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_disCard.UseVisualStyleBackColor = true;
            bt_disCard.Click += bt_disCard_Click;
            // 
            // bt_checkOFF
            // 
            bt_checkOFF.Dock = DockStyle.Top;
            bt_checkOFF.FlatAppearance.BorderSize = 0;
            bt_checkOFF.FlatStyle = FlatStyle.Flat;
            bt_checkOFF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_checkOFF.ForeColor = Color.FromArgb(232, 241, 245);
            bt_checkOFF.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            bt_checkOFF.IconColor = Color.FromArgb(232, 241, 245);
            bt_checkOFF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_checkOFF.ImageAlign = ContentAlignment.MiddleLeft;
            bt_checkOFF.Location = new Point(0, 231);
            bt_checkOFF.Name = "bt_checkOFF";
            bt_checkOFF.Padding = new Padding(10, 0, 20, 0);
            bt_checkOFF.Size = new Size(220, 60);
            bt_checkOFF.TabIndex = 2;
            bt_checkOFF.Text = "CHECK OFF";
            bt_checkOFF.TextAlign = ContentAlignment.MiddleLeft;
            bt_checkOFF.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_checkOFF.UseVisualStyleBackColor = true;
            bt_checkOFF.Click += bt_checkOFF_Click;
            // 
            // bt_Home
            // 
            bt_Home.Dock = DockStyle.Top;
            bt_Home.FlatAppearance.BorderSize = 0;
            bt_Home.FlatStyle = FlatStyle.Flat;
            bt_Home.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Home.ForeColor = Color.FromArgb(232, 241, 245);
            bt_Home.IconChar = FontAwesome.Sharp.IconChar.House;
            bt_Home.IconColor = Color.FromArgb(232, 241, 245);
            bt_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Home.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Home.Location = new Point(0, 171);
            bt_Home.Name = "bt_Home";
            bt_Home.Padding = new Padding(10, 0, 20, 0);
            bt_Home.Size = new Size(220, 60);
            bt_Home.TabIndex = 1;
            bt_Home.Text = "HOME";
            bt_Home.TextAlign = ContentAlignment.MiddleLeft;
            bt_Home.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Home.UseVisualStyleBackColor = true;
            bt_Home.Click += bt_Home_Click;
            // 
            // pn_Logo
            // 
            pn_Logo.BackColor = Color.FromArgb(0, 74, 124);
            pn_Logo.BorderStyle = BorderStyle.FixedSingle;
            pn_Logo.Dock = DockStyle.Top;
            pn_Logo.Location = new Point(0, 0);
            pn_Logo.Name = "pn_Logo";
            pn_Logo.Size = new Size(220, 171);
            pn_Logo.TabIndex = 0;
            // 
            // pn_Trans
            // 
            pn_Trans.BackColor = Color.FromArgb(0, 74, 124);
            pn_Trans.Controls.Add(panel2);
            pn_Trans.Controls.Add(Lb_Menu);
            pn_Trans.Dock = DockStyle.Top;
            pn_Trans.Location = new Point(220, 0);
            pn_Trans.Margin = new Padding(0);
            pn_Trans.Name = "pn_Trans";
            pn_Trans.Size = new Size(916, 64);
            pn_Trans.TabIndex = 1;
            pn_Trans.MouseDown += pn_Trans_MouseDown;
            // 
            // panel2
            // 
            panel2.Location = new Point(86, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 3;
            // 
            // Lb_Menu
            // 
            Lb_Menu.AutoEllipsis = true;
            Lb_Menu.Dock = DockStyle.Left;
            Lb_Menu.FlatAppearance.BorderSize = 0;
            Lb_Menu.FlatStyle = FlatStyle.Flat;
            Lb_Menu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Menu.ForeColor = Color.FromArgb(232, 241, 245);
            Lb_Menu.IconChar = FontAwesome.Sharp.IconChar.House;
            Lb_Menu.IconColor = Color.FromArgb(232, 241, 245);
            Lb_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Lb_Menu.IconSize = 43;
            Lb_Menu.ImageAlign = ContentAlignment.MiddleLeft;
            Lb_Menu.Location = new Point(0, 0);
            Lb_Menu.Name = "Lb_Menu";
            Lb_Menu.Size = new Size(200, 64);
            Lb_Menu.TabIndex = 0;
            Lb_Menu.Text = "HOME";
            Lb_Menu.TextAlign = ContentAlignment.MiddleLeft;
            Lb_Menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            Lb_Menu.UseVisualStyleBackColor = true;
            Lb_Menu.Click += Lb_Menu_Click;
            // 
            // pn_Desktop
            // 
            pn_Desktop.Dock = DockStyle.Fill;
            pn_Desktop.Location = new Point(220, 64);
            pn_Desktop.Name = "pn_Desktop";
            pn_Desktop.Size = new Size(916, 577);
            pn_Desktop.TabIndex = 3;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1136, 641);
            Controls.Add(pn_Desktop);
            Controls.Add(pn_Trans);
            Controls.Add(pn_Menu);
            Cursor = Cursors.PanWest;
            Name = "Form_Main";
            Text = " ";
            Load += Form_Main_Load;
            pn_Menu.ResumeLayout(false);
            pn_Trans.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Menu;
        private Panel pn_Logo;
        private FontAwesome.Sharp.IconButton bt_Home;
        private FontAwesome.Sharp.IconButton bt_disCard;
        private FontAwesome.Sharp.IconButton bt_checkOFF;
        private Panel pn_Trans;
        private FontAwesome.Sharp.IconButton Lb_Menu;
        private Panel panel2;
        private Panel pn_Desktop;
    }
}
