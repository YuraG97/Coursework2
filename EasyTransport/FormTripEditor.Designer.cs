namespace EasyTransport
{
    partial class FormTripEditor
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
            this.ScheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.StopsNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArriveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteLbl = new System.Windows.Forms.Label();
            this.RoutesCmbbox = new System.Windows.Forms.ComboBox();
            this.TransportLbl = new System.Windows.Forms.Label();
            this.TransportCmbbox = new System.Windows.Forms.ComboBox();
            this.TripDateDtPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.ScheduleDataGrid.Location = new System.Drawing.Point(12, 107);
            this.ScheduleDataGrid.Name = "ScheduleDataGrid";
            this.ScheduleDataGrid.Size = new System.Drawing.Size(640, 353);
            this.ScheduleDataGrid.TabIndex = 0;
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
            // RouteLbl
            // 
            this.RouteLbl.AutoSize = true;
            this.RouteLbl.Location = new System.Drawing.Point(12, 9);
            this.RouteLbl.Name = "RouteLbl";
            this.RouteLbl.Size = new System.Drawing.Size(73, 20);
            this.RouteLbl.TabIndex = 1;
            this.RouteLbl.Text = "Маршрут";
            // 
            // RoutesCmbbox
            // 
            this.RoutesCmbbox.FormattingEnabled = true;
            this.RoutesCmbbox.Location = new System.Drawing.Point(213, 6);
            this.RoutesCmbbox.Name = "RoutesCmbbox";
            this.RoutesCmbbox.Size = new System.Drawing.Size(439, 28);
            this.RoutesCmbbox.TabIndex = 2;
            this.RoutesCmbbox.SelectedIndexChanged += new System.EventHandler(this.RoutesCmbbox_SelectedIndexChanged);
            // 
            // TransportLbl
            // 
            this.TransportLbl.AutoSize = true;
            this.TransportLbl.Location = new System.Drawing.Point(12, 43);
            this.TransportLbl.Name = "TransportLbl";
            this.TransportLbl.Size = new System.Drawing.Size(83, 20);
            this.TransportLbl.TabIndex = 3;
            this.TransportLbl.Text = "Транспорт";
            // 
            // TransportCmbbox
            // 
            this.TransportCmbbox.FormattingEnabled = true;
            this.TransportCmbbox.Location = new System.Drawing.Point(213, 40);
            this.TransportCmbbox.Name = "TransportCmbbox";
            this.TransportCmbbox.Size = new System.Drawing.Size(439, 28);
            this.TransportCmbbox.TabIndex = 4;
            // 
            // TripDateDtPicker
            // 
            this.TripDateDtPicker.Location = new System.Drawing.Point(213, 74);
            this.TripDateDtPicker.Name = "TripDateDtPicker";
            this.TripDateDtPicker.Size = new System.Drawing.Size(200, 27);
            this.TripDateDtPicker.TabIndex = 5;
            this.TripDateDtPicker.ValueChanged += new System.EventHandler(this.TripDateDtPicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата виходу на рейс";
            // 
            // FormTripEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TripDateDtPicker);
            this.Controls.Add(this.TransportCmbbox);
            this.Controls.Add(this.TransportLbl);
            this.Controls.Add(this.RoutesCmbbox);
            this.Controls.Add(this.RouteLbl);
            this.Controls.Add(this.ScheduleDataGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTripEditor";
            this.Text = "Новий рейс";
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ScheduleDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopsNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveStop;
        private System.Windows.Forms.Label RouteLbl;
        private System.Windows.Forms.ComboBox RoutesCmbbox;
        private System.Windows.Forms.Label TransportLbl;
        private System.Windows.Forms.ComboBox TransportCmbbox;
        private System.Windows.Forms.DateTimePicker TripDateDtPicker;
        private System.Windows.Forms.Label label1;
    }
}