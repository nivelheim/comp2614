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
using System.Text.RegularExpressions;

namespace COMP2614Assign06
{
    /// <summary>
    /// This form is used for Edit Record dialog
    /// </summary>
    public partial class Dialog : Form
    {
        //Error provider for validation messages
        private ErrorProvider errorProvider = new ErrorProvider();
        public ClientViewModel ClientModel { get; set; }    //For displaying purposes
        public int SelectedRow { get; set; }                //Currently selected row from GridView
        public bool BindingSet { get; set; } = false;       //To check if binding is already set

        public Dialog(MainForm form)
        {
            //main = form;
            //this.FormClosing += new FormClosingEventHandler(this.dButtonOk_Click);
            InitializeComponent();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            //Set textbox with ClientModel passed from main form
            ClientModel.SetDisplayingClient(ClientModel.Clients[SelectedRow]);

            //To check if bindings are already set to textboxes
            if (BindingSet == false)
            {
                SetBindings();
                BindingSet = true;
            }

            //Clear error icon when opening this dialog
            errorProvider.SetError(dButtonOk, String.Empty);

        }

        private void dButtonOk_Click(object sender, EventArgs e)
        {
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

                    //Set error next to the OK button
                    errorProvider.SetError(dButtonOk, ClientValidation.ErrorMessage);
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
        }  
        
        private void setTextbox()
        {

        }

        //This method binds VM passed from main form to the textboxes in this form
        private void SetBindings()
        {
            dTextClientCode.DataBindings.Add("Text", ClientModel, "ClientCode", false, DataSourceUpdateMode.OnValidation, "");
            dTextCompanyName.DataBindings.Add("Text", ClientModel, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
            dTextAddress1.DataBindings.Add("Text", ClientModel, "Address1", false, DataSourceUpdateMode.OnValidation, "");
            dTextAddress2.DataBindings.Add("Text", ClientModel, "Address2", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            dTextCity.DataBindings.Add("Text", ClientModel, "City", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            dMaskProvince.DataBindings.Add("Text", ClientModel, "Province", false, DataSourceUpdateMode.OnValidation, "");
            dMaskPostalCode.DataBindings.Add("Text", ClientModel, "PostalCode", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");
            dTextSales.DataBindings.Add("Text", ClientModel, "YtdSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            dTextNotes.DataBindings.Add("Text", ClientModel, "Notes", true, DataSourceUpdateMode.OnValidation, "[Not Applicable]");

            dBoxCreditHold.DataBindings.Add("Checked", ClientModel, "IsCreditHold", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void dButtonCancel_Click(object sender, EventArgs e)
        {

        }

        //No longer used
        private bool formValidation()
        {
           

            bool validationResult = true;

            String regexProvince = @"[A-Z][A-Z]";
            String regexPostalCode = @"[A-Z]\d[A-Z] \d[A-Z]\d";

            if (!Regex.IsMatch(dMaskProvince.Text, regexProvince))
            {
                errorProvider.SetError(dButtonOk, "Provincial must be in AA format");
                validationResult = false;
            }
            else
            {
                errorProvider.SetError(dButtonOk, string.Empty);
            }

            if (!Regex.IsMatch(dMaskPostalCode.Text, regexPostalCode))
            {
                errorProvider.SetError(dButtonOk, "Postal Code must be in A9A 9A9 format");
                validationResult = false;
            }
            else
            {
                errorProvider.SetError(dButtonOk, string.Empty);
            }

            return validationResult;
        }
    }
}
