namespace db_trud
{
    partial class Guest_From_for_Org
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
            this.выйтиИзПриложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактироватьРезюмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзГостевогоРежимаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // выйтиИзПриложенияToolStripMenuItem
            // 
            this.выйтиИзПриложенияToolStripMenuItem.Name = "выйтиИзПриложенияToolStripMenuItem";
            this.выйтиИзПриложенияToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.выйтиИзПриложенияToolStripMenuItem.Text = "Выйти из приложения";
            this.выйтиИзПриложенияToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзПриложенияToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.data1);
            this.panel1.Location = new System.Drawing.Point(38, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 351);
            this.panel1.TabIndex = 4;
            // 
            // data1
            // 
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(45, 40);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(545, 266);
            this.data1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьРезюмеToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактироватьРезюмеToolStripMenuItem
            // 
            this.редактироватьРезюмеToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.редактироватьРезюмеToolStripMenuItem.Name = "редактироватьРезюмеToolStripMenuItem";
            this.редактироватьРезюмеToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.редактироватьРезюмеToolStripMenuItem.Text = "Резюме";
           // this.редактироватьРезюмеToolStripMenuItem.Click += new System.EventHandler(this.редактироватьРезюмеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиИзГостевогоРежимаToolStripMenuItem,
            this.выйтиИзПриложенияToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 24);
            this.toolStripMenuItem1.Text = "Выход";
            // 
            // выйтиИзГостевогоРежимаToolStripMenuItem
            // 
            this.выйтиИзГостевогоРежимаToolStripMenuItem.Name = "выйтиИзГостевогоРежимаToolStripMenuItem";
            this.выйтиИзГостевогоРежимаToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.выйтиИзГостевогоРежимаToolStripMenuItem.Text = "Выйти из гостевого режима";
            this.выйтиИзГостевогоРежимаToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзГостевогоРежимаToolStripMenuItem_Click);
            // 
            // Guest_From_for_Org
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 421);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Guest_From_for_Org";
            this.Text = "Вы зашли как гость (Юридическое лицо)";
            this.Load += new System.EventHandler(this.Guest_From_for_Org_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem выйтиИзПриложенияToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьРезюмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзГостевогоРежимаToolStripMenuItem;

    }
}