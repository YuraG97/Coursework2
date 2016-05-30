namespace EasyTransport
{
    partial class FormTrips
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
            this.CreateCopyTripBtn = new System.Windows.Forms.Button();
            this.RemoveTripBtn = new System.Windows.Forms.Button();
            this.ChangeTripBtn = new System.Windows.Forms.Button();
            this.AddNewTripBtn = new System.Windows.Forms.Button();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.TripsLstbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CreateCopyTripBtn
            // 
            this.CreateCopyTripBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCopyTripBtn.Location = new System.Drawing.Point(341, 400);
            this.CreateCopyTripBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateCopyTripBtn.Name = "CreateCopyTripBtn";
            this.CreateCopyTripBtn.Size = new System.Drawing.Size(154, 61);
            this.CreateCopyTripBtn.TabIndex = 33;
            this.CreateCopyTripBtn.Text = "Створити копію";
            this.CreateCopyTripBtn.UseVisualStyleBackColor = true;
            this.CreateCopyTripBtn.Click += new System.EventHandler(this.CreateCopyTripBtn_Click);
            // 
            // RemoveTripBtn
            // 
            this.RemoveTripBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveTripBtn.Location = new System.Drawing.Point(503, 400);
            this.RemoveTripBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveTripBtn.Name = "RemoveTripBtn";
            this.RemoveTripBtn.Size = new System.Drawing.Size(154, 61);
            this.RemoveTripBtn.TabIndex = 32;
            this.RemoveTripBtn.Text = "Видалити рейс";
            this.RemoveTripBtn.UseVisualStyleBackColor = true;
            this.RemoveTripBtn.Click += new System.EventHandler(this.RemoveTripBtn_Click);
            // 
            // ChangeTripBtn
            // 
            this.ChangeTripBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeTripBtn.Location = new System.Drawing.Point(179, 400);
            this.ChangeTripBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeTripBtn.Name = "ChangeTripBtn";
            this.ChangeTripBtn.Size = new System.Drawing.Size(154, 61);
            this.ChangeTripBtn.TabIndex = 31;
            this.ChangeTripBtn.Text = "Редагувати рейс";
            this.ChangeTripBtn.UseVisualStyleBackColor = true;
            this.ChangeTripBtn.Click += new System.EventHandler(this.ChangeTripBtn_Click);
            // 
            // AddNewTripBtn
            // 
            this.AddNewTripBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewTripBtn.Location = new System.Drawing.Point(17, 400);
            this.AddNewTripBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewTripBtn.Name = "AddNewTripBtn";
            this.AddNewTripBtn.Size = new System.Drawing.Size(154, 61);
            this.AddNewTripBtn.TabIndex = 30;
            this.AddNewTripBtn.Text = "Новий рейс";
            this.AddNewTripBtn.UseVisualStyleBackColor = true;
            this.AddNewTripBtn.Click += new System.EventHandler(this.AddNewTripBtn_Click);
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(289, 10);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(368, 28);
            this.TransportTypeCmbbox.TabIndex = 29;
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(13, 13);
            this.TransportTypeLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TransportTypeLbl.Name = "TransportTypeLbl";
            this.TransportTypeLbl.Size = new System.Drawing.Size(118, 20);
            this.TransportTypeLbl.TabIndex = 28;
            this.TransportTypeLbl.Text = "Тип транспорту";
            // 
            // TripsLstbox
            // 
            this.TripsLstbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripsLstbox.FormattingEnabled = true;
            this.TripsLstbox.ItemHeight = 20;
            this.TripsLstbox.Location = new System.Drawing.Point(17, 42);
            this.TripsLstbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TripsLstbox.Name = "TripsLstbox";
            this.TripsLstbox.Size = new System.Drawing.Size(640, 344);
            this.TripsLstbox.TabIndex = 27;
            // 
            // FormTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 480);
            this.Controls.Add(this.CreateCopyTripBtn);
            this.Controls.Add(this.RemoveTripBtn);
            this.Controls.Add(this.ChangeTripBtn);
            this.Controls.Add(this.AddNewTripBtn);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.TransportTypeLbl);
            this.Controls.Add(this.TripsLstbox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTrips";
            this.Text = "Рейси";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCopyTripBtn;
        private System.Windows.Forms.Button RemoveTripBtn;
        private System.Windows.Forms.Button ChangeTripBtn;
        private System.Windows.Forms.Button AddNewTripBtn;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ListBox TripsLstbox;
    }
}