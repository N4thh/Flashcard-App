namespace Flashcard_app
{
    partial class Form_AnswerFolders
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
            bt_Category = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            bt_Home = new FontAwesome.Sharp.IconButton();
            grBox_Menu = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            bt_ListQuestion = new FontAwesome.Sharp.IconButton();
            bt_Add = new FontAwesome.Sharp.IconButton();
            bt_Edit = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            tbLayout_FlashCard = new TableLayoutPanel();
            panel1 = new Panel();
            lb_CardAnswer = new Label();
            pn_Left = new Panel();
            lb_CardQuestion = new Label();
            pn_Trans.SuspendLayout();
            grBox_Menu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tbLayout_FlashCard.SuspendLayout();
            panel1.SuspendLayout();
            pn_Left.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Trans
            // 
            pn_Trans.BackColor = Color.FromArgb(35, 83, 71);
            pn_Trans.BorderStyle = BorderStyle.FixedSingle;
            pn_Trans.Controls.Add(lb_NameFolder);
            pn_Trans.Controls.Add(bt_Setting);
            pn_Trans.Controls.Add(bt_Category);
            pn_Trans.Controls.Add(panel2);
            pn_Trans.Controls.Add(bt_Home);
            pn_Trans.Dock = DockStyle.Top;
            pn_Trans.Location = new Point(0, 0);
            pn_Trans.Margin = new Padding(0);
            pn_Trans.Name = "pn_Trans";
            pn_Trans.Size = new Size(1136, 64);
            pn_Trans.TabIndex = 2;
            // 
            // lb_NameFolder
            // 
            lb_NameFolder.BackColor = Color.FromArgb(0, 74, 124);
            lb_NameFolder.Dock = DockStyle.Fill;
            lb_NameFolder.FlatStyle = FlatStyle.Flat;
            lb_NameFolder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_NameFolder.ForeColor = Color.FromArgb(232, 241, 245);
            lb_NameFolder.Location = new Point(263, 0);
            lb_NameFolder.Name = "lb_NameFolder";
            lb_NameFolder.Size = new Size(834, 62);
            lb_NameFolder.TabIndex = 6;
            lb_NameFolder.Text = "NAME FOLDER";
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
            // bt_Category
            // 
            bt_Category.AutoEllipsis = true;
            bt_Category.BackColor = Color.FromArgb(0, 74, 124);
            bt_Category.Dock = DockStyle.Left;
            bt_Category.FlatAppearance.BorderSize = 0;
            bt_Category.FlatStyle = FlatStyle.Flat;
            bt_Category.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Category.ForeColor = Color.FromArgb(232, 241, 245);
            bt_Category.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            bt_Category.IconColor = Color.FromArgb(232, 241, 245);
            bt_Category.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Category.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Category.Location = new Point(125, 0);
            bt_Category.Name = "bt_Category";
            bt_Category.Size = new Size(138, 62);
            bt_Category.TabIndex = 4;
            bt_Category.Text = "Category";
            bt_Category.TextAlign = ContentAlignment.MiddleLeft;
            bt_Category.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Category.UseVisualStyleBackColor = false;
            bt_Category.Click += bt_Category_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(86, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 3;
            // 
            // bt_Home
            // 
            bt_Home.AutoEllipsis = true;
            bt_Home.BackColor = Color.FromArgb(0, 74, 124);
            bt_Home.Dock = DockStyle.Left;
            bt_Home.FlatAppearance.BorderSize = 0;
            bt_Home.FlatStyle = FlatStyle.Flat;
            bt_Home.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Home.ForeColor = Color.FromArgb(232, 241, 245);
            bt_Home.IconChar = FontAwesome.Sharp.IconChar.House;
            bt_Home.IconColor = Color.FromArgb(232, 241, 245);
            bt_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Home.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Home.Location = new Point(0, 0);
            bt_Home.Name = "bt_Home";
            bt_Home.Size = new Size(125, 62);
            bt_Home.TabIndex = 0;
            bt_Home.Text = "HOME";
            bt_Home.TextAlign = ContentAlignment.MiddleLeft;
            bt_Home.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Home.UseVisualStyleBackColor = false;
            bt_Home.Click += bt_Home_Click;
            // 
            // grBox_Menu
            // 
            grBox_Menu.BackColor = Color.FromArgb(0, 74, 124);
            grBox_Menu.Controls.Add(tableLayoutPanel1);
            grBox_Menu.Controls.Add(iconButton4);
            grBox_Menu.Dock = DockStyle.Bottom;
            grBox_Menu.FlatStyle = FlatStyle.Flat;
            grBox_Menu.Location = new Point(0, 534);
            grBox_Menu.Name = "grBox_Menu";
            grBox_Menu.Size = new Size(1136, 107);
            grBox_Menu.TabIndex = 4;
            grBox_Menu.TabStop = false;
            grBox_Menu.Enter += grBox_Menu_Enter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel1.Controls.Add(bt_ListQuestion, 2, 0);
            tableLayoutPanel1.Controls.Add(bt_Add, 1, 0);
            tableLayoutPanel1.Controls.Add(bt_Edit, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1068, 85);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // bt_ListQuestion
            // 
            bt_ListQuestion.AutoSize = true;
            bt_ListQuestion.Dock = DockStyle.Fill;
            bt_ListQuestion.FlatAppearance.BorderSize = 0;
            bt_ListQuestion.FlatStyle = FlatStyle.Flat;
            bt_ListQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_ListQuestion.ForeColor = Color.FromArgb(241, 239, 236);
            bt_ListQuestion.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            bt_ListQuestion.IconColor = Color.FromArgb(232, 241, 245);
            bt_ListQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_ListQuestion.IconSize = 55;
            bt_ListQuestion.Location = new Point(728, 3);
            bt_ListQuestion.Name = "bt_ListQuestion";
            bt_ListQuestion.Size = new Size(337, 79);
            bt_ListQuestion.TabIndex = 4;
            bt_ListQuestion.TextAlign = ContentAlignment.MiddleLeft;
            bt_ListQuestion.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_ListQuestion.UseVisualStyleBackColor = true;
            bt_ListQuestion.Click += bt_ListQuestion_Click_1;
            // 
            // bt_Add
            // 
            bt_Add.AutoSize = true;
            bt_Add.Dock = DockStyle.Fill;
            bt_Add.FlatAppearance.BorderSize = 0;
            bt_Add.FlatStyle = FlatStyle.Flat;
            bt_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Add.ForeColor = Color.FromArgb(241, 239, 236);
            bt_Add.IconChar = FontAwesome.Sharp.IconChar.Add;
            bt_Add.IconColor = Color.FromArgb(232, 241, 245);
            bt_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Add.IconSize = 55;
            bt_Add.Location = new Point(408, 3);
            bt_Add.Name = "bt_Add";
            bt_Add.Size = new Size(314, 79);
            bt_Add.TabIndex = 3;
            bt_Add.TextAlign = ContentAlignment.MiddleLeft;
            bt_Add.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Add.UseVisualStyleBackColor = true;
            // 
            // bt_Edit
            // 
            bt_Edit.AutoSize = true;
            bt_Edit.Dock = DockStyle.Fill;
            bt_Edit.FlatAppearance.BorderSize = 0;
            bt_Edit.FlatStyle = FlatStyle.Flat;
            bt_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Edit.ForeColor = Color.FromArgb(241, 239, 236);
            bt_Edit.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            bt_Edit.IconColor = Color.FromArgb(232, 241, 245);
            bt_Edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Edit.IconSize = 55;
            bt_Edit.Location = new Point(3, 3);
            bt_Edit.Name = "bt_Edit";
            bt_Edit.Size = new Size(399, 79);
            bt_Edit.TabIndex = 2;
            bt_Edit.TextAlign = ContentAlignment.MiddleLeft;
            bt_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Edit.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.AutoSize = true;
            iconButton4.Dock = DockStyle.Right;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton4.ForeColor = Color.FromArgb(241, 239, 236);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            iconButton4.IconColor = Color.FromArgb(232, 241, 245);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 55;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(1071, 19);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(62, 85);
            iconButton4.TabIndex = 4;
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // tbLayout_FlashCard
            // 
            tbLayout_FlashCard.ColumnCount = 2;
            tbLayout_FlashCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbLayout_FlashCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbLayout_FlashCard.Controls.Add(panel1, 0, 0);
            tbLayout_FlashCard.Controls.Add(pn_Left, 1, 0);
            tbLayout_FlashCard.Dock = DockStyle.Fill;
            tbLayout_FlashCard.Location = new Point(0, 64);
            tbLayout_FlashCard.Name = "tbLayout_FlashCard";
            tbLayout_FlashCard.RowCount = 1;
            tbLayout_FlashCard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbLayout_FlashCard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbLayout_FlashCard.Size = new Size(1136, 470);
            tbLayout_FlashCard.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 241, 245);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lb_CardAnswer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 464);
            panel1.TabIndex = 9;
            // 
            // lb_CardAnswer
            // 
            lb_CardAnswer.Dock = DockStyle.Fill;
            lb_CardAnswer.Font = new Font("Sans Serif Collection", 11.9999981F);
            lb_CardAnswer.ForeColor = Color.FromArgb(0, 86, 145);
            lb_CardAnswer.Location = new Point(0, 0);
            lb_CardAnswer.Name = "lb_CardAnswer";
            lb_CardAnswer.Size = new Size(560, 462);
            lb_CardAnswer.TabIndex = 0;
            lb_CardAnswer.Text = "ANSWER";
            lb_CardAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pn_Left
            // 
            pn_Left.BackColor = Color.FromArgb(232, 241, 245);
            pn_Left.BorderStyle = BorderStyle.FixedSingle;
            pn_Left.Controls.Add(lb_CardQuestion);
            pn_Left.Dock = DockStyle.Fill;
            pn_Left.Location = new Point(571, 3);
            pn_Left.Name = "pn_Left";
            pn_Left.Size = new Size(562, 464);
            pn_Left.TabIndex = 8;
            // 
            // lb_CardQuestion
            // 
            lb_CardQuestion.Dock = DockStyle.Fill;
            lb_CardQuestion.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_CardQuestion.ForeColor = Color.FromArgb(0, 86, 145);
            lb_CardQuestion.Location = new Point(0, 0);
            lb_CardQuestion.Name = "lb_CardQuestion";
            lb_CardQuestion.Size = new Size(560, 462);
            lb_CardQuestion.TabIndex = 0;
            lb_CardQuestion.Text = "QUESTION";
            lb_CardQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_AnswerFolders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1136, 641);
            Controls.Add(tbLayout_FlashCard);
            Controls.Add(grBox_Menu);
            Controls.Add(pn_Trans);
            Name = "Form_AnswerFolders";
            pn_Trans.ResumeLayout(false);
            grBox_Menu.ResumeLayout(false);
            grBox_Menu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tbLayout_FlashCard.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pn_Left.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Trans;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton bt_Home;
        private FontAwesome.Sharp.IconButton bt_Category;
        private FontAwesome.Sharp.IconButton bt_Setting;
        private GroupBox grBox_Menu;
        private Panel panel3;
        private Label lb_NameFolder;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TableLayoutPanel tbLayout_FlashCard;
        private Panel panel1;
        private Label lb_CardAnswer;
        private Panel pn_Left;
        private Label lb_CardQuestion;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton bt_Add;
        private FontAwesome.Sharp.IconButton bt_Edit;
        private FontAwesome.Sharp.IconButton bt_ListQuestion;
    }
}