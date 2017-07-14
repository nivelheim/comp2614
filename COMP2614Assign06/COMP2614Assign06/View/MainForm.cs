using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace COMP2614Assign06
{
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;
        private ClientCollection clientList;
        private Dialog clientDialog;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool configured = false;
            // configured = true; // uncomment to configure DataGridView 
            clientList = DataAccessObject.SelectAll();
            clientVM = new ClientViewModel(clientList);
            clientDialog = new Dialog(this);

            dataGridViewClients.AutoGenerateColumns = true;
            dataGridViewClients.DataSource = clientVM.Clients;
           //setupDataGridView();
        }

        /*No more used data binding
        private void setBindings(bool configured)
        {
            textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress2.DataBindings.Add("Text", clientVM, "Address2", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            textBoxCity.DataBindings.Add("Text", clientVM, "City", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            textBoxProvince.DataBindings.Add("Text", clientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
            textBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            textBoxSales.DataBindings.Add("Text", clientVM, "YtdSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            textBoxNotes.DataBindings.Add("Text", clientVM, "Notes", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
           
            checkBoxHold.DataBindings.Add("Checked", clientVM, "IsCreditHold");

            dataGridViewClients.AutoGenerateColumns = !configured;
            dataGridViewClients.DataSource = clientVM.Clients;
        }

        */

        private void setupDataGridView()
        {        
            // configure for readonly 
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // add columns

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "id";
            id.DataPropertyName = "ClientCode";
            id.HeaderText = "Id";
            id.Width = 70;
            id.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            id.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(id);

            DataGridViewTextBoxColumn cName = new DataGridViewTextBoxColumn();
            cName.Name = "cName";
            cName.DataPropertyName = "CompanyName";
            cName.HeaderText = "Company Name";
            cName.Width = 90;
            cName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(cName);

            DataGridViewTextBoxColumn addr1 = new DataGridViewTextBoxColumn();
            addr1.Name = "addr1";
            addr1.DataPropertyName = "Address1";
            addr1.HeaderText = "Address 1";
            addr1.Width = 100;
            addr1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(addr1);

            DataGridViewTextBoxColumn addr2 = new DataGridViewTextBoxColumn();
            addr2.Name = "addr2";
            addr2.DataPropertyName = "Address2";
            addr2.HeaderText = "Address 2";
            addr2.Width = 100;
            addr2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(addr2);

            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
            city.Name = "city";
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.Width = 100;
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            DataGridViewTextBoxColumn prov = new DataGridViewTextBoxColumn();
            prov.Name = "prov";
            prov.DataPropertyName = "Province";
            prov.HeaderText = "Province";
            prov.Width = 100;
            prov.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(prov);

            DataGridViewTextBoxColumn pCode = new DataGridViewTextBoxColumn();
            pCode.Name = "pCode";
            pCode.DataPropertyName = "PostalCode";
            pCode.HeaderText = "PostalCode";
            pCode.Width = 100;
            pCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(pCode);

            DataGridViewTextBoxColumn sales = new DataGridViewTextBoxColumn();
            sales.Name = "sales";
            sales.DataPropertyName = "YtdSales";
            sales.HeaderText = "YTD Sales";
            sales.Width = 90;
            sales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            sales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            sales.DefaultCellStyle.Format = "N2";
            sales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(sales);

            DataGridViewCheckBoxColumn hold = new DataGridViewCheckBoxColumn();
            hold.Name = "hold";
            hold.DataPropertyName = "IsCreditHold";
            hold.HeaderText = "Credit Hold";
            hold.Width = 70;
            hold.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(hold);

            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 100;
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);
        }

        /* No more used event
        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            
            Client client = clientVM.Clients[index];
            clientVM.SetDisplayingClient(client);
            labelProductLegend.Text = string.Empty;
            labelProductData.Text = string.Empty;

            
        }
        */

        private void mainEditButton_Click(object sender, EventArgs e)
        {
            clientDialog.SelectedRow = dataGridViewClients.CurrentRow.Index;
            clientDialog.ClientModel = clientVM;
            clientDialog.ShowDialog();

            if (clientDialog.DialogResult == DialogResult.OK) 
            {
                clientVM.Clients = DataAccessObject.SelectAll();
                dataGridViewClients.DataSource = clientVM.Clients;
                dataGridViewClients.Refresh();
            }

            //clientDialog.Dispose();                        
        }


        /*Unused clickevent
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            clientVM.SaveClient(index);
           
            clientVM.Clients.ResetItem(index);

            string outputLegend = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}\r\n{9}\r\n"
                                         , "CliID:"
                                         , "ComName:"
                                         , "Addr1:"
                                         , "Addr2:"
                                         , "City:"
                                         , "Prov:"
                                         , "PoCode:"
                                         , "Sales:"
                                         , "Taxable:"
                                         , "Notes:");


            string outputData = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}\r\n{9}\r\n"
                                         , client.ClientCode
                                         , client.CompanyName
                                         , client.Address1
                                         , client.Address2
                                         , client.City
                                         , client.Province
                                         , client.PostalCode
                                         , client.YtdSales
                                         , client.IsCreditHold
                                         , client.Notes);

            labelProductLegend.Text = outputLegend;
            labelProductData.Text = outputData;
        }
        */
        
        private void textBoxSku_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelProductLegend_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelProductData_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
