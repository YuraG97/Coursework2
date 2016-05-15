namespace EasyTransport
{
    partial class FormStops
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
            this.RemoveStopBtn = new System.Windows.Forms.Button();
            this.ChangeStopBtn = new System.Windows.Forms.Button();
            this.AddNewStopBtn = new System.Windows.Forms.Button();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.StopsLstbox = new System.Windows.Forms.ListBox();
            this.CreateCopyStopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveStopBtn
            // 
            this.RemoveStopBtn.Location = new System.Drawing.Point(477, 399);
            this.RemoveStopBtn.Name = "RemoveStopBtn";
            this.RemoveStopBtn.Size = new System.Drawing.Size(148, 66);
            this.RemoveStopBtn.TabIndex = 11;
            this.RemoveStopBtn.Text = "Видалити зупинку";
            this.RemoveStopBtn.UseVisualStyleBackColor = true;
            this.RemoveStopBtn.Click += new System.EventHandler(this.RemoveStopBtn_Click);
            // 
            // ChangeStopBtn
            // 
            this.ChangeStopBtn.Location = new System.Drawing.Point(169, 399);
            this.ChangeStopBtn.Name = "ChangeStopBtn";
            this.ChangeStopBtn.Size = new System.Drawing.Size(148, 66);
            this.ChangeStopBtn.TabIndex = 10;
            this.ChangeStopBtn.Text = "Редагувати зупинку";
            this.ChangeStopBtn.UseVisualStyleBackColor = true;
            this.ChangeStopBtn.Click += new System.EventHandler(this.ChangeStopBtn_Click);
            // 
            // AddNewStopBtn
            // 
            this.AddNewStopBtn.Location = new System.Drawing.Point(15, 399);
            this.AddNewStopBtn.Name = "AddNewStopBtn";
            this.AddNewStopBtn.Size = new System.Drawing.Size(148, 66);
            this.AddNewStopBtn.TabIndex = 9;
            this.AddNewStopBtn.Text = "Нова зупинка";
            this.AddNewStopBtn.UseVisualStyleBackColor = true;
            this.AddNewStopBtn.Click += new System.EventHandler(this.AddNewStopBtn_Click);
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(348, 9);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(6);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(277, 29);
            this.TransportTypeCmbbox.TabIndex = 8;
            this.TransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(15, 9);
            this.TransportTypeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TransportTypeLbl.Name = "TransportTypeLbl";
            this.TransportTypeLbl.Size = new System.Drawing.Size(122, 21);
            this.TransportTypeLbl.TabIndex = 7;
            this.TransportTypeLbl.Text = "Тип транспорту";
            // 
            // StopsLstbox
            // 
            this.StopsLstbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopsLstbox.FormattingEnabled = true;
            this.StopsLstbox.ItemHeight = 21;
            this.StopsLstbox.Location = new System.Drawing.Point(15, 50);
            this.StopsLstbox.Margin = new System.Windows.Forms.Padding(6);
            this.StopsLstbox.Name = "StopsLstbox";
            this.StopsLstbox.Size = new System.Drawing.Size(610, 340);
            this.StopsLstbox.TabIndex = 6;
            // 
            // CreateCopyStopBtn
            // 
            this.CreateCopyStopBtn.Location = new System.Drawing.Point(323, 399);
            this.CreateCopyStopBtn.Name = "CreateCopyStopBtn";
            this.CreateCopyStopBtn.Size = new System.Drawing.Size(148, 66);
            this.CreateCopyStopBtn.TabIndex = 12;
            this.CreateCopyStopBtn.Text = "Створити копію";
            this.CreateCopyStopBtn.UseVisualStyleBackColor = true;
            this.CreateCopyStopBtn.Click += new System.EventHandler(this.CreateCopyStopBtn_Click);
            // 
            // FormStops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 481);
            this.Controls.Add(this.CreateCopyStopBtn);
            this.Controls.Add(this.RemoveStopBtn);
            this.Controls.Add(this.ChangeStopBtn);
            this.Controls.Add(this.AddNewStopBtn);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.TransportTypeLbl);
            this.Controls.Add(this.StopsLstbox);
            this.Name = "FormStops";
            this.Text = "Зупинки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveStopBtn;
        private System.Windows.Forms.Button ChangeStopBtn;
        private System.Windows.Forms.Button AddNewStopBtn;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ListBox StopsLstbox;
        private System.Windows.Forms.Button CreateCopyStopBtn;
    }
}