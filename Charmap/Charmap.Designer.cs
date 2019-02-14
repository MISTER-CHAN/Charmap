namespace Charmap
{
    partial class Charmap
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lvCharmap = new System.Windows.Forms.ListView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.prevPage = new System.Windows.Forms.ToolStripMenuItem();
            this.nextPage = new System.Windows.Forms.ToolStripMenuItem();
            this.content = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiGoto = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCharmap
            // 
            this.lvCharmap.Font = new System.Drawing.Font("MISTER_CHAN", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvCharmap.Location = new System.Drawing.Point(12, 27);
            this.lvCharmap.MultiSelect = false;
            this.lvCharmap.Name = "lvCharmap";
            this.lvCharmap.Size = new System.Drawing.Size(776, 398);
            this.lvCharmap.TabIndex = 0;
            this.lvCharmap.UseCompatibleStateImageBehavior = false;
            this.lvCharmap.SelectedIndexChanged += new System.EventHandler(this.LvCharmap_SelectedIndexChanged);
            this.lvCharmap.DoubleClick += new System.EventHandler(this.LvCharmap_DoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prevPage,
            this.nextPage,
            this.content,
            this.tsmiGoto,
            this.copy});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // prevPage
            // 
            this.prevPage.Name = "prevPage";
            this.prevPage.Size = new System.Drawing.Size(31, 20);
            this.prevPage.Text = "<<";
            this.prevPage.Click += new System.EventHandler(this.PrevPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(31, 20);
            this.nextPage.Text = ">>";
            this.nextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // content
            // 
            this.content.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.content.Items.AddRange(new object[] {
            "0 ~ FFF",
            "1000 ~ 1FFF",
            "2000 ~ 2FFF",
            "3000 ~ 3FFF",
            "4000 ~ 9FFF",
            "A000 ~ AFFF",
            "B000 ~ EFFF",
            "F000 ~ FFFF",
            "10000 ~ 10FFFF"});
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(75, 20);
            this.content.SelectedIndexChanged += new System.EventHandler(this.Content_SelectedIndexChanged);
            // 
            // tsmiGoto
            // 
            this.tsmiGoto.Name = "tsmiGoto";
            this.tsmiGoto.Size = new System.Drawing.Size(41, 20);
            this.tsmiGoto.Text = "轉到";
            this.tsmiGoto.Click += new System.EventHandler(this.Goto_Click);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(41, 20);
            this.copy.Text = "複製";
            this.copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(12, 17);
            this.status.Text = "0";
            // 
            // Charmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lvCharmap);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Charmap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charmap";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCharmap;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem prevPage;
        private System.Windows.Forms.ToolStripMenuItem nextPage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoto;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripComboBox content;
    }
}

