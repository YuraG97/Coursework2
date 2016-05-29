namespace EasyTransport
{
    partial class FormTransportEditor
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
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.CreateNewTransport = new System.Windows.Forms.Button();
            this.MarkLbl = new System.Windows.Forms.Label();
            this.SerieLbl = new System.Windows.Forms.Label();
            this.SerialNumLbl = new System.Windows.Forms.Label();
            this.MarkTxtbox = new System.Windows.Forms.TextBox();
            this.SerieTxtbox = new System.Windows.Forms.TextBox();
            this.SerialNumberTxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(144, 14);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(200, 28);
            this.TransportTypeCmbbox.TabIndex = 12;
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(12, 17);
            this.TransportTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransportTypeLbl.Name = "TransportTypeLbl";
            this.TransportTypeLbl.Size = new System.Drawing.Size(118, 20);
            this.TransportTypeLbl.TabIndex = 11;
            this.TransportTypeLbl.Text = "Тип транспорту";
            // 
            // CreateNewTransport
            // 
            this.CreateNewTransport.Location = new System.Drawing.Point(231, 160);
            this.CreateNewTransport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateNewTransport.Name = "CreateNewTransport";
            this.CreateNewTransport.Size = new System.Drawing.Size(113, 58);
            this.CreateNewTransport.TabIndex = 19;
            this.CreateNewTransport.Text = "Створити";
            this.CreateNewTransport.UseVisualStyleBackColor = true;
            this.CreateNewTransport.Click += new System.EventHandler(this.CreateNewTransport_Click);
            // 
            // MarkLbl
            // 
            this.MarkLbl.AutoSize = true;
            this.MarkLbl.Location = new System.Drawing.Point(12, 53);
            this.MarkLbl.Name = "MarkLbl";
            this.MarkLbl.Size = new System.Drawing.Size(54, 20);
            this.MarkLbl.TabIndex = 20;
            this.MarkLbl.Text = "Марка";
            // 
            // SerieLbl
            // 
            this.SerieLbl.AutoSize = true;
            this.SerieLbl.Location = new System.Drawing.Point(12, 86);
            this.SerieLbl.Name = "SerieLbl";
            this.SerieLbl.Size = new System.Drawing.Size(47, 20);
            this.SerieLbl.TabIndex = 21;
            this.SerieLbl.Text = "Серія";
            // 
            // SerialNumLbl
            // 
            this.SerialNumLbl.AutoSize = true;
            this.SerialNumLbl.Location = new System.Drawing.Point(12, 119);
            this.SerialNumLbl.Name = "SerialNumLbl";
            this.SerialNumLbl.Size = new System.Drawing.Size(125, 20);
            this.SerialNumLbl.TabIndex = 22;
            this.SerialNumLbl.Text = "Серійний номер";
            // 
            // MarkTxtbox
            // 
            this.MarkTxtbox.Location = new System.Drawing.Point(144, 50);
            this.MarkTxtbox.Name = "MarkTxtbox";
            this.MarkTxtbox.Size = new System.Drawing.Size(200, 27);
            this.MarkTxtbox.TabIndex = 23;
            // 
            // SerieTxtbox
            // 
            this.SerieTxtbox.Location = new System.Drawing.Point(144, 83);
            this.SerieTxtbox.Name = "SerieTxtbox";
            this.SerieTxtbox.Size = new System.Drawing.Size(200, 27);
            this.SerieTxtbox.TabIndex = 24;
            // 
            // SerialNumberTxtbox
            // 
            this.SerialNumberTxtbox.Location = new System.Drawing.Point(144, 116);
            this.SerialNumberTxtbox.Name = "SerialNumberTxtbox";
            this.SerialNumberTxtbox.Size = new System.Drawing.Size(200, 27);
            this.SerialNumberTxtbox.TabIndex = 25;
            // 
            // FormTransportEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 226);
            this.Controls.Add(this.SerialNumberTxtbox);
            this.Controls.Add(this.SerieTxtbox);
            this.Controls.Add(this.MarkTxtbox);
            this.Controls.Add(this.SerialNumLbl);
            this.Controls.Add(this.SerieLbl);
            this.Controls.Add(this.MarkLbl);
            this.Controls.Add(this.CreateNewTransport);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.TransportTypeLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTransportEditor";
            this.Text = "Новий транспорт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.Button CreateNewTransport;
        private System.Windows.Forms.Label MarkLbl;
        private System.Windows.Forms.Label SerieLbl;
        private System.Windows.Forms.Label SerialNumLbl;
        private System.Windows.Forms.TextBox MarkTxtbox;
        private System.Windows.Forms.TextBox SerieTxtbox;
        private System.Windows.Forms.TextBox SerialNumberTxtbox;
    }
}