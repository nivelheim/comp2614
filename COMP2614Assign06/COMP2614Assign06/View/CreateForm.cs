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
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace COMP2614Assign06.View
{
    /// <summary>
    /// This form is used for creating new user record
    /// </summary>
    public partial class CreateForm : Form
    {
        //ErrorProvider used for validation 
        private ErrorProvider errorProvider = new ErrorProvider();

        public CreateForm()
        {
            InitializeComponent();
        }

        //Called everytime Add Record form is opened
        private void CreateForm_Load(object sender, EventArgs e)
        {
            errorProvider.SetError(cButtonOk, String.Empty);
        }

        //Called everytime the OK button is clicked
        private void cButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(cMaskTextClientCode.Text
                                            , cTextCompanyName.Text
                                            , cTextAddress1.Text
                                            , cTextAddress2.Text
                                            , cTextCity.Text
                                            , cMaskTextProvince.Text
                                            , cMaskTextPostalCode.Text
                                            , Int32.Parse(cTextSales.Text)
                                            , cCheckBoxHold.Checked
                                            , cTextNotes.Text);
                int rowsAffected;
                string errorMessage;


                rowsAffected = ClientValidation.AddClient(client);

                if (rowsAffected > 0)
                {
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

                    //Sets error next to the OK button
                    errorProvider.SetError(cButtonOk, ClientValidation.ErrorMessage);
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

        /*
        private bool formValidation()
        {
            bool validationResult = true;

            String regexClientCode = @"[A-Z][A-Z][A-Z][A-Z][A-Z]";
            String regexProvince = @"[A-Z][A-Z]";
            String regexPostalCode = @"[A-Z]\d[A-Z] \d[A-Z]\d";

            String errorMessage;

            if (!Regex.IsMatch(cMaskTextClientCode.Text, regexClientCode))
            {
                errorProvider.SetError(cButtonOk, "Client Code must be in AAAAA format");
                validationResult = false;
            }
            else
            {
                errorProvider.SetError(cButtonOk, string.Empty);
            }

            if (!Regex.IsMatch(cMaskTextProvince.Text, regexProvince))
            {
                errorProvider.SetError(cButtonOk, "Provincial must be in AA format");
                validationResult = false;
            }
            else
            {
                errorProvider.SetError(cButtonOk, string.Empty);
            }

            if (!Regex.IsMatch(cMaskTextPostalCode.Text, regexPostalCode))
            {
                errorProvider.SetError(cButtonOk, "Postal Code must be in A9A 9A9 format");
                validationResult = false;
            }
            else
            {
                errorProvider.SetError(cButtonOk, string.Empty);
            }

            return validationResult;
        }
        */
    }
}
