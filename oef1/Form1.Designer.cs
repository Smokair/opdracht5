namespace oef1
{
    partial class Notepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redBgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenBgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueBgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redBgToolStripMenuItem,
            this.greenBgToolStripMenuItem,
            this.blueBgToolStripMenuItem});
            this.backgroundToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // redBgToolStripMenuItem
            // 
            this.redBgToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.redBgToolStripMenuItem.Name = "redBgToolStripMenuItem";
            this.redBgToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redBgToolStripMenuItem.Text = "Red";
            this.redBgToolStripMenuItem.Click += new System.EventHandler(this.smaillToolStripMenuItem_Click);
            // 
            // greenBgToolStripMenuItem
            // 
            this.greenBgToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.greenBgToolStripMenuItem.Name = "greenBgToolStripMenuItem";
            this.greenBgToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenBgToolStripMenuItem.Text = "Green";
            this.greenBgToolStripMenuItem.Click += new System.EventHandler(this.greenBgToolStripMenuItem_Click);
            // 
            // blueBgToolStripMenuItem
            // 
            this.blueBgToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.blueBgToolStripMenuItem.Name = "blueBgToolStripMenuItem";
            this.blueBgToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueBgToolStripMenuItem.Text = "Blue";
            this.blueBgToolStripMenuItem.Click += new System.EventHandler(this.blueBgToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem1,
            this.greenToolStripMenuItem1,
            this.blueToolStripMenuItem1});
            this.fontToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // smallToolStripMenuItem1
            // 
            this.smallToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smallToolStripMenuItem1.Name = "smallToolStripMenuItem1";
            this.smallToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.smallToolStripMenuItem1.Text = "Small";
            this.smallToolStripMenuItem1.Click += new System.EventHandler(this.smallToolStripMenuItem1_Click);
            // 
            // greenToolStripMenuItem1
            // 
            this.greenToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
            this.greenToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.greenToolStripMenuItem1.Text = "Normal";
            this.greenToolStripMenuItem1.Click += new System.EventHandler(this.greenToolStripMenuItem1_Click);
            // 
            // blueToolStripMenuItem1
            // 
            this.blueToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
            this.blueToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.blueToolStripMenuItem1.Text = "Large";
            this.blueToolStripMenuItem1.Click += new System.EventHandler(this.blueToolStripMenuItem1_Click);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem smallToolStripMenuItem1;
        private ToolStripMenuItem greenToolStripMenuItem1;
        private ToolStripMenuItem blueToolStripMenuItem1;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem redBgToolStripMenuItem;
        private ToolStripMenuItem greenBgToolStripMenuItem;
        private ToolStripMenuItem blueBgToolStripMenuItem;
    }
}