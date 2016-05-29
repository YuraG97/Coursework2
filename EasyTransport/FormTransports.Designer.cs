namespace EasyTransport
{
    partial class FormTransports
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
            this.CreateCopyTransportBtn = new System.Windows.Forms.Button();
            this.RemoveTransportBtn = new System.Windows.Forms.Button();
            this.ChangeTransportBtn = new System.Windows.Forms.Button();
            this.AddNewTransportBtn = new System.Windows.Forms.Button();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.TransportsLstbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CreateCopyTransportBtn
            // 
            this.CreateCopyTransportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCopyTransportBtn.Location = new System.Drawing.Point(341, 398);
            this.CreateCopyTransportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateCopyTransportBtn.Name = "CreateCopyTransportBtn";
            this.CreateCopyTransportBtn.Size = new System.Drawing.Size(154, 61);
            this.CreateCopyTransportBtn.TabIndex = 26;
            this.CreateCopyTransportBtn.Text = "Створити копію";
            this.CreateCopyTransportBtn.UseVisualStyleBackColor = true;
            this.CreateCopyTransportBtn.Click += new System.EventHandler(this.CreateCopyTransportBtn_Click);
            // 
            // RemoveTransportBtn
            // 
            this.RemoveTransportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveTransportBtn.Location = new System.Drawing.Point(503, 398);
            this.RemoveTransportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveTransportBtn.Name = "RemoveTransportBtn";
            this.RemoveTransportBtn.Size = new System.Drawing.Size(154, 61);
            this.RemoveTransportBtn.TabIndex = 25;
            this.RemoveTransportBtn.Text = "Видалити транспорт";
            this.RemoveTransportBtn.UseVisualStyleBackColor = true;
            this.RemoveTransportBtn.Click += new System.EventHandler(this.RemoveTransportBtn_Click);
            // 
            // ChangeTransportBtn
            // 
            this.ChangeTransportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeTransportBtn.Location = new System.Drawing.Point(179, 398);
            this.ChangeTransportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeTransportBtn.Name = "ChangeTransportBtn";
            this.ChangeTransportBtn.Size = new System.Drawing.Size(154, 61);
            this.ChangeTransportBtn.TabIndex = 24;
            this.ChangeTransportBtn.Text = "Редагувати транспорт";
            this.ChangeTransportBtn.UseVisualStyleBackColor = true;
            this.ChangeTransportBtn.Click += new System.EventHandler(this.ChangeTransportBtn_Click);
            // 
            // AddNewTransportBtn
            // 
            this.AddNewTransportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewTransportBtn.Location = new System.Drawing.Point(17, 398);
            this.AddNewTransportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewTransportBtn.Name = "AddNewTransportBtn";
            this.AddNewTransportBtn.Size = new System.Drawing.Size(154, 61);
            this.AddNewTransportBtn.TabIndex = 23;
            this.AddNewTransportBtn.Text = "Новий транспорт";
            this.AddNewTransportBtn.UseVisualStyleBackColor = true;
            this.AddNewTransportBtn.Click += new System.EventHandler(this.AddNewTransportBtn_Click);
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(289, 8);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(368, 28);
            this.TransportTypeCmbbox.TabIndex = 22;
            this.TransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(13, 11);
            this.TransportTypeLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TransportTypeLbl.Name = "TransportTypeLbl";
            this.TransportTypeLbl.Size = new System.Drawing.Size(118, 20);
            this.TransportTypeLbl.TabIndex = 21;
            this.TransportTypeLbl.Text = "Тип транспорту";
            // 
            // TransportsLstbox
            // 
            this.TransportsLstbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportsLstbox.FormattingEnabled = true;
            this.TransportsLstbox.ItemHeight = 20;
            this.TransportsLstbox.Location = new System.Drawing.Point(17, 40);
            this.TransportsLstbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TransportsLstbox.Name = "TransportsLstbox";
            this.TransportsLstbox.Size = new System.Drawing.Size(640, 344);
            this.TransportsLstbox.TabIndex = 20;
            // 
            // FormTransports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 471);
            this.Controls.Add(this.CreateCopyTransportBtn);
            this.Controls.Add(this.RemoveTransportBtn);
            this.Controls.Add(this.ChangeTransportBtn);
            this.Controls.Add(this.AddNewTransportBtn);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.TransportTypeLbl);
            this.Controls.Add(this.TransportsLstbox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTransports";
            this.Text = "Транспорт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCopyTransportBtn;
        private System.Windows.Forms.Button RemoveTransportBtn;
        private System.Windows.Forms.Button ChangeTransportBtn;
        private System.Windows.Forms.Button AddNewTransportBtn;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ListBox TransportsLstbox;
    }
}