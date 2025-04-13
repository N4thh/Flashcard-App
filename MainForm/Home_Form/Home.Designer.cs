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
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            flowLayout_Main.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayout_Main
            // 
            flowLayout_Main.Controls.Add(bt_AddMain);
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
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
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
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayout_Main;
        private FontAwesome.Sharp.IconButton bt_AddMain;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}