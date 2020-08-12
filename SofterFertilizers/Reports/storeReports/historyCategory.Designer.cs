﻿namespace SofterFertilizers.Reports.storeReports
{
    partial class historyCategory
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
            this.showFlowButton = new SofterFertilizers.roundedButton();
            this.label16 = new System.Windows.Forms.Label();
            this.categoryDGV = new System.Windows.Forms.DataGridView();
            this.fromDate = new SofterFertilizers.BCDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).BeginInit();
            this.SuspendLayout();
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
            this.showFlowButton.Location = new System.Drawing.Point(40, 92);
            this.showFlowButton.Name = "showFlowButton";
            this.showFlowButton.Size = new System.Drawing.Size(135, 38);
            this.showFlowButton.TabIndex = 930;
            this.showFlowButton.Text = "عرض";
            this.showFlowButton.UseVisualStyleBackColor = false;
            this.showFlowButton.Click += new System.EventHandler(this.showFlowButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tempus Sans ITC", 22F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.label16.Location = new System.Drawing.Point(792, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(313, 39);
            this.label16.TabIndex = 929;
            this.label16.Text = "جرد الأصناف في يوم محدد";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.categoryDGV.Location = new System.Drawing.Point(15, 149);
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
            this.categoryDGV.Size = new System.Drawing.Size(1795, 695);
            this.categoryDGV.TabIndex = 928;
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
            this.fromDate.Location = new System.Drawing.Point(216, 89);
            this.fromDate.Name = "fromDate";
            this.fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromDate.Size = new System.Drawing.Size(175, 39);
            this.fromDate.TabIndex = 975;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(262, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 974;
            this.label3.Text = "التاريخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(628, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 28);
            this.label1.TabIndex = 976;
            this.label1.Text = "إن لم يعرض نتيجى, فمعناه أن النظام لم يعمل في ذاك اليوم .. فاختر أقرب يوم لتاريخه" +
    " ";
            // 
            // historyCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showFlowButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.categoryDGV);
            this.Name = "historyCategory";
            this.Size = new System.Drawing.Size(1825, 848);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private roundedButton showFlowButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView categoryDGV;
        private BCDateTimePicker fromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}