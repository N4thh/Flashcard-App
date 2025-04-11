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
            tableLayoutPanel1 = new TableLayoutPanel();
            tb_EditType = new TextBox();
            iconPictureBox1 = new IconPictureBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tb_EditNote = new TextBox();
            iconPictureBox2 = new IconPictureBox();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            iconPictureBox3 = new IconPictureBox();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            iconButton1 = new IconButton();
            iconButton2 = new IconButton();
            iconButton3 = new IconButton();
            iconButton4 = new IconButton();
            iconButton5 = new IconButton();
            pn_Bot = new Panel();
            bt_Save = new Button();
            bt_Cancel = new Button();
            flowLayout_Middle.SuspendLayout();
            tableLayout_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPicture_Name).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            flowLayout_Middle.Controls.Add(tableLayoutPanel1);
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
            tableLayout_Name.Size = new Size(421, 42);
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
            iconPicture_Name.IconSize = 30;
            iconPicture_Name.Location = new Point(6, 6);
            iconPicture_Name.Name = "iconPicture_Name";
            iconPicture_Name.Size = new Size(34, 30);
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
            lb_Tile.Size = new Size(55, 36);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(tb_EditType, 2, 0);
            tableLayoutPanel1.Controls.Add(iconPictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(421, 42);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tb_EditType
            // 
            tb_EditType.BorderStyle = BorderStyle.None;
            tb_EditType.Dock = DockStyle.Fill;
            tb_EditType.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_EditType.Location = new Point(115, 3);
            tb_EditType.Margin = new Padding(5, 0, 0, 0);
            tb_EditType.Name = "tb_EditType";
            tb_EditType.RightToLeft = RightToLeft.No;
            tb_EditType.Size = new Size(303, 32);
            tb_EditType.TabIndex = 7;
            tb_EditType.Enter += tb_EditType_Enter;
            tb_EditType.Leave += tb_EditType_Leave;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = IconChar.BarChart;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(6, 6);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(34, 30);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Sans Serif Collection", 6.749999F);
            label2.Location = new Point(49, 3);
            label2.Name = "label2";
            label2.Size = new Size(55, 36);
            label2.TabIndex = 5;
            label2.Text = "Type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel2.Location = new Point(3, 99);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(421, 42);
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
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(6, 6);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(34, 30);
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
            label4.Size = new Size(55, 36);
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
            tableLayoutPanel3.Location = new Point(3, 147);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(421, 42);
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
            iconPictureBox3.IconSize = 30;
            iconPictureBox3.Location = new Point(6, 6);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(34, 30);
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
            label6.Size = new Size(55, 36);
            label6.TabIndex = 5;
            label6.Text = "Colors";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(iconButton1);
            flowLayoutPanel1.Controls.Add(iconButton2);
            flowLayoutPanel1.Controls.Add(iconButton3);
            flowLayoutPanel1.Controls.Add(iconButton4);
            flowLayoutPanel1.Controls.Add(iconButton5);
            flowLayoutPanel1.Location = new Point(113, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(302, 30);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.ButtonFace;
            iconButton1.Dock = DockStyle.Top;
            iconButton1.IconChar = IconChar.Circle;
            iconButton1.IconColor = Color.Salmon;
            iconButton1.IconFont = IconFont.Solid;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(3, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(30, 23);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.ButtonHighlight;
            iconButton2.Dock = DockStyle.Top;
            iconButton2.IconChar = IconChar.Circle;
            iconButton2.IconColor = Color.Red;
            iconButton2.IconFont = IconFont.Solid;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(39, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(30, 23);
            iconButton2.TabIndex = 1;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = SystemColors.ButtonFace;
            iconButton3.Dock = DockStyle.Top;
            iconButton3.IconChar = IconChar.Circle;
            iconButton3.IconColor = Color.Lime;
            iconButton3.IconFont = IconFont.Solid;
            iconButton3.IconSize = 20;
            iconButton3.Location = new Point(75, 3);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(30, 23);
            iconButton3.TabIndex = 2;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = SystemColors.ButtonFace;
            iconButton4.Dock = DockStyle.Top;
            iconButton4.IconChar = IconChar.Circle;
            iconButton4.IconColor = Color.Turquoise;
            iconButton4.IconFont = IconFont.Solid;
            iconButton4.IconSize = 20;
            iconButton4.Location = new Point(111, 3);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(30, 23);
            iconButton4.TabIndex = 3;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = SystemColors.ButtonFace;
            iconButton5.Dock = DockStyle.Top;
            iconButton5.IconChar = IconChar.Circle;
            iconButton5.IconColor = Color.Violet;
            iconButton5.IconFont = IconFont.Solid;
            iconButton5.IconSize = 20;
            iconButton5.Location = new Point(147, 3);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(30, 23);
            iconButton5.TabIndex = 4;
            iconButton5.UseVisualStyleBackColor = false;
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
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
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
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
        private IconButton iconButton1;
        private IconButton iconButton2;
        private IconButton iconButton3;
        private IconButton iconButton4;
        private IconButton iconButton5;
        private TextBox tb_EditName;
        private TextBox tb_EditType;
        private TextBox tb_EditNote;
    }
}