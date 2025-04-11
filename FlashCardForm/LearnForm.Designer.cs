namespace Flashcard_app
{
    partial class Form_StudyMode
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
            bt_Setting = new FontAwesome.Sharp.IconButton();
            lb_Mode = new Label();
            panel2 = new Panel();
            bt_Exit = new FontAwesome.Sharp.IconButton();
            grBox_Menu = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            bt_No = new FontAwesome.Sharp.IconButton();
            bt_Yes = new FontAwesome.Sharp.IconButton();
            bt_Next = new FontAwesome.Sharp.IconButton();
            bt_Flip = new FontAwesome.Sharp.IconButton();
            bt_Shuffle = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            pn_Card = new Panel();
            lb_CardText = new Label();
            pn_Trans.SuspendLayout();
            grBox_Menu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pn_Card.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Trans
            // 
            pn_Trans.BackColor = Color.FromArgb(0, 74, 124);
            pn_Trans.BorderStyle = BorderStyle.FixedSingle;
            pn_Trans.Controls.Add(bt_Setting);
            pn_Trans.Controls.Add(lb_Mode);
            pn_Trans.Controls.Add(panel2);
            pn_Trans.Controls.Add(bt_Exit);
            pn_Trans.Dock = DockStyle.Top;
            pn_Trans.Location = new Point(0, 0);
            pn_Trans.Margin = new Padding(0);
            pn_Trans.Name = "pn_Trans";
            pn_Trans.Size = new Size(1136, 64);
            pn_Trans.TabIndex = 2;
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
            bt_Setting.TabIndex = 8;
            bt_Setting.TextAlign = ContentAlignment.MiddleLeft;
            bt_Setting.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Setting.UseVisualStyleBackColor = false;
            // 
            // lb_Mode
            // 
            lb_Mode.BackColor = Color.FromArgb(0, 74, 124);
            lb_Mode.Dock = DockStyle.Fill;
            lb_Mode.FlatStyle = FlatStyle.Flat;
            lb_Mode.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Mode.ForeColor = Color.FromArgb(232, 241, 245);
            lb_Mode.Location = new Point(65, 0);
            lb_Mode.Name = "lb_Mode";
            lb_Mode.Size = new Size(1069, 62);
            lb_Mode.TabIndex = 7;
            lb_Mode.Text = "STUDY MODE";
            lb_Mode.TextAlign = ContentAlignment.MiddleLeft;
            lb_Mode.MouseDown += lb_Mode_MouseDown;
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
            bt_Exit.ForeColor = Color.FromArgb(241, 239, 236);
            bt_Exit.IconChar = FontAwesome.Sharp.IconChar.PersonThroughWindow;
            bt_Exit.IconColor = Color.FromArgb(232, 241, 245);
            bt_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Exit.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Exit.Location = new Point(0, 0);
            bt_Exit.Name = "bt_Exit";
            bt_Exit.Size = new Size(65, 62);
            bt_Exit.TabIndex = 0;
            bt_Exit.TextAlign = ContentAlignment.MiddleLeft;
            bt_Exit.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Exit.UseVisualStyleBackColor = false;
            bt_Exit.Click += bt_Exit_Click;
            // 
            // grBox_Menu
            // 
            grBox_Menu.BackColor = Color.FromArgb(0, 74, 124);
            grBox_Menu.Controls.Add(tableLayoutPanel2);
            grBox_Menu.Controls.Add(bt_Next);
            grBox_Menu.Controls.Add(bt_Flip);
            grBox_Menu.Controls.Add(bt_Shuffle);
            grBox_Menu.Dock = DockStyle.Bottom;
            grBox_Menu.FlatStyle = FlatStyle.Flat;
            grBox_Menu.Location = new Point(0, 534);
            grBox_Menu.Name = "grBox_Menu";
            grBox_Menu.Size = new Size(1136, 107);
            grBox_Menu.TabIndex = 5;
            grBox_Menu.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(bt_No, 1, 0);
            tableLayoutPanel2.Controls.Add(bt_Yes, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(65, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1006, 85);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // bt_No
            // 
            bt_No.AutoSize = true;
            bt_No.Dock = DockStyle.Fill;
            bt_No.FlatAppearance.BorderSize = 0;
            bt_No.FlatStyle = FlatStyle.Flat;
            bt_No.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_No.ForeColor = Color.FromArgb(241, 239, 236);
            bt_No.IconChar = FontAwesome.Sharp.IconChar.Close;
            bt_No.IconColor = Color.FromArgb(232, 241, 245);
            bt_No.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_No.IconSize = 55;
            bt_No.Location = new Point(506, 3);
            bt_No.Name = "bt_No";
            bt_No.Size = new Size(497, 79);
            bt_No.TabIndex = 7;
            bt_No.TextAlign = ContentAlignment.MiddleLeft;
            bt_No.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_No.UseVisualStyleBackColor = true;
            // 
            // bt_Yes
            // 
            bt_Yes.AutoSize = true;
            bt_Yes.Dock = DockStyle.Fill;
            bt_Yes.FlatAppearance.BorderSize = 0;
            bt_Yes.FlatStyle = FlatStyle.Flat;
            bt_Yes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Yes.ForeColor = Color.FromArgb(241, 239, 236);
            bt_Yes.IconChar = FontAwesome.Sharp.IconChar.Check;
            bt_Yes.IconColor = Color.FromArgb(232, 241, 245);
            bt_Yes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Yes.IconSize = 55;
            bt_Yes.Location = new Point(3, 3);
            bt_Yes.Name = "bt_Yes";
            bt_Yes.Size = new Size(497, 79);
            bt_Yes.TabIndex = 6;
            bt_Yes.TextAlign = ContentAlignment.MiddleLeft;
            bt_Yes.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Yes.UseVisualStyleBackColor = true;
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
            // bt_Flip
            // 
            bt_Flip.AutoSize = true;
            bt_Flip.FlatAppearance.BorderSize = 0;
            bt_Flip.FlatStyle = FlatStyle.Flat;
            bt_Flip.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Flip.ForeColor = Color.FromArgb(241, 239, 236);
            bt_Flip.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            bt_Flip.IconColor = Color.FromArgb(232, 241, 245);
            bt_Flip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Flip.IconSize = 55;
            bt_Flip.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Flip.Location = new Point(1003, 28);
            bt_Flip.Name = "bt_Flip";
            bt_Flip.Size = new Size(62, 73);
            bt_Flip.TabIndex = 2;
            bt_Flip.TextAlign = ContentAlignment.MiddleLeft;
            bt_Flip.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Flip.UseVisualStyleBackColor = true;
            // 
            // bt_Shuffle
            // 
            bt_Shuffle.AutoSize = true;
            bt_Shuffle.Dock = DockStyle.Left;
            bt_Shuffle.FlatAppearance.BorderSize = 0;
            bt_Shuffle.FlatStyle = FlatStyle.Flat;
            bt_Shuffle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bt_Shuffle.ForeColor = Color.FromArgb(241, 239, 236);
            bt_Shuffle.IconChar = FontAwesome.Sharp.IconChar.Shuffle;
            bt_Shuffle.IconColor = Color.FromArgb(232, 241, 245);
            bt_Shuffle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_Shuffle.IconSize = 55;
            bt_Shuffle.ImageAlign = ContentAlignment.MiddleLeft;
            bt_Shuffle.Location = new Point(3, 19);
            bt_Shuffle.Name = "bt_Shuffle";
            bt_Shuffle.Size = new Size(62, 85);
            bt_Shuffle.TabIndex = 1;
            bt_Shuffle.TextAlign = ContentAlignment.MiddleLeft;
            bt_Shuffle.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Shuffle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pn_Card, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1136, 470);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // pn_Card
            // 
            pn_Card.BackColor = Color.FromArgb(232, 241, 245);
            pn_Card.BorderStyle = BorderStyle.FixedSingle;
            pn_Card.Controls.Add(lb_CardText);
            pn_Card.Dock = DockStyle.Fill;
            pn_Card.Location = new Point(3, 3);
            pn_Card.Name = "pn_Card";
            pn_Card.Size = new Size(1130, 464);
            pn_Card.TabIndex = 7;
            // 
            // lb_CardText
            // 
            lb_CardText.Dock = DockStyle.Fill;
            lb_CardText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_CardText.ForeColor = Color.FromArgb(0, 86, 145);
            lb_CardText.Location = new Point(0, 0);
            lb_CardText.Margin = new Padding(0);
            lb_CardText.Name = "lb_CardText";
            lb_CardText.Size = new Size(1128, 462);
            lb_CardText.TabIndex = 0;
            lb_CardText.Text = "QUESTION";
            lb_CardText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_StudyMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1136, 641);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(grBox_Menu);
            Controls.Add(pn_Trans);
            Name = "Form_StudyMode";
            pn_Trans.ResumeLayout(false);
            grBox_Menu.ResumeLayout(false);
            grBox_Menu.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pn_Card.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Trans;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton bt_Exit;
        private Label lb_Mode;
        private FontAwesome.Sharp.IconButton bt_Setting;
        private GroupBox grBox_Menu;
        private FontAwesome.Sharp.IconButton bt_Next;
        private FontAwesome.Sharp.IconButton bt_Flip;
        private FontAwesome.Sharp.IconButton bt_Shuffle;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pn_Card;
        private Label lb_CardText;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton bt_No;
        private FontAwesome.Sharp.IconButton bt_Yes;
    }
}