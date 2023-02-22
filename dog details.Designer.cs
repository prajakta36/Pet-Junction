namespace WindowsFormsApp1
{
    partial class dog_details
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siberianHuskyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchBulldogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puppiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.americanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.americanEskimoDogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dogsToolStripMenuItem,
            this.puppiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dogsToolStripMenuItem
            // 
            this.dogsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.germToolStripMenuItem,
            this.siberianHuskyToolStripMenuItem,
            this.frenchBulldogsToolStripMenuItem});
            this.dogsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dogsToolStripMenuItem.Name = "dogsToolStripMenuItem";
            this.dogsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.dogsToolStripMenuItem.Text = "Dogs";
            this.dogsToolStripMenuItem.Click += new System.EventHandler(this.dogsToolStripMenuItem_Click);
            // 
            // germToolStripMenuItem
            // 
            this.germToolStripMenuItem.Name = "germToolStripMenuItem";
            this.germToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.germToolStripMenuItem.Text = "German shepherd";
            this.germToolStripMenuItem.Click += new System.EventHandler(this.germToolStripMenuItem_Click);
            // 
            // siberianHuskyToolStripMenuItem
            // 
            this.siberianHuskyToolStripMenuItem.Name = "siberianHuskyToolStripMenuItem";
            this.siberianHuskyToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.siberianHuskyToolStripMenuItem.Text = "siberian husky";
            this.siberianHuskyToolStripMenuItem.Click += new System.EventHandler(this.siberianHuskyToolStripMenuItem_Click);
            // 
            // frenchBulldogsToolStripMenuItem
            // 
            this.frenchBulldogsToolStripMenuItem.Name = "frenchBulldogsToolStripMenuItem";
            this.frenchBulldogsToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.frenchBulldogsToolStripMenuItem.Text = "french Bulldogs";
            this.frenchBulldogsToolStripMenuItem.Click += new System.EventHandler(this.frenchBulldogsToolStripMenuItem_Click);
            // 
            // puppiesToolStripMenuItem
            // 
            this.puppiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.americanToolStripMenuItem,
            this.americanEskimoDogToolStripMenuItem});
            this.puppiesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puppiesToolStripMenuItem.Name = "puppiesToolStripMenuItem";
            this.puppiesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.puppiesToolStripMenuItem.Text = "Puppies";
            this.puppiesToolStripMenuItem.Click += new System.EventHandler(this.puppiesToolStripMenuItem_Click);
            // 
            // americanToolStripMenuItem
            // 
            this.americanToolStripMenuItem.Name = "americanToolStripMenuItem";
            this.americanToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.americanToolStripMenuItem.Text = " American Foxhound";
            this.americanToolStripMenuItem.Click += new System.EventHandler(this.americanToolStripMenuItem_Click);
            // 
            // americanEskimoDogToolStripMenuItem
            // 
            this.americanEskimoDogToolStripMenuItem.Name = "americanEskimoDogToolStripMenuItem";
            this.americanEskimoDogToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.americanEskimoDogToolStripMenuItem.Text = "American Eskimo dog";
            this.americanEskimoDogToolStripMenuItem.Click += new System.EventHandler(this.americanEskimoDogToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dog_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dogd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "dog_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dog_details";
            this.Load += new System.EventHandler(this.dog_details_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siberianHuskyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchBulldogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puppiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem americanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem americanEskimoDogToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}