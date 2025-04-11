namespace Flashcard_app
{
    partial class Form_ListQuestion
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
            pn_Trans = new Panel();
            lb_NameFolder = new Label();
            bt_Setting = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            bt_Exit = new FontAwesome.Sharp.IconButton();
            grBox_Menu = new GroupBox();
            bt_Next = new FontAwesome.Sharp.IconButton();
            bt_Add = new FontAwesome.Sharp.IconButton();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            pn_Id = new Panel();
            lb_Id = new Label();
            pn_Question = new Panel();
            lb_Question = new Label();
            pn_Trans.SuspendLayout();
            grBox_Menu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pn_Id.SuspendLayout();
            pn_Question.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Trans
            // 
            pn_Trans.BackColor = Color.FromArgb(12, 59, 46);
            pn_Trans.BorderStyle = BorderStyle.FixedSingle;
            pn_Trans.Controls.Add(lb_NameFolder);
            pn_Trans.Controls.Add(bt_Setting);
            pn_Trans.Controls.Add(panel2);
            pn_Trans.Controls.Add(bt_Exit);
            pn_Trans.Dock = DockStyle.Top;
            pn_Trans.Location = new Point(0, 0);
            pn_Trans.Margin = new Padding(0);
            pn_Trans.Name = "pn_Trans";
            pn_Trans.Size = new Size(1136, 64);
            pn_Trans.TabIndex = 3;
            // 
            // lb_NameFolder
            // 
            lb_NameFolder.BackColor = Color.FromArgb(0, 74, 124);
            lb_NameFolder.Dock = DockStyle.Fill;
            lb_NameFolder.FlatStyle = FlatStyle.Flat;
            lb_NameFolder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_NameFolder.ForeColor = Color.FromArgb(232, 241, 245);
            lb_NameFolder.Location = new Point(67, 0);
            lb_NameFolder.Name = "lb_NameFolder";
            lb_NameFolder.Size = new Size(1030, 62);
            lb_NameFolder.TabIndex = 6;
            lb_NameFolder.Text = "QUESTION LIST";
            lb_NameFolder.TextAlign = ContentAlignment.MiddleLeft;
            lb_NameFolder.MouseDown += lb_NameFolder_MouseDown;
            // 
            // bt_Setting
            // 
            bt_Setting.AutoEllipsis = true;
            bt_Setting.BackColor = Color.FromArgb(0, 74, 124);
            bt_Setting.Dock = DockStyle.Right;
            bt_Setting.FlatAppearance.BorderSize = 0;
            bt_Setting.FlatStyle = FlatStyle.Flat;
            bt_Setting.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Setting.ForeColor = Color.FromArgb(241, 239, 236);
            bt_Setting.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            bt_Setting.IconColor = Color.FromArgb(232, 241, 245);
            bt_Setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Setting.IconSize = 30;
            bt_Setting.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Setting.Location = new Point(1097, 0);
            bt_Setting.Name = "bt_Setting";
            bt_Setting.Size = new Size(37, 62);
            bt_Setting.TabIndex = 5;
            bt_Setting.TextAlign = ContentAlignment.MiddleLeft;
            bt_Setting.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Setting.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(86, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 3;
            // 
            // bt_Exit
            // 
            bt_Exit.AutoEllipsis = true;
            bt_Exit.BackColor = Color.FromArgb(0, 74, 124);
            bt_Exit.Dock = DockStyle.Left;
            bt_Exit.FlatAppearance.BorderSize = 0;
            bt_Exit.FlatStyle = FlatStyle.Flat;
            bt_Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Exit.ForeColor = Color.FromArgb(232, 241, 245);
            bt_Exit.IconChar = FontAwesome.Sharp.IconChar.PersonThroughWindow;
            bt_Exit.IconColor = Color.FromArgb(232, 241, 245);
            bt_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Exit.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Exit.Location = new Point(0, 0);
            bt_Exit.Name = "bt_Exit";
            bt_Exit.Size = new Size(67, 62);
            bt_Exit.TabIndex = 0;
            bt_Exit.TextAlign = ContentAlignment.MiddleLeft;
            bt_Exit.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Exit.UseVisualStyleBackColor = false;
            bt_Exit.Click += bt_Exit_Click;
            // 
            // grBox_Menu
            // 
            grBox_Menu.BackColor = Color.FromArgb(0, 74, 124);
            grBox_Menu.Controls.Add(bt_Next);
            grBox_Menu.Controls.Add(bt_Add);
            grBox_Menu.Dock = DockStyle.Bottom;
            grBox_Menu.FlatStyle = FlatStyle.Flat;
            grBox_Menu.Location = new Point(0, 534);
            grBox_Menu.Name = "grBox_Menu";
            grBox_Menu.Size = new Size(1136, 107);
            grBox_Menu.TabIndex = 5;
            grBox_Menu.TabStop = false;
            // 
            // bt_Next
            // 
            bt_Next.AutoSize = true;
            bt_Next.Dock = DockStyle.Right;
            bt_Next.FlatAppearance.BorderSize = 0;
            bt_Next.FlatStyle = FlatStyle.Flat;
            bt_Next.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Next.ForeColor = Color.FromArgb(241, 239, 236);
            bt_Next.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            bt_Next.IconColor = Color.FromArgb(232, 241, 245);
            bt_Next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Next.IconSize = 55;
            bt_Next.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Next.Location = new Point(1071, 19);
            bt_Next.Name = "bt_Next";
            bt_Next.Size = new Size(62, 85);
            bt_Next.TabIndex = 4;
            bt_Next.TextAlign = ContentAlignment.MiddleLeft;
            bt_Next.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Next.UseVisualStyleBackColor = true;
            // 
            // bt_Add
            // 
            bt_Add.AutoSize = true;
            bt_Add.Dock = DockStyle.Left;
            bt_Add.FlatAppearance.BorderSize = 0;
            bt_Add.FlatStyle = FlatStyle.Flat;
            bt_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Add.ForeColor = Color.FromArgb(241, 239, 236);
            bt_Add.IconChar = FontAwesome.Sharp.IconChar.Add;
            bt_Add.IconColor = Color.FromArgb(232, 241, 245);
            bt_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Add.IconSize = 55;
            bt_Add.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Add.Location = new Point(3, 19);
            bt_Add.Name = "bt_Add";
            bt_Add.Size = new Size(62, 85);
            bt_Add.TabIndex = 2;
            bt_Add.TextAlign = ContentAlignment.MiddleLeft;
            bt_Add.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Add.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.90909F));
            tableLayoutPanel1.Controls.Add(pn_Id, 0, 0);
            tableLayoutPanel1.Controls.Add(pn_Question, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1136, 470);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // pn_Id
            // 
            pn_Id.BackColor = Color.FromArgb(232, 241, 245);
            pn_Id.Controls.Add(lb_Id);
            pn_Id.Dock = DockStyle.Fill;
            pn_Id.Location = new Point(0, 0);
            pn_Id.Margin = new Padding(0);
            pn_Id.Name = "pn_Id";
            pn_Id.Size = new Size(103, 470);
            pn_Id.TabIndex = 2;
            // 
            // lb_Id
            // 
            lb_Id.BorderStyle = BorderStyle.FixedSingle;
            lb_Id.Dock = DockStyle.Top;
            lb_Id.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Id.ForeColor = Color.FromArgb(0, 86, 145);
            lb_Id.Location = new Point(0, 0);
            lb_Id.Name = "lb_Id";
            lb_Id.Size = new Size(103, 22);
            lb_Id.TabIndex = 0;
            lb_Id.Text = "ID";
            // 
            // pn_Question
            // 
            pn_Question.BackColor = Color.FromArgb(232, 241, 245);
            pn_Question.Controls.Add(lb_Question);
            pn_Question.Dock = DockStyle.Fill;
            pn_Question.Location = new Point(106, 0);
            pn_Question.Margin = new Padding(3, 0, 0, 0);
            pn_Question.Name = "pn_Question";
            pn_Question.Size = new Size(1030, 470);
            pn_Question.TabIndex = 3;
            // 
            // lb_Question
            // 
            lb_Question.BackColor = Color.FromArgb(232, 241, 245);
            lb_Question.BorderStyle = BorderStyle.FixedSingle;
            lb_Question.Dock = DockStyle.Top;
            lb_Question.FlatStyle = FlatStyle.Flat;
            lb_Question.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Question.ForeColor = Color.FromArgb(0, 86, 145);
            lb_Question.Location = new Point(0, 0);
            lb_Question.Name = "lb_Question";
            lb_Question.Size = new Size(1030, 23);
            lb_Question.TabIndex = 0;
            lb_Question.Text = "Question";
            // 
            // Form_ListQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1136, 641);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(grBox_Menu);
            Controls.Add(pn_Trans);
            Name = "Form_ListQuestion";
            pn_Trans.ResumeLayout(false);
            grBox_Menu.ResumeLayout(false);
            grBox_Menu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pn_Id.ResumeLayout(false);
            pn_Question.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Trans;
        private Label lb_NameFolder;
        private FontAwesome.Sharp.IconButton bt_Setting;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton bt_Exit;
        private GroupBox grBox_Menu;
        private FontAwesome.Sharp.IconButton bt_Next;
        private FontAwesome.Sharp.IconButton bt_Add;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pn_Id;
        private Label lb_Id;
        private Panel pn_Question;
        private Label lb_Question;
    }
}