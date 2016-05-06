namespace EasyTransport
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.License = new System.Windows.Forms.Label();
            this.Developer = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.ProgramName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ліцензія";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(578, 296);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 29;
            this.button1.Text = "Закрити";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // License
            // 
            this.License.AutoSize = true;
            this.License.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.License.Location = new System.Drawing.Point(12, 283);
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(305, 51);
            this.License.TabIndex = 21;
            this.License.Text = "Даний програмний продукт захищений \r\nавторськими правами про розповсюдження\r\nдано" +
    "го продукту та його використання.";
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Developer.Location = new System.Drawing.Point(427, 202);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(203, 51);
            this.Developer.TabIndex = 20;
            this.Developer.Text = "Розробник даного продукту :\r\nГаврилюк Ю.О. (НТУУ \'КПІ\', \r\nФакультет ІОТ, група ІТ" +
    "-42)";
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.Image = global::EasyTransport.Properties.Resources.shuttle_icon;
            this.Logo.Location = new System.Drawing.Point(430, 14);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(255, 171);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 19;
            this.Logo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 119);
            this.label3.TabIndex = 18;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Version.Location = new System.Drawing.Point(14, 54);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(182, 44);
            this.Version.TabIndex = 17;
            this.Version.Text = "Версія 1.0.0 build 1\r\nвід 20.03.2016";
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgramName.Location = new System.Drawing.Point(12, 14);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(239, 28);
            this.ProgramName.TabIndex = 16;
            this.ProgramName.Text = "АІС \"EasyTransport\"";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 344);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.License);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.ProgramName);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "Про програму";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label License;
        private System.Windows.Forms.Label Developer;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label ProgramName;
    }
}