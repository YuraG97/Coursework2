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
            this.RemoveStopBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveStopBtn.Location = new System.Drawing.Point(510, 401);
            this.RemoveStopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveStopBtn.Name = "RemoveStopBtn";
            this.RemoveStopBtn.Size = new System.Drawing.Size(154, 61);
            this.RemoveStopBtn.TabIndex = 11;
            this.RemoveStopBtn.Text = "Видалити зупинку";
            this.RemoveStopBtn.UseVisualStyleBackColor = true;
            this.RemoveStopBtn.Click += new System.EventHandler(this.RemoveStopBtn_Click);
            // 
            // ChangeStopBtn
            // 
            this.ChangeStopBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeStopBtn.Location = new System.Drawing.Point(186, 401);
            this.ChangeStopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeStopBtn.Name = "ChangeStopBtn";
            this.ChangeStopBtn.Size = new System.Drawing.Size(154, 61);
            this.ChangeStopBtn.TabIndex = 10;
            this.ChangeStopBtn.Text = "Редагувати зупинку";
            this.ChangeStopBtn.UseVisualStyleBackColor = true;
            this.ChangeStopBtn.Click += new System.EventHandler(this.ChangeStopBtn_Click);
            // 
            // AddNewStopBtn
            // 
            this.AddNewStopBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewStopBtn.Location = new System.Drawing.Point(24, 401);
            this.AddNewStopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewStopBtn.Name = "AddNewStopBtn";
            this.AddNewStopBtn.Size = new System.Drawing.Size(154, 61);
            this.AddNewStopBtn.TabIndex = 9;
            this.AddNewStopBtn.Text = "Нова зупинка";
            this.AddNewStopBtn.UseVisualStyleBackColor = true;
            this.AddNewStopBtn.Click += new System.EventHandler(this.AddNewStopBtn_Click);
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(296, 11);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(368, 28);
            this.TransportTypeCmbbox.TabIndex = 8;
            this.TransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(20, 14);
            this.TransportTypeLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TransportTypeLbl.Name = "TransportTypeLbl";
            this.TransportTypeLbl.Size = new System.Drawing.Size(118, 20);
            this.TransportTypeLbl.TabIndex = 7;
            this.TransportTypeLbl.Text = "Тип транспорту";
            // 
            // StopsLstbox
            // 
            this.StopsLstbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopsLstbox.FormattingEnabled = true;
            this.StopsLstbox.ItemHeight = 20;
            this.StopsLstbox.Location = new System.Drawing.Point(24, 43);
            this.StopsLstbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.StopsLstbox.Name = "StopsLstbox";
            this.StopsLstbox.Size = new System.Drawing.Size(640, 344);
            this.StopsLstbox.TabIndex = 6;
            // 
            // CreateCopyStopBtn
            // 
            this.CreateCopyStopBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCopyStopBtn.Location = new System.Drawing.Point(348, 401);
            this.CreateCopyStopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateCopyStopBtn.Name = "CreateCopyStopBtn";
            this.CreateCopyStopBtn.Size = new System.Drawing.Size(154, 61);
            this.CreateCopyStopBtn.TabIndex = 12;
            this.CreateCopyStopBtn.Text = "Створити копію";
            this.CreateCopyStopBtn.UseVisualStyleBackColor = true;
            this.CreateCopyStopBtn.Click += new System.EventHandler(this.CreateCopyStopBtn_Click);
            // 
            // FormStops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 471);
            this.Controls.Add(this.CreateCopyStopBtn);
            this.Controls.Add(this.RemoveStopBtn);
            this.Controls.Add(this.ChangeStopBtn);
            this.Controls.Add(this.AddNewStopBtn);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.TransportTypeLbl);
            this.Controls.Add(this.StopsLstbox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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