namespace KenHttpClientTestAppForInterfax
{
    partial class DlgFaxPdfDocument
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFaxDestinations = new System.Windows.Forms.DataGridView();
            this.Column_FaxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FaxContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FaxSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCSID = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFaxDocumentFilename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleLine = new System.Windows.Forms.Label();
            this.buttonCancelFax = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSendFax = new System.Windows.Forms.Button();
            this.textBoxFaxDocumentFolderName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaxDestinations)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(518, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(580, 750);
            this.webBrowser1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(102, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(319, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Appears on FAX Header for {To} variable and in email subject line.\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 340);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "CSID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Contact:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Appears on Subject column of online InterFAX Outbound Queue and in email body.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Subject:";
            // 
            // dataGridViewFaxDestinations
            // 
            this.dataGridViewFaxDestinations.AllowUserToAddRows = false;
            this.dataGridViewFaxDestinations.AllowUserToDeleteRows = false;
            this.dataGridViewFaxDestinations.AllowUserToResizeRows = false;
            this.dataGridViewFaxDestinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaxDestinations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_FaxNumber,
            this.Column_FaxContact,
            this.Column_FaxSubject});
            this.dataGridViewFaxDestinations.Location = new System.Drawing.Point(12, 401);
            this.dataGridViewFaxDestinations.MultiSelect = false;
            this.dataGridViewFaxDestinations.Name = "dataGridViewFaxDestinations";
            this.dataGridViewFaxDestinations.ReadOnly = true;
            this.dataGridViewFaxDestinations.RowHeadersVisible = false;
            this.dataGridViewFaxDestinations.Size = new System.Drawing.Size(488, 120);
            this.dataGridViewFaxDestinations.TabIndex = 58;
            // 
            // Column_FaxNumber
            // 
            this.Column_FaxNumber.HeaderText = "Fax Number";
            this.Column_FaxNumber.Name = "Column_FaxNumber";
            this.Column_FaxNumber.ReadOnly = true;
            // 
            // Column_FaxContact
            // 
            this.Column_FaxContact.HeaderText = "Contact";
            this.Column_FaxContact.Name = "Column_FaxContact";
            this.Column_FaxContact.ReadOnly = true;
            this.Column_FaxContact.Width = 120;
            // 
            // Column_FaxSubject
            // 
            this.Column_FaxSubject.HeaderText = "Subject";
            this.Column_FaxSubject.Name = "Column_FaxSubject";
            this.Column_FaxSubject.ReadOnly = true;
            this.Column_FaxSubject.Width = 250;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(329, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Appears on FAX Header for {From} variable and in email subject line.\r\n";
            // 
            // textBoxCSID
            // 
            this.textBoxCSID.Location = new System.Drawing.Point(125, 250);
            this.textBoxCSID.Name = "textBoxCSID";
            this.textBoxCSID.ReadOnly = true;
            this.textBoxCSID.Size = new System.Drawing.Size(309, 20);
            this.textBoxCSID.TabIndex = 54;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(125, 224);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.ReadOnly = true;
            this.textBoxSubject.Size = new System.Drawing.Size(309, 20);
            this.textBoxSubject.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "CSID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fax document file name:";
            // 
            // textBoxFaxDocumentFilename
            // 
            this.textBoxFaxDocumentFilename.Location = new System.Drawing.Point(18, 198);
            this.textBoxFaxDocumentFilename.Name = "textBoxFaxDocumentFilename";
            this.textBoxFaxDocumentFilename.ReadOnly = true;
            this.textBoxFaxDocumentFilename.Size = new System.Drawing.Size(488, 20);
            this.textBoxFaxDocumentFilename.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(475, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "The PDF file on the right half of this screen is the document that will be faxed " +
    "---->";
            // 
            // TitleLine
            // 
            this.TitleLine.AutoSize = true;
            this.TitleLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLine.ForeColor = System.Drawing.Color.Blue;
            this.TitleLine.Location = new System.Drawing.Point(20, 106);
            this.TitleLine.Name = "TitleLine";
            this.TitleLine.Size = new System.Drawing.Size(248, 20);
            this.TitleLine.TabIndex = 42;
            this.TitleLine.Text = "Information for fax to be sent.";
            // 
            // buttonCancelFax
            // 
            this.buttonCancelFax.Location = new System.Drawing.Point(359, 540);
            this.buttonCancelFax.Name = "buttonCancelFax";
            this.buttonCancelFax.Size = new System.Drawing.Size(141, 23);
            this.buttonCancelFax.TabIndex = 47;
            this.buttonCancelFax.Text = "Cancel Fax Request";
            this.buttonCancelFax.UseVisualStyleBackColor = true;
            this.buttonCancelFax.Click += new System.EventHandler(this.buttonCancelFax_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fax document folder:";
            // 
            // buttonSendFax
            // 
            this.buttonSendFax.Location = new System.Drawing.Point(194, 540);
            this.buttonSendFax.Name = "buttonSendFax";
            this.buttonSendFax.Size = new System.Drawing.Size(141, 23);
            this.buttonSendFax.TabIndex = 46;
            this.buttonSendFax.Text = "Send Fax";
            this.buttonSendFax.UseVisualStyleBackColor = true;
            this.buttonSendFax.Click += new System.EventHandler(this.buttonSendFax_Click);
            // 
            // textBoxFaxDocumentFolderName
            // 
            this.textBoxFaxDocumentFolderName.Location = new System.Drawing.Point(18, 151);
            this.textBoxFaxDocumentFolderName.Name = "textBoxFaxDocumentFolderName";
            this.textBoxFaxDocumentFolderName.ReadOnly = true;
            this.textBoxFaxDocumentFolderName.Size = new System.Drawing.Size(488, 20);
            this.textBoxFaxDocumentFolderName.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(20, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "*** Destinations. ***";
            // 
            // DlgFaxPdfDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 778);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFaxDestinations);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxCSID);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFaxDocumentFilename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TitleLine);
            this.Controls.Add(this.buttonCancelFax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSendFax);
            this.Controls.Add(this.textBoxFaxDocumentFolderName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.webBrowser1);
            this.Name = "DlgFaxPdfDocument";
            this.Text = "DlgFaxPdfDocument";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DlgFaxPdfDocument_FormClosed);
            this.Load += new System.EventHandler(this.DlgFaxPdfDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaxDestinations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFaxDestinations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FaxNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FaxContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FaxSubject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCSID;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFaxDocumentFilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TitleLine;
        private System.Windows.Forms.Button buttonCancelFax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSendFax;
        private System.Windows.Forms.TextBox textBoxFaxDocumentFolderName;
        private System.Windows.Forms.Label label6;
    }
}