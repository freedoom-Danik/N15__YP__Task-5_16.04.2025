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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItemRed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.contextMenuStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClose = new System.Windows.Forms.Button();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();

            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;

            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripComboBox1,
                this.toolStripMenuItemRed,
                this.toolStripMenuItemGreen,
                this.toolStripMenuItemBlue,
                this.toolStripSeparator1,
                this.exitToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "&Color";

            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
                "белый",
                "красный",
                "черный",
                "синий",
                "желтый"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);

            // 
            // toolStripMenuItemRed
            // 
            this.toolStripMenuItemRed.Name = "toolStripMenuItemRed";
            this.toolStripMenuItemRed.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemRed.Text = "Красный";
            this.toolStripMenuItemRed.Click += new System.EventHandler(this.toolStripMenuItemRed_Click);

            // 
            // toolStripMenuItemGreen
            // 
            this.toolStripMenuItemGreen.Name = "toolStripMenuItemGreen";
            this.toolStripMenuItemGreen.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemGreen.Text = "Зеленый";
            this.toolStripMenuItemGreen.Click += new System.EventHandler(this.toolStripMenuItemGreen_Click);

            // 
            // toolStripMenuItemBlue
            // 
            this.toolStripMenuItemBlue.Name = "toolStripMenuItemBlue";
            this.toolStripMenuItemBlue.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBlue.Text = "Синий";
            this.toolStripMenuItemBlue.Click += new System.EventHandler(this.toolStripMenuItemBlue_Click);

            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);

            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitApplication);

            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.contextMenuStripComboBox,
                this.contextMenuStripTextBox1,
                this.contextMenuStripTextBox2,
                this.contextMenuStripTextBox3,
                this.contextMenuStripSeparator,
                this.contextMenuStripExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 126);

            // 
            // contextMenuStripComboBox
            // 
            this.contextMenuStripComboBox.Items.AddRange(new object[] {
                "белый",
                "красный",
                "черный",
                "синий",
                "желтый"});
            this.contextMenuStripComboBox.Name = "contextMenuStripComboBox";
            this.contextMenuStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.contextMenuStripComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);

            // 
            // contextMenuStripTextBox1
            // 
            this.contextMenuStripTextBox1.Name = "contextMenuStripTextBox1";
            this.contextMenuStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.contextMenuStripTextBox1.Text = "0";
            this.contextMenuStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);

            // 
            // contextMenuStripTextBox2
            // 
            this.contextMenuStripTextBox2.Name = "contextMenuStripTextBox2";
            this.contextMenuStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.contextMenuStripTextBox2.Text = "0";
            this.contextMenuStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);

            // 
            // contextMenuStripTextBox3
            // 
            this.contextMenuStripTextBox3.Name = "contextMenuStripTextBox3";
            this.contextMenuStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.contextMenuStripTextBox3.Text = "0";
            this.contextMenuStripTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);

            // 
            // contextMenuStripSeparator
            // 
            this.contextMenuStripSeparator.Name = "contextMenuStripSeparator";
            this.contextMenuStripSeparator.Size = new System.Drawing.Size(177, 6);

            // 
            // contextMenuStripExit
            // 
            this.contextMenuStripExit.Name = "contextMenuStripExit";
            this.contextMenuStripExit.Size = new System.Drawing.Size(180, 22);
            this.contextMenuStripExit.Text = "E&xit";
            this.contextMenuStripExit.Click += new System.EventHandler(this.ExitApplication);

            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(10, 400);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ExitApplication);

            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Красный";
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);

            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Зеленый";
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);

            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Синий";
            this.toolStripTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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