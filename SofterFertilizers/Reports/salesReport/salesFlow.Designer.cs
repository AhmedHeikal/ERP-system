﻿namespace SofterFertilizers.Reports
{
    partial class salesFlow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.storeNameComboBox = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.reportComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDate = new SofterFertilizers.BCDateTimePicker();
            this.toDate = new SofterFertilizers.BCDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.showFlowButton = new SofterFertilizers.roundedButton();
            this.categoryDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tempus Sans ITC", 22F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.label16.Location = new System.Drawing.Point(697, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 39);
            this.label16.TabIndex = 775;
            this.label16.Text = "حركة المبيعات";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // storeNameComboBox
            // 
            this.storeNameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.storeNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storeNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.storeNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.storeNameComboBox.ForeColor = System.Drawing.Color.White;
            this.storeNameComboBox.FormattingEnabled = true;
            this.storeNameComboBox.Location = new System.Drawing.Point(1487, 104);
            this.storeNameComboBox.Name = "storeNameComboBox";
            this.storeNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.storeNameComboBox.Size = new System.Drawing.Size(160, 27);
            this.storeNameComboBox.TabIndex = 777;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(1536, 73);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 28);
            this.label30.TabIndex = 776;
            this.label30.Text = "المخزن";
            // 
            // reportComboBox
            // 
            this.reportComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.reportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.reportComboBox.ForeColor = System.Drawing.Color.White;
            this.reportComboBox.FormattingEnabled = true;
            this.reportComboBox.Location = new System.Drawing.Point(1291, 104);
            this.reportComboBox.Name = "reportComboBox";
            this.reportComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportComboBox.Size = new System.Drawing.Size(160, 27);
            this.reportComboBox.TabIndex = 779;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1325, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 778;
            this.label1.Text = "نوع التقرير";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(476, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 28);
            this.label3.TabIndex = 782;
            this.label3.Text = "من";
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
            this.fromDate.Location = new System.Drawing.Point(404, 113);
            this.fromDate.Name = "fromDate";
            this.fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDate.Size = new System.Drawing.Size(175, 39);
            this.fromDate.TabIndex = 783;
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
            this.toDate.Location = new System.Drawing.Point(196, 113);
            this.toDate.Name = "toDate";
            this.toDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toDate.Size = new System.Drawing.Size(175, 39);
            this.toDate.TabIndex = 785;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(266, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 28);
            this.label4.TabIndex = 784;
            this.label4.Text = "إلى";
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
            this.showFlowButton.Location = new System.Drawing.Point(3, 104);
            this.showFlowButton.Name = "showFlowButton";
            this.showFlowButton.Size = new System.Drawing.Size(135, 38);
            this.showFlowButton.TabIndex = 786;
            this.showFlowButton.Text = "عرض";
            this.showFlowButton.UseVisualStyleBackColor = false;
            this.showFlowButton.Click += new System.EventHandler(this.showFlowButton_Click);
            // 
            // categoryDGV
            // 
            this.categoryDGV.AllowUserToAddRows = false;
            this.categoryDGV.AllowUserToDeleteRows = false;
            this.categoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.categoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoryDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.categoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.categoryDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.categoryDGV.GridColor = System.Drawing.Color.White;
            this.categoryDGV.Location = new System.Drawing.Point(3, 158);
            this.categoryDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryDGV.MultiSelect = false;
            this.categoryDGV.Name = "categoryDGV";
            this.categoryDGV.ReadOnly = true;
            this.categoryDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.categoryDGV.RowHeadersWidth = 30;
            this.categoryDGV.RowTemplate.Height = 26;
            this.categoryDGV.Size = new System.Drawing.Size(1644, 674);
            this.categoryDGV.TabIndex = 787;
            // 
            // salesFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.categoryDGV);
            this.Controls.Add(this.showFlowButton);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storeNameComboBox);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label16);
            this.Name = "salesFlow";
            this.Size = new System.Drawing.Size(1653, 848);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox storeNameComboBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox reportComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private BCDateTimePicker fromDate;
        private BCDateTimePicker toDate;
        private System.Windows.Forms.Label label4;
        private roundedButton showFlowButton;
        private System.Windows.Forms.DataGridView categoryDGV;
    }
}