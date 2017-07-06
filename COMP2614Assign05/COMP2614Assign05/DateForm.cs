using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign05
{
    public partial class DateForm : Form
    {
        bool status;
        private System.Windows.Forms.ToolTip labelTooltip;

        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This click action is for validation
        /// sets text, color, and tooltips depending on the return value of DateValidator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validateButton_Click(object sender, EventArgs e)
        {
            status = DateValidator.validateInput(yearBox.Text, monthBox.Text, dateBox.Text);
            if (status == false)
            {
                validateLabel.Text = "Invalid";
                validateLabel.ForeColor = Color.FromKnownColor(KnownColor.Crimson);
                toolTipOnLabel.SetToolTip(validateLabel, "Entered Date is invalid");
            }

            else
            {
                validateLabel.Text = "Valid";
                validateLabel.ForeColor = Color.FromKnownColor(KnownColor.ForestGreen);
                toolTipOnLabel.SetToolTip(validateLabel, "Entered Date is valid");
            }

        }

        /// <summary>
        /// Selects all the text from the TextBox with focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }
    }
}
