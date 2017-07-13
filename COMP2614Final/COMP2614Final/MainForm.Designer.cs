namespace COMP2614Final
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelSku = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSkuList = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelExtended = new System.Windows.Forms.Label();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.listBoxSku = new System.Windows.Forms.ListBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxExtended = new System.Windows.Forms.TextBox();
            this.labelLegends = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSku
            // 
            this.labelSku.AutoSize = true;
            this.labelSku.Location = new System.Drawing.Point(173, 61);
            this.labelSku.Name = "labelSku";
            this.labelSku.Size = new System.Drawing.Size(32, 13);
            this.labelSku.TabIndex = 4;
            this.labelSku.Text = "S&KU:";
            this.labelSku.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(173, 26);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "&Quantity:";
            // 
            // labelSkuList
            // 
            this.labelSkuList.AutoSize = true;
            this.labelSkuList.Location = new System.Drawing.Point(1, 3);
            this.labelSkuList.Name = "labelSkuList";
            this.labelSkuList.Size = new System.Drawing.Size(48, 13);
            this.labelSkuList.TabIndex = 0;
            this.labelSkuList.Text = "&SKU List";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(173, 93);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "&Description:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(173, 126);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "&Price:";
            // 
            // labelExtended
            // 
            this.labelExtended.AutoSize = true;
            this.labelExtended.Location = new System.Drawing.Point(173, 158);
            this.labelExtended.Name = "labelExtended";
            this.labelExtended.Size = new System.Drawing.Size(55, 13);
            this.labelExtended.TabIndex = 10;
            this.labelExtended.Text = "Extended:";
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(266, 194);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTaxable.TabIndex = 12;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // listBoxSku
            // 
            this.listBoxSku.FormattingEnabled = true;
            this.listBoxSku.Location = new System.Drawing.Point(1, 19);
            this.listBoxSku.Name = "listBoxSku";
            this.listBoxSku.Size = new System.Drawing.Size(120, 212);
            this.listBoxSku.TabIndex = 1;
            this.listBoxSku.SelectedIndexChanged += new System.EventHandler(this.listBoxSku_SelectedIndexChanged);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(266, 23);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 3;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSku
            // 
            this.textBoxSku.Location = new System.Drawing.Point(266, 58);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(138, 20);
            this.textBoxSku.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(266, 91);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(223, 20);
            this.textBoxDescription.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(266, 124);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(138, 20);
            this.textBoxPrice.TabIndex = 9;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxExtended
            // 
            this.textBoxExtended.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxExtended.Location = new System.Drawing.Point(266, 156);
            this.textBoxExtended.Name = "textBoxExtended";
            this.textBoxExtended.ReadOnly = true;
            this.textBoxExtended.ShortcutsEnabled = false;
            this.textBoxExtended.Size = new System.Drawing.Size(138, 20);
            this.textBoxExtended.TabIndex = 11;
            this.textBoxExtended.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelLegends
            // 
            this.labelLegends.AutoSize = true;
            this.labelLegends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLegends.Location = new System.Drawing.Point(505, 26);
            this.labelLegends.Name = "labelLegends";
            this.labelLegends.Size = new System.Drawing.Size(97, 80);
            this.labelLegends.TabIndex = 14;
            this.labelLegends.Text = "Sub Total:\r\nGST:\r\nPST:\r\nGrand Total:\r\n";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelResults.Location = new System.Drawing.Point(624, 26);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(0, 20);
            this.labelResults.TabIndex = 15;
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(414, 190);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Sa&ve";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 233);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelLegends);
            this.Controls.Add(this.textBoxExtended);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.listBoxSku);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.labelExtended);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSkuList);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelSku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "COMP2614 Final Exam";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSku;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSkuList;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelExtended;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.ListBox listBoxSku;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxExtended;
        private System.Windows.Forms.Label labelLegends;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button buttonSave;
    }
}

