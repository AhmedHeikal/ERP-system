﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Configuration;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;

namespace SofterFertilizers.BasicData
{
    public partial class saveToExcel : UserControl
    {
        public saveToExcel()
        {
            InitializeComponent();
            fillCategoryDGV();
        }
        string constring = System.Configuration.ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        void fillCategoryDGV()
        {
            categoryDGV.DataBindings.Clear();

            string Query = "select id as 'كود الصنف', categoryName as 'اسم الصنف' , companyName as 'الشركة' ,mainUnit as 'الوحدة', mainType as 'النوع', storeCode as 'الكود المخزني', notes as 'ملاحظات', sellingPrice as 'السعر', packagePrice as 'سعر الجملة', halfPackagePrice as 'نص جملة', buyingPrice as 'سعر الشراء', topDiscountRate 'أعلى نسبة خصم', highestBuyingQuantity as 'كمية البيع القصوى', lowestQuantity as 'أقل كمية', highestQuantity as  'أكثر كمية' from categoryTable;";

            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                categoryDGV.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {

            }

            conDataBase.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "unknown.xls";
            // set filters - this can be done in properties as well
            savefile.Filter = "Excel Files|*.xls";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string path = savefile.FileName;
                string Query = "select id as 'كود الصنف', categoryName as 'اسم الصنف' , companyName as 'الشركة' ,mainUnit as 'الوحدة', mainType as 'النوع', storeCode as 'الكود المخزني', notes as 'ملاحظات', sellingPrice as 'السعر', packagePrice as 'سعر الجملة', halfPackagePrice as 'نص جملة', buyingPrice as 'سعر الشراء', topDiscountRate 'أعلى نسبة خصم', highestBuyingQuantity as 'كمية البيع القصوى', lowestQuantity as 'أقل كمية', highestQuantity as  'أكثر كمية' from categoryTable;";

                SqlConnection conDataBase = new SqlConnection(constring);
                SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                  
                    DataSet ds = new DataSet();
                    sda.Fill(dbdataset);
                    ds.Tables.Add(dbdataset);
                    ExcelLibrary.DataSetHelper.CreateWorkbook(path, ds);

                }
                catch (Exception ex)
                {
 
                }
            }


        }
    }
}