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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoutes));
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.FilterTransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.AddNewRouteBtn = new System.Windows.Forms.Button();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.RemoveRouteBtn = new System.Windows.Forms.Button();
            this.RoutesListGroup = new System.Windows.Forms.GroupBox();
            this.RoutesList = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvDirColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteEditGroup = new System.Windows.Forms.GroupBox();
            this.TicketCostNumupdown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveStopRouteInvDirBtn = new System.Windows.Forms.Button();
            this.AddStopToRouteInvDirBtn = new System.Windows.Forms.Button();
            this.RemoveStopRouteBtn = new System.Windows.Forms.Button();
            this.AddStopToRouteBtn = new System.Windows.Forms.Button();
            this.InvDirLabel = new System.Windows.Forms.Label();
            this.DirLabel = new System.Windows.Forms.Label();
            this.InverseDirectStopsLstbox = new System.Windows.Forms.ListBox();
            this.DirectStopsLstbox = new System.Windows.Forms.ListBox();
            this.NextStopInvDirectCmbbox = new System.Windows.Forms.ComboBox();
            this.NextStopCmbbox = new System.Windows.Forms.ComboBox();
            this.SaveOrCreateRoute = new System.Windows.Forms.Button();
            this.TypeTransportLbl = new System.Windows.Forms.Label();
            this.TransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.RouteNameTxtbox = new System.Windows.Forms.TextBox();
            this.RouteNameLbl = new System.Windows.Forms.Label();
            this.RoutesLabel = new System.Windows.Forms.Label();
            this.RoutesListGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoutesList)).BeginInit();
            this.RouteEditGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketCostNumupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(6, 22);
            this.TransportTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransportTypeLbl.Name = "TransportTypeLbl";
            this.TransportTypeLbl.Size = new System.Drawing.Size(122, 21);
            this.TransportTypeLbl.TabIndex = 1;
            this.TransportTypeLbl.Text = "Тип транспорту";
            // 
            // FilterTransportTypeCmbbox
            // 
            this.FilterTransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterTransportTypeCmbbox.FormattingEnabled = true;
            this.FilterTransportTypeCmbbox.Location = new System.Drawing.Point(212, 19);
            this.FilterTransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterTransportTypeCmbbox.Name = "FilterTransportTypeCmbbox";
            this.FilterTransportTypeCmbbox.Size = new System.Drawing.Size(229, 29);
            this.FilterTransportTypeCmbbox.TabIndex = 2;
            this.FilterTransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeCmbbox_SelectedIndexChanged);
            // 
            // AddNewRouteBtn
            // 
            this.AddNewRouteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewRouteBtn.ImageKey = "Map__Directions-128.png";
            this.AddNewRouteBtn.ImageList = this.IconsList;
            this.AddNewRouteBtn.Location = new System.Drawing.Point(276, 640);
            this.AddNewRouteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddNewRouteBtn.Name = "AddNewRouteBtn";
            this.AddNewRouteBtn.Size = new System.Drawing.Size(165, 43);
            this.AddNewRouteBtn.TabIndex = 3;
            this.AddNewRouteBtn.Text = "Новий маршрут";
            this.AddNewRouteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewRouteBtn.UseVisualStyleBackColor = true;
            this.AddNewRouteBtn.Click += new System.EventHandler(this.AddNewRoute_Click);
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "map_pin_add_1-512.png");
            this.IconsList.Images.SetKeyName(1, "saveIcon.png");
            this.IconsList.Images.SetKeyName(2, "Map__Directions-128.png");
            this.IconsList.Images.SetKeyName(3, "deleteIcon.png");
            this.IconsList.Images.SetKeyName(4, "addStopItem.png");
            this.IconsList.Images.SetKeyName(5, "delete-icon-47792.png");
            // 
            // RemoveRouteBtn
            // 
            this.RemoveRouteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveRouteBtn.ImageKey = "deleteIcon.png";
            this.RemoveRouteBtn.ImageList = this.IconsList;
            this.RemoveRouteBtn.Location = new System.Drawing.Point(25, 640);
            this.RemoveRouteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveRouteBtn.Name = "RemoveRouteBtn";
            this.RemoveRouteBtn.Size = new System.Drawing.Size(187, 43);
            this.RemoveRouteBtn.TabIndex = 5;
            this.RemoveRouteBtn.Text = "Видалити маршрут";
            this.RemoveRouteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveRouteBtn.UseVisualStyleBackColor = true;
            this.RemoveRouteBtn.Click += new System.EventHandler(this.RemoveRoute_Click);
            // 
            // RoutesListGroup
            // 
            this.RoutesListGroup.Controls.Add(this.RoutesList);
            this.RoutesListGroup.Controls.Add(this.AddNewRouteBtn);
            this.RoutesListGroup.Controls.Add(this.TransportTypeLbl);
            this.RoutesListGroup.Controls.Add(this.FilterTransportTypeCmbbox);
            this.RoutesListGroup.Location = new System.Drawing.Point(11, 40);
            this.RoutesListGroup.Margin = new System.Windows.Forms.Padding(2);
            this.RoutesListGroup.Name = "RoutesListGroup";
            this.RoutesListGroup.Padding = new System.Windows.Forms.Padding(2);
            this.RoutesListGroup.Size = new System.Drawing.Size(447, 691);
            this.RoutesListGroup.TabIndex = 6;
            this.RoutesListGroup.TabStop = false;
            this.RoutesListGroup.Text = "Список маршрутів";
            // 
            // RoutesList
            // 
            this.RoutesList.AllowUserToAddRows = false;
            this.RoutesList.AllowUserToDeleteRows = false;
            this.RoutesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoutesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.DirColumn,
            this.InvDirColumn});
            this.RoutesList.Location = new System.Drawing.Point(10, 56);
            this.RoutesList.Name = "RoutesList";
            this.RoutesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoutesList.Size = new System.Drawing.Size(431, 579);
            this.RoutesList.TabIndex = 4;
            this.RoutesList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoutesList_RowEnter);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Назва";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // DirColumn
            // 
            this.DirColumn.HeaderText = "Прямий хід";
            this.DirColumn.Name = "DirColumn";
            this.DirColumn.ReadOnly = true;
            // 
            // InvDirColumn
            // 
            this.InvDirColumn.HeaderText = "Зворотній хід";
            this.InvDirColumn.Name = "InvDirColumn";
            this.InvDirColumn.ReadOnly = true;
            // 
            // RouteEditGroup
            // 
            this.RouteEditGroup.Controls.Add(this.TicketCostNumupdown);
            this.RouteEditGroup.Controls.Add(this.label3);
            this.RouteEditGroup.Controls.Add(this.RemoveStopRouteInvDirBtn);
            this.RouteEditGroup.Controls.Add(this.AddStopToRouteInvDirBtn);
            this.RouteEditGroup.Controls.Add(this.RemoveStopRouteBtn);
            this.RouteEditGroup.Controls.Add(this.AddStopToRouteBtn);
            this.RouteEditGroup.Controls.Add(this.InvDirLabel);
            this.RouteEditGroup.Controls.Add(this.DirLabel);
            this.RouteEditGroup.Controls.Add(this.InverseDirectStopsLstbox);
            this.RouteEditGroup.Controls.Add(this.DirectStopsLstbox);
            this.RouteEditGroup.Controls.Add(this.NextStopInvDirectCmbbox);
            this.RouteEditGroup.Controls.Add(this.NextStopCmbbox);
            this.RouteEditGroup.Controls.Add(this.SaveOrCreateRoute);
            this.RouteEditGroup.Controls.Add(this.TypeTransportLbl);
            this.RouteEditGroup.Controls.Add(this.TransportTypeCmbbox);
            this.RouteEditGroup.Controls.Add(this.RouteNameTxtbox);
            this.RouteEditGroup.Controls.Add(this.RouteNameLbl);
            this.RouteEditGroup.Controls.Add(this.RemoveRouteBtn);
            this.RouteEditGroup.Location = new System.Drawing.Point(463, 40);
            this.RouteEditGroup.Name = "RouteEditGroup";
            this.RouteEditGroup.Size = new System.Drawing.Size(526, 691);
            this.RouteEditGroup.TabIndex = 7;
            this.RouteEditGroup.TabStop = false;
            this.RouteEditGroup.Text = "Редагування маршруту";
            // 
            // TicketCostNumupdown
            // 
            this.TicketCostNumupdown.DecimalPlaces = 2;
            this.TicketCostNumupdown.Location = new System.Drawing.Point(147, 95);
            this.TicketCostNumupdown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TicketCostNumupdown.Name = "TicketCostNumupdown";
            this.TicketCostNumupdown.Size = new System.Drawing.Size(166, 27);
            this.TicketCostNumupdown.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Вартість квитка";
            // 
            // RemoveStopRouteInvDirBtn
            // 
            this.RemoveStopRouteInvDirBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveStopRouteInvDirBtn.ImageKey = "delete-icon-47792.png";
            this.RemoveStopRouteInvDirBtn.ImageList = this.IconsList;
            this.RemoveStopRouteInvDirBtn.Location = new System.Drawing.Point(388, 186);
            this.RemoveStopRouteInvDirBtn.Name = "RemoveStopRouteInvDirBtn";
            this.RemoveStopRouteInvDirBtn.Size = new System.Drawing.Size(113, 43);
            this.RemoveStopRouteInvDirBtn.TabIndex = 31;
            this.RemoveStopRouteInvDirBtn.Text = "Вилучити";
            this.RemoveStopRouteInvDirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveStopRouteInvDirBtn.UseVisualStyleBackColor = true;
            this.RemoveStopRouteInvDirBtn.Click += new System.EventHandler(this.RemoveStopRouteInvDirBtn_Click);
            // 
            // AddStopToRouteInvDirBtn
            // 
            this.AddStopToRouteInvDirBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddStopToRouteInvDirBtn.ImageKey = "addStopItem.png";
            this.AddStopToRouteInvDirBtn.ImageList = this.IconsList;
            this.AddStopToRouteInvDirBtn.Location = new System.Drawing.Point(266, 186);
            this.AddStopToRouteInvDirBtn.Name = "AddStopToRouteInvDirBtn";
            this.AddStopToRouteInvDirBtn.Size = new System.Drawing.Size(118, 43);
            this.AddStopToRouteInvDirBtn.TabIndex = 30;
            this.AddStopToRouteInvDirBtn.Text = "Додати";
            this.AddStopToRouteInvDirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStopToRouteInvDirBtn.UseVisualStyleBackColor = true;
            this.AddStopToRouteInvDirBtn.Click += new System.EventHandler(this.AddStopToRouteInvDirBtn_Click);
            // 
            // RemoveStopRouteBtn
            // 
            this.RemoveStopRouteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveStopRouteBtn.ImageKey = "delete-icon-47792.png";
            this.RemoveStopRouteBtn.ImageList = this.IconsList;
            this.RemoveStopRouteBtn.Location = new System.Drawing.Point(147, 186);
            this.RemoveStopRouteBtn.Name = "RemoveStopRouteBtn";
            this.RemoveStopRouteBtn.Size = new System.Drawing.Size(113, 43);
            this.RemoveStopRouteBtn.TabIndex = 29;
            this.RemoveStopRouteBtn.Text = "Вилучити";
            this.RemoveStopRouteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveStopRouteBtn.UseVisualStyleBackColor = true;
            this.RemoveStopRouteBtn.Click += new System.EventHandler(this.RemoveStopRouteBtn_Click);
            // 
            // AddStopToRouteBtn
            // 
            this.AddStopToRouteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddStopToRouteBtn.ImageKey = "addStopItem.png";
            this.AddStopToRouteBtn.ImageList = this.IconsList;
            this.AddStopToRouteBtn.Location = new System.Drawing.Point(25, 186);
            this.AddStopToRouteBtn.Name = "AddStopToRouteBtn";
            this.AddStopToRouteBtn.Size = new System.Drawing.Size(118, 43);
            this.AddStopToRouteBtn.TabIndex = 28;
            this.AddStopToRouteBtn.Text = "Додати";
            this.AddStopToRouteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStopToRouteBtn.UseVisualStyleBackColor = true;
            this.AddStopToRouteBtn.Click += new System.EventHandler(this.AddStopToRouteBtn_Click);
            // 
            // InvDirLabel
            // 
            this.InvDirLabel.AutoSize = true;
            this.InvDirLabel.Location = new System.Drawing.Point(262, 129);
            this.InvDirLabel.Name = "InvDirLabel";
            this.InvDirLabel.Size = new System.Drawing.Size(103, 20);
            this.InvDirLabel.TabIndex = 27;
            this.InvDirLabel.Text = "Зворотній хід";
            // 
            // DirLabel
            // 
            this.DirLabel.AutoSize = true;
            this.DirLabel.Location = new System.Drawing.Point(21, 129);
            this.DirLabel.Name = "DirLabel";
            this.DirLabel.Size = new System.Drawing.Size(89, 20);
            this.DirLabel.TabIndex = 26;
            this.DirLabel.Text = "Прямий хід";
            // 
            // InverseDirectStopsLstbox
            // 
            this.InverseDirectStopsLstbox.FormattingEnabled = true;
            this.InverseDirectStopsLstbox.ItemHeight = 20;
            this.InverseDirectStopsLstbox.Location = new System.Drawing.Point(266, 235);
            this.InverseDirectStopsLstbox.Name = "InverseDirectStopsLstbox";
            this.InverseDirectStopsLstbox.Size = new System.Drawing.Size(235, 404);
            this.InverseDirectStopsLstbox.TabIndex = 25;
            // 
            // DirectStopsLstbox
            // 
            this.DirectStopsLstbox.FormattingEnabled = true;
            this.DirectStopsLstbox.ItemHeight = 20;
            this.DirectStopsLstbox.Location = new System.Drawing.Point(25, 235);
            this.DirectStopsLstbox.Name = "DirectStopsLstbox";
            this.DirectStopsLstbox.Size = new System.Drawing.Size(235, 404);
            this.DirectStopsLstbox.TabIndex = 24;
            // 
            // NextStopInvDirectCmbbox
            // 
            this.NextStopInvDirectCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NextStopInvDirectCmbbox.FormattingEnabled = true;
            this.NextStopInvDirectCmbbox.Location = new System.Drawing.Point(266, 152);
            this.NextStopInvDirectCmbbox.Name = "NextStopInvDirectCmbbox";
            this.NextStopInvDirectCmbbox.Size = new System.Drawing.Size(235, 28);
            this.NextStopInvDirectCmbbox.TabIndex = 23;
            // 
            // NextStopCmbbox
            // 
            this.NextStopCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NextStopCmbbox.FormattingEnabled = true;
            this.NextStopCmbbox.Location = new System.Drawing.Point(25, 152);
            this.NextStopCmbbox.Name = "NextStopCmbbox";
            this.NextStopCmbbox.Size = new System.Drawing.Size(235, 28);
            this.NextStopCmbbox.TabIndex = 22;
            // 
            // SaveOrCreateRoute
            // 
            this.SaveOrCreateRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveOrCreateRoute.ImageKey = "saveIcon.png";
            this.SaveOrCreateRoute.ImageList = this.IconsList;
            this.SaveOrCreateRoute.Location = new System.Drawing.Point(387, 640);
            this.SaveOrCreateRoute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveOrCreateRoute.Name = "SaveOrCreateRoute";
            this.SaveOrCreateRoute.Size = new System.Drawing.Size(114, 43);
            this.SaveOrCreateRoute.TabIndex = 21;
            this.SaveOrCreateRoute.Text = "Зберегти";
            this.SaveOrCreateRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveOrCreateRoute.UseVisualStyleBackColor = true;
            this.SaveOrCreateRoute.Click += new System.EventHandler(this.SaveOrCreateRoute_Click);
            // 
            // TypeTransportLbl
            // 
            this.TypeTransportLbl.AutoSize = true;
            this.TypeTransportLbl.Location = new System.Drawing.Point(21, 27);
            this.TypeTransportLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeTransportLbl.Name = "TypeTransportLbl";
            this.TypeTransportLbl.Size = new System.Drawing.Size(118, 20);
            this.TypeTransportLbl.TabIndex = 20;
            this.TypeTransportLbl.Text = "Тип транспорту";
            // 
            // TransportTypeCmbbox
            // 
            this.TransportTypeCmbbox.FormattingEnabled = true;
            this.TransportTypeCmbbox.Location = new System.Drawing.Point(147, 22);
            this.TransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransportTypeCmbbox.Name = "TransportTypeCmbbox";
            this.TransportTypeCmbbox.Size = new System.Drawing.Size(187, 28);
            this.TransportTypeCmbbox.TabIndex = 19;
            // 
            // RouteNameTxtbox
            // 
            this.RouteNameTxtbox.Location = new System.Drawing.Point(147, 60);
            this.RouteNameTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RouteNameTxtbox.Name = "RouteNameTxtbox";
            this.RouteNameTxtbox.Size = new System.Drawing.Size(187, 27);
            this.RouteNameTxtbox.TabIndex = 18;
            // 
            // RouteNameLbl
            // 
            this.RouteNameLbl.AutoSize = true;
            this.RouteNameLbl.Location = new System.Drawing.Point(21, 63);
            this.RouteNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RouteNameLbl.Name = "RouteNameLbl";
            this.RouteNameLbl.Size = new System.Drawing.Size(51, 20);
            this.RouteNameLbl.TabIndex = 17;
            this.RouteNameLbl.Text = "Назва";
            // 
            // RoutesLabel
            // 
            this.RoutesLabel.AutoSize = true;
            this.RoutesLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoutesLabel.Location = new System.Drawing.Point(437, 7);
            this.RoutesLabel.Name = "RoutesLabel";
            this.RoutesLabel.Size = new System.Drawing.Size(115, 30);
            this.RoutesLabel.TabIndex = 8;
            this.RoutesLabel.Text = "Маршрути";
            // 
            // FormRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 742);
            this.Controls.Add(this.RoutesLabel);
            this.Controls.Add(this.RouteEditGroup);
            this.Controls.Add(this.RoutesListGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRoutes";
            this.Text = "Маршрути";
            this.RoutesListGroup.ResumeLayout(false);
            this.RoutesListGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoutesList)).EndInit();
            this.RouteEditGroup.ResumeLayout(false);
            this.RouteEditGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketCostNumupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ComboBox FilterTransportTypeCmbbox;
        private System.Windows.Forms.Button AddNewRouteBtn;
        private System.Windows.Forms.Button RemoveRouteBtn;
        private System.Windows.Forms.GroupBox RoutesListGroup;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.DataGridView RoutesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvDirColumn;
        private System.Windows.Forms.GroupBox RouteEditGroup;
        private System.Windows.Forms.NumericUpDown TicketCostNumupdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveStopRouteInvDirBtn;
        private System.Windows.Forms.Button AddStopToRouteInvDirBtn;
        private System.Windows.Forms.Button RemoveStopRouteBtn;
        private System.Windows.Forms.Button AddStopToRouteBtn;
        private System.Windows.Forms.Label InvDirLabel;
        private System.Windows.Forms.Label DirLabel;
        private System.Windows.Forms.ListBox InverseDirectStopsLstbox;
        private System.Windows.Forms.ListBox DirectStopsLstbox;
        private System.Windows.Forms.ComboBox NextStopInvDirectCmbbox;
        private System.Windows.Forms.ComboBox NextStopCmbbox;
        private System.Windows.Forms.Button SaveOrCreateRoute;
        private System.Windows.Forms.Label TypeTransportLbl;
        private System.Windows.Forms.ComboBox TransportTypeCmbbox;
        private System.Windows.Forms.TextBox RouteNameTxtbox;
        private System.Windows.Forms.Label RouteNameLbl;
        private System.Windows.Forms.Label RoutesLabel;
    }
}