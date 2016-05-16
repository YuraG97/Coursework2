namespace EasyTransport
{
    partial class FormRoutes
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
            this.RoutesLstbox = new System.Windows.Forms.ListBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.AddNewRouteBtn = new System.Windows.Forms.Button();
            this.ChangeRouteBtn = new System.Windows.Forms.Button();
            this.RemoveRouteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoutesLstbox
            // 
            this.RoutesLstbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoutesLstbox.FormattingEnabled = true;
            this.RoutesLstbox.ItemHeight = 21;
            this.RoutesLstbox.Location = new System.Drawing.Point(15, 50);
            this.RoutesLstbox.Margin = new System.Windows.Forms.Padding(6);
            this.RoutesLstbox.Name = "RoutesLstbox";
            this.RoutesLstbox.Size = new System.Drawing.Size(612, 340);
            this.RoutesLstbox.TabIndex = 0;
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(15, 9);
            this.TransportTypeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TransportTypeLbl.Name = "TransportTypeLbl";
            this.TransportTypeLbl.Size = new System.Drawing.Size(122, 21);
            this.TransportTypeLbl.TabIndex = 1;
            this.TransportTypeLbl.Text = "Тип транспорту";
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(350, 9);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(6);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(277, 29);
            this.TransportTypeCmbbox.TabIndex = 2;
            this.TransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // AddNewRouteBtn
            // 
            this.AddNewRouteBtn.Location = new System.Drawing.Point(15, 400);
            this.AddNewRouteBtn.Name = "AddNewRouteBtn";
            this.AddNewRouteBtn.Size = new System.Drawing.Size(200, 66);
            this.AddNewRouteBtn.TabIndex = 3;
            this.AddNewRouteBtn.Text = "Новий маршрут";
            this.AddNewRouteBtn.UseVisualStyleBackColor = true;
            this.AddNewRouteBtn.Click += new System.EventHandler(this.AddNewRoute_Click);
            // 
            // ChangeRouteBtn
            // 
            this.ChangeRouteBtn.Location = new System.Drawing.Point(221, 400);
            this.ChangeRouteBtn.Name = "ChangeRouteBtn";
            this.ChangeRouteBtn.Size = new System.Drawing.Size(200, 66);
            this.ChangeRouteBtn.TabIndex = 4;
            this.ChangeRouteBtn.Text = "Редагувати маршрут";
            this.ChangeRouteBtn.UseVisualStyleBackColor = true;
            this.ChangeRouteBtn.Click += new System.EventHandler(this.ChangeRoute_Click);
            // 
            // RemoveRouteBtn
            // 
            this.RemoveRouteBtn.Location = new System.Drawing.Point(427, 400);
            this.RemoveRouteBtn.Name = "RemoveRouteBtn";
            this.RemoveRouteBtn.Size = new System.Drawing.Size(200, 66);
            this.RemoveRouteBtn.TabIndex = 5;
            this.RemoveRouteBtn.Text = "Видалити маршрут";
            this.RemoveRouteBtn.UseVisualStyleBackColor = true;
            this.RemoveRouteBtn.Click += new System.EventHandler(this.RemoveRoute_Click);
            // 
            // FormRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 478);
            this.Controls.Add(this.RemoveRouteBtn);
            this.Controls.Add(this.ChangeRouteBtn);
            this.Controls.Add(this.AddNewRouteBtn);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.TransportTypeLbl);
            this.Controls.Add(this.RoutesLstbox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormRoutes";
            this.Text = "Маршрути";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RoutesLstbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Button AddNewRouteBtn;
        private System.Windows.Forms.Button ChangeRouteBtn;
        private System.Windows.Forms.Button RemoveRouteBtn;
    }
}