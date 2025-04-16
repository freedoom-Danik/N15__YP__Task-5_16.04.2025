namespace N15__YP__Task_5_16._04._2025
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            colorToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripMenuItemRed = new ToolStripMenuItem();
            toolStripMenuItemGreen = new ToolStripMenuItem();
            toolStripMenuItemBlue = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStripComboBox = new ToolStripComboBox();
            contextMenuStripTextBox1 = new ToolStripTextBox();
            contextMenuStripTextBox2 = new ToolStripTextBox();
            contextMenuStripTextBox3 = new ToolStripTextBox();
            contextMenuStripSeparator = new ToolStripSeparator();
            contextMenuStripExit = new ToolStripMenuItem();
            buttonClose = new Button();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { colorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1, toolStripMenuItemRed, toolStripMenuItemGreen, toolStripMenuItemBlue, toolStripSeparator1, exitToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(48, 20);
            colorToolStripMenuItem.Text = "&Color";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Items.AddRange(new object[] { "белый", "красный", "черный", "синий", "желтый" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            toolStripComboBox1.SelectedIndexChanged += comboBoxColor_SelectedIndexChanged;
            // 
            // toolStripMenuItemRed
            // 
            toolStripMenuItemRed.Name = "toolStripMenuItemRed";
            toolStripMenuItemRed.Size = new Size(181, 22);
            toolStripMenuItemRed.Text = "Красный";
            toolStripMenuItemRed.Click += toolStripMenuItemRed_Click;
            // 
            // toolStripMenuItemGreen
            // 
            toolStripMenuItemGreen.Name = "toolStripMenuItemGreen";
            toolStripMenuItemGreen.Size = new Size(181, 22);
            toolStripMenuItemGreen.Text = "Зеленый";
            toolStripMenuItemGreen.Click += toolStripMenuItemGreen_Click;
            // 
            // toolStripMenuItemBlue
            // 
            toolStripMenuItemBlue.Name = "toolStripMenuItemBlue";
            toolStripMenuItemBlue.Size = new Size(181, 22);
            toolStripMenuItemBlue.Text = "Синий";
            toolStripMenuItemBlue.Click += toolStripMenuItemBlue_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitApplication;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { contextMenuStripComboBox, contextMenuStripTextBox1, contextMenuStripTextBox2, contextMenuStripTextBox3, contextMenuStripSeparator, contextMenuStripExit });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 134);
            // 
            // contextMenuStripComboBox
            // 
            contextMenuStripComboBox.Items.AddRange(new object[] { "белый", "красный", "черный", "синий", "желтый" });
            contextMenuStripComboBox.Name = "contextMenuStripComboBox";
            contextMenuStripComboBox.Size = new Size(121, 23);
            contextMenuStripComboBox.SelectedIndexChanged += comboBoxColor_SelectedIndexChanged;
            // 
            // contextMenuStripTextBox1
            // 
            contextMenuStripTextBox1.Name = "contextMenuStripTextBox1";
            contextMenuStripTextBox1.Size = new Size(100, 23);
            contextMenuStripTextBox1.Text = "0";
            //contextMenuStripTextBox1.TextChanged += textBoxRGB_TextChanged;
            // 
            // contextMenuStripTextBox2
            // 
            contextMenuStripTextBox2.Name = "contextMenuStripTextBox2";
            contextMenuStripTextBox2.Size = new Size(100, 23);
            contextMenuStripTextBox2.Text = "0";
            //contextMenuStripTextBox2.TextChanged += textBoxRGB_TextChanged;
            // 
            // contextMenuStripTextBox3
            // 
            contextMenuStripTextBox3.Name = "contextMenuStripTextBox3";
            contextMenuStripTextBox3.Size = new Size(100, 23);
            contextMenuStripTextBox3.Text = "0";
            //contextMenuStripTextBox3.TextChanged += textBoxRGB_TextChanged;
            // 
            // contextMenuStripSeparator
            // 
            contextMenuStripSeparator.Name = "contextMenuStripSeparator";
            contextMenuStripSeparator.Size = new Size(178, 6);
            // 
            // contextMenuStripExit
            // 
            contextMenuStripExit.Name = "contextMenuStripExit";
            contextMenuStripExit.Size = new Size(181, 22);
            contextMenuStripExit.Text = "E&xit";
            contextMenuStripExit.Click += ExitApplication;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 462);
            buttonClose.Margin = new Padding(4, 3, 4, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(88, 27);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ExitApplication;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "0";
            toolStripTextBox1.ToolTipText = "Красный";
            //toolStripTextBox1.TextChanged += textBoxRGB_TextChanged;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            toolStripTextBox2.Text = "0";
            toolStripTextBox2.ToolTipText = "Зеленый";
            //toolStripTextBox2.TextChanged += textBoxRGB_TextChanged;
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(100, 23);
            toolStripTextBox3.Text = "0";
            toolStripTextBox3.ToolTipText = "Синий";
            //toolStripTextBox3.TextChanged += textBoxRGB_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonClose);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGreen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox contextMenuStripComboBox;
        private System.Windows.Forms.ToolStripTextBox contextMenuStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox contextMenuStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox contextMenuStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator contextMenuStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStripExit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
    }
}