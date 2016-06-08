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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoads));
            this.CreateCopyRoadBtn = new System.Windows.Forms.Button();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.RemoveRoadBtn = new System.Windows.Forms.Button();
            this.AddNewRoadBtn = new System.Windows.Forms.Button();
            this.FilterTransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.RoadsListGroup = new System.Windows.Forms.GroupBox();
            this.RoadsList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartStopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndStopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityCmbbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IsRoadTwoDirChckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondStopCmbbox = new System.Windows.Forms.ComboBox();
            this.FirstStopCmbbox = new System.Windows.Forms.ComboBox();
            this.RoadLengthNumupdown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveOrCreateRoadBtn = new System.Windows.Forms.Button();
            this.RoadEditorGroup = new System.Windows.Forms.GroupBox();
            this.RoadsLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.RoadsListGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoadsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadLengthNumupdown)).BeginInit();
            this.RoadEditorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCopyRoadBtn
            // 
            this.CreateCopyRoadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCopyRoadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateCopyRoadBtn.ImageKey = "copy.png";
            this.CreateCopyRoadBtn.ImageList = this.IconsList;
            this.CreateCopyRoadBtn.Location = new System.Drawing.Point(15, 410);
            this.CreateCopyRoadBtn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.CreateCopyRoadBtn.Name = "CreateCopyRoadBtn";
            this.CreateCopyRoadBtn.Size = new System.Drawing.Size(163, 39);
            this.CreateCopyRoadBtn.TabIndex = 19;
            this.CreateCopyRoadBtn.Text = "Створити копію";
            this.CreateCopyRoadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateCopyRoadBtn.UseVisualStyleBackColor = true;
            this.CreateCopyRoadBtn.Click += new System.EventHandler(this.CreateCopyRoadBtn_Click);
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "copy.png");
            this.IconsList.Images.SetKeyName(1, "deleteIcon.png");
            this.IconsList.Images.SetKeyName(2, "newRoad.png");
            this.IconsList.Images.SetKeyName(3, "saveIcon.png");
            // 
            // RemoveRoadBtn
            // 
            this.RemoveRoadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveRoadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveRoadBtn.ImageKey = "deleteIcon.png";
            this.RemoveRoadBtn.ImageList = this.IconsList;
            this.RemoveRoadBtn.Location = new System.Drawing.Point(10, 410);
            this.RemoveRoadBtn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.RemoveRoadBtn.Name = "RemoveRoadBtn";
            this.RemoveRoadBtn.Size = new System.Drawing.Size(171, 39);
            this.RemoveRoadBtn.TabIndex = 18;
            this.RemoveRoadBtn.Text = "Видалити дорогу";
            this.RemoveRoadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveRoadBtn.UseVisualStyleBackColor = true;
            this.RemoveRoadBtn.Click += new System.EventHandler(this.RemoveRoadBtn_Click);
            // 
            // AddNewRoadBtn
            // 
            this.AddNewRoadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewRoadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewRoadBtn.ImageKey = "newRoad.png";
            this.AddNewRoadBtn.ImageList = this.IconsList;
            this.AddNewRoadBtn.Location = new System.Drawing.Point(295, 410);
            this.AddNewRoadBtn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.AddNewRoadBtn.Name = "AddNewRoadBtn";
            this.AddNewRoadBtn.Size = new System.Drawing.Size(163, 39);
            this.AddNewRoadBtn.TabIndex = 16;
            this.AddNewRoadBtn.Text = "Нова дорога";
            this.AddNewRoadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewRoadBtn.UseVisualStyleBackColor = true;
            this.AddNewRoadBtn.Click += new System.EventHandler(this.AddNewRoadBtn_Click);
            // 
            // FilterTransportTypeCmbbox
            // 
            this.FilterTransportTypeCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterTransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterTransportTypeCmbbox.FormattingEnabled = true;
            this.FilterTransportTypeCmbbox.Location = new System.Drawing.Point(180, 25);
            this.FilterTransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.FilterTransportTypeCmbbox.Name = "FilterTransportTypeCmbbox";
            this.FilterTransportTypeCmbbox.Size = new System.Drawing.Size(210, 28);
            this.FilterTransportTypeCmbbox.TabIndex = 15;
            this.FilterTransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(11, 28);
            this.TransportTypeLbl.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.TransportTypeLbl.Name = "TransportTypeLbl";
            this.TransportTypeLbl.Size = new System.Drawing.Size(118, 20);
            this.TransportTypeLbl.TabIndex = 14;
            this.TransportTypeLbl.Text = "Тип транспорту";
            // 
            // RoadsListGroup
            // 
            this.RoadsListGroup.Controls.Add(this.RoadsList);
            this.RoadsListGroup.Controls.Add(this.CreateCopyRoadBtn);
            this.RoadsListGroup.Controls.Add(this.TransportTypeLbl);
            this.RoadsListGroup.Controls.Add(this.FilterTransportTypeCmbbox);
            this.RoadsListGroup.Controls.Add(this.AddNewRoadBtn);
            this.RoadsListGroup.Location = new System.Drawing.Point(12, 40);
            this.RoadsListGroup.Name = "RoadsListGroup";
            this.RoadsListGroup.Size = new System.Drawing.Size(470, 460);
            this.RoadsListGroup.TabIndex = 20;
            this.RoadsListGroup.TabStop = false;
            this.RoadsListGroup.Text = "Список доріг";
            // 
            // RoadsList
            // 
            this.RoadsList.AllowUserToAddRows = false;
            this.RoadsList.AllowUserToDeleteRows = false;
            this.RoadsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoadsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.StartStopColumn,
            this.EndStopColumn,
            this.TransportTypeColumn});
            this.RoadsList.Location = new System.Drawing.Point(15, 70);
            this.RoadsList.Name = "RoadsList";
            this.RoadsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoadsList.Size = new System.Drawing.Size(443, 329);
            this.RoadsList.TabIndex = 20;
            this.RoadsList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoadsList_RowEnter);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // StartStopColumn
            // 
            this.StartStopColumn.HeaderText = "Початок";
            this.StartStopColumn.Name = "StartStopColumn";
            this.StartStopColumn.ReadOnly = true;
            // 
            // EndStopColumn
            // 
            this.EndStopColumn.HeaderText = "Кінець";
            this.EndStopColumn.Name = "EndStopColumn";
            this.EndStopColumn.ReadOnly = true;
            // 
            // TransportTypeColumn
            // 
            this.TransportTypeColumn.HeaderText = "Тип";
            this.TransportTypeColumn.Name = "TransportTypeColumn";
            this.TransportTypeColumn.ReadOnly = true;
            // 
            // QualityCmbbox
            // 
            this.QualityCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QualityCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QualityCmbbox.FormattingEnabled = true;
            this.QualityCmbbox.Location = new System.Drawing.Point(198, 201);
            this.QualityCmbbox.Name = "QualityCmbbox";
            this.QualityCmbbox.Size = new System.Drawing.Size(186, 28);
            this.QualityCmbbox.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Якість";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Дорога двонаправлена";
            // 
            // IsRoadTwoDirChckbox
            // 
            this.IsRoadTwoDirChckbox.AutoSize = true;
            this.IsRoadTwoDirChckbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsRoadTwoDirChckbox.Location = new System.Drawing.Point(198, 173);
            this.IsRoadTwoDirChckbox.Name = "IsRoadTwoDirChckbox";
            this.IsRoadTwoDirChckbox.Size = new System.Drawing.Size(15, 14);
            this.IsRoadTwoDirChckbox.TabIndex = 32;
            this.IsRoadTwoDirChckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Кінцева зупинка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Початкова зупинка";
            // 
            // SecondStopCmbbox
            // 
            this.SecondStopCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondStopCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondStopCmbbox.FormattingEnabled = true;
            this.SecondStopCmbbox.Location = new System.Drawing.Point(198, 124);
            this.SecondStopCmbbox.Name = "SecondStopCmbbox";
            this.SecondStopCmbbox.Size = new System.Drawing.Size(186, 28);
            this.SecondStopCmbbox.TabIndex = 29;
            // 
            // FirstStopCmbbox
            // 
            this.FirstStopCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstStopCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstStopCmbbox.FormattingEnabled = true;
            this.FirstStopCmbbox.Location = new System.Drawing.Point(198, 92);
            this.FirstStopCmbbox.Name = "FirstStopCmbbox";
            this.FirstStopCmbbox.Size = new System.Drawing.Size(185, 28);
            this.FirstStopCmbbox.TabIndex = 28;
            // 
            // RoadLengthNumupdown
            // 
            this.RoadLengthNumupdown.DecimalPlaces = 2;
            this.RoadLengthNumupdown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoadLengthNumupdown.Location = new System.Drawing.Point(198, 59);
            this.RoadLengthNumupdown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.RoadLengthNumupdown.Name = "RoadLengthNumupdown";
            this.RoadLengthNumupdown.Size = new System.Drawing.Size(185, 27);
            this.RoadLengthNumupdown.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Довжина";
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(198, 25);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(185, 28);
            this.TransportTypeCmbbox.TabIndex = 25;
            this.TransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Тип транспорту";
            // 
            // SaveOrCreateRoadBtn
            // 
            this.SaveOrCreateRoadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveOrCreateRoadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveOrCreateRoadBtn.ImageKey = "saveIcon.png";
            this.SaveOrCreateRoadBtn.ImageList = this.IconsList;
            this.SaveOrCreateRoadBtn.Location = new System.Drawing.Point(216, 410);
            this.SaveOrCreateRoadBtn.Name = "SaveOrCreateRoadBtn";
            this.SaveOrCreateRoadBtn.Size = new System.Drawing.Size(171, 39);
            this.SaveOrCreateRoadBtn.TabIndex = 23;
            this.SaveOrCreateRoadBtn.Text = "Зберегти";
            this.SaveOrCreateRoadBtn.UseVisualStyleBackColor = true;
            this.SaveOrCreateRoadBtn.Click += new System.EventHandler(this.SaveOrCreateRoadBtn_Click);
            // 
            // RoadEditorGroup
            // 
            this.RoadEditorGroup.Controls.Add(this.DescriptionLabel);
            this.RoadEditorGroup.Controls.Add(this.DescriptionTextBox);
            this.RoadEditorGroup.Controls.Add(this.RemoveRoadBtn);
            this.RoadEditorGroup.Controls.Add(this.QualityCmbbox);
            this.RoadEditorGroup.Controls.Add(this.SaveOrCreateRoadBtn);
            this.RoadEditorGroup.Controls.Add(this.IsRoadTwoDirChckbox);
            this.RoadEditorGroup.Controls.Add(this.label6);
            this.RoadEditorGroup.Controls.Add(this.SecondStopCmbbox);
            this.RoadEditorGroup.Controls.Add(this.label4);
            this.RoadEditorGroup.Controls.Add(this.FirstStopCmbbox);
            this.RoadEditorGroup.Controls.Add(this.RoadLengthNumupdown);
            this.RoadEditorGroup.Controls.Add(this.label5);
            this.RoadEditorGroup.Controls.Add(this.TransportTypeCmbbox);
            this.RoadEditorGroup.Controls.Add(this.label1);
            this.RoadEditorGroup.Controls.Add(this.label2);
            this.RoadEditorGroup.Controls.Add(this.label3);
            this.RoadEditorGroup.Location = new System.Drawing.Point(488, 40);
            this.RoadEditorGroup.Name = "RoadEditorGroup";
            this.RoadEditorGroup.Size = new System.Drawing.Size(393, 460);
            this.RoadEditorGroup.TabIndex = 36;
            this.RoadEditorGroup.TabStop = false;
            this.RoadEditorGroup.Text = "Редагування дороги";
            // 
            // RoadsLabel
            // 
            this.RoadsLabel.AutoSize = true;
            this.RoadsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoadsLabel.Location = new System.Drawing.Point(398, 7);
            this.RoadsLabel.Name = "RoadsLabel";
            this.RoadsLabel.Size = new System.Drawing.Size(84, 30);
            this.RoadsLabel.TabIndex = 37;
            this.RoadsLabel.Text = "Дороги";
            this.RoadsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(198, 235);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(185, 139);
            this.DescriptionTextBox.TabIndex = 36;
            this.DescriptionTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 238);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(75, 20);
            this.DescriptionLabel.TabIndex = 37;
            this.DescriptionLabel.Text = "Примітки";
            // 
            // FormRoads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 511);
            this.Controls.Add(this.RoadsLabel);
            this.Controls.Add(this.RoadEditorGroup);
            this.Controls.Add(this.RoadsListGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRoads";
            this.Text = "Дороги";
            this.RoadsListGroup.ResumeLayout(false);
            this.RoadsListGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoadsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadLengthNumupdown)).EndInit();
            this.RoadEditorGroup.ResumeLayout(false);
            this.RoadEditorGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCopyRoadBtn;
        private System.Windows.Forms.Button RemoveRoadBtn;
        private System.Windows.Forms.Button AddNewRoadBtn;
        private System.Windows.Forms.ComboBox FilterTransportTypeCmbbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.GroupBox RoadsListGroup;
        private System.Windows.Forms.ComboBox QualityCmbbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox IsRoadTwoDirChckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SecondStopCmbbox;
        private System.Windows.Forms.ComboBox FirstStopCmbbox;
        private System.Windows.Forms.NumericUpDown RoadLengthNumupdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveOrCreateRoadBtn;
        private System.Windows.Forms.GroupBox RoadEditorGroup;
        private System.Windows.Forms.Label RoadsLabel;
        private System.Windows.Forms.DataGridView RoadsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartStopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndStopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportTypeColumn;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
    }
}