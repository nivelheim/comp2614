namespace COMP2614Assign06
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mainEditButton = new System.Windows.Forms.Button();
            this.mainLabelTotal = new System.Windows.Forms.Label();
            this.mainLabelOutput = new System.Windows.Forms.Label();
            this.mainAddButton = new System.Windows.Forms.Button();
            this.mainDeleteButton = new System.Windows.Forms.Button();
            this.mainCheckBox = new System.Windows.Forms.CheckBox();
            this.mainTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(30, 102);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(680, 249);
            this.dataGridViewClients.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data&Grid";
            // 
            // mainEditButton
            // 
            this.mainEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainEditButton.Location = new System.Drawing.Point(616, 368);
            this.mainEditButton.Name = "mainEditButton";
            this.mainEditButton.Size = new System.Drawing.Size(94, 23);
            this.mainEditButton.TabIndex = 8;
            this.mainEditButton.Text = "&Edit Record";
            this.mainEditButton.UseVisualStyleBackColor = true;
            this.mainEditButton.Click += new System.EventHandler(this.mainEditButton_Click);
            // 
            // mainLabelTotal
            // 
            this.mainLabelTotal.AutoSize = true;
            this.mainLabelTotal.Location = new System.Drawing.Point(501, 24);
            this.mainLabelTotal.Name = "mainLabelTotal";
            this.mainLabelTotal.Size = new System.Drawing.Size(115, 36);
            this.mainLabelTotal.TabIndex = 1;
            this.mainLabelTotal.Text = "Total YTD Sales:\r\n\r\nCredit Hold Counts:\r\n";
            // 
            // mainLabelOutput
            // 
            this.mainLabelOutput.AutoSize = true;
            this.mainLabelOutput.Location = new System.Drawing.Point(632, 24);
            this.mainLabelOutput.Name = "mainLabelOutput";
            this.mainLabelOutput.Size = new System.Drawing.Size(0, 12);
            this.mainLabelOutput.TabIndex = 2;
            this.mainLabelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainAddButton
            // 
            this.mainAddButton.Location = new System.Drawing.Point(383, 368);
            this.mainAddButton.Name = "mainAddButton";
            this.mainAddButton.Size = new System.Drawing.Size(92, 23);
            this.mainAddButton.TabIndex = 6;
            this.mainAddButton.Text = "&Add Record";
            this.mainAddButton.UseVisualStyleBackColor = true;
            this.mainAddButton.Click += new System.EventHandler(this.mainAddButton_Click);
            // 
            // mainDeleteButton
            // 
            this.mainDeleteButton.Location = new System.Drawing.Point(497, 368);
            this.mainDeleteButton.Name = "mainDeleteButton";
            this.mainDeleteButton.Size = new System.Drawing.Size(100, 23);
            this.mainDeleteButton.TabIndex = 7;
            this.mainDeleteButton.Text = "&Delete Record";
            this.mainDeleteButton.UseVisualStyleBackColor = true;
            this.mainDeleteButton.Click += new System.EventHandler(this.mainDeleteButton_Click);
            // 
            // mainCheckBox
            // 
            this.mainCheckBox.AutoSize = true;
            this.mainCheckBox.Location = new System.Drawing.Point(244, 372);
            this.mainCheckBox.Name = "mainCheckBox";
            this.mainCheckBox.Size = new System.Drawing.Size(115, 16);
            this.mainCheckBox.TabIndex = 5;
            this.mainCheckBox.Text = "Disable &warning";
            this.mainCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainTitle.Location = new System.Drawing.Point(30, 24);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(320, 27);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "COMP2614 Final Project";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 410);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.mainCheckBox);
            this.Controls.Add(this.mainDeleteButton);
            this.Controls.Add(this.mainAddButton);
            this.Controls.Add(this.mainLabelOutput);
            this.Controls.Add(this.mainLabelTotal);
            this.Controls.Add(this.mainEditButton);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMP2614 Final Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainEditButton;
        private System.Windows.Forms.Label mainLabelTotal;
        private System.Windows.Forms.Label mainLabelOutput;
        private System.Windows.Forms.Button mainAddButton;
        private System.Windows.Forms.Button mainDeleteButton;
        private System.Windows.Forms.CheckBox mainCheckBox;
        private System.Windows.Forms.Label mainTitle;
    }
}

