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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrips));
            this.RemoveTripBtn = new System.Windows.Forms.Button();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.AddNewTripBtn = new System.Windows.Forms.Button();
            this.FilterTransportTypeCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLbl = new System.Windows.Forms.Label();
            this.TripsLstbox = new System.Windows.Forms.ListBox();
            this.TripsListGroup = new System.Windows.Forms.GroupBox();
            this.TripEditorGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TripDateDtPicker = new System.Windows.Forms.DateTimePicker();
            this.TransportCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportLbl = new System.Windows.Forms.Label();
            this.RoutesCmbbox = new System.Windows.Forms.ComboBox();
            this.RouteLbl = new System.Windows.Forms.Label();
            this.ScheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.StopsNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArriveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripsLabel = new System.Windows.Forms.Label();
            this.TripsListGroup.SuspendLayout();
            this.TripEditorGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveTripBtn
            // 
            this.RemoveTripBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveTripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveTripBtn.ImageKey = "delete-icon-47792.png";
            this.RemoveTripBtn.ImageList = this.IconList;
            this.RemoveTripBtn.Location = new System.Drawing.Point(11, 444);
            this.RemoveTripBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveTripBtn.Name = "RemoveTripBtn";
            this.RemoveTripBtn.Size = new System.Drawing.Size(154, 61);
            this.RemoveTripBtn.TabIndex = 32;
            this.RemoveTripBtn.Text = "Видалити рейс";
            this.RemoveTripBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveTripBtn.UseVisualStyleBackColor = true;
            this.RemoveTripBtn.Click += new System.EventHandler(this.RemoveTripBtn_Click);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "add-to-calendar.png");
            this.IconList.Images.SetKeyName(1, "delete-icon-47792.png");
            // 
            // AddNewTripBtn
            // 
            this.AddNewTripBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewTripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewTripBtn.ImageKey = "add-to-calendar.png";
            this.AddNewTripBtn.ImageList = this.IconList;
            this.AddNewTripBtn.Location = new System.Drawing.Point(176, 444);
            this.AddNewTripBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewTripBtn.Name = "AddNewTripBtn";
            this.AddNewTripBtn.Size = new System.Drawing.Size(154, 61);
            this.AddNewTripBtn.TabIndex = 30;
            this.AddNewTripBtn.Text = "Новий рейс";
            this.AddNewTripBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewTripBtn.UseVisualStyleBackColor = true;
            this.AddNewTripBtn.Click += new System.EventHandler(this.AddNewTripBtn_Click);
            // 
            // FilterTransportTypeCmbbox
            // 
            this.FilterTransportTypeCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterTransportTypeCmbbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterTransportTypeCmbbox.FormattingEnabled = true;
            this.FilterTransportTypeCmbbox.Location = new System.Drawing.Point(141, 22);
            this.FilterTransportTypeCmbbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.FilterTransportTypeCmbbox.Name = "FilterTransportTypeCmbbox";
            this.FilterTransportTypeCmbbox.Size = new System.Drawing.Size(189, 28);
            this.FilterTransportTypeCmbbox.TabIndex = 29;
            this.FilterTransportTypeCmbbox.SelectedIndexChanged += new System.EventHandler(this.FilterTransportTypeCmbbox_SelectedIndexChanged);
            // 
            // TransportTypeLbl
            // 
            this.TransportTypeLbl.AutoSize = true;
            this.TransportTypeLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportTypeLbl.Location = new System.Drawing.Point(7, 25);
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
            this.TripsLstbox.Location = new System.Drawing.Point(11, 54);
            this.TripsLstbox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TripsLstbox.Name = "TripsLstbox";
            this.TripsLstbox.Size = new System.Drawing.Size(319, 384);
            this.TripsLstbox.TabIndex = 27;
            this.TripsLstbox.SelectedIndexChanged += new System.EventHandler(this.TripsLstbox_SelectedIndexChanged);
            // 
            // TripsListGroup
            // 
            this.TripsListGroup.Controls.Add(this.TripsLstbox);
            this.TripsListGroup.Controls.Add(this.RemoveTripBtn);
            this.TripsListGroup.Controls.Add(this.TransportTypeLbl);
            this.TripsListGroup.Controls.Add(this.AddNewTripBtn);
            this.TripsListGroup.Controls.Add(this.FilterTransportTypeCmbbox);
            this.TripsListGroup.Location = new System.Drawing.Point(12, 45);
            this.TripsListGroup.Name = "TripsListGroup";
            this.TripsListGroup.Size = new System.Drawing.Size(343, 513);
            this.TripsListGroup.TabIndex = 33;
            this.TripsListGroup.TabStop = false;
            this.TripsListGroup.Text = "Список доступних рейсів";
            // 
            // TripEditorGroup
            // 
            this.TripEditorGroup.Controls.Add(this.label1);
            this.TripEditorGroup.Controls.Add(this.TripDateDtPicker);
            this.TripEditorGroup.Controls.Add(this.TransportCmbbox);
            this.TripEditorGroup.Controls.Add(this.TransportLbl);
            this.TripEditorGroup.Controls.Add(this.RoutesCmbbox);
            this.TripEditorGroup.Controls.Add(this.RouteLbl);
            this.TripEditorGroup.Controls.Add(this.ScheduleDataGrid);
            this.TripEditorGroup.Location = new System.Drawing.Point(361, 45);
            this.TripEditorGroup.Name = "TripEditorGroup";
            this.TripEditorGroup.Size = new System.Drawing.Size(715, 513);
            this.TripEditorGroup.TabIndex = 34;
            this.TripEditorGroup.TabStop = false;
            this.TripEditorGroup.Text = "Редактор рейсів";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Дата виходу на рейс";
            // 
            // TripDateDtPicker
            // 
            this.TripDateDtPicker.Location = new System.Drawing.Point(212, 88);
            this.TripDateDtPicker.Name = "TripDateDtPicker";
            this.TripDateDtPicker.Size = new System.Drawing.Size(200, 27);
            this.TripDateDtPicker.TabIndex = 12;
            this.TripDateDtPicker.ValueChanged += new System.EventHandler(this.TripDateDtPicker_ValueChanged);
            // 
            // TransportCmbbox
            // 
            this.TransportCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransportCmbbox.FormattingEnabled = true;
            this.TransportCmbbox.Location = new System.Drawing.Point(212, 54);
            this.TransportCmbbox.Name = "TransportCmbbox";
            this.TransportCmbbox.Size = new System.Drawing.Size(439, 28);
            this.TransportCmbbox.TabIndex = 11;
            this.TransportCmbbox.SelectedIndexChanged += new System.EventHandler(this.TransportCmbbox_SelectedIndexChanged);
            // 
            // TransportLbl
            // 
            this.TransportLbl.AutoSize = true;
            this.TransportLbl.Location = new System.Drawing.Point(11, 57);
            this.TransportLbl.Name = "TransportLbl";
            this.TransportLbl.Size = new System.Drawing.Size(83, 20);
            this.TransportLbl.TabIndex = 10;
            this.TransportLbl.Text = "Транспорт";
            // 
            // RoutesCmbbox
            // 
            this.RoutesCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoutesCmbbox.FormattingEnabled = true;
            this.RoutesCmbbox.Location = new System.Drawing.Point(212, 20);
            this.RoutesCmbbox.Name = "RoutesCmbbox";
            this.RoutesCmbbox.Size = new System.Drawing.Size(439, 28);
            this.RoutesCmbbox.TabIndex = 9;
            this.RoutesCmbbox.SelectedIndexChanged += new System.EventHandler(this.RoutesCmbbox_SelectedIndexChanged);
            // 
            // RouteLbl
            // 
            this.RouteLbl.AutoSize = true;
            this.RouteLbl.Location = new System.Drawing.Point(11, 23);
            this.RouteLbl.Name = "RouteLbl";
            this.RouteLbl.Size = new System.Drawing.Size(73, 20);
            this.RouteLbl.TabIndex = 8;
            this.RouteLbl.Text = "Маршрут";
            // 
            // ScheduleDataGrid
            // 
            this.ScheduleDataGrid.AllowUserToAddRows = false;
            this.ScheduleDataGrid.AllowUserToDeleteRows = false;
            this.ScheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StopsNames,
            this.ArriveTime,
            this.StopInterval,
            this.LeaveStop});
            this.ScheduleDataGrid.Location = new System.Drawing.Point(15, 121);
            this.ScheduleDataGrid.Name = "ScheduleDataGrid";
            this.ScheduleDataGrid.Size = new System.Drawing.Size(694, 384);
            this.ScheduleDataGrid.TabIndex = 7;
            this.ScheduleDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleDataGrid_CellEndEdit);
            // 
            // StopsNames
            // 
            this.StopsNames.HeaderText = "Зупинки";
            this.StopsNames.Name = "StopsNames";
            this.StopsNames.ReadOnly = true;
            // 
            // ArriveTime
            // 
            this.ArriveTime.HeaderText = "Прибуття";
            this.ArriveTime.Name = "ArriveTime";
            this.ArriveTime.Width = 125;
            // 
            // StopInterval
            // 
            this.StopInterval.HeaderText = "Стоянка";
            this.StopInterval.Name = "StopInterval";
            this.StopInterval.Width = 125;
            // 
            // LeaveStop
            // 
            this.LeaveStop.HeaderText = "Відправлення";
            this.LeaveStop.Name = "LeaveStop";
            this.LeaveStop.Width = 125;
            // 
            // TripsLabel
            // 
            this.TripsLabel.AutoSize = true;
            this.TripsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripsLabel.Location = new System.Drawing.Point(515, 9);
            this.TripsLabel.Name = "TripsLabel";
            this.TripsLabel.Size = new System.Drawing.Size(70, 30);
            this.TripsLabel.TabIndex = 35;
            this.TripsLabel.Text = "Рейси";
            // 
            // FormTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 565);
            this.Controls.Add(this.TripsLabel);
            this.Controls.Add(this.TripEditorGroup);
            this.Controls.Add(this.TripsListGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTrips";
            this.Text = "Рейси";
            this.TripsListGroup.ResumeLayout(false);
            this.TripsListGroup.PerformLayout();
            this.TripEditorGroup.ResumeLayout(false);
            this.TripEditorGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RemoveTripBtn;
        private System.Windows.Forms.Button AddNewTripBtn;
        private System.Windows.Forms.ComboBox FilterTransportTypeCmbbox;
        private System.Windows.Forms.Label TransportTypeLbl;
        private System.Windows.Forms.ListBox TripsLstbox;
        private System.Windows.Forms.GroupBox TripsListGroup;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.GroupBox TripEditorGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TripDateDtPicker;
        private System.Windows.Forms.ComboBox TransportCmbbox;
        private System.Windows.Forms.Label TransportLbl;
        private System.Windows.Forms.ComboBox RoutesCmbbox;
        private System.Windows.Forms.Label RouteLbl;
        private System.Windows.Forms.DataGridView ScheduleDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopsNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveStop;
        private System.Windows.Forms.Label TripsLabel;
    }
}