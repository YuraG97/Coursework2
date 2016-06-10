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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransports));
            this.CreateCopyTransportBtn = new System.Windows.Forms.Button();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.RemoveTransportBtn = new System.Windows.Forms.Button();
            this.AddNewTransportBtn = new System.Windows.Forms.Button();
            this.FilterTransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.TransportsLstbox = new System.Windows.Forms.ListBox();
            this.TransportListGroup = new System.Windows.Forms.GroupBox();
            this.TransportEditGroup = new System.Windows.Forms.GroupBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.RichTextBox();
            this.AverageSpeedLabel = new System.Windows.Forms.Label();
            this.AverageSpeedNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.SerialNumLbl = new System.Windows.Forms.Label();
            this.SerialNumberTxtbox = new System.Windows.Forms.TextBox();
            this.SerieLbl = new System.Windows.Forms.Label();
            this.MarkLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SerieTxtbox = new System.Windows.Forms.TextBox();
            this.SaveTransport = new System.Windows.Forms.Button();
            this.MarkTxtbox = new System.Windows.Forms.TextBox();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportLabel = new System.Windows.Forms.Label();
            this.TransportListGroup.SuspendLayout();
            this.TransportEditGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AverageSpeedNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCopyTransportBtn
            // 
            this.CreateCopyTransportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCopyTransportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateCopyTransportBtn.ImageKey = "copy.png";
            this.CreateCopyTransportBtn.ImageList = this.IconsList;
            this.CreateCopyTransportBtn.Location = new System.Drawing.Point(11, 410);
            this.CreateCopyTransportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateCopyTransportBtn.Name = "CreateCopyTransportBtn";
            this.CreateCopyTransportBtn.Size = new System.Drawing.Size(160, 61);
            this.CreateCopyTransportBtn.TabIndex = 26;
            this.CreateCopyTransportBtn.Text = "Створити копію";
            this.CreateCopyTransportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateCopyTransportBtn.UseVisualStyleBackColor = true;
            this.CreateCopyTransportBtn.Click += new System.EventHandler(this.CreateCopyTransportBtn_Click);
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "addTransport.jpg");
            this.IconsList.Images.SetKeyName(1, "copy.png");
            this.IconsList.Images.SetKeyName(2, "deleteIcon.png");
            this.IconsList.Images.SetKeyName(3, "saveIcon.png");
            // 
            // RemoveTransportBtn
            // 
            this.RemoveTransportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveTransportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveTransportBtn.ImageKey = "deleteIcon.png";
            this.RemoveTransportBtn.ImageList = this.IconsList;
            this.RemoveTransportBtn.Location = new System.Drawing.Point(7, 410);
            this.RemoveTransportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveTransportBtn.Name = "RemoveTransportBtn";
            this.RemoveTransportBtn.Size = new System.Drawing.Size(186, 61);
            this.RemoveTransportBtn.TabIndex = 25;
            this.RemoveTransportBtn.Text = "Видалити транспорт";
            this.RemoveTransportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveTransportBtn.UseVisualStyleBackColor = true;
            this.RemoveTransportBtn.Click += new System.EventHandler(this.RemoveTransportBtn_Click);
            // 
            // AddNewTransportBtn
            // 
            this.AddNewTransportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewTransportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewTransportBtn.ImageKey = "addTransport.jpg";
            this.AddNewTransportBtn.ImageList = this.IconsList;
            this.AddNewTransportBtn.Location = new System.Drawing.Point(179, 410);
            this.AddNewTransportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewTransportBtn.Name = "AddNewTransportBtn";
            this.AddNewTransportBtn.Size = new System.Drawing.Size(170, 61);
            this.AddNewTransportBtn.TabIndex = 23;
            this.AddNewTransportBtn.Text = "Новий транспорт";
            this.AddNewTransportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewTransportBtn.UseVisualStyleBackColor = true;
            this.AddNewTransportBtn.Click += new System.EventHandler(this.AddNewTransportBtn_Click);
            // 
            // FilterTransportTypeCmbbox
            // 
            this.FilterTransportTypeCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterTransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterTransportTypeCmbbox.FormattingEnabled = true;
            this.FilterTransportTypeCmbbox.Location = new System.Drawing.Point(141, 21);
            this.FilterTransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.FilterTransportTypeCmbbox.Name = "FilterTransportTypeCmbbox";
            this.FilterTransportTypeCmbbox.Size = new System.Drawing.Size(208, 28);
            this.FilterTransportTypeCmbbox.TabIndex = 22;
            this.FilterTransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(7, 24);
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
            this.TransportsLstbox.Location = new System.Drawing.Point(11, 53);
            this.TransportsLstbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TransportsLstbox.Name = "TransportsLstbox";
            this.TransportsLstbox.Size = new System.Drawing.Size(338, 344);
            this.TransportsLstbox.TabIndex = 20;
            this.TransportsLstbox.SelectedIndexChanged += new System.EventHandler(this.TransportsLstbox_SelectedIndexChanged);
            // 
            // TransportListGroup
            // 
            this.TransportListGroup.Controls.Add(this.TransportsLstbox);
            this.TransportListGroup.Controls.Add(this.CreateCopyTransportBtn);
            this.TransportListGroup.Controls.Add(this.TransportTypeLbl);
            this.TransportListGroup.Controls.Add(this.FilterTransportTypeCmbbox);
            this.TransportListGroup.Controls.Add(this.AddNewTransportBtn);
            this.TransportListGroup.Location = new System.Drawing.Point(12, 37);
            this.TransportListGroup.Name = "TransportListGroup";
            this.TransportListGroup.Size = new System.Drawing.Size(360, 479);
            this.TransportListGroup.TabIndex = 27;
            this.TransportListGroup.TabStop = false;
            this.TransportListGroup.Text = "Список транспорту";
            // 
            // TransportEditGroup
            // 
            this.TransportEditGroup.Controls.Add(this.DescriptionLabel);
            this.TransportEditGroup.Controls.Add(this.DescriptionTextbox);
            this.TransportEditGroup.Controls.Add(this.AverageSpeedLabel);
            this.TransportEditGroup.Controls.Add(this.AverageSpeedNumUpDown);
            this.TransportEditGroup.Controls.Add(this.SerialNumLbl);
            this.TransportEditGroup.Controls.Add(this.SerialNumberTxtbox);
            this.TransportEditGroup.Controls.Add(this.SerieLbl);
            this.TransportEditGroup.Controls.Add(this.RemoveTransportBtn);
            this.TransportEditGroup.Controls.Add(this.MarkLbl);
            this.TransportEditGroup.Controls.Add(this.label1);
            this.TransportEditGroup.Controls.Add(this.SerieTxtbox);
            this.TransportEditGroup.Controls.Add(this.SaveTransport);
            this.TransportEditGroup.Controls.Add(this.MarkTxtbox);
            this.TransportEditGroup.Controls.Add(this.TransportTypeCmbbox);
            this.TransportEditGroup.Location = new System.Drawing.Point(378, 36);
            this.TransportEditGroup.Name = "TransportEditGroup";
            this.TransportEditGroup.Size = new System.Drawing.Size(375, 479);
            this.TransportEditGroup.TabIndex = 28;
            this.TransportEditGroup.TabStop = false;
            this.TransportEditGroup.Text = "Редагування транспорту";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 248);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(45, 20);
            this.DescriptionLabel.TabIndex = 41;
            this.DescriptionLabel.Text = "Опис";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Location = new System.Drawing.Point(166, 245);
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(200, 140);
            this.DescriptionTextbox.TabIndex = 40;
            this.DescriptionTextbox.Text = "";
            // 
            // AverageSpeedLabel
            // 
            this.AverageSpeedLabel.AutoSize = true;
            this.AverageSpeedLabel.Location = new System.Drawing.Point(6, 214);
            this.AverageSpeedLabel.Name = "AverageSpeedLabel";
            this.AverageSpeedLabel.Size = new System.Drawing.Size(141, 20);
            this.AverageSpeedLabel.TabIndex = 39;
            this.AverageSpeedLabel.Text = "Середня швидкість";
            // 
            // AverageSpeedNumUpDown
            // 
            this.AverageSpeedNumUpDown.Location = new System.Drawing.Point(166, 212);
            this.AverageSpeedNumUpDown.Name = "AverageSpeedNumUpDown";
            this.AverageSpeedNumUpDown.Size = new System.Drawing.Size(200, 27);
            this.AverageSpeedNumUpDown.TabIndex = 38;
            // 
            // SerialNumLbl
            // 
            this.SerialNumLbl.AutoSize = true;
            this.SerialNumLbl.Location = new System.Drawing.Point(6, 182);
            this.SerialNumLbl.Name = "SerialNumLbl";
            this.SerialNumLbl.Size = new System.Drawing.Size(125, 20);
            this.SerialNumLbl.TabIndex = 34;
            this.SerialNumLbl.Text = "Серійний номер";
            // 
            // SerialNumberTxtbox
            // 
            this.SerialNumberTxtbox.Location = new System.Drawing.Point(166, 179);
            this.SerialNumberTxtbox.Name = "SerialNumberTxtbox";
            this.SerialNumberTxtbox.Size = new System.Drawing.Size(200, 27);
            this.SerialNumberTxtbox.TabIndex = 37;
            // 
            // SerieLbl
            // 
            this.SerieLbl.AutoSize = true;
            this.SerieLbl.Location = new System.Drawing.Point(6, 149);
            this.SerieLbl.Name = "SerieLbl";
            this.SerieLbl.Size = new System.Drawing.Size(47, 20);
            this.SerieLbl.TabIndex = 33;
            this.SerieLbl.Text = "Серія";
            // 
            // MarkLbl
            // 
            this.MarkLbl.AutoSize = true;
            this.MarkLbl.Location = new System.Drawing.Point(6, 116);
            this.MarkLbl.Name = "MarkLbl";
            this.MarkLbl.Size = new System.Drawing.Size(54, 20);
            this.MarkLbl.TabIndex = 32;
            this.MarkLbl.Text = "Марка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Тип транспорту";
            // 
            // SerieTxtbox
            // 
            this.SerieTxtbox.Location = new System.Drawing.Point(166, 146);
            this.SerieTxtbox.Name = "SerieTxtbox";
            this.SerieTxtbox.Size = new System.Drawing.Size(200, 27);
            this.SerieTxtbox.TabIndex = 36;
            // 
            // SaveTransport
            // 
            this.SaveTransport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveTransport.ImageKey = "saveIcon.png";
            this.SaveTransport.ImageList = this.IconsList;
            this.SaveTransport.Location = new System.Drawing.Point(248, 410);
            this.SaveTransport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveTransport.Name = "SaveTransport";
            this.SaveTransport.Size = new System.Drawing.Size(118, 61);
            this.SaveTransport.TabIndex = 31;
            this.SaveTransport.Text = "Зберегти";
            this.SaveTransport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveTransport.UseVisualStyleBackColor = true;
            this.SaveTransport.Click += new System.EventHandler(this.SaveTransport_Click);
            // 
            // MarkTxtbox
            // 
            this.MarkTxtbox.Location = new System.Drawing.Point(166, 113);
            this.MarkTxtbox.Name = "MarkTxtbox";
            this.MarkTxtbox.Size = new System.Drawing.Size(200, 27);
            this.MarkTxtbox.TabIndex = 35;
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(166, 77);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(200, 28);
            this.TransportTypeCmbbox.TabIndex = 30;
            // 
            // TransportLabel
            // 
            this.TransportLabel.AutoSize = true;
            this.TransportLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportLabel.Location = new System.Drawing.Point(315, 9);
            this.TransportLabel.Name = "TransportLabel";
            this.TransportLabel.Size = new System.Drawing.Size(114, 30);
            this.TransportLabel.TabIndex = 29;
            this.TransportLabel.Text = "Транспорт";
            // 
            // FormTransports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 528);
            this.Controls.Add(this.TransportLabel);
            this.Controls.Add(this.TransportEditGroup);
            this.Controls.Add(this.TransportListGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTransports";
            this.Text = "Транспорт";
            this.TransportListGroup.ResumeLayout(false);
            this.TransportListGroup.PerformLayout();
            this.TransportEditGroup.ResumeLayout(false);
            this.TransportEditGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AverageSpeedNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCopyTransportBtn;
        private System.Windows.Forms.Button RemoveTransportBtn;
        private System.Windows.Forms.Button AddNewTransportBtn;
        private System.Windows.Forms.ComboBox FilterTransportTypeCmbbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ListBox TransportsLstbox;
        private System.Windows.Forms.GroupBox TransportListGroup;
        private System.Windows.Forms.GroupBox TransportEditGroup;
        private System.Windows.Forms.Label AverageSpeedLabel;
        private System.Windows.Forms.NumericUpDown AverageSpeedNumUpDown;
        private System.Windows.Forms.Label SerialNumLbl;
        private System.Windows.Forms.TextBox SerialNumberTxtbox;
        private System.Windows.Forms.Label SerieLbl;
        private System.Windows.Forms.Label MarkLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SerieTxtbox;
        private System.Windows.Forms.Button SaveTransport;
        private System.Windows.Forms.TextBox MarkTxtbox;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox DescriptionTextbox;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.Label TransportLabel;
    }
}