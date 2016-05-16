namespace EasyTransport
{
    partial class FormStopEditor
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
            this.StopNameTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StopCoordYNumupdown = new System.Windows.Forms.NumericUpDown();
            this.StopCoordXNumupdown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateNewStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StopCoordYNumupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopCoordXNumupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // StopNameTxtbox
            // 
            this.StopNameTxtbox.Location = new System.Drawing.Point(152, 52);
            this.StopNameTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopNameTxtbox.Name = "StopNameTxtbox";
            this.StopNameTxtbox.Size = new System.Drawing.Size(160, 27);
            this.StopNameTxtbox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(108, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(108, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "X";
            // 
            // StopCoordYNumupdown
            // 
            this.StopCoordYNumupdown.Location = new System.Drawing.Point(152, 126);
            this.StopCoordYNumupdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopCoordYNumupdown.Name = "StopCoordYNumupdown";
            this.StopCoordYNumupdown.Size = new System.Drawing.Size(160, 27);
            this.StopCoordYNumupdown.TabIndex = 14;
            // 
            // StopCoordXNumupdown
            // 
            this.StopCoordXNumupdown.Location = new System.Drawing.Point(152, 89);
            this.StopCoordXNumupdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopCoordXNumupdown.Name = "StopCoordXNumupdown";
            this.StopCoordXNumupdown.Size = new System.Drawing.Size(160, 27);
            this.StopCoordXNumupdown.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Координати";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Назва";
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(152, 11);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(160, 28);
            this.TransportTypeCmbbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Тип транспорту";
            // 
            // CreateNewStop
            // 
            this.CreateNewStop.Location = new System.Drawing.Point(330, 132);
            this.CreateNewStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateNewStop.Name = "CreateNewStop";
            this.CreateNewStop.Size = new System.Drawing.Size(113, 58);
            this.CreateNewStop.TabIndex = 18;
            this.CreateNewStop.Text = "Створити";
            this.CreateNewStop.UseVisualStyleBackColor = true;
            this.CreateNewStop.Click += new System.EventHandler(this.CreateNewStop_Click);
            // 
            // FormStopEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 195);
            this.Controls.Add(this.CreateNewStop);
            this.Controls.Add(this.StopNameTxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StopCoordYNumupdown);
            this.Controls.Add(this.StopCoordXNumupdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStopEditor";
            this.Text = "Редактор зупинок";
            ((System.ComponentModel.ISupportInitialize)(this.StopCoordYNumupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopCoordXNumupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StopNameTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown StopCoordYNumupdown;
        private System.Windows.Forms.NumericUpDown StopCoordXNumupdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateNewStop;
    }
}