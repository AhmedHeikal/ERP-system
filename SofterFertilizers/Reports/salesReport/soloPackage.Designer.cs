﻿namespace SofterFertilizers.Reports
{
    partial class soloPackage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryDGV = new System.Windows.Forms.DataGridView();
            this.showFlowButton = new SofterFertilizers.roundedButton();
            this.toDate = new SofterFertilizers.BCDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDate = new SofterFertilizers.BCDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.billTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryDGV
            // 
            this.categoryDGV.AllowUserToAddRows = false;
            this.categoryDGV.AllowUserToDeleteRows = false;
            this.categoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.categoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoryDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoryDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.categoryDGV.GridColor = System.Drawing.Color.White;
            this.categoryDGV.Location = new System.Drawing.Point(17, 116);
            this.categoryDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryDGV.MultiSelect = false;
            this.categoryDGV.Name = "categoryDGV";
            this.categoryDGV.ReadOnly = true;
            this.categoryDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.categoryDGV.RowHeadersWidth = 30;
            this.categoryDGV.RowTemplate.Height = 26;
            this.categoryDGV.Size = new System.Drawing.Size(1795, 715);
            this.categoryDGV.TabIndex = 861;
            this.categoryDGV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoryDGV_RowHeaderMouseDoubleClick);
            // 
            // showFlowButton
            // 
            this.showFlowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.showFlowButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.showFlowButton.FlatAppearance.BorderSize = 0;
            this.showFlowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.showFlowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.showFlowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showFlowButton.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold);
            this.showFlowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.showFlowButton.Location = new System.Drawing.Point(17, 63);
            this.showFlowButton.Name = "showFlowButton";
            this.showFlowButton.Size = new System.Drawing.Size(135, 38);
            this.showFlowButton.TabIndex = 860;
            this.showFlowButton.Text = "عرض";
            this.showFlowButton.UseVisualStyleBackColor = false;
            this.showFlowButton.Click += new System.EventHandler(this.showFlowButton_Click);
            // 
            // toDate
            // 
            this.toDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toDate.BackDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toDate.CalendarFont = new System.Drawing.Font("Tempus Sans ITC", 16F);
            this.toDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.toDate.CustomFormat = "yyyy-MM-dd";
            this.toDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.toDate.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(210, 72);
            this.toDate.Name = "toDate";
            this.toDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toDate.Size = new System.Drawing.Size(175, 39);
            this.toDate.TabIndex = 859;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(281, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 28);
            this.label4.TabIndex = 858;
            this.label4.Text = "إلى";
            // 
            // fromDate
            // 
            this.fromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.fromDate.BackDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.fromDate.CalendarFont = new System.Drawing.Font("Tempus Sans ITC", 16F);
            this.fromDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.fromDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.fromDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.fromDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.fromDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.fromDate.CustomFormat = "yyyy-MM-dd";
            this.fromDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fromDate.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(418, 72);
            this.fromDate.Name = "fromDate";
            this.fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDate.Size = new System.Drawing.Size(175, 39);
            this.fromDate.TabIndex = 857;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(491, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 28);
            this.label3.TabIndex = 856;
            this.label3.Text = "من";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tempus Sans ITC", 22F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.label16.Location = new System.Drawing.Point(830, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 39);
            this.label16.TabIndex = 854;
            this.label16.Text = "مبيعات جملة وقطاعي";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // billTypeComboBox
            // 
            this.billTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.billTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.billTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billTypeComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.billTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.billTypeComboBox.FormattingEnabled = true;
            this.billTypeComboBox.Location = new System.Drawing.Point(1600, 70);
            this.billTypeComboBox.Name = "billTypeComboBox";
            this.billTypeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.billTypeComboBox.Size = new System.Drawing.Size(200, 27);
            this.billTypeComboBox.TabIndex = 863;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1652, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 862;
            this.label2.Text = "نوع الفاتورة";
            // 
            // soloPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.billTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryDGV);
            this.Controls.Add(this.showFlowButton);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Name = "soloPackage";
            this.Size = new System.Drawing.Size(1825, 848);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView categoryDGV;
        private roundedButton showFlowButton;
        private BCDateTimePicker toDate;
        private System.Windows.Forms.Label label4;
        private BCDateTimePicker fromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox billTypeComboBox;
        private System.Windows.Forms.Label label2;
    }
}
