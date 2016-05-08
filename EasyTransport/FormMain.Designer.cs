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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutesBtn = new System.Windows.Forms.Button();
            this.TransportBtn = new System.Windows.Forms.Button();
            this.TripsBtn = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuItem,
            this.AboutProgramMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.MainMenu.Size = new System.Drawing.Size(566, 27);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MainMenuItem
            // 
            this.MainMenuItem.Name = "MainMenuItem";
            this.MainMenuItem.Size = new System.Drawing.Size(65, 19);
            this.MainMenuItem.Text = "Головна";
            // 
            // AboutProgramMenuItem
            // 
            this.AboutProgramMenuItem.Name = "AboutProgramMenuItem";
            this.AboutProgramMenuItem.Size = new System.Drawing.Size(99, 19);
            this.AboutProgramMenuItem.Text = "Про програму";
            this.AboutProgramMenuItem.Click += new System.EventHandler(this.AboutProgramMenuItem_Click);
            // 
            // RoutesBtn
            // 
            this.RoutesBtn.Location = new System.Drawing.Point(15, 33);
            this.RoutesBtn.Margin = new System.Windows.Forms.Padding(6);
            this.RoutesBtn.Name = "RoutesBtn";
            this.RoutesBtn.Size = new System.Drawing.Size(261, 136);
            this.RoutesBtn.TabIndex = 1;
            this.RoutesBtn.Text = "Маршрути";
            this.RoutesBtn.UseVisualStyleBackColor = true;
            this.RoutesBtn.Click += new System.EventHandler(this.RoutesBtn_Click);
            // 
            // TransportBtn
            // 
            this.TransportBtn.Location = new System.Drawing.Point(15, 181);
            this.TransportBtn.Margin = new System.Windows.Forms.Padding(6);
            this.TransportBtn.Name = "TransportBtn";
            this.TransportBtn.Size = new System.Drawing.Size(261, 136);
            this.TransportBtn.TabIndex = 2;
            this.TransportBtn.Text = "Транспорт";
            this.TransportBtn.UseVisualStyleBackColor = true;
            this.TransportBtn.Click += new System.EventHandler(this.TransportBtn_Click);
            // 
            // TripsBtn
            // 
            this.TripsBtn.Location = new System.Drawing.Point(288, 33);
            this.TripsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.TripsBtn.Name = "TripsBtn";
            this.TripsBtn.Size = new System.Drawing.Size(261, 136);
            this.TripsBtn.TabIndex = 3;
            this.TripsBtn.Text = "Рейси";
            this.TripsBtn.UseVisualStyleBackColor = true;
            this.TripsBtn.Click += new System.EventHandler(this.TripsBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 331);
            this.Controls.Add(this.TripsBtn);
            this.Controls.Add(this.TransportBtn);
            this.Controls.Add(this.RoutesBtn);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.Text = "EasyTransport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramMenuItem;
        private System.Windows.Forms.Button RoutesBtn;
        private System.Windows.Forms.Button TransportBtn;
        private System.Windows.Forms.Button TripsBtn;
    }
}

