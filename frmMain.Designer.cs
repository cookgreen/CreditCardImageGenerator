namespace VisaCardImageGenerator
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCardValidDate = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Card ValidDate";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(135, 6);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PlaceholderText = "Card Number ";
            this.txtCardNumber.Size = new System.Drawing.Size(415, 27);
            this.txtCardNumber.TabIndex = 3;
            this.txtCardNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtCardNumber_Validating);
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(135, 41);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.PlaceholderText = "Card Name";
            this.txtCardName.Size = new System.Drawing.Size(415, 27);
            this.txtCardName.TabIndex = 4;
            // 
            // txtCardValidDate
            // 
            this.txtCardValidDate.Location = new System.Drawing.Point(135, 78);
            this.txtCardValidDate.Name = "txtCardValidDate";
            this.txtCardValidDate.PlaceholderText = "MM/YY";
            this.txtCardValidDate.Size = new System.Drawing.Size(125, 27);
            this.txtCardValidDate.TabIndex = 5;
            this.txtCardValidDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtCardValidDate_Validating);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(358, 113);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(192, 72);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 197);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtCardValidDate);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visa Card Image Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCardNumber;
        private TextBox txtCardName;
        private TextBox txtCardValidDate;
        private Button btnExport;
    }
}