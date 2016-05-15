namespace EasyTransport
{
    partial class FormRouteEditor
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
            this.RouteNameLbl = new System.Windows.Forms.Label();
            this.RouteNameTxtbox = new System.Windows.Forms.TextBox();
            this.TypeTransportCmbbox = new System.Windows.Forms.ComboBox();
            this.TypeTransportLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RouteNameLbl
            // 
            this.RouteNameLbl.AutoSize = true;
            this.RouteNameLbl.Location = new System.Drawing.Point(13, 13);
            this.RouteNameLbl.Name = "RouteNameLbl";
            this.RouteNameLbl.Size = new System.Drawing.Size(39, 13);
            this.RouteNameLbl.TabIndex = 0;
            this.RouteNameLbl.Text = "Назва";
            // 
            // RouteNameTxtbox
            // 
            this.RouteNameTxtbox.Location = new System.Drawing.Point(105, 10);
            this.RouteNameTxtbox.Name = "RouteNameTxtbox";
            this.RouteNameTxtbox.Size = new System.Drawing.Size(141, 20);
            this.RouteNameTxtbox.TabIndex = 1;
            // 
            // TypeTransportCmbbox
            // 
            this.TypeTransportCmbbox.FormattingEnabled = true;
            this.TypeTransportCmbbox.Location = new System.Drawing.Point(105, 36);
            this.TypeTransportCmbbox.Name = "TypeTransportCmbbox";
            this.TypeTransportCmbbox.Size = new System.Drawing.Size(141, 21);
            this.TypeTransportCmbbox.TabIndex = 2;
            // 
            // TypeTransportLbl
            // 
            this.TypeTransportLbl.AutoSize = true;
            this.TypeTransportLbl.Location = new System.Drawing.Point(13, 39);
            this.TypeTransportLbl.Name = "TypeTransportLbl";
            this.TypeTransportLbl.Size = new System.Drawing.Size(86, 13);
            this.TypeTransportLbl.TabIndex = 3;
            this.TypeTransportLbl.Text = "Тип транспорту";
            // 
            // FormRouteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 440);
            this.Controls.Add(this.TypeTransportLbl);
            this.Controls.Add(this.TypeTransportCmbbox);
            this.Controls.Add(this.RouteNameTxtbox);
            this.Controls.Add(this.RouteNameLbl);
            this.Name = "FormRouteEditor";
            this.Text = "Редактор маршрутів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RouteNameLbl;
        private System.Windows.Forms.TextBox RouteNameTxtbox;
        private System.Windows.Forms.ComboBox TypeTransportCmbbox;
        private System.Windows.Forms.Label TypeTransportLbl;
    }
}