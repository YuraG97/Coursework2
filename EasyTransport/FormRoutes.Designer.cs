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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.AddNewRoute = new System.Windows.Forms.Button();
            this.ChangeRoute = new System.Windows.Forms.Button();
            this.RemoveRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(15, 50);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(612, 340);
            this.listBox1.TabIndex = 0;
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
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(277, 29);
            this.TransportTypeCmbbox.TabIndex = 2;
            // 
            // AddNewRoute
            // 
            this.AddNewRoute.Location = new System.Drawing.Point(15, 400);
            this.AddNewRoute.Name = "AddNewRoute";
            this.AddNewRoute.Size = new System.Drawing.Size(200, 66);
            this.AddNewRoute.TabIndex = 3;
            this.AddNewRoute.Text = "Новий маршрут";
            this.AddNewRoute.UseVisualStyleBackColor = true;
            this.AddNewRoute.Click += new System.EventHandler(this.AddNewRoute_Click);
            // 
            // ChangeRoute
            // 
            this.ChangeRoute.Location = new System.Drawing.Point(221, 400);
            this.ChangeRoute.Name = "ChangeRoute";
            this.ChangeRoute.Size = new System.Drawing.Size(200, 66);
            this.ChangeRoute.TabIndex = 4;
            this.ChangeRoute.Text = "Редагувати маршрут";
            this.ChangeRoute.UseVisualStyleBackColor = true;
            this.ChangeRoute.Click += new System.EventHandler(this.ChangeRoute_Click);
            // 
            // RemoveRoute
            // 
            this.RemoveRoute.Location = new System.Drawing.Point(427, 400);
            this.RemoveRoute.Name = "RemoveRoute";
            this.RemoveRoute.Size = new System.Drawing.Size(200, 66);
            this.RemoveRoute.TabIndex = 5;
            this.RemoveRoute.Text = "Видалити маршрут";
            this.RemoveRoute.UseVisualStyleBackColor = true;
            this.RemoveRoute.Click += new System.EventHandler(this.RemoveRoute_Click);
            // 
            // FormRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 478);
            this.Controls.Add(this.RemoveRoute);
            this.Controls.Add(this.ChangeRoute);
            this.Controls.Add(this.AddNewRoute);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.TransportTypeLbl);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormRoutes";
            this.Text = "Маршрути";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Button AddNewRoute;
        private System.Windows.Forms.Button ChangeRoute;
        private System.Windows.Forms.Button RemoveRoute;
    }
}