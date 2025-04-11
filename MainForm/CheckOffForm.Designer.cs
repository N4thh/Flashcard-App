namespace Flashcard_app
{
    partial class Form_CheckOffForm
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
            pn_Menu = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            bt_Search = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            pn_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pn_Menu
            // 
            pn_Menu.BackColor = Color.FromArgb(0, 74, 124);
            pn_Menu.Controls.Add(iconButton2);
            pn_Menu.Controls.Add(iconButton1);
            pn_Menu.Controls.Add(bt_Search);
            pn_Menu.Dock = DockStyle.Right;
            pn_Menu.Location = new Point(843, 0);
            pn_Menu.Name = "pn_Menu";
            pn_Menu.Size = new Size(57, 528);
            pn_Menu.TabIndex = 7;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.FromArgb(232, 241, 245);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton2.IconColor = Color.FromArgb(232, 241, 245);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 120);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(57, 60);
            iconButton2.TabIndex = 8;
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.FromArgb(232, 241, 245);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.RotateBack;
            iconButton1.IconColor = Color.FromArgb(232, 241, 245);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 60);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(57, 60);
            iconButton1.TabIndex = 7;
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // bt_Search
            // 
            bt_Search.Dock = DockStyle.Top;
            bt_Search.FlatAppearance.BorderSize = 0;
            bt_Search.FlatStyle = FlatStyle.Flat;
            bt_Search.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Search.ForeColor = Color.FromArgb(232, 241, 245);
            bt_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            bt_Search.IconColor = Color.FromArgb(232, 241, 245);
            bt_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Search.IconSize = 30;
            bt_Search.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Search.Location = new Point(0, 0);
            bt_Search.Name = "bt_Search";
            bt_Search.Padding = new Padding(10, 0, 20, 0);
            bt_Search.Size = new Size(57, 60);
            bt_Search.TabIndex = 5;
            bt_Search.TextAlign = ContentAlignment.MiddleLeft;
            bt_Search.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Search.UseVisualStyleBackColor = true;
            bt_Search.Click += bt_Search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(232, 241, 245);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 528);
            dataGridView1.TabIndex = 8;
            // 
            // Form_CheckOffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 528);
            Controls.Add(dataGridView1);
            Controls.Add(pn_Menu);
            Name = "Form_CheckOffForm";
            Text = "CHECK OFF";
            pn_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pn_Menu;
        private FontAwesome.Sharp.IconButton bt_Search;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dataGridView1;
    }
}