namespace EasyTransport
{
    partial class FormRoads
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
            this.CreateCopyRoadBtn = new System.Windows.Forms.Button();
            this.RemoveRoadBtn = new System.Windows.Forms.Button();
            this.ChangeRoadBtn = new System.Windows.Forms.Button();
            this.AddNewRoadBtn = new System.Windows.Forms.Button();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.RoadsLstbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CreateCopyRoadBtn
            // 
            this.CreateCopyRoadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCopyRoadBtn.Location = new System.Drawing.Point(344, 405);
            this.CreateCopyRoadBtn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.CreateCopyRoadBtn.Name = "CreateCopyRoadBtn";
            this.CreateCopyRoadBtn.Size = new System.Drawing.Size(152, 59);
            this.CreateCopyRoadBtn.TabIndex = 19;
            this.CreateCopyRoadBtn.Text = "Створити копію";
            this.CreateCopyRoadBtn.UseVisualStyleBackColor = true;
            this.CreateCopyRoadBtn.Click += new System.EventHandler(this.CreateCopyRoadBtn_Click);
            // 
            // RemoveRoadBtn
            // 
            this.RemoveRoadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveRoadBtn.Location = new System.Drawing.Point(506, 405);
            this.RemoveRoadBtn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.RemoveRoadBtn.Name = "RemoveRoadBtn";
            this.RemoveRoadBtn.Size = new System.Drawing.Size(152, 59);
            this.RemoveRoadBtn.TabIndex = 18;
            this.RemoveRoadBtn.Text = "Видалити дорогу";
            this.RemoveRoadBtn.UseVisualStyleBackColor = true;
            this.RemoveRoadBtn.Click += new System.EventHandler(this.RemoveRoadBtn_Click);
            // 
            // ChangeRoadBtn
            // 
            this.ChangeRoadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeRoadBtn.Location = new System.Drawing.Point(182, 405);
            this.ChangeRoadBtn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.ChangeRoadBtn.Name = "ChangeRoadBtn";
            this.ChangeRoadBtn.Size = new System.Drawing.Size(152, 59);
            this.ChangeRoadBtn.TabIndex = 17;
            this.ChangeRoadBtn.Text = "Редагувати дорогу";
            this.ChangeRoadBtn.UseVisualStyleBackColor = true;
            this.ChangeRoadBtn.Click += new System.EventHandler(this.ChangeRoadBtn_Click);
            // 
            // AddNewRoadBtn
            // 
            this.AddNewRoadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewRoadBtn.Location = new System.Drawing.Point(20, 405);
            this.AddNewRoadBtn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.AddNewRoadBtn.Name = "AddNewRoadBtn";
            this.AddNewRoadBtn.Size = new System.Drawing.Size(152, 59);
            this.AddNewRoadBtn.TabIndex = 16;
            this.AddNewRoadBtn.Text = "Нова дорога";
            this.AddNewRoadBtn.UseVisualStyleBackColor = true;
            this.AddNewRoadBtn.Click += new System.EventHandler(this.AddNewRoadBtn_Click);
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(382, 12);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(276, 28);
            this.TransportTypeCmbbox.TabIndex = 15;
            this.TransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(17, 15);
            this.TransportTypeLbl.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.TransportTypeLbl.Name = "TransportTypeLbl";
            this.TransportTypeLbl.Size = new System.Drawing.Size(118, 20);
            this.TransportTypeLbl.TabIndex = 14;
            this.TransportTypeLbl.Text = "Тип транспорту";
            // 
            // RoadsLstbox
            // 
            this.RoadsLstbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoadsLstbox.FormattingEnabled = true;
            this.RoadsLstbox.ItemHeight = 20;
            this.RoadsLstbox.Location = new System.Drawing.Point(20, 49);
            this.RoadsLstbox.Margin = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.RoadsLstbox.Name = "RoadsLstbox";
            this.RoadsLstbox.Size = new System.Drawing.Size(638, 344);
            this.RoadsLstbox.TabIndex = 13;
            // 
            // FormRoads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 485);
            this.Controls.Add(this.CreateCopyRoadBtn);
            this.Controls.Add(this.RemoveRoadBtn);
            this.Controls.Add(this.ChangeRoadBtn);
            this.Controls.Add(this.AddNewRoadBtn);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.TransportTypeLbl);
            this.Controls.Add(this.RoadsLstbox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRoads";
            this.Text = "Дороги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCopyRoadBtn;
        private System.Windows.Forms.Button RemoveRoadBtn;
        private System.Windows.Forms.Button ChangeRoadBtn;
        private System.Windows.Forms.Button AddNewRoadBtn;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ListBox RoadsLstbox;
    }
}