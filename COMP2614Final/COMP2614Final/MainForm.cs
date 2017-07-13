using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP2614FinalLibrary;

namespace COMP2614Final
{
    public partial class MainForm : Form
    {
        private ProductViewModel productVM;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            productVM = new ProductViewModel(DataAccessObject.SelectAll());
            //setSideData();
            setBindings();
        }

        private void setBindings()
        {
            textBoxQuantity.DataBindings.Add("Text", productVM, "Quantity", true, DataSourceUpdateMode.OnValidation, "#,##0;(#,##0));0");
            textBoxSku.DataBindings.Add("Text", productVM, "Sku", false, DataSourceUpdateMode.OnValidation);
            textBoxDescription.DataBindings.Add("Text", productVM, "Description", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            textBoxPrice.DataBindings.Add("Text", productVM, "Price", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00));0.00");
            textBoxExtended.DataBindings.Add("Text", productVM, "Extended", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00));0.00");
            checkBoxTaxable.DataBindings.Add("CheckState", productVM, "IsTaxable", true, DataSourceUpdateMode.OnValidation, 0);

            listBoxSku.DataSource = productVM.Products;
            listBoxSku.DisplayMember = "Sku";

        }

        private void setSideData()
        {
            string outputData = string.Format("{0:N2}\r\n{1:N2}\r\n{2:N2}\r\n{3:N2}\r\n"
                                         , productVM.Products.Subtotal
                                         , productVM.Products.CalcGst
                                         , productVM.Products.CalcPst
                                         , productVM.Products.Grandtotal);

            labelResults.Text = outputData;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSku_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxSku.SelectedIndex);
            Product product = productVM.Products[selectedIndex];
            productVM.SetDisplayingProduct(product);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = listBoxSku.SelectedIndex;
            Product product = productVM.GetDisplayingProduct();
            productVM.SaveClient(index);
            setSideData();
        }
    }
}
