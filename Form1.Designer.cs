namespace KenHttpClientTestAppForInterfax
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTest1Balance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSimulatorFaxNumberSuccess = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTest2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSimulatorFaxNumberFailure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTest2FaxID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTest3BatchID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonTest3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTest4BatchID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonTest4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTest4ListChildFaxIDs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTest5ListIDs = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonTest5 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxCtrFaxDetailsInResponse = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNextImage = new System.Windows.Forms.Button();
            this.buttonPrevImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTest7 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxTest7FaxID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxPageNofN = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.checkBoxSaveImageAsTif = new System.Windows.Forms.CheckBox();
            this.buttonTest3A = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.Column_Test5id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Test5status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Test5units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Test5costPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Test5SenderCSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Test5contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Test5DestFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Test5subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ken\'s test application for KenHttpClientLibraryForInterfax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Test 1:  GetPrePaidCardBalance";
            // 
            // buttonTest1
            // 
            this.buttonTest1.Location = new System.Drawing.Point(108, 224);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(75, 23);
            this.buttonTest1.TabIndex = 3;
            this.buttonTest1.Text = "Test 1";
            this.buttonTest1.UseVisualStyleBackColor = true;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance: ";
            // 
            // textBoxTest1Balance
            // 
            this.textBoxTest1Balance.Location = new System.Drawing.Point(256, 227);
            this.textBoxTest1Balance.Name = "textBoxTest1Balance";
            this.textBoxTest1Balance.ReadOnly = true;
            this.textBoxTest1Balance.Size = new System.Drawing.Size(100, 20);
            this.textBoxTest1Balance.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(603, 64);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // textBoxSimulatorFaxNumberSuccess
            // 
            this.textBoxSimulatorFaxNumberSuccess.Location = new System.Drawing.Point(237, 130);
            this.textBoxSimulatorFaxNumberSuccess.Name = "textBoxSimulatorFaxNumberSuccess";
            this.textBoxSimulatorFaxNumberSuccess.ReadOnly = true;
            this.textBoxSimulatorFaxNumberSuccess.Size = new System.Drawing.Size(100, 20);
            this.textBoxSimulatorFaxNumberSuccess.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Simulator fax number (success):";
            // 
            // buttonTest2
            // 
            this.buttonTest2.Location = new System.Drawing.Point(108, 301);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(75, 23);
            this.buttonTest2.TabIndex = 8;
            this.buttonTest2.Text = "Test 2";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(598, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Test 2:  SendFaxToSingleDestination - send 2-page fax to the Interfax simulator f" +
    "ax number(success)";
            // 
            // textBoxSimulatorFaxNumberFailure
            // 
            this.textBoxSimulatorFaxNumberFailure.Location = new System.Drawing.Point(237, 156);
            this.textBoxSimulatorFaxNumberFailure.Name = "textBoxSimulatorFaxNumberFailure";
            this.textBoxSimulatorFaxNumberFailure.ReadOnly = true;
            this.textBoxSimulatorFaxNumberFailure.Size = new System.Drawing.Size(100, 20);
            this.textBoxSimulatorFaxNumberFailure.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Simulator fax number (failure):";
            // 
            // textBoxTest2FaxID
            // 
            this.textBoxTest2FaxID.Location = new System.Drawing.Point(252, 301);
            this.textBoxTest2FaxID.Name = "textBoxTest2FaxID";
            this.textBoxTest2FaxID.ReadOnly = true;
            this.textBoxTest2FaxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTest2FaxID.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "faxID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(358, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "You may want to save this faxID for later tests.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkViolet;
            this.label10.Location = new System.Drawing.Point(358, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "You may want to save this batchID for later tests.";
            // 
            // textBoxTest3BatchID
            // 
            this.textBoxTest3BatchID.Location = new System.Drawing.Point(252, 381);
            this.textBoxTest3BatchID.Name = "textBoxTest3BatchID";
            this.textBoxTest3BatchID.ReadOnly = true;
            this.textBoxTest3BatchID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTest3BatchID.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "batchID:";
            // 
            // buttonTest3
            // 
            this.buttonTest3.Location = new System.Drawing.Point(108, 380);
            this.buttonTest3.Name = "buttonTest3";
            this.buttonTest3.Size = new System.Drawing.Size(75, 23);
            this.buttonTest3.TabIndex = 17;
            this.buttonTest3.Text = "Test 3";
            this.buttonTest3.UseVisualStyleBackColor = true;
            this.buttonTest3.Click += new System.EventHandler(this.buttonTest3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(638, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Test 3:  SendFaxToMultipleDestinations- send single page fax to the Interfax simu" +
    "lator fax number(success)";
            // 
            // textBoxTest4BatchID
            // 
            this.textBoxTest4BatchID.Location = new System.Drawing.Point(252, 509);
            this.textBoxTest4BatchID.Name = "textBoxTest4BatchID";
            this.textBoxTest4BatchID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTest4BatchID.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 513);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "batchID:";
            // 
            // buttonTest4
            // 
            this.buttonTest4.Location = new System.Drawing.Point(108, 507);
            this.buttonTest4.Name = "buttonTest4";
            this.buttonTest4.Size = new System.Drawing.Size(75, 23);
            this.buttonTest4.TabIndex = 22;
            this.buttonTest4.Text = "Test 4";
            this.buttonTest4.UseVisualStyleBackColor = true;
            this.buttonTest4.Click += new System.EventHandler(this.buttonTest4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 460);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(495, 32);
            this.label15.TabIndex = 21;
            this.label15.Text = "Test 4:  GetBatchChildFaxes - Gets FaxDetailSummary for each child fax in a batch" +
    ".\r\n              We are only interested in the faxIDs for each fax in the batch." +
    "";
            // 
            // textBoxTest4ListChildFaxIDs
            // 
            this.textBoxTest4ListChildFaxIDs.Location = new System.Drawing.Point(273, 535);
            this.textBoxTest4ListChildFaxIDs.Name = "textBoxTest4ListChildFaxIDs";
            this.textBoxTest4ListChildFaxIDs.ReadOnly = true;
            this.textBoxTest4ListChildFaxIDs.Size = new System.Drawing.Size(263, 20);
            this.textBoxTest4ListChildFaxIDs.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 539);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Child FaxIDs:";
            // 
            // textBoxTest5ListIDs
            // 
            this.textBoxTest5ListIDs.Location = new System.Drawing.Point(266, 638);
            this.textBoxTest5ListIDs.Name = "textBoxTest5ListIDs";
            this.textBoxTest5ListIDs.Size = new System.Drawing.Size(263, 20);
            this.textBoxTest5ListIDs.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 642);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "List FaxIDs:";
            // 
            // buttonTest5
            // 
            this.buttonTest5.Location = new System.Drawing.Point(108, 634);
            this.buttonTest5.Name = "buttonTest5";
            this.buttonTest5.Size = new System.Drawing.Size(75, 23);
            this.buttonTest5.TabIndex = 28;
            this.buttonTest5.Text = "Test 5";
            this.buttonTest5.UseVisualStyleBackColor = true;
            this.buttonTest5.Click += new System.EventHandler(this.buttonTest5_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(41, 582);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(486, 32);
            this.label18.TabIndex = 27;
            this.label18.Text = "Test 5:  GetFaxDetailsViaSearch - Gets FaxDetailAll via Search for a list of faxI" +
    "Ds.\r\n             We only show partial here.";
            // 
            // textBoxCtrFaxDetailsInResponse
            // 
            this.textBoxCtrFaxDetailsInResponse.Location = new System.Drawing.Point(621, 664);
            this.textBoxCtrFaxDetailsInResponse.Name = "textBoxCtrFaxDetailsInResponse";
            this.textBoxCtrFaxDetailsInResponse.ReadOnly = true;
            this.textBoxCtrFaxDetailsInResponse.Size = new System.Drawing.Size(45, 20);
            this.textBoxCtrFaxDetailsInResponse.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(449, 667);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(166, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Number of fax details in response:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Test5id,
            this.Column_Test5status,
            this.Column_Test5units,
            this.Column_Test5costPerUnit,
            this.Column_Test5SenderCSID,
            this.Column_Test5contact,
            this.Column_Test5DestFax,
            this.Column_Test5subject});
            this.dataGridView1.Location = new System.Drawing.Point(44, 690);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(746, 135);
            this.dataGridView1.TabIndex = 45;
            // 
            // buttonNextImage
            // 
            this.buttonNextImage.Location = new System.Drawing.Point(1148, 736);
            this.buttonNextImage.Name = "buttonNextImage";
            this.buttonNextImage.Size = new System.Drawing.Size(64, 23);
            this.buttonNextImage.TabIndex = 52;
            this.buttonNextImage.Text = "Next page";
            this.buttonNextImage.UseVisualStyleBackColor = true;
            this.buttonNextImage.Click += new System.EventHandler(this.buttonNextImage_Click);
            // 
            // buttonPrevImage
            // 
            this.buttonPrevImage.Location = new System.Drawing.Point(1068, 736);
            this.buttonPrevImage.Name = "buttonPrevImage";
            this.buttonPrevImage.Size = new System.Drawing.Size(64, 23);
            this.buttonPrevImage.TabIndex = 51;
            this.buttonPrevImage.Text = "Prev page";
            this.buttonPrevImage.UseVisualStyleBackColor = true;
            this.buttonPrevImage.Click += new System.EventHandler(this.buttonPrevImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(864, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTest7
            // 
            this.buttonTest7.Location = new System.Drawing.Point(932, 47);
            this.buttonTest7.Name = "buttonTest7";
            this.buttonTest7.Size = new System.Drawing.Size(75, 23);
            this.buttonTest7.TabIndex = 46;
            this.buttonTest7.Text = "Test 7";
            this.buttonTest7.UseVisualStyleBackColor = true;
            this.buttonTest7.Click += new System.EventHandler(this.buttonTest7_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(889, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 16);
            this.label19.TabIndex = 53;
            this.label19.Text = "Test 7:  GetFaxImage";
            // 
            // textBoxTest7FaxID
            // 
            this.textBoxTest7FaxID.Location = new System.Drawing.Point(1068, 49);
            this.textBoxTest7FaxID.Name = "textBoxTest7FaxID";
            this.textBoxTest7FaxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTest7FaxID.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1027, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "faxID:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(936, 742);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 56;
            this.label22.Text = "Page:";
            // 
            // textBoxPageNofN
            // 
            this.textBoxPageNofN.Location = new System.Drawing.Point(977, 739);
            this.textBoxPageNofN.Name = "textBoxPageNofN";
            this.textBoxPageNofN.ReadOnly = true;
            this.textBoxPageNofN.Size = new System.Drawing.Size(71, 20);
            this.textBoxPageNofN.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkViolet;
            this.label17.Location = new System.Drawing.Point(542, 507);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "You may want to save these for later tests.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(41, 847);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(387, 64);
            this.label25.TabIndex = 59;
            this.label25.Text = resources.GetString("label25.Text");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(871, 778);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(493, 48);
            this.label24.TabIndex = 60;
            this.label24.Text = resources.GetString("label24.Text");
            // 
            // checkBoxSaveImageAsTif
            // 
            this.checkBoxSaveImageAsTif.AutoSize = true;
            this.checkBoxSaveImageAsTif.Location = new System.Drawing.Point(1033, 18);
            this.checkBoxSaveImageAsTif.Name = "checkBoxSaveImageAsTif";
            this.checkBoxSaveImageAsTif.Size = new System.Drawing.Size(187, 17);
            this.checkBoxSaveImageAsTif.TabIndex = 61;
            this.checkBoxSaveImageAsTif.Text = "Open as PDF (see Note for Test7)";
            this.checkBoxSaveImageAsTif.UseVisualStyleBackColor = true;
            // 
            // buttonTest3A
            // 
            this.buttonTest3A.Location = new System.Drawing.Point(108, 412);
            this.buttonTest3A.Name = "buttonTest3A";
            this.buttonTest3A.Size = new System.Drawing.Size(75, 23);
            this.buttonTest3A.TabIndex = 62;
            this.buttonTest3A.Text = "Test 3a";
            this.buttonTest3A.UseVisualStyleBackColor = true;
            this.buttonTest3A.Click += new System.EventHandler(this.buttonTest3A_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(189, 417);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(225, 13);
            this.label23.TabIndex = 63;
            this.label23.Text = "Display special GUI for faxing a pdf document.";
            // 
            // Column_Test5id
            // 
            this.Column_Test5id.HeaderText = "id";
            this.Column_Test5id.Name = "Column_Test5id";
            this.Column_Test5id.ReadOnly = true;
            this.Column_Test5id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_Test5status
            // 
            this.Column_Test5status.HeaderText = "status";
            this.Column_Test5status.Name = "Column_Test5status";
            this.Column_Test5status.ReadOnly = true;
            this.Column_Test5status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Test5status.Width = 40;
            // 
            // Column_Test5units
            // 
            this.Column_Test5units.HeaderText = "units";
            this.Column_Test5units.Name = "Column_Test5units";
            this.Column_Test5units.ReadOnly = true;
            this.Column_Test5units.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Test5units.Width = 40;
            // 
            // Column_Test5costPerUnit
            // 
            this.Column_Test5costPerUnit.HeaderText = "cost Per Unit";
            this.Column_Test5costPerUnit.Name = "Column_Test5costPerUnit";
            this.Column_Test5costPerUnit.ReadOnly = true;
            this.Column_Test5costPerUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Test5costPerUnit.Width = 60;
            // 
            // Column_Test5SenderCSID
            // 
            this.Column_Test5SenderCSID.HeaderText = "Sender CSID";
            this.Column_Test5SenderCSID.Name = "Column_Test5SenderCSID";
            this.Column_Test5SenderCSID.ReadOnly = true;
            this.Column_Test5SenderCSID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Test5SenderCSID.Width = 80;
            // 
            // Column_Test5contact
            // 
            this.Column_Test5contact.HeaderText = "contact";
            this.Column_Test5contact.Name = "Column_Test5contact";
            this.Column_Test5contact.ReadOnly = true;
            this.Column_Test5contact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Test5contact.Width = 150;
            // 
            // Column_Test5DestFax
            // 
            this.Column_Test5DestFax.HeaderText = "Dest. Fax";
            this.Column_Test5DestFax.Name = "Column_Test5DestFax";
            this.Column_Test5DestFax.ReadOnly = true;
            this.Column_Test5DestFax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_Test5subject
            // 
            this.Column_Test5subject.HeaderText = "subject";
            this.Column_Test5subject.Name = "Column_Test5subject";
            this.Column_Test5subject.ReadOnly = true;
            this.Column_Test5subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Test5subject.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 931);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.buttonTest3A);
            this.Controls.Add(this.checkBoxSaveImageAsTif);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxPageNofN);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBoxTest7FaxID);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.buttonNextImage);
            this.Controls.Add(this.buttonPrevImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonTest7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxCtrFaxDetailsInResponse);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxTest5ListIDs);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonTest5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxTest4ListChildFaxIDs);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxTest4BatchID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonTest4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxTest3BatchID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonTest3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxTest2FaxID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSimulatorFaxNumberFailure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSimulatorFaxNumberSuccess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonTest2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTest1Balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTest1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KenHttpClientTestAppForInterfax";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTest1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTest1Balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSimulatorFaxNumberSuccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTest2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSimulatorFaxNumberFailure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTest2FaxID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTest3BatchID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonTest3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTest4BatchID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonTest4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxTest4ListChildFaxIDs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTest5ListIDs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonTest5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxCtrFaxDetailsInResponse;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNextImage;
        private System.Windows.Forms.Button buttonPrevImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonTest7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxTest7FaxID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxPageNofN;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox checkBoxSaveImageAsTif;
        private System.Windows.Forms.Button buttonTest3A;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Test5id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Test5status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Test5units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Test5costPerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Test5SenderCSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Test5contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Test5DestFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Test5subject;
    }
}

