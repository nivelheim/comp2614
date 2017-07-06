namespace COMP2614Assign05
{
    partial class DateForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateForm));
            this.validateButton = new System.Windows.Forms.Button();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.validateLabel = new System.Windows.Forms.Label();
            this.toolTipOnLabel = new System.Windows.Forms.ToolTip(this.components);
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(189, 80);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(83, 24);
            this.validateButton.TabIndex = 3;
            this.validateButton.Text = "&Check Date";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(12, 37);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(80, 21);
            this.yearBox.TabIndex = 0;
            this.yearBox.Enter += new System.EventHandler(this.textBox_Click);
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(101, 37);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(80, 21);
            this.monthBox.TabIndex = 1;
            this.monthBox.Enter += new System.EventHandler(this.textBox_Click);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(192, 37);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(80, 21);
            this.dateBox.TabIndex = 2;
            this.dateBox.Enter += new System.EventHandler(this.textBox_Click);
            // 
            // validateLabel
            // 
            this.validateLabel.AutoSize = true;
            this.validateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.validateLabel.Location = new System.Drawing.Point(12, 80);
            this.validateLabel.Name = "validateLabel";
            this.validateLabel.Size = new System.Drawing.Size(0, 24);
            this.validateLabel.TabIndex = 0;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 22);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(35, 12);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "&Year:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(99, 22);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(44, 12);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "&Month:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(190, 22);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(31, 12);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "&Day:";
            // 
            // DateForm
            // 
            this.AcceptButton = this.validateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.validateLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.validateButton);
            this.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DateForm";
            this.Text = "Date Validator";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label validateLabel;
        private System.Windows.Forms.ToolTip toolTipOnLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}

