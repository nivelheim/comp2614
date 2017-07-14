using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClassLibrary;

namespace COMP2614Assign06
{
    public partial class Dialog : Form
    {
        MainForm main;
        public ClientViewModel ClientModel { get; set; }
        public int SelectedRow { get; set; }
        public bool BindingSet { get; set; } = false;

        public Dialog(MainForm form)
        {
            main = form;
            this.FormClosing += new FormClosingEventHandler(this.dButtonOk_Click);
            InitializeComponent();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            ClientModel.SetDisplayingClient(ClientModel.Clients[SelectedRow]);

            if (BindingSet == false)
            {
                SetBindings();
                BindingSet = true;
            }
        }

        private void dButtonOk_Click(object sender, EventArgs e)
        {
            //ClientModel.SaveClient(SelectedRow);

            
            int rowsAffected;

            Client client = ClientModel.GetDisplayingClient();
            DataAccessObject.UpdateClient(client);
            ClientModel.Clients = ClientValidation.GetClients();
            this.DialogResult = DialogResult.OK;
            

            /*
            try
            {
                Client client = ClientModel.GetDisplayingClient();
                int rowsAffected;
                string errorMessage;


                rowsAffected = ClientValidation.UpdateClient(client);
                
                if (rowsAffected > 0)
                {
                    ClientModel.Clients = ClientValidation.GetClients();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (rowsAffected == 0)
                    {
                        errorMessage = "No DB changes were made";
                    }
                    else
                    {
                        errorMessage = ClientValidation.ErrorMessage;
                    }

                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        
        private void setTextbox()
        {

        }

        private void SetBindings()
        {
            dTextCompanyName.DataBindings.Add("Text", ClientModel, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
            dTextAddress1.DataBindings.Add("Text", ClientModel, "Address1", false, DataSourceUpdateMode.OnValidation, "");
            dTextAddress2.DataBindings.Add("Text", ClientModel, "Address2", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            dTextCity.DataBindings.Add("Text", ClientModel, "City", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            dTextProvince.DataBindings.Add("Text", ClientModel, "Province", false, DataSourceUpdateMode.OnValidation, "");
            dTextPostalCode.DataBindings.Add("Text", ClientModel, "PostalCode", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            dTextSales.DataBindings.Add("Text", ClientModel, "YtdSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            dTextNotes.DataBindings.Add("Text", ClientModel, "Notes", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");

            dBoxCreditHold.DataBindings.Add("Checked", ClientModel, "IsCreditHold");
        }

        
    }
}
