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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStops));
            this.RemoveStopBtn = new System.Windows.Forms.Button();
            this.AddNewStopBtn = new System.Windows.Forms.Button();
            this.FilterTransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.StopsLstbox = new System.Windows.Forms.ListBox();
            this.CreateCopyStopBtn = new System.Windows.Forms.Button();
            this.ListOfStopsGroupBox = new System.Windows.Forms.GroupBox();
            this.StopsLabel = new System.Windows.Forms.Label();
            this.SaveStopButton = new System.Windows.Forms.Button();
            this.StopNameTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StopCoordYNumupdown = new System.Windows.Forms.NumericUpDown();
            this.StopCoordXNumupdown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.ListOfStopsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopCoordYNumupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopCoordXNumupdown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveStopBtn
            // 
            this.RemoveStopBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveStopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveStopBtn.ImageKey = "deleteIcon.png";
            this.RemoveStopBtn.ImageList = this.IconsList;
            this.RemoveStopBtn.Location = new System.Drawing.Point(12, 436);
            this.RemoveStopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveStopBtn.Name = "RemoveStopBtn";
            this.RemoveStopBtn.Size = new System.Drawing.Size(173, 43);
            this.RemoveStopBtn.TabIndex = 11;
            this.RemoveStopBtn.Text = "Видалити зупинку";
            this.RemoveStopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveStopBtn.UseVisualStyleBackColor = true;
            this.RemoveStopBtn.Click += new System.EventHandler(this.RemoveStopBtn_Click);
            // 
            // AddNewStopBtn
            // 
            this.AddNewStopBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewStopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewStopBtn.ImageKey = "map_pin_add_1-512.png";
            this.AddNewStopBtn.ImageList = this.IconsList;
            this.AddNewStopBtn.Location = new System.Drawing.Point(12, 436);
            this.AddNewStopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewStopBtn.Name = "AddNewStopBtn";
            this.AddNewStopBtn.Size = new System.Drawing.Size(153, 43);
            this.AddNewStopBtn.TabIndex = 9;
            this.AddNewStopBtn.Text = "Нова зупинка";
            this.AddNewStopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewStopBtn.UseVisualStyleBackColor = true;
            this.AddNewStopBtn.Click += new System.EventHandler(this.AddNewStopBtn_Click);
            // 
            // FilterTransportTypeCmbbox
            // 
            this.FilterTransportTypeCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterTransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterTransportTypeCmbbox.FormattingEnabled = true;
            this.FilterTransportTypeCmbbox.Location = new System.Drawing.Point(129, 32);
            this.FilterTransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.FilterTransportTypeCmbbox.Name = "FilterTransportTypeCmbbox";
            this.FilterTransportTypeCmbbox.Size = new System.Drawing.Size(199, 28);
            this.FilterTransportTypeCmbbox.TabIndex = 8;
            this.FilterTransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(8, 35);
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
            this.StopsLstbox.Location = new System.Drawing.Point(12, 78);
            this.StopsLstbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.StopsLstbox.Name = "StopsLstbox";
            this.StopsLstbox.Size = new System.Drawing.Size(316, 344);
            this.StopsLstbox.TabIndex = 6;
            this.StopsLstbox.SelectedIndexChanged += new System.EventHandler(this.StopsLstbox_SelectedIndexChanged);
            // 
            // CreateCopyStopBtn
            // 
            this.CreateCopyStopBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCopyStopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateCopyStopBtn.ImageKey = "copy.png";
            this.CreateCopyStopBtn.ImageList = this.IconsList;
            this.CreateCopyStopBtn.Location = new System.Drawing.Point(173, 436);
            this.CreateCopyStopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateCopyStopBtn.Name = "CreateCopyStopBtn";
            this.CreateCopyStopBtn.Size = new System.Drawing.Size(162, 43);
            this.CreateCopyStopBtn.TabIndex = 12;
            this.CreateCopyStopBtn.Text = "Створити копію";
            this.CreateCopyStopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateCopyStopBtn.UseVisualStyleBackColor = true;
            this.CreateCopyStopBtn.Click += new System.EventHandler(this.CreateCopyStopBtn_Click);
            // 
            // ListOfStopsGroupBox
            // 
            this.ListOfStopsGroupBox.Controls.Add(this.StopsLstbox);
            this.ListOfStopsGroupBox.Controls.Add(this.AddNewStopBtn);
            this.ListOfStopsGroupBox.Controls.Add(this.CreateCopyStopBtn);
            this.ListOfStopsGroupBox.Controls.Add(this.TransportTypeLbl);
            this.ListOfStopsGroupBox.Controls.Add(this.FilterTransportTypeCmbbox);
            this.ListOfStopsGroupBox.Location = new System.Drawing.Point(12, 57);
            this.ListOfStopsGroupBox.Name = "ListOfStopsGroupBox";
            this.ListOfStopsGroupBox.Size = new System.Drawing.Size(342, 487);
            this.ListOfStopsGroupBox.TabIndex = 13;
            this.ListOfStopsGroupBox.TabStop = false;
            this.ListOfStopsGroupBox.Text = "Список зупинок";
            // 
            // StopsLabel
            // 
            this.StopsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopsLabel.AutoSize = true;
            this.StopsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopsLabel.Location = new System.Drawing.Point(309, 9);
            this.StopsLabel.Name = "StopsLabel";
            this.StopsLabel.Size = new System.Drawing.Size(92, 30);
            this.StopsLabel.TabIndex = 14;
            this.StopsLabel.Text = "Зупинки";
            this.StopsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveStopButton
            // 
            this.SaveStopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveStopButton.ImageKey = "saveIcon.png";
            this.SaveStopButton.ImageList = this.IconsList;
            this.SaveStopButton.Location = new System.Drawing.Point(193, 436);
            this.SaveStopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveStopButton.Name = "SaveStopButton";
            this.SaveStopButton.Size = new System.Drawing.Size(173, 43);
            this.SaveStopButton.TabIndex = 28;
            this.SaveStopButton.Text = "Зберегти";
            this.SaveStopButton.UseVisualStyleBackColor = true;
            this.SaveStopButton.Click += new System.EventHandler(this.SaveStopButton_Click);
            // 
            // StopNameTxtbox
            // 
            this.StopNameTxtbox.Location = new System.Drawing.Point(148, 108);
            this.StopNameTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopNameTxtbox.Name = "StopNameTxtbox";
            this.StopNameTxtbox.Size = new System.Drawing.Size(228, 27);
            this.StopNameTxtbox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(111, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(110, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "X";
            // 
            // StopCoordYNumupdown
            // 
            this.StopCoordYNumupdown.Location = new System.Drawing.Point(148, 182);
            this.StopCoordYNumupdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopCoordYNumupdown.Name = "StopCoordYNumupdown";
            this.StopCoordYNumupdown.Size = new System.Drawing.Size(228, 27);
            this.StopCoordYNumupdown.TabIndex = 24;
            // 
            // StopCoordXNumupdown
            // 
            this.StopCoordXNumupdown.Location = new System.Drawing.Point(148, 145);
            this.StopCoordXNumupdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopCoordXNumupdown.Name = "StopCoordXNumupdown";
            this.StopCoordXNumupdown.Size = new System.Drawing.Size(228, 27);
            this.StopCoordXNumupdown.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Координати";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(77, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Назва";
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(148, 67);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(228, 28);
            this.TransportTypeCmbbox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Тип транспорту";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(83, 224);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(45, 20);
            this.Description.TabIndex = 29;
            this.Description.Text = "Опис";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(148, 224);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(228, 96);
            this.DescriptionTextBox.TabIndex = 30;
            this.DescriptionTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.RemoveStopBtn);
            this.groupBox1.Controls.Add(this.SaveStopButton);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.TransportTypeCmbbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.StopCoordXNumupdown);
            this.groupBox1.Controls.Add(this.StopCoordYNumupdown);
            this.groupBox1.Controls.Add(this.StopNameTxtbox);
            this.groupBox1.Location = new System.Drawing.Point(360, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 487);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редагування зупинки";
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "copy.png");
            this.IconsList.Images.SetKeyName(1, "deleteIcon.png");
            this.IconsList.Images.SetKeyName(2, "map_pin_add_1-512.png");
            this.IconsList.Images.SetKeyName(3, "saveIcon.png");
            // 
            // FormStops
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(757, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StopsLabel);
            this.Controls.Add(this.ListOfStopsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStops";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зупинки";
            this.ListOfStopsGroupBox.ResumeLayout(false);
            this.ListOfStopsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopCoordYNumupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopCoordXNumupdown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveStopBtn;
        private System.Windows.Forms.Button AddNewStopBtn;
        private System.Windows.Forms.ComboBox FilterTransportTypeCmbbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ListBox StopsLstbox;
        private System.Windows.Forms.Button CreateCopyStopBtn;
        private System.Windows.Forms.GroupBox ListOfStopsGroupBox;
        private System.Windows.Forms.Label StopsLabel;
        private System.Windows.Forms.Button SaveStopButton;
        private System.Windows.Forms.TextBox StopNameTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown StopCoordYNumupdown;
        private System.Windows.Forms.NumericUpDown StopCoordXNumupdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList IconsList;
    }
}