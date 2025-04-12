using FontAwesome.Sharp;

namespace Flashcard_app.MainForm.Home_Form
{
    partial class Form_AddFolder
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
            lb_Name = new Label();
            flowLayout_Middle = new FlowLayoutPanel();
            tableLayout_Name = new TableLayoutPanel();
            iconPicture_Name = new IconPictureBox();
            lb_Tile = new Label();
            tb_EditName = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tb_EditNote = new TextBox();
            iconPictureBox2 = new IconPictureBox();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            iconPictureBox3 = new IconPictureBox();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bt_Organe = new IconButton();
            bt_Red = new IconButton();
            bt_Green = new IconButton();
            bt_Blue = new IconButton();
            bt_Purple = new IconButton();
            pn_Bot = new Panel();
            bt_Save = new Button();
            bt_Cancel = new Button();
            flowLayout_Middle.SuspendLayout();
            tableLayout_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPicture_Name).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pn_Bot.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Name
            // 
            lb_Name.Dock = DockStyle.Top;
            lb_Name.Font = new Font("Sans Serif Collection", 11.9999981F);
            lb_Name.ForeColor = Color.FromArgb(0, 86, 145);
            lb_Name.Location = new Point(0, 0);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(424, 32);
            lb_Name.TabIndex = 1;
            lb_Name.Text = "Add new folder";
            lb_Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayout_Middle
            // 
            flowLayout_Middle.Controls.Add(tableLayout_Name);
            flowLayout_Middle.Controls.Add(tableLayoutPanel2);
            flowLayout_Middle.Controls.Add(tableLayoutPanel3);
            flowLayout_Middle.Dock = DockStyle.Fill;
            flowLayout_Middle.Location = new Point(0, 32);
            flowLayout_Middle.Name = "flowLayout_Middle";
            flowLayout_Middle.Size = new Size(424, 229);
            flowLayout_Middle.TabIndex = 2;
            // 
            // tableLayout_Name
            // 
            tableLayout_Name.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayout_Name.ColumnCount = 3;
            tableLayout_Name.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayout_Name.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayout_Name.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayout_Name.Controls.Add(iconPicture_Name, 0, 0);
            tableLayout_Name.Controls.Add(lb_Tile, 1, 0);
            tableLayout_Name.Controls.Add(tb_EditName, 2, 0);
            tableLayout_Name.Dock = DockStyle.Top;
            tableLayout_Name.Location = new Point(3, 3);
            tableLayout_Name.Name = "tableLayout_Name";
            tableLayout_Name.RowCount = 1;
            tableLayout_Name.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayout_Name.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayout_Name.Size = new Size(421, 57);
            tableLayout_Name.TabIndex = 0;
            // 
            // iconPicture_Name
            // 
            iconPicture_Name.BackColor = SystemColors.Control;
            iconPicture_Name.Dock = DockStyle.Fill;
            iconPicture_Name.ForeColor = SystemColors.ControlText;
            iconPicture_Name.IconChar = IconChar.Edit;
            iconPicture_Name.IconColor = SystemColors.ControlText;
            iconPicture_Name.IconFont = IconFont.Auto;
            iconPicture_Name.IconSize = 34;
            iconPicture_Name.Location = new Point(6, 6);
            iconPicture_Name.Name = "iconPicture_Name";
            iconPicture_Name.Size = new Size(34, 45);
            iconPicture_Name.TabIndex = 0;
            iconPicture_Name.TabStop = false;
            // 
            // lb_Tile
            // 
            lb_Tile.AutoSize = true;
            lb_Tile.Dock = DockStyle.Fill;
            lb_Tile.Font = new Font("Sans Serif Collection", 6.749999F);
            lb_Tile.Location = new Point(49, 3);
            lb_Tile.Name = "lb_Tile";
            lb_Tile.Size = new Size(55, 51);
            lb_Tile.TabIndex = 5;
            lb_Tile.Text = "Title";
            lb_Tile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_EditName
            // 
            tb_EditName.BorderStyle = BorderStyle.None;
            tb_EditName.Dock = DockStyle.Fill;
            tb_EditName.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_EditName.Location = new Point(115, 3);
            tb_EditName.Margin = new Padding(5, 0, 0, 0);
            tb_EditName.Name = "tb_EditName";
            tb_EditName.RightToLeft = RightToLeft.No;
            tb_EditName.Size = new Size(303, 32);
            tb_EditName.TabIndex = 6;
            tb_EditName.TextChanged += tb_EditName_TextChanged;
            tb_EditName.Enter += tb_EditName_Enter;
            tb_EditName.Leave += tb_EditName_Leave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.Controls.Add(tb_EditNote, 2, 0);
            tableLayoutPanel2.Controls.Add(iconPictureBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 66);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(421, 57);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tb_EditNote
            // 
            tb_EditNote.BorderStyle = BorderStyle.None;
            tb_EditNote.Dock = DockStyle.Fill;
            tb_EditNote.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_EditNote.Location = new Point(115, 3);
            tb_EditNote.Margin = new Padding(5, 0, 0, 0);
            tb_EditNote.Name = "tb_EditNote";
            tb_EditNote.RightToLeft = RightToLeft.No;
            tb_EditNote.Size = new Size(303, 32);
            tb_EditNote.TabIndex = 7;
            tb_EditNote.Enter += tb_EditNote_Enter;
            tb_EditNote.Leave += tb_EditNote_Leave;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.Control;
            iconPictureBox2.Dock = DockStyle.Fill;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = IconChar.StickyNote;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = IconFont.Auto;
            iconPictureBox2.IconSize = 34;
            iconPictureBox2.Location = new Point(6, 6);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(34, 45);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Sans Serif Collection", 6.749999F);
            label4.Location = new Point(49, 3);
            label4.Name = "label4";
            label4.Size = new Size(55, 51);
            label4.TabIndex = 5;
            label4.Text = "Note";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(iconPictureBox3, 0, 0);
            tableLayoutPanel3.Controls.Add(label6, 1, 0);
            tableLayoutPanel3.Controls.Add(flowLayoutPanel1, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 129);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(421, 57);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = SystemColors.Control;
            iconPictureBox3.Dock = DockStyle.Fill;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = IconChar.FontAwesomeLogoFull;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = IconFont.Auto;
            iconPictureBox3.IconSize = 34;
            iconPictureBox3.Location = new Point(6, 6);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(34, 45);
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Sans Serif Collection", 6.749999F);
            label6.Location = new Point(49, 3);
            label6.Name = "label6";
            label6.Size = new Size(55, 51);
            label6.TabIndex = 5;
            label6.Text = "Colors";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(bt_Organe);
            flowLayoutPanel1.Controls.Add(bt_Red);
            flowLayoutPanel1.Controls.Add(bt_Green);
            flowLayoutPanel1.Controls.Add(bt_Blue);
            flowLayoutPanel1.Controls.Add(bt_Purple);
            flowLayoutPanel1.Location = new Point(113, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(302, 30);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // bt_Organe
            // 
            bt_Organe.BackColor = SystemColors.ButtonFace;
            bt_Organe.Dock = DockStyle.Top;
            bt_Organe.IconChar = IconChar.Circle;
            bt_Organe.IconColor = Color.Coral;
            bt_Organe.IconFont = IconFont.Solid;
            bt_Organe.IconSize = 20;
            bt_Organe.Location = new Point(3, 3);
            bt_Organe.Name = "bt_Organe";
            bt_Organe.Size = new Size(30, 23);
            bt_Organe.TabIndex = 0;
            bt_Organe.UseVisualStyleBackColor = false;
            bt_Organe.Click += bt_Organe_Click;
            // 
            // bt_Red
            // 
            bt_Red.BackColor = SystemColors.ButtonHighlight;
            bt_Red.Dock = DockStyle.Top;
            bt_Red.IconChar = IconChar.Circle;
            bt_Red.IconColor = Color.Red;
            bt_Red.IconFont = IconFont.Solid;
            bt_Red.IconSize = 20;
            bt_Red.Location = new Point(39, 3);
            bt_Red.Name = "bt_Red";
            bt_Red.Size = new Size(30, 23);
            bt_Red.TabIndex = 1;
            bt_Red.UseVisualStyleBackColor = false;
            bt_Red.Click += bt_Red_Click;
            // 
            // bt_Green
            // 
            bt_Green.BackColor = SystemColors.ButtonFace;
            bt_Green.Dock = DockStyle.Top;
            bt_Green.IconChar = IconChar.Circle;
            bt_Green.IconColor = Color.Lime;
            bt_Green.IconFont = IconFont.Solid;
            bt_Green.IconSize = 20;
            bt_Green.Location = new Point(75, 3);
            bt_Green.Name = "bt_Green";
            bt_Green.Size = new Size(30, 23);
            bt_Green.TabIndex = 2;
            bt_Green.UseVisualStyleBackColor = false;
            bt_Green.Click += bt_Green_Click;
            // 
            // bt_Blue
            // 
            bt_Blue.BackColor = SystemColors.ButtonFace;
            bt_Blue.Dock = DockStyle.Top;
            bt_Blue.IconChar = IconChar.Circle;
            bt_Blue.IconColor = Color.Turquoise;
            bt_Blue.IconFont = IconFont.Solid;
            bt_Blue.IconSize = 20;
            bt_Blue.Location = new Point(111, 3);
            bt_Blue.Name = "bt_Blue";
            bt_Blue.Size = new Size(30, 23);
            bt_Blue.TabIndex = 3;
            bt_Blue.UseVisualStyleBackColor = false;
            bt_Blue.Click += bt_Blue_Click;
            // 
            // bt_Purple
            // 
            bt_Purple.BackColor = SystemColors.ButtonFace;
            bt_Purple.Dock = DockStyle.Top;
            bt_Purple.IconChar = IconChar.Circle;
            bt_Purple.IconColor = Color.Violet;
            bt_Purple.IconFont = IconFont.Solid;
            bt_Purple.IconSize = 20;
            bt_Purple.Location = new Point(147, 3);
            bt_Purple.Name = "bt_Purple";
            bt_Purple.Size = new Size(30, 23);
            bt_Purple.TabIndex = 4;
            bt_Purple.UseVisualStyleBackColor = false;
            bt_Purple.Click += bt_Purple_Click;
            // 
            // pn_Bot
            // 
            pn_Bot.Controls.Add(bt_Save);
            pn_Bot.Controls.Add(bt_Cancel);
            pn_Bot.Dock = DockStyle.Bottom;
            pn_Bot.Location = new Point(0, 221);
            pn_Bot.Name = "pn_Bot";
            pn_Bot.Size = new Size(424, 40);
            pn_Bot.TabIndex = 3;
            // 
            // bt_Save
            // 
            bt_Save.Dock = DockStyle.Right;
            bt_Save.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Save.Location = new Point(248, 0);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new Size(88, 40);
            bt_Save.TabIndex = 3;
            bt_Save.Text = "Save";
            bt_Save.UseVisualStyleBackColor = true;
            bt_Save.Click += bt_Save_Click;
            // 
            // bt_Cancel
            // 
            bt_Cancel.Dock = DockStyle.Right;
            bt_Cancel.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Cancel.Location = new Point(336, 0);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new Size(88, 40);
            bt_Cancel.TabIndex = 2;
            bt_Cancel.Text = "Cancel";
            bt_Cancel.UseVisualStyleBackColor = true;
            bt_Cancel.Click += bt_Cancel_Click_1;
            // 
            // Form_AddFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 261);
            Controls.Add(pn_Bot);
            Controls.Add(flowLayout_Middle);
            Controls.Add(lb_Name);
            Name = "Form_AddFolder";
            Text = "Form_AddFolder";
            flowLayout_Middle.ResumeLayout(false);
            tableLayout_Name.ResumeLayout(false);
            tableLayout_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPicture_Name).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pn_Bot.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lb_Name;
        private FlowLayoutPanel flowLayout_Middle;
        private Panel pn_Bot;
        private Button bt_Cancel;
        private TableLayoutPanel tableLayout_Name;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label6;
        private Button bt_Save;
        private IconPictureBox iconPicture_Name;
        private Label lb_Tile;
        private FlowLayoutPanel flowLayoutPanel1;
        private IconButton bt_Organe;
        private IconButton bt_Red;
        private IconButton bt_Green;
        private IconButton bt_Blue;
        private IconButton bt_Purple;
        private TextBox tb_EditName;
        private TextBox tb_EditNote;
    }
}