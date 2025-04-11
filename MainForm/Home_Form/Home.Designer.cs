namespace Flashcard_app
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayout_Main = new FlowLayoutPanel();
            bt_AddMain = new FontAwesome.Sharp.IconButton();
            pn_Folder = new FlowLayoutPanel();
            pn_MenuFolder = new FlowLayoutPanel();
            bt_AddFolder = new FontAwesome.Sharp.IconButton();
            lb_NameFolder = new Label();
            flowLayout_Main.SuspendLayout();
            pn_Folder.SuspendLayout();
            pn_MenuFolder.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayout_Main
            // 
            flowLayout_Main.Controls.Add(bt_AddMain);
            flowLayout_Main.Controls.Add(pn_Folder);
            flowLayout_Main.Dock = DockStyle.Fill;
            flowLayout_Main.Location = new Point(0, 0);
            flowLayout_Main.Name = "flowLayout_Main";
            flowLayout_Main.Size = new Size(900, 528);
            flowLayout_Main.TabIndex = 7;
            // 
            // bt_AddMain
            // 
            bt_AddMain.AutoSize = true;
            bt_AddMain.BackColor = Color.FromArgb(232, 241, 245);
            bt_AddMain.FlatStyle = FlatStyle.Flat;
            bt_AddMain.ForeColor = Color.FromArgb(0, 86, 145);
            bt_AddMain.IconChar = FontAwesome.Sharp.IconChar.Add;
            bt_AddMain.IconColor = Color.FromArgb(0, 86, 145);
            bt_AddMain.IconFont = FontAwesome.Sharp.IconFont.Solid;
            bt_AddMain.IconSize = 30;
            bt_AddMain.Location = new Point(3, 3);
            bt_AddMain.Name = "bt_AddMain";
            bt_AddMain.Size = new Size(46, 38);
            bt_AddMain.TabIndex = 9;
            bt_AddMain.UseVisualStyleBackColor = false;
            bt_AddMain.Click += bt_AddMain_Click;
            // 
            // pn_Folder
            // 
            pn_Folder.BackColor = Color.FromArgb(232, 241, 245);
            pn_Folder.BorderStyle = BorderStyle.FixedSingle;
            pn_Folder.Controls.Add(pn_MenuFolder);
            pn_Folder.Controls.Add(lb_NameFolder);
            pn_Folder.Location = new Point(82, 3);
            pn_Folder.Margin = new Padding(30, 3, 3, 3);
            pn_Folder.Name = "pn_Folder";
            pn_Folder.Size = new Size(197, 207);
            pn_Folder.TabIndex = 11;
            pn_Folder.Paint += pn_Folder_Paint_1;
            pn_Folder.DoubleClick += FormAnsOpen_DoubleClick;
            // 
            // pn_MenuFolder
            // 
            pn_MenuFolder.Controls.Add(bt_AddFolder);
            pn_MenuFolder.Location = new Point(0, 0);
            pn_MenuFolder.Margin = new Padding(0, 0, 0, 3);
            pn_MenuFolder.Name = "pn_MenuFolder";
            pn_MenuFolder.Size = new Size(197, 36);
            pn_MenuFolder.TabIndex = 0;
            // 
            // bt_AddFolder
            // 
            bt_AddFolder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_AddFolder.FlatAppearance.BorderSize = 0;
            bt_AddFolder.FlatStyle = FlatStyle.Flat;
            bt_AddFolder.ForeColor = Color.FromArgb(0, 86, 145);
            bt_AddFolder.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            bt_AddFolder.IconColor = Color.FromArgb(0, 86, 145);
            bt_AddFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_AddFolder.IconSize = 30;
            bt_AddFolder.ImageAlign = ContentAlignment.MiddleRight;
            bt_AddFolder.Location = new Point(0, 0);
            bt_AddFolder.Margin = new Padding(0);
            bt_AddFolder.Name = "bt_AddFolder";
            bt_AddFolder.Size = new Size(37, 35);
            bt_AddFolder.TabIndex = 3;
            bt_AddFolder.TextAlign = ContentAlignment.MiddleRight;
            bt_AddFolder.UseVisualStyleBackColor = true;
            // 
            // lb_NameFolder
            // 
            lb_NameFolder.Dock = DockStyle.Top;
            lb_NameFolder.Font = new Font("Sans Serif Collection", 11.9999981F);
            lb_NameFolder.ForeColor = Color.FromArgb(0, 86, 145);
            lb_NameFolder.Location = new Point(3, 39);
            lb_NameFolder.Name = "lb_NameFolder";
            lb_NameFolder.Size = new Size(190, 30);
            lb_NameFolder.TabIndex = 1;
            lb_NameFolder.Text = "Name";
            lb_NameFolder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 528);
            Controls.Add(flowLayout_Main);
            Name = "Home";
            Text = "HOME";
            Load += Home_Load;
            flowLayout_Main.ResumeLayout(false);
            flowLayout_Main.PerformLayout();
            pn_Folder.ResumeLayout(false);
            pn_MenuFolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayout_Main;
        private FontAwesome.Sharp.IconButton bt_AddMain;
        private FlowLayoutPanel pn_Folder;
        private FlowLayoutPanel pn_MenuFolder;
        private FontAwesome.Sharp.IconButton bt_AddFolder;
        private Label lb_NameFolder;
    }
}