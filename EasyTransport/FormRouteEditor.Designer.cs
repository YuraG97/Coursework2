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
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TypeTransportLbl = new System.Windows.Forms.Label();
            this.SaveOrCreateRoute = new System.Windows.Forms.Button();
            this.NextStopCmbbox = new System.Windows.Forms.ComboBox();
            this.NextStopInvDirectCmbbox = new System.Windows.Forms.ComboBox();
            this.DirectStopsLstbox = new System.Windows.Forms.ListBox();
            this.InverseDirectStopsLstbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddStopToRouteBtn = new System.Windows.Forms.Button();
            this.RemoveStopRouteBtn = new System.Windows.Forms.Button();
            this.RemoveStopRouteInvDirBtn = new System.Windows.Forms.Button();
            this.AddStopToRouteInvDirBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TicketCostNumupdown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TicketCostNumupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // RouteNameLbl
            // 
            this.RouteNameLbl.AutoSize = true;
            this.RouteNameLbl.Location = new System.Drawing.Point(19, 55);
            this.RouteNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RouteNameLbl.Name = "RouteNameLbl";
            this.RouteNameLbl.Size = new System.Drawing.Size(51, 20);
            this.RouteNameLbl.TabIndex = 0;
            this.RouteNameLbl.Text = "Назва";
            // 
            // RouteNameTxtbox
            // 
            this.RouteNameTxtbox.Location = new System.Drawing.Point(141, 51);
            this.RouteNameTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RouteNameTxtbox.Name = "RouteNameTxtbox";
            this.RouteNameTxtbox.Size = new System.Drawing.Size(187, 27);
            this.RouteNameTxtbox.TabIndex = 1;
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(141, 9);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(187, 28);
            this.TransportTypeCmbbox.TabIndex = 2;
            this.TransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // TypeTransportLbl
            // 
            this.TypeTransportLbl.AutoSize = true;
            this.TypeTransportLbl.Location = new System.Drawing.Point(19, 14);
            this.TypeTransportLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeTransportLbl.Name = "TypeTransportLbl";
            this.TypeTransportLbl.Size = new System.Drawing.Size(118, 20);
            this.TypeTransportLbl.TabIndex = 3;
            this.TypeTransportLbl.Text = "Тип транспорту";
            // 
            // SaveOrCreateRoute
            // 
            this.SaveOrCreateRoute.Location = new System.Drawing.Point(525, 529);
            this.SaveOrCreateRoute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveOrCreateRoute.Name = "SaveOrCreateRoute";
            this.SaveOrCreateRoute.Size = new System.Drawing.Size(156, 51);
            this.SaveOrCreateRoute.TabIndex = 4;
            this.SaveOrCreateRoute.Text = "Створити";
            this.SaveOrCreateRoute.UseVisualStyleBackColor = true;
            this.SaveOrCreateRoute.Click += new System.EventHandler(this.SaveOrCreateRoute_Click);
            // 
            // NextStopCmbbox
            // 
            this.NextStopCmbbox.FormattingEnabled = true;
            this.NextStopCmbbox.Location = new System.Drawing.Point(19, 129);
            this.NextStopCmbbox.Name = "NextStopCmbbox";
            this.NextStopCmbbox.Size = new System.Drawing.Size(235, 28);
            this.NextStopCmbbox.TabIndex = 5;
            // 
            // NextStopInvDirectCmbbox
            // 
            this.NextStopInvDirectCmbbox.FormattingEnabled = true;
            this.NextStopInvDirectCmbbox.Location = new System.Drawing.Point(260, 129);
            this.NextStopInvDirectCmbbox.Name = "NextStopInvDirectCmbbox";
            this.NextStopInvDirectCmbbox.Size = new System.Drawing.Size(235, 28);
            this.NextStopInvDirectCmbbox.TabIndex = 6;
            // 
            // DirectStopsLstbox
            // 
            this.DirectStopsLstbox.FormattingEnabled = true;
            this.DirectStopsLstbox.ItemHeight = 20;
            this.DirectStopsLstbox.Location = new System.Drawing.Point(19, 196);
            this.DirectStopsLstbox.Name = "DirectStopsLstbox";
            this.DirectStopsLstbox.Size = new System.Drawing.Size(235, 384);
            this.DirectStopsLstbox.TabIndex = 7;
            // 
            // InverseDirectStopsLstbox
            // 
            this.InverseDirectStopsLstbox.FormattingEnabled = true;
            this.InverseDirectStopsLstbox.ItemHeight = 20;
            this.InverseDirectStopsLstbox.Location = new System.Drawing.Point(260, 196);
            this.InverseDirectStopsLstbox.Name = "InverseDirectStopsLstbox";
            this.InverseDirectStopsLstbox.Size = new System.Drawing.Size(235, 384);
            this.InverseDirectStopsLstbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Прямий хід";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Зворотній хід";
            // 
            // AddStopToRouteBtn
            // 
            this.AddStopToRouteBtn.Location = new System.Drawing.Point(19, 163);
            this.AddStopToRouteBtn.Name = "AddStopToRouteBtn";
            this.AddStopToRouteBtn.Size = new System.Drawing.Size(118, 27);
            this.AddStopToRouteBtn.TabIndex = 11;
            this.AddStopToRouteBtn.Text = "Додати";
            this.AddStopToRouteBtn.UseVisualStyleBackColor = true;
            this.AddStopToRouteBtn.Click += new System.EventHandler(this.AddStopToRouteBtn_Click);
            // 
            // RemoveStopRouteBtn
            // 
            this.RemoveStopRouteBtn.Location = new System.Drawing.Point(141, 163);
            this.RemoveStopRouteBtn.Name = "RemoveStopRouteBtn";
            this.RemoveStopRouteBtn.Size = new System.Drawing.Size(113, 27);
            this.RemoveStopRouteBtn.TabIndex = 12;
            this.RemoveStopRouteBtn.Text = "Вилучити";
            this.RemoveStopRouteBtn.UseVisualStyleBackColor = true;
            this.RemoveStopRouteBtn.Click += new System.EventHandler(this.RemoveStopRouteBtn_Click);
            // 
            // RemoveStopRouteInvDirBtn
            // 
            this.RemoveStopRouteInvDirBtn.Location = new System.Drawing.Point(382, 163);
            this.RemoveStopRouteInvDirBtn.Name = "RemoveStopRouteInvDirBtn";
            this.RemoveStopRouteInvDirBtn.Size = new System.Drawing.Size(113, 27);
            this.RemoveStopRouteInvDirBtn.TabIndex = 14;
            this.RemoveStopRouteInvDirBtn.Text = "Вилучити";
            this.RemoveStopRouteInvDirBtn.UseVisualStyleBackColor = true;
            this.RemoveStopRouteInvDirBtn.Click += new System.EventHandler(this.RemoveStopRouteInvDirBtn_Click);
            // 
            // AddStopToRouteInvDirBtn
            // 
            this.AddStopToRouteInvDirBtn.Location = new System.Drawing.Point(260, 163);
            this.AddStopToRouteInvDirBtn.Name = "AddStopToRouteInvDirBtn";
            this.AddStopToRouteInvDirBtn.Size = new System.Drawing.Size(118, 27);
            this.AddStopToRouteInvDirBtn.TabIndex = 13;
            this.AddStopToRouteInvDirBtn.Text = "Додати";
            this.AddStopToRouteInvDirBtn.UseVisualStyleBackColor = true;
            this.AddStopToRouteInvDirBtn.Click += new System.EventHandler(this.AddStopToRouteInvDirBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Вартість квитка";
            // 
            // TicketCostNumupdown
            // 
            this.TicketCostNumupdown.DecimalPlaces = 2;
            this.TicketCostNumupdown.Location = new System.Drawing.Point(515, 10);
            this.TicketCostNumupdown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TicketCostNumupdown.Name = "TicketCostNumupdown";
            this.TicketCostNumupdown.Size = new System.Drawing.Size(166, 27);
            this.TicketCostNumupdown.TabIndex = 16;
            // 
            // FormRouteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 597);
            this.Controls.Add(this.TicketCostNumupdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RemoveStopRouteInvDirBtn);
            this.Controls.Add(this.AddStopToRouteInvDirBtn);
            this.Controls.Add(this.RemoveStopRouteBtn);
            this.Controls.Add(this.AddStopToRouteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InverseDirectStopsLstbox);
            this.Controls.Add(this.DirectStopsLstbox);
            this.Controls.Add(this.NextStopInvDirectCmbbox);
            this.Controls.Add(this.NextStopCmbbox);
            this.Controls.Add(this.SaveOrCreateRoute);
            this.Controls.Add(this.TypeTransportLbl);
            this.Controls.Add(this.TransportTypeCmbbox);
            this.Controls.Add(this.RouteNameTxtbox);
            this.Controls.Add(this.RouteNameLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRouteEditor";
            this.Text = "Редактор маршрутів";
            ((System.ComponentModel.ISupportInitialize)(this.TicketCostNumupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RouteNameLbl;
        private System.Windows.Forms.TextBox RouteNameTxtbox;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.Label TypeTransportLbl;
        private System.Windows.Forms.Button SaveOrCreateRoute;
        private System.Windows.Forms.ComboBox NextStopCmbbox;
        private System.Windows.Forms.ComboBox NextStopInvDirectCmbbox;
        private System.Windows.Forms.ListBox DirectStopsLstbox;
        private System.Windows.Forms.ListBox InverseDirectStopsLstbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddStopToRouteBtn;
        private System.Windows.Forms.Button RemoveStopRouteBtn;
        private System.Windows.Forms.Button RemoveStopRouteInvDirBtn;
        private System.Windows.Forms.Button AddStopToRouteInvDirBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TicketCostNumupdown;
    }
}