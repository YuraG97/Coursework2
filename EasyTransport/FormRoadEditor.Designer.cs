namespace EasyTransport
{
    partial class FormRoadEditor
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
            this.SaveOrCreateRoadBtn = new System.Windows.Forms.Button();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoadLengthNumupdown = new System.Windows.Forms.NumericUpDown();
            this.FirstStopCmbbox = new System.Windows.Forms.ComboBox();
            this.SecondStopCmbbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IsRoadTwoDirChckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.QualityCmbbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoadLengthNumupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveOrCreateRoadBtn
            // 
            this.SaveOrCreateRoadBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveOrCreateRoadBtn.Location = new System.Drawing.Point(431, 194);
            this.SaveOrCreateRoadBtn.Name = "SaveOrCreateRoadBtn";
            this.SaveOrCreateRoadBtn.Size = new System.Drawing.Size(118, 54);
            this.SaveOrCreateRoadBtn.TabIndex = 0;
            this.SaveOrCreateRoadBtn.Text = "Створити";
            this.SaveOrCreateRoadBtn.UseVisualStyleBackColor = true;
            this.SaveOrCreateRoadBtn.Click += new System.EventHandler(this.SaveOrCreateRoadBtn_Click);
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(211, 6);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(185, 28);
            this.TransportTypeCmbbox.TabIndex = 12;
            this.TransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Тип транспорту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Довжина";
            // 
            // RoadLengthNumupdown
            // 
            this.RoadLengthNumupdown.DecimalPlaces = 2;
            this.RoadLengthNumupdown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoadLengthNumupdown.Location = new System.Drawing.Point(211, 38);
            this.RoadLengthNumupdown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.RoadLengthNumupdown.Name = "RoadLengthNumupdown";
            this.RoadLengthNumupdown.Size = new System.Drawing.Size(185, 27);
            this.RoadLengthNumupdown.TabIndex = 14;
            // 
            // FirstStopCmbbox
            // 
            this.FirstStopCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstStopCmbbox.FormattingEnabled = true;
            this.FirstStopCmbbox.Location = new System.Drawing.Point(211, 71);
            this.FirstStopCmbbox.Name = "FirstStopCmbbox";
            this.FirstStopCmbbox.Size = new System.Drawing.Size(185, 28);
            this.FirstStopCmbbox.TabIndex = 15;
            // 
            // SecondStopCmbbox
            // 
            this.SecondStopCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondStopCmbbox.FormattingEnabled = true;
            this.SecondStopCmbbox.Location = new System.Drawing.Point(210, 105);
            this.SecondStopCmbbox.Name = "SecondStopCmbbox";
            this.SecondStopCmbbox.Size = new System.Drawing.Size(186, 28);
            this.SecondStopCmbbox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Початкова зупинка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Кінцева зупинка";
            // 
            // IsRoadTwoDirChckbox
            // 
            this.IsRoadTwoDirChckbox.AutoSize = true;
            this.IsRoadTwoDirChckbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsRoadTwoDirChckbox.Location = new System.Drawing.Point(211, 150);
            this.IsRoadTwoDirChckbox.Name = "IsRoadTwoDirChckbox";
            this.IsRoadTwoDirChckbox.Size = new System.Drawing.Size(15, 14);
            this.IsRoadTwoDirChckbox.TabIndex = 19;
            this.IsRoadTwoDirChckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Дорога двонаправлена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Якість";
            // 
            // QualityCmbbox
            // 
            this.QualityCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QualityCmbbox.FormattingEnabled = true;
            this.QualityCmbbox.Location = new System.Drawing.Point(210, 179);
            this.QualityCmbbox.Name = "QualityCmbbox";
            this.QualityCmbbox.Size = new System.Drawing.Size(186, 28);
            this.QualityCmbbox.TabIndex = 22;
            // 
            // FormRoadEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 258);
            this.Controls.Add(this.QualityCmbbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IsRoadTwoDirChckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondStopCmbbox);
            this.Controls.Add(this.FirstStopCmbbox);
            this.Controls.Add(this.RoadLengthNumupdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveOrCreateRoadBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormRoadEditor";
            this.Text = "Редактор дороги";
            ((System.ComponentModel.ISupportInitialize)(this.RoadLengthNumupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveOrCreateRoadBtn;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RoadLengthNumupdown;
        private System.Windows.Forms.ComboBox FirstStopCmbbox;
        private System.Windows.Forms.ComboBox SecondStopCmbbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox IsRoadTwoDirChckbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox QualityCmbbox;
    }
}