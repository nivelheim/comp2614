namespace COMP2614Assign06
{
    partial class Dialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dLabelCompanyName = new System.Windows.Forms.Label();
            this.dLabelAddress1 = new System.Windows.Forms.Label();
            this.dLabelAddress2 = new System.Windows.Forms.Label();
            this.dLabelCity = new System.Windows.Forms.Label();
            this.dLabelProvince = new System.Windows.Forms.Label();
            this.dLabelPostalCode = new System.Windows.Forms.Label();
            this.dLabelSales = new System.Windows.Forms.Label();
            this.dLabelNotes = new System.Windows.Forms.Label();
            this.dBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.dButtonOk = new System.Windows.Forms.Button();
            this.dButtonCancel = new System.Windows.Forms.Button();
            this.dTextCompanyName = new System.Windows.Forms.TextBox();
            this.dTextAddress1 = new System.Windows.Forms.TextBox();
            this.dTextAddress2 = new System.Windows.Forms.TextBox();
            this.dTextCity = new System.Windows.Forms.TextBox();
            this.dTextSales = new System.Windows.Forms.TextBox();
            this.dTextNotes = new System.Windows.Forms.TextBox();
            this.dLabelClientCode = new System.Windows.Forms.Label();
            this.dMaskProvince = new System.Windows.Forms.MaskedTextBox();
            this.dMaskPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.dTextClientCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dLabelCompanyName
            // 
            this.dLabelCompanyName.AutoSize = true;
            this.dLabelCompanyName.Location = new System.Drawing.Point(22, 66);
            this.dLabelCompanyName.Name = "dLabelCompanyName";
            this.dLabelCompanyName.Size = new System.Drawing.Size(98, 12);
            this.dLabelCompanyName.TabIndex = 2;
            this.dLabelCompanyName.Text = "&Company Name";
            // 
            // dLabelAddress1
            // 
            this.dLabelAddress1.AutoSize = true;
            this.dLabelAddress1.Location = new System.Drawing.Point(22, 100);
            this.dLabelAddress1.Name = "dLabelAddress1";
            this.dLabelAddress1.Size = new System.Drawing.Size(62, 12);
            this.dLabelAddress1.TabIndex = 4;
            this.dLabelAddress1.Text = "Address &1";
            // 
            // dLabelAddress2
            // 
            this.dLabelAddress2.AutoSize = true;
            this.dLabelAddress2.Location = new System.Drawing.Point(22, 136);
            this.dLabelAddress2.Name = "dLabelAddress2";
            this.dLabelAddress2.Size = new System.Drawing.Size(62, 12);
            this.dLabelAddress2.TabIndex = 6;
            this.dLabelAddress2.Text = "Address &2";
            // 
            // dLabelCity
            // 
            this.dLabelCity.AutoSize = true;
            this.dLabelCity.Location = new System.Drawing.Point(22, 173);
            this.dLabelCity.Name = "dLabelCity";
            this.dLabelCity.Size = new System.Drawing.Size(27, 12);
            this.dLabelCity.TabIndex = 8;
            this.dLabelCity.Text = "Ci&ty";
            // 
            // dLabelProvince
            // 
            this.dLabelProvince.AutoSize = true;
            this.dLabelProvince.Location = new System.Drawing.Point(22, 208);
            this.dLabelProvince.Name = "dLabelProvince";
            this.dLabelProvince.Size = new System.Drawing.Size(54, 12);
            this.dLabelProvince.TabIndex = 10;
            this.dLabelProvince.Text = "&Province";
            // 
            // dLabelPostalCode
            // 
            this.dLabelPostalCode.AutoSize = true;
            this.dLabelPostalCode.Location = new System.Drawing.Point(22, 244);
            this.dLabelPostalCode.Name = "dLabelPostalCode";
            this.dLabelPostalCode.Size = new System.Drawing.Size(74, 12);
            this.dLabelPostalCode.TabIndex = 12;
            this.dLabelPostalCode.Text = "Postal C&ode";
            // 
            // dLabelSales
            // 
            this.dLabelSales.AutoSize = true;
            this.dLabelSales.Location = new System.Drawing.Point(22, 280);
            this.dLabelSales.Name = "dLabelSales";
            this.dLabelSales.Size = new System.Drawing.Size(65, 12);
            this.dLabelSales.TabIndex = 14;
            this.dLabelSales.Text = "&YTD Sales";
            // 
            // dLabelNotes
            // 
            this.dLabelNotes.AutoSize = true;
            this.dLabelNotes.Location = new System.Drawing.Point(22, 315);
            this.dLabelNotes.Name = "dLabelNotes";
            this.dLabelNotes.Size = new System.Drawing.Size(38, 12);
            this.dLabelNotes.TabIndex = 16;
            this.dLabelNotes.Text = "&Notes";
            // 
            // dBoxCreditHold
            // 
            this.dBoxCreditHold.AutoSize = true;
            this.dBoxCreditHold.Location = new System.Drawing.Point(129, 360);
            this.dBoxCreditHold.Name = "dBoxCreditHold";
            this.dBoxCreditHold.Size = new System.Drawing.Size(86, 16);
            this.dBoxCreditHold.TabIndex = 18;
            this.dBoxCreditHold.Text = "Credit &Hold";
            this.dBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // dButtonOk
            // 
            this.dButtonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dButtonOk.Location = new System.Drawing.Point(129, 403);
            this.dButtonOk.Name = "dButtonOk";
            this.dButtonOk.Size = new System.Drawing.Size(75, 23);
            this.dButtonOk.TabIndex = 19;
            this.dButtonOk.Text = "OK";
            this.dButtonOk.UseVisualStyleBackColor = true;
            this.dButtonOk.Click += new System.EventHandler(this.dButtonOk_Click);
            // 
            // dButtonCancel
            // 
            this.dButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dButtonCancel.Location = new System.Drawing.Point(237, 403);
            this.dButtonCancel.Name = "dButtonCancel";
            this.dButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.dButtonCancel.TabIndex = 20;
            this.dButtonCancel.Text = "Cancel";
            this.dButtonCancel.UseVisualStyleBackColor = true;
            this.dButtonCancel.Click += new System.EventHandler(this.dButtonCancel_Click);
            // 
            // dTextCompanyName
            // 
            this.dTextCompanyName.Location = new System.Drawing.Point(129, 63);
            this.dTextCompanyName.Name = "dTextCompanyName";
            this.dTextCompanyName.Size = new System.Drawing.Size(153, 21);
            this.dTextCompanyName.TabIndex = 3;
            // 
            // dTextAddress1
            // 
            this.dTextAddress1.Location = new System.Drawing.Point(129, 97);
            this.dTextAddress1.Name = "dTextAddress1";
            this.dTextAddress1.Size = new System.Drawing.Size(153, 21);
            this.dTextAddress1.TabIndex = 5;
            // 
            // dTextAddress2
            // 
            this.dTextAddress2.Location = new System.Drawing.Point(129, 133);
            this.dTextAddress2.Name = "dTextAddress2";
            this.dTextAddress2.Size = new System.Drawing.Size(153, 21);
            this.dTextAddress2.TabIndex = 7;
            // 
            // dTextCity
            // 
            this.dTextCity.Location = new System.Drawing.Point(129, 170);
            this.dTextCity.Name = "dTextCity";
            this.dTextCity.Size = new System.Drawing.Size(109, 21);
            this.dTextCity.TabIndex = 9;
            // 
            // dTextSales
            // 
            this.dTextSales.Location = new System.Drawing.Point(129, 277);
            this.dTextSales.Name = "dTextSales";
            this.dTextSales.Size = new System.Drawing.Size(109, 21);
            this.dTextSales.TabIndex = 15;
            // 
            // dTextNotes
            // 
            this.dTextNotes.Location = new System.Drawing.Point(129, 312);
            this.dTextNotes.Name = "dTextNotes";
            this.dTextNotes.Size = new System.Drawing.Size(183, 21);
            this.dTextNotes.TabIndex = 17;
            // 
            // dLabelClientCode
            // 
            this.dLabelClientCode.AutoSize = true;
            this.dLabelClientCode.Location = new System.Drawing.Point(22, 31);
            this.dLabelClientCode.Name = "dLabelClientCode";
            this.dLabelClientCode.Size = new System.Drawing.Size(75, 12);
            this.dLabelClientCode.TabIndex = 0;
            this.dLabelClientCode.Text = "Client Co&de:";
            // 
            // dMaskProvince
            // 
            this.dMaskProvince.Location = new System.Drawing.Point(129, 205);
            this.dMaskProvince.Mask = ">A>A";
            this.dMaskProvince.Name = "dMaskProvince";
            this.dMaskProvince.Size = new System.Drawing.Size(75, 21);
            this.dMaskProvince.TabIndex = 11;
            // 
            // dMaskPostalCode
            // 
            this.dMaskPostalCode.Location = new System.Drawing.Point(129, 241);
            this.dMaskPostalCode.Mask = ">A9>A 9>A9";
            this.dMaskPostalCode.Name = "dMaskPostalCode";
            this.dMaskPostalCode.Size = new System.Drawing.Size(75, 21);
            this.dMaskPostalCode.TabIndex = 13;
            // 
            // dTextClientCode
            // 
            this.dTextClientCode.Location = new System.Drawing.Point(129, 28);
            this.dTextClientCode.Name = "dTextClientCode";
            this.dTextClientCode.ReadOnly = true;
            this.dTextClientCode.Size = new System.Drawing.Size(153, 21);
            this.dTextClientCode.TabIndex = 1;
            // 
            // Dialog
            // 
            this.AcceptButton = this.dButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.dButtonCancel;
            this.ClientSize = new System.Drawing.Size(340, 438);
            this.Controls.Add(this.dTextClientCode);
            this.Controls.Add(this.dMaskPostalCode);
            this.Controls.Add(this.dMaskProvince);
            this.Controls.Add(this.dLabelClientCode);
            this.Controls.Add(this.dTextNotes);
            this.Controls.Add(this.dTextSales);
            this.Controls.Add(this.dTextCity);
            this.Controls.Add(this.dTextAddress2);
            this.Controls.Add(this.dTextAddress1);
            this.Controls.Add(this.dTextCompanyName);
            this.Controls.Add(this.dButtonCancel);
            this.Controls.Add(this.dButtonOk);
            this.Controls.Add(this.dBoxCreditHold);
            this.Controls.Add(this.dLabelNotes);
            this.Controls.Add(this.dLabelSales);
            this.Controls.Add(this.dLabelPostalCode);
            this.Controls.Add(this.dLabelProvince);
            this.Controls.Add(this.dLabelCity);
            this.Controls.Add(this.dLabelAddress2);
            this.Controls.Add(this.dLabelAddress1);
            this.Controls.Add(this.dLabelCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Record";
            this.Load += new System.EventHandler(this.Dialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dLabelCompanyName;
        private System.Windows.Forms.Label dLabelAddress1;
        private System.Windows.Forms.Label dLabelAddress2;
        private System.Windows.Forms.Label dLabelCity;
        private System.Windows.Forms.Label dLabelProvince;
        private System.Windows.Forms.Label dLabelPostalCode;
        private System.Windows.Forms.Label dLabelSales;
        private System.Windows.Forms.Label dLabelNotes;
        private System.Windows.Forms.CheckBox dBoxCreditHold;
        private System.Windows.Forms.Button dButtonOk;
        private System.Windows.Forms.Button dButtonCancel;
        private System.Windows.Forms.TextBox dTextCompanyName;
        private System.Windows.Forms.TextBox dTextAddress1;
        private System.Windows.Forms.TextBox dTextAddress2;
        private System.Windows.Forms.TextBox dTextCity;
        private System.Windows.Forms.TextBox dTextSales;
        private System.Windows.Forms.TextBox dTextNotes;
        private System.Windows.Forms.Label dLabelClientCode;
        private System.Windows.Forms.MaskedTextBox dMaskProvince;
        private System.Windows.Forms.MaskedTextBox dMaskPostalCode;
        private System.Windows.Forms.TextBox dTextClientCode;
    }
}