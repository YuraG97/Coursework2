namespace EasyTransport
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutesBtn = new System.Windows.Forms.Button();
            this.TransportBtn = new System.Windows.Forms.Button();
            this.TripsBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.проПрограмуToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.проПрограмуToolStripMenuItem.Text = "Головна";
            // 
            // проПрограмуToolStripMenuItem1
            // 
            this.проПрограмуToolStripMenuItem1.Name = "проПрограмуToolStripMenuItem1";
            this.проПрограмуToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem1.Text = "Про програму";
            this.проПрограмуToolStripMenuItem1.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem1_Click);
            // 
            // RoutesBtn
            // 
            this.RoutesBtn.Location = new System.Drawing.Point(12, 27);
            this.RoutesBtn.Name = "RoutesBtn";
            this.RoutesBtn.Size = new System.Drawing.Size(226, 116);
            this.RoutesBtn.TabIndex = 1;
            this.RoutesBtn.UseVisualStyleBackColor = true;
            // 
            // TransportBtn
            // 
            this.TransportBtn.Location = new System.Drawing.Point(244, 27);
            this.TransportBtn.Name = "TransportBtn";
            this.TransportBtn.Size = new System.Drawing.Size(226, 116);
            this.TransportBtn.TabIndex = 2;
            this.TransportBtn.UseVisualStyleBackColor = true;
            // 
            // TripsBtn
            // 
            this.TripsBtn.Location = new System.Drawing.Point(12, 149);
            this.TripsBtn.Name = "TripsBtn";
            this.TripsBtn.Size = new System.Drawing.Size(226, 116);
            this.TripsBtn.TabIndex = 3;
            this.TripsBtn.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 274);
            this.Controls.Add(this.TripsBtn);
            this.Controls.Add(this.TransportBtn);
            this.Controls.Add(this.RoutesBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "EasyTransport";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem1;
        private System.Windows.Forms.Button RoutesBtn;
        private System.Windows.Forms.Button TransportBtn;
        private System.Windows.Forms.Button TripsBtn;
    }
}

