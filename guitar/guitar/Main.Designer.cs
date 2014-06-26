namespace guitar
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.吉他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.電吉他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.烏克麗麗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.最終結算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.吉他ToolStripMenuItem,
            this.電吉他ToolStripMenuItem,
            this.烏克麗麗ToolStripMenuItem,
            this.配件ToolStripMenuItem,
            this.最終結算ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 吉他ToolStripMenuItem
            // 
            this.吉他ToolStripMenuItem.Name = "吉他ToolStripMenuItem";
            this.吉他ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.吉他ToolStripMenuItem.Text = "木吉他";
            this.吉他ToolStripMenuItem.Click += new System.EventHandler(this.吉他ToolStripMenuItem_Click);
            // 
            // 電吉他ToolStripMenuItem
            // 
            this.電吉他ToolStripMenuItem.Name = "電吉他ToolStripMenuItem";
            this.電吉他ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.電吉他ToolStripMenuItem.Text = "電吉他";
            this.電吉他ToolStripMenuItem.Click += new System.EventHandler(this.電吉他ToolStripMenuItem_Click);
            // 
            // 烏克麗麗ToolStripMenuItem
            // 
            this.烏克麗麗ToolStripMenuItem.Name = "烏克麗麗ToolStripMenuItem";
            this.烏克麗麗ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.烏克麗麗ToolStripMenuItem.Text = "烏克麗麗";
            this.烏克麗麗ToolStripMenuItem.Click += new System.EventHandler(this.烏克麗麗ToolStripMenuItem_Click);
            // 
            // 配件ToolStripMenuItem
            // 
            this.配件ToolStripMenuItem.Name = "配件ToolStripMenuItem";
            this.配件ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.配件ToolStripMenuItem.Text = "配件";
            this.配件ToolStripMenuItem.Click += new System.EventHandler(this.配件ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 478);
            this.panel1.TabIndex = 1;
            // 
            // 最終結算ToolStripMenuItem
            // 
            this.最終結算ToolStripMenuItem.Name = "最終結算ToolStripMenuItem";
            this.最終結算ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.最終結算ToolStripMenuItem.Text = "最終結算";
            this.最終結算ToolStripMenuItem.Click += new System.EventHandler(this.最終結算ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 吉他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 電吉他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 烏克麗麗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配件ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 最終結算ToolStripMenuItem;
    }
}