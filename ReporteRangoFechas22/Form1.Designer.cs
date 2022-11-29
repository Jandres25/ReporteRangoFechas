namespace ReporteRangoFechas22
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.netSalesByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dTPToDate = new System.Windows.Forms.DateTimePicker();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnThisYear = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnLast7days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.netSalesByPeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // netSalesByPeriodBindingSource
            // 
            this.netSalesByPeriodBindingSource.DataSource = typeof(Domain.NetSalesByPeriod);
            // 
            // salesListingBindingSource
            // 
            this.salesListingBindingSource.DataSource = typeof(Domain.SalesListing);
            // 
            // salesReportBindingSource
            // 
            this.salesReportBindingSource.DataSource = typeof(Domain.SalesReport);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblHasta);
            this.panel1.Controls.Add(this.lblDesde);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.dTPToDate);
            this.panel1.Controls.Add(this.dTPStartDate);
            this.panel1.Controls.Add(this.btnCustom);
            this.panel1.Controls.Add(this.btnThisYear);
            this.panel1.Controls.Add(this.btnLast30Days);
            this.panel1.Controls.Add(this.btnThisMonth);
            this.panel1.Controls.Add(this.btnLast7days);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 566);
            this.panel1.TabIndex = 1;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(16, 383);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 31;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(16, 325);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 30;
            this.lblDesde.Text = "Desde:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(41, 444);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 27);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dTPToDate
            // 
            this.dTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPToDate.Location = new System.Drawing.Point(77, 383);
            this.dTPToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Size = new System.Drawing.Size(87, 20);
            this.dTPToDate.TabIndex = 28;
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPStartDate.Location = new System.Drawing.Point(77, 320);
            this.dTPStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(87, 20);
            this.dTPStartDate.TabIndex = 23;
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(41, 258);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(104, 27);
            this.btnCustom.TabIndex = 27;
            this.btnCustom.Text = "Personalizado";
            this.btnCustom.UseVisualStyleBackColor = true;
            // 
            // btnThisYear
            // 
            this.btnThisYear.Location = new System.Drawing.Point(41, 211);
            this.btnThisYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Size = new System.Drawing.Size(104, 27);
            this.btnThisYear.TabIndex = 26;
            this.btnThisYear.Text = "Este Año";
            this.btnThisYear.UseVisualStyleBackColor = true;
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Location = new System.Drawing.Point(41, 167);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(104, 27);
            this.btnLast30Days.TabIndex = 25;
            this.btnLast30Days.Text = "Ultimos 30 Dias";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Location = new System.Drawing.Point(41, 119);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(104, 27);
            this.btnThisMonth.TabIndex = 24;
            this.btnThisMonth.Text = "Este Mes";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLast7days
            // 
            this.btnLast7days.Location = new System.Drawing.Point(41, 73);
            this.btnLast7days.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast7days.Name = "btnLast7days";
            this.btnLast7days.Size = new System.Drawing.Size(104, 27);
            this.btnLast7days.TabIndex = 22;
            this.btnLast7days.Text = "Ultimos 7 Dias";
            this.btnLast7days.UseVisualStyleBackColor = true;
            this.btnLast7days.Click += new System.EventHandler(this.btnLast7days_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(41, 27);
            this.btnToday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(104, 27);
            this.btnToday.TabIndex = 21;
            this.btnToday.Text = "Ahora";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "netSalesByPeriodDT";
            reportDataSource1.Value = this.netSalesByPeriodBindingSource;
            reportDataSource2.Name = "saleListingDT";
            reportDataSource2.Value = this.salesListingBindingSource;
            reportDataSource3.Name = "salesReportDT";
            reportDataSource3.Value = this.salesReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReporteRangoFechas22.Reports.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(183, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(840, 566);
            this.reportViewer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 566);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Fechas por Periodos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.netSalesByPeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dTPToDate;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnThisYear;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLast7days;
        private System.Windows.Forms.Button btnToday;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource netSalesByPeriodBindingSource;
        private System.Windows.Forms.BindingSource salesListingBindingSource;
        private System.Windows.Forms.BindingSource salesReportBindingSource;
    }
}

