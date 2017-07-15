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
using COMP2614Assign06.View;

namespace COMP2614Assign06
{
    /// <summary>
    /// This is the main form that contains GridView and CRUD functionality
    /// </summary>
    public partial class MainForm : Form
    {
        private CreateForm createDialog;        //Add Record Form
        private ClientViewModel clientVM;       //ViewModel
        private ClientCollection clientList;    //Collection used for ViewModel initialization and update
        private Dialog clientDialog;            //Edit Record Form

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //bool configured = false;
            // configured = true; // uncomment to configure DataGridView 
            clientList = DataAccessObject.SelectAll();      //Fetch records from DB
            clientVM = new ClientViewModel(clientList);     //Connect VM with fetched DB
            clientDialog = new Dialog(this);                //Create Edit Record Dialog
            createDialog = new CreateForm();                //Create Add Record Dialog

            dataGridViewClients.AutoGenerateColumns = false;    //DO NOT autogenerate columns
            dataGridViewClients.DataSource = clientVM.Clients;  //Datasource from VM
            setupDataGridView();
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


        //Edit Button Event
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
                setOutputLabel();
            }                      
        }

        //Output Label Setup Method
        private void setOutputLabel()
        {
            string outputData = string.Format("{0:N2}\r\n\n{1}{2}\r\n"
                                         , clientVM.Clients.TotalYTDSales
                                         , clientVM.Clients.CreditHoldCount
                                         , " Credit Holds");

            mainLabelOutput.Text = outputData;
        }

        //Add Button Behaviour
        private void mainAddButton_Click(object sender, EventArgs e)
        {
            createDialog.ShowDialog();

            if (createDialog.DialogResult == DialogResult.OK)
            {
                clientVM.Clients = DataAccessObject.SelectAll();
                dataGridViewClients.DataSource = clientVM.Clients;
                dataGridViewClients.Refresh();
                setOutputLabel();
            }
        }

        //Delete Button Behaviour
        private void mainDeleteButton_Click(object sender, EventArgs e)
        {
            Client client;
            //For instant deletion
            if (mainCheckBox.Checked == true)
            {
                client = clientVM.Clients.ElementAt(dataGridViewClients.CurrentRow.Index);
                ClientValidation.DeleteClient(client);
            }

            //Checked deletion
            else
            {
                const string message = "Are you sure you want to delete selected record?";
                const string caption = "Confirm Deletion";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    client = clientVM.Clients.ElementAt(dataGridViewClients.CurrentRow.Index);
                    ClientValidation.DeleteClient(client);
                }
            }

            clientVM.Clients = DataAccessObject.SelectAll();
            dataGridViewClients.DataSource = clientVM.Clients;
            dataGridViewClients.Refresh();
            setOutputLabel();
        }
    }
}
