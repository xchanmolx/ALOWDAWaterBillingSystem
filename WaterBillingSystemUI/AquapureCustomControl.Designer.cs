namespace WaterBillingSystemUI
{
    partial class AquapureCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AquapureCustomControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnUserAgreement = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnPaymentForTreasurer = new System.Windows.Forms.Button();
            this.btnPrintWaterReading = new System.Windows.Forms.Button();
            this.btnTransferThenUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.txtPreviousReading = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCustomerCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotalAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRateExcessCubicMeter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCurrentBill = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotalMembers = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtVAT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAmountMinimumCubicMeter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAmountExcessCubicMeter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtExcessCBM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtConsume = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMinimumCubicMeter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRateMinimumCubicMeter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMeterNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCurrentReading = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblALOWDA = new System.Windows.Forms.Label();
            this.lblAquapure = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProviderAquapure = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDatePaid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAmountPaid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBalance = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCreditBalance = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotalDue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPreviousBalance = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPreviousBalancePillipinas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOtherInformation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPriorityLessAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtForTheMonthOf = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbBoxFocus = new System.Windows.Forms.ComboBox();
            this.lblFocus = new System.Windows.Forms.Label();
            this.txtCurrentBillTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPrintOfficeFile = new System.Windows.Forms.Button();
            this.btnPrintMonthlyReading = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.dgvAquapure = new System.Windows.Forms.DataGridView();
            this.btnMayorsAccount = new System.Windows.Forms.Button();
            this.checkBoxLastMonthPrintPayment = new System.Windows.Forms.CheckBox();
            this.checkBoxLastMonthPrintMonthlyReading = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAquapure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAquapure)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxStatus
            // 
            this.cmbBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBoxStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxStatus.FormattingEnabled = true;
            this.cmbBoxStatus.Items.AddRange(new object[] {
            "Status",
            "Connection",
            "Disconnection",
            "Penalty/Warning",
            "Government",
            "PriorityLessCBM"});
            this.cmbBoxStatus.Location = new System.Drawing.Point(536, 326);
            this.cmbBoxStatus.Name = "cmbBoxStatus";
            this.cmbBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxStatus.TabIndex = 7;
            // 
            // btnUserAgreement
            // 
            this.btnUserAgreement.BackColor = System.Drawing.Color.White;
            this.btnUserAgreement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAgreement.FlatAppearance.BorderSize = 0;
            this.btnUserAgreement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAgreement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAgreement.ForeColor = System.Drawing.Color.Black;
            this.btnUserAgreement.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAgreement.Image")));
            this.btnUserAgreement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAgreement.Location = new System.Drawing.Point(724, -5);
            this.btnUserAgreement.Name = "btnUserAgreement";
            this.btnUserAgreement.Size = new System.Drawing.Size(176, 50);
            this.btnUserAgreement.TabIndex = 37;
            this.btnUserAgreement.TabStop = false;
            this.btnUserAgreement.Text = "User Agreement";
            this.btnUserAgreement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserAgreement.UseVisualStyleBackColor = false;
            this.btnUserAgreement.Click += new System.EventHandler(this.btnUserAgreement_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(756, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 50);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Clear";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(670, 377);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 50);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(670, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 34;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.White;
            this.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.Black;
            this.btnReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnReceipt.Image")));
            this.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.Location = new System.Drawing.Point(851, 208);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(127, 50);
            this.btnReceipt.TabIndex = 33;
            this.btnReceipt.TabStop = false;
            this.btnReceipt.Text = "Print Billing Statement";
            this.btnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnPaymentForTreasurer
            // 
            this.btnPaymentForTreasurer.BackColor = System.Drawing.Color.White;
            this.btnPaymentForTreasurer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentForTreasurer.FlatAppearance.BorderSize = 0;
            this.btnPaymentForTreasurer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentForTreasurer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentForTreasurer.ForeColor = System.Drawing.Color.Black;
            this.btnPaymentForTreasurer.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentForTreasurer.Image")));
            this.btnPaymentForTreasurer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentForTreasurer.Location = new System.Drawing.Point(851, 158);
            this.btnPaymentForTreasurer.Name = "btnPaymentForTreasurer";
            this.btnPaymentForTreasurer.Size = new System.Drawing.Size(175, 50);
            this.btnPaymentForTreasurer.TabIndex = 32;
            this.btnPaymentForTreasurer.TabStop = false;
            this.btnPaymentForTreasurer.Text = "Print Payment for Treasurer\'s Office";
            this.btnPaymentForTreasurer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentForTreasurer.UseVisualStyleBackColor = false;
            this.btnPaymentForTreasurer.Click += new System.EventHandler(this.btnPaymentForTreasurer_Click);
            // 
            // btnPrintWaterReading
            // 
            this.btnPrintWaterReading.BackColor = System.Drawing.Color.White;
            this.btnPrintWaterReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintWaterReading.FlatAppearance.BorderSize = 0;
            this.btnPrintWaterReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintWaterReading.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintWaterReading.ForeColor = System.Drawing.Color.Black;
            this.btnPrintWaterReading.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintWaterReading.Image")));
            this.btnPrintWaterReading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintWaterReading.Location = new System.Drawing.Point(851, 108);
            this.btnPrintWaterReading.Name = "btnPrintWaterReading";
            this.btnPrintWaterReading.Size = new System.Drawing.Size(127, 50);
            this.btnPrintWaterReading.TabIndex = 31;
            this.btnPrintWaterReading.TabStop = false;
            this.btnPrintWaterReading.Text = "Print Water Reading";
            this.btnPrintWaterReading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintWaterReading.UseVisualStyleBackColor = false;
            this.btnPrintWaterReading.Click += new System.EventHandler(this.btnPrintWaterReading_Click);
            // 
            // btnTransferThenUpdate
            // 
            this.btnTransferThenUpdate.BackColor = System.Drawing.Color.White;
            this.btnTransferThenUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferThenUpdate.FlatAppearance.BorderSize = 0;
            this.btnTransferThenUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferThenUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferThenUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnTransferThenUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferThenUpdate.Image")));
            this.btnTransferThenUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransferThenUpdate.Location = new System.Drawing.Point(851, 64);
            this.btnTransferThenUpdate.Name = "btnTransferThenUpdate";
            this.btnTransferThenUpdate.Size = new System.Drawing.Size(108, 50);
            this.btnTransferThenUpdate.TabIndex = 30;
            this.btnTransferThenUpdate.TabStop = false;
            this.btnTransferThenUpdate.Text = "Transfer";
            this.btnTransferThenUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransferThenUpdate.UseVisualStyleBackColor = false;
            this.btnTransferThenUpdate.Click += new System.EventHandler(this.btnTransferThenUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(756, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 50);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnForm
            // 
            this.btnForm.BackColor = System.Drawing.Color.White;
            this.btnForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm.FlatAppearance.BorderSize = 0;
            this.btnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm.ForeColor = System.Drawing.Color.Black;
            this.btnForm.Image = ((System.Drawing.Image)(resources.GetObject("btnForm.Image")));
            this.btnForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForm.Location = new System.Drawing.Point(631, -7);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(87, 50);
            this.btnForm.TabIndex = 29;
            this.btnForm.TabStop = false;
            this.btnForm.Text = "Form";
            this.btnForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnForm.UseVisualStyleBackColor = false;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // txtPreviousReading
            // 
            this.txtPreviousReading.BackColor = System.Drawing.Color.White;
            this.txtPreviousReading.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreviousReading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousReading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPreviousReading.HintForeColor = System.Drawing.Color.Empty;
            this.txtPreviousReading.HintText = "Previous Reading";
            this.txtPreviousReading.isPassword = false;
            this.txtPreviousReading.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPreviousReading.LineIdleColor = System.Drawing.Color.Black;
            this.txtPreviousReading.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPreviousReading.LineThickness = 1;
            this.txtPreviousReading.Location = new System.Drawing.Point(177, 353);
            this.txtPreviousReading.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreviousReading.Name = "txtPreviousReading";
            this.txtPreviousReading.Size = new System.Drawing.Size(111, 33);
            this.txtPreviousReading.TabIndex = 5;
            this.txtPreviousReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPreviousReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreviousReading_KeyPress);
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.BackColor = System.Drawing.Color.White;
            this.txtCustomerCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCustomerCode.HintForeColor = System.Drawing.Color.Empty;
            this.txtCustomerCode.HintText = "Customer ID";
            this.txtCustomerCode.isPassword = false;
            this.txtCustomerCode.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCustomerCode.LineIdleColor = System.Drawing.Color.Black;
            this.txtCustomerCode.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCustomerCode.LineThickness = 1;
            this.txtCustomerCode.Location = new System.Drawing.Point(4, 312);
            this.txtCustomerCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(165, 33);
            this.txtCustomerCode.TabIndex = 1;
            this.txtCustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtName.LineIdleColor = System.Drawing.Color.Black;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtName.LineThickness = 1;
            this.txtName.Location = new System.Drawing.Point(4, 353);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 33);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalAmount.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalAmount.HintText = "Total Amount";
            this.txtTotalAmount.isPassword = false;
            this.txtTotalAmount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalAmount.LineIdleColor = System.Drawing.Color.Black;
            this.txtTotalAmount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalAmount.LineThickness = 1;
            this.txtTotalAmount.Location = new System.Drawing.Point(177, 476);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(157, 33);
            this.txtTotalAmount.TabIndex = 42;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRateExcessCubicMeter
            // 
            this.txtRateExcessCubicMeter.BackColor = System.Drawing.Color.White;
            this.txtRateExcessCubicMeter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRateExcessCubicMeter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateExcessCubicMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRateExcessCubicMeter.HintForeColor = System.Drawing.Color.Empty;
            this.txtRateExcessCubicMeter.HintText = "";
            this.txtRateExcessCubicMeter.isPassword = false;
            this.txtRateExcessCubicMeter.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtRateExcessCubicMeter.LineIdleColor = System.Drawing.Color.Black;
            this.txtRateExcessCubicMeter.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtRateExcessCubicMeter.LineThickness = 1;
            this.txtRateExcessCubicMeter.Location = new System.Drawing.Point(905, 476);
            this.txtRateExcessCubicMeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtRateExcessCubicMeter.Name = "txtRateExcessCubicMeter";
            this.txtRateExcessCubicMeter.Size = new System.Drawing.Size(63, 33);
            this.txtRateExcessCubicMeter.TabIndex = 43;
            this.txtRateExcessCubicMeter.Text = "15.63";
            this.txtRateExcessCubicMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCurrentBill
            // 
            this.txtCurrentBill.BackColor = System.Drawing.Color.White;
            this.txtCurrentBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentBill.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentBill.HintForeColor = System.Drawing.Color.Empty;
            this.txtCurrentBill.HintText = "Current Bill";
            this.txtCurrentBill.isPassword = false;
            this.txtCurrentBill.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCurrentBill.LineIdleColor = System.Drawing.Color.Black;
            this.txtCurrentBill.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCurrentBill.LineThickness = 1;
            this.txtCurrentBill.Location = new System.Drawing.Point(446, 435);
            this.txtCurrentBill.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentBill.Name = "txtCurrentBill";
            this.txtCurrentBill.Size = new System.Drawing.Size(94, 33);
            this.txtCurrentBill.TabIndex = 21;
            this.txtCurrentBill.TabStop = false;
            this.txtCurrentBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotalMembers
            // 
            this.txtTotalMembers.BackColor = System.Drawing.Color.White;
            this.txtTotalMembers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalMembers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalMembers.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalMembers.HintText = "";
            this.txtTotalMembers.isPassword = false;
            this.txtTotalMembers.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalMembers.LineIdleColor = System.Drawing.Color.Black;
            this.txtTotalMembers.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalMembers.LineThickness = 1;
            this.txtTotalMembers.Location = new System.Drawing.Point(846, 394);
            this.txtTotalMembers.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalMembers.Name = "txtTotalMembers";
            this.txtTotalMembers.Size = new System.Drawing.Size(189, 33);
            this.txtTotalMembers.TabIndex = 46;
            this.txtTotalMembers.TabStop = false;
            this.txtTotalMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.White;
            this.txtVAT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVAT.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVAT.HintForeColor = System.Drawing.Color.Empty;
            this.txtVAT.HintText = "VAT";
            this.txtVAT.isPassword = false;
            this.txtVAT.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtVAT.LineIdleColor = System.Drawing.Color.Black;
            this.txtVAT.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtVAT.LineThickness = 1;
            this.txtVAT.Location = new System.Drawing.Point(342, 476);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(4);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(96, 33);
            this.txtVAT.TabIndex = 44;
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAmountMinimumCubicMeter
            // 
            this.txtAmountMinimumCubicMeter.BackColor = System.Drawing.Color.White;
            this.txtAmountMinimumCubicMeter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountMinimumCubicMeter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountMinimumCubicMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmountMinimumCubicMeter.HintForeColor = System.Drawing.Color.Empty;
            this.txtAmountMinimumCubicMeter.HintText = "Amount Minimum CBM";
            this.txtAmountMinimumCubicMeter.isPassword = false;
            this.txtAmountMinimumCubicMeter.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAmountMinimumCubicMeter.LineIdleColor = System.Drawing.Color.Black;
            this.txtAmountMinimumCubicMeter.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAmountMinimumCubicMeter.LineThickness = 1;
            this.txtAmountMinimumCubicMeter.Location = new System.Drawing.Point(177, 435);
            this.txtAmountMinimumCubicMeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountMinimumCubicMeter.Name = "txtAmountMinimumCubicMeter";
            this.txtAmountMinimumCubicMeter.Size = new System.Drawing.Size(157, 33);
            this.txtAmountMinimumCubicMeter.TabIndex = 40;
            this.txtAmountMinimumCubicMeter.TabStop = false;
            this.txtAmountMinimumCubicMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAmountExcessCubicMeter
            // 
            this.txtAmountExcessCubicMeter.BackColor = System.Drawing.Color.White;
            this.txtAmountExcessCubicMeter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountExcessCubicMeter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountExcessCubicMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmountExcessCubicMeter.HintForeColor = System.Drawing.Color.Empty;
            this.txtAmountExcessCubicMeter.HintText = "Amount Excess CBM";
            this.txtAmountExcessCubicMeter.isPassword = false;
            this.txtAmountExcessCubicMeter.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAmountExcessCubicMeter.LineIdleColor = System.Drawing.Color.Black;
            this.txtAmountExcessCubicMeter.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAmountExcessCubicMeter.LineThickness = 1;
            this.txtAmountExcessCubicMeter.Location = new System.Drawing.Point(4, 476);
            this.txtAmountExcessCubicMeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountExcessCubicMeter.Name = "txtAmountExcessCubicMeter";
            this.txtAmountExcessCubicMeter.Size = new System.Drawing.Size(165, 33);
            this.txtAmountExcessCubicMeter.TabIndex = 41;
            this.txtAmountExcessCubicMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtExcessCBM
            // 
            this.txtExcessCBM.BackColor = System.Drawing.Color.White;
            this.txtExcessCBM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExcessCBM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcessCBM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExcessCBM.HintForeColor = System.Drawing.Color.Empty;
            this.txtExcessCBM.HintText = "Excess CBM";
            this.txtExcessCBM.isPassword = false;
            this.txtExcessCBM.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtExcessCBM.LineIdleColor = System.Drawing.Color.Black;
            this.txtExcessCBM.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtExcessCBM.LineThickness = 1;
            this.txtExcessCBM.Location = new System.Drawing.Point(342, 435);
            this.txtExcessCBM.Margin = new System.Windows.Forms.Padding(4);
            this.txtExcessCBM.Name = "txtExcessCBM";
            this.txtExcessCBM.Size = new System.Drawing.Size(96, 33);
            this.txtExcessCBM.TabIndex = 38;
            this.txtExcessCBM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtConsume
            // 
            this.txtConsume.BackColor = System.Drawing.Color.White;
            this.txtConsume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsume.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConsume.HintForeColor = System.Drawing.Color.Empty;
            this.txtConsume.HintText = "Consume";
            this.txtConsume.isPassword = false;
            this.txtConsume.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtConsume.LineIdleColor = System.Drawing.Color.Black;
            this.txtConsume.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtConsume.LineThickness = 1;
            this.txtConsume.Location = new System.Drawing.Point(4, 435);
            this.txtConsume.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsume.Name = "txtConsume";
            this.txtConsume.Size = new System.Drawing.Size(165, 33);
            this.txtConsume.TabIndex = 26;
            this.txtConsume.TabStop = false;
            this.txtConsume.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMinimumCubicMeter
            // 
            this.txtMinimumCubicMeter.BackColor = System.Drawing.Color.White;
            this.txtMinimumCubicMeter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimumCubicMeter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimumCubicMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMinimumCubicMeter.HintForeColor = System.Drawing.Color.Empty;
            this.txtMinimumCubicMeter.HintText = "Minimum CBM";
            this.txtMinimumCubicMeter.isPassword = false;
            this.txtMinimumCubicMeter.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtMinimumCubicMeter.LineIdleColor = System.Drawing.Color.Black;
            this.txtMinimumCubicMeter.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtMinimumCubicMeter.LineThickness = 1;
            this.txtMinimumCubicMeter.Location = new System.Drawing.Point(177, 394);
            this.txtMinimumCubicMeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinimumCubicMeter.Name = "txtMinimumCubicMeter";
            this.txtMinimumCubicMeter.Size = new System.Drawing.Size(111, 33);
            this.txtMinimumCubicMeter.TabIndex = 6;
            this.txtMinimumCubicMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMinimumCubicMeter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumCubicMeter_KeyPress);
            // 
            // txtRateMinimumCubicMeter
            // 
            this.txtRateMinimumCubicMeter.BackColor = System.Drawing.Color.White;
            this.txtRateMinimumCubicMeter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRateMinimumCubicMeter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateMinimumCubicMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRateMinimumCubicMeter.HintForeColor = System.Drawing.Color.Empty;
            this.txtRateMinimumCubicMeter.HintText = "Amount Per Cubic Meter";
            this.txtRateMinimumCubicMeter.isPassword = false;
            this.txtRateMinimumCubicMeter.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtRateMinimumCubicMeter.LineIdleColor = System.Drawing.Color.Black;
            this.txtRateMinimumCubicMeter.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtRateMinimumCubicMeter.LineThickness = 1;
            this.txtRateMinimumCubicMeter.Location = new System.Drawing.Point(905, 435);
            this.txtRateMinimumCubicMeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtRateMinimumCubicMeter.Name = "txtRateMinimumCubicMeter";
            this.txtRateMinimumCubicMeter.Size = new System.Drawing.Size(63, 33);
            this.txtRateMinimumCubicMeter.TabIndex = 28;
            this.txtRateMinimumCubicMeter.Text = "10.71";
            this.txtRateMinimumCubicMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMeterNumber
            // 
            this.txtMeterNumber.BackColor = System.Drawing.Color.White;
            this.txtMeterNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMeterNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeterNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMeterNumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtMeterNumber.HintText = "Meter Number";
            this.txtMeterNumber.isPassword = false;
            this.txtMeterNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtMeterNumber.LineIdleColor = System.Drawing.Color.Black;
            this.txtMeterNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtMeterNumber.LineThickness = 1;
            this.txtMeterNumber.Location = new System.Drawing.Point(4, 394);
            this.txtMeterNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtMeterNumber.Name = "txtMeterNumber";
            this.txtMeterNumber.Size = new System.Drawing.Size(165, 33);
            this.txtMeterNumber.TabIndex = 3;
            this.txtMeterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCurrentReading
            // 
            this.txtCurrentReading.BackColor = System.Drawing.Color.White;
            this.txtCurrentReading.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentReading.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentReading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentReading.HintForeColor = System.Drawing.Color.Empty;
            this.txtCurrentReading.HintText = "Current Reading";
            this.txtCurrentReading.isPassword = false;
            this.txtCurrentReading.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCurrentReading.LineIdleColor = System.Drawing.Color.Black;
            this.txtCurrentReading.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCurrentReading.LineThickness = 1;
            this.txtCurrentReading.Location = new System.Drawing.Point(177, 312);
            this.txtCurrentReading.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentReading.Name = "txtCurrentReading";
            this.txtCurrentReading.Size = new System.Drawing.Size(111, 33);
            this.txtCurrentReading.TabIndex = 4;
            this.txtCurrentReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCurrentReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentReading_KeyPress);
            // 
            // lblALOWDA
            // 
            this.lblALOWDA.AutoSize = true;
            this.lblALOWDA.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALOWDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.lblALOWDA.Location = new System.Drawing.Point(315, 0);
            this.lblALOWDA.Name = "lblALOWDA";
            this.lblALOWDA.Size = new System.Drawing.Size(359, 21);
            this.lblALOWDA.TabIndex = 17;
            this.lblALOWDA.Text = "Aloguinsan Water Development Authority";
            // 
            // lblAquapure
            // 
            this.lblAquapure.AutoSize = true;
            this.lblAquapure.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAquapure.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblAquapure.Location = new System.Drawing.Point(403, 17);
            this.lblAquapure.Name = "lblAquapure";
            this.lblAquapure.Size = new System.Drawing.Size(147, 18);
            this.lblAquapure.TabIndex = 18;
            this.lblAquapure.Text = "AQUAPURE (ALOG)";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "Search";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSearch.LineIdleColor = System.Drawing.Color.Black;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSearch.LineThickness = 1;
            this.txtSearch.Location = new System.Drawing.Point(3, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(633, 39);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // errorProviderAquapure
            // 
            this.errorProviderAquapure.ContainerControl = this;
            // 
            // txtDatePaid
            // 
            this.txtDatePaid.BackColor = System.Drawing.Color.White;
            this.txtDatePaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatePaid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatePaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDatePaid.HintForeColor = System.Drawing.Color.Empty;
            this.txtDatePaid.HintText = "Date Paid";
            this.txtDatePaid.isPassword = false;
            this.txtDatePaid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtDatePaid.LineIdleColor = System.Drawing.Color.Black;
            this.txtDatePaid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtDatePaid.LineThickness = 1;
            this.txtDatePaid.Location = new System.Drawing.Point(296, 353);
            this.txtDatePaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatePaid.Name = "txtDatePaid";
            this.txtDatePaid.Size = new System.Drawing.Size(89, 33);
            this.txtDatePaid.TabIndex = 14;
            this.txtDatePaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.BackColor = System.Drawing.Color.White;
            this.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountPaid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmountPaid.HintForeColor = System.Drawing.Color.Empty;
            this.txtAmountPaid.HintText = "Amount Paid";
            this.txtAmountPaid.isPassword = false;
            this.txtAmountPaid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAmountPaid.LineIdleColor = System.Drawing.Color.Black;
            this.txtAmountPaid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAmountPaid.LineThickness = 1;
            this.txtAmountPaid.Location = new System.Drawing.Point(296, 312);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(89, 33);
            this.txtAmountPaid.TabIndex = 13;
            this.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBalance.HintForeColor = System.Drawing.Color.Empty;
            this.txtBalance.HintText = "Balance";
            this.txtBalance.isPassword = false;
            this.txtBalance.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtBalance.LineIdleColor = System.Drawing.Color.Black;
            this.txtBalance.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtBalance.LineThickness = 1;
            this.txtBalance.Location = new System.Drawing.Point(798, 435);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(99, 33);
            this.txtBalance.TabIndex = 49;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCreditBalance
            // 
            this.txtCreditBalance.BackColor = System.Drawing.Color.White;
            this.txtCreditBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreditBalance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreditBalance.HintForeColor = System.Drawing.Color.Empty;
            this.txtCreditBalance.HintText = "Credit Balance";
            this.txtCreditBalance.isPassword = false;
            this.txtCreditBalance.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCreditBalance.LineIdleColor = System.Drawing.Color.Black;
            this.txtCreditBalance.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCreditBalance.LineThickness = 1;
            this.txtCreditBalance.Location = new System.Drawing.Point(798, 476);
            this.txtCreditBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditBalance.Name = "txtCreditBalance";
            this.txtCreditBalance.Size = new System.Drawing.Size(99, 33);
            this.txtCreditBalance.TabIndex = 50;
            this.txtCreditBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotal.HintText = "Total";
            this.txtTotal.isPassword = false;
            this.txtTotal.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotal.LineIdleColor = System.Drawing.Color.Black;
            this.txtTotal.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotal.LineThickness = 1;
            this.txtTotal.Location = new System.Drawing.Point(691, 435);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(99, 33);
            this.txtTotal.TabIndex = 49;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.BackColor = System.Drawing.Color.White;
            this.txtTotalDue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDue.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalDue.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalDue.HintText = "Total Due";
            this.txtTotalDue.isPassword = false;
            this.txtTotalDue.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalDue.LineIdleColor = System.Drawing.Color.Black;
            this.txtTotalDue.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalDue.LineThickness = 1;
            this.txtTotalDue.Location = new System.Drawing.Point(691, 476);
            this.txtTotalDue.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.Size = new System.Drawing.Size(99, 33);
            this.txtTotalDue.TabIndex = 50;
            this.txtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPreviousBalance
            // 
            this.txtPreviousBalance.BackColor = System.Drawing.Color.White;
            this.txtPreviousBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreviousBalance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPreviousBalance.HintForeColor = System.Drawing.Color.Empty;
            this.txtPreviousBalance.HintText = "Prev Balance";
            this.txtPreviousBalance.isPassword = false;
            this.txtPreviousBalance.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPreviousBalance.LineIdleColor = System.Drawing.Color.Black;
            this.txtPreviousBalance.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPreviousBalance.LineThickness = 1;
            this.txtPreviousBalance.Location = new System.Drawing.Point(296, 394);
            this.txtPreviousBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreviousBalance.Name = "txtPreviousBalance";
            this.txtPreviousBalance.Size = new System.Drawing.Size(89, 33);
            this.txtPreviousBalance.TabIndex = 8;
            this.txtPreviousBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPreviousBalancePillipinas
            // 
            this.txtPreviousBalancePillipinas.BackColor = System.Drawing.Color.White;
            this.txtPreviousBalancePillipinas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreviousBalancePillipinas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousBalancePillipinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPreviousBalancePillipinas.HintForeColor = System.Drawing.Color.Empty;
            this.txtPreviousBalancePillipinas.HintText = "Prev. Bal. Pilipinas";
            this.txtPreviousBalancePillipinas.isPassword = false;
            this.txtPreviousBalancePillipinas.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPreviousBalancePillipinas.LineIdleColor = System.Drawing.Color.Black;
            this.txtPreviousBalancePillipinas.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPreviousBalancePillipinas.LineThickness = 1;
            this.txtPreviousBalancePillipinas.Location = new System.Drawing.Point(536, 394);
            this.txtPreviousBalancePillipinas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreviousBalancePillipinas.Name = "txtPreviousBalancePillipinas";
            this.txtPreviousBalancePillipinas.Size = new System.Drawing.Size(138, 33);
            this.txtPreviousBalancePillipinas.TabIndex = 10;
            this.txtPreviousBalancePillipinas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOtherInformation
            // 
            this.txtOtherInformation.BackColor = System.Drawing.Color.White;
            this.txtOtherInformation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOtherInformation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOtherInformation.HintForeColor = System.Drawing.Color.Empty;
            this.txtOtherInformation.HintText = "Other Information";
            this.txtOtherInformation.isPassword = false;
            this.txtOtherInformation.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtOtherInformation.LineIdleColor = System.Drawing.Color.Black;
            this.txtOtherInformation.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtOtherInformation.LineThickness = 1;
            this.txtOtherInformation.Location = new System.Drawing.Point(393, 312);
            this.txtOtherInformation.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherInformation.Name = "txtOtherInformation";
            this.txtOtherInformation.Size = new System.Drawing.Size(135, 33);
            this.txtOtherInformation.TabIndex = 11;
            this.txtOtherInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPriorityLessAmount
            // 
            this.txtPriorityLessAmount.BackColor = System.Drawing.Color.White;
            this.txtPriorityLessAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriorityLessAmount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriorityLessAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPriorityLessAmount.HintForeColor = System.Drawing.Color.Empty;
            this.txtPriorityLessAmount.HintText = "Priority Less Amount";
            this.txtPriorityLessAmount.isPassword = false;
            this.txtPriorityLessAmount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPriorityLessAmount.LineIdleColor = System.Drawing.Color.Black;
            this.txtPriorityLessAmount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPriorityLessAmount.LineThickness = 1;
            this.txtPriorityLessAmount.Location = new System.Drawing.Point(393, 353);
            this.txtPriorityLessAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriorityLessAmount.Name = "txtPriorityLessAmount";
            this.txtPriorityLessAmount.Size = new System.Drawing.Size(135, 33);
            this.txtPriorityLessAmount.TabIndex = 12;
            this.txtPriorityLessAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtForTheMonthOf
            // 
            this.txtForTheMonthOf.BackColor = System.Drawing.Color.White;
            this.txtForTheMonthOf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtForTheMonthOf.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForTheMonthOf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtForTheMonthOf.HintForeColor = System.Drawing.Color.Empty;
            this.txtForTheMonthOf.HintText = "for the Month of";
            this.txtForTheMonthOf.isPassword = false;
            this.txtForTheMonthOf.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtForTheMonthOf.LineIdleColor = System.Drawing.Color.Black;
            this.txtForTheMonthOf.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtForTheMonthOf.LineThickness = 1;
            this.txtForTheMonthOf.Location = new System.Drawing.Point(393, 394);
            this.txtForTheMonthOf.Margin = new System.Windows.Forms.Padding(4);
            this.txtForTheMonthOf.Name = "txtForTheMonthOf";
            this.txtForTheMonthOf.Size = new System.Drawing.Size(135, 33);
            this.txtForTheMonthOf.TabIndex = 9;
            this.txtForTheMonthOf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbBoxFocus
            // 
            this.cmbBoxFocus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBoxFocus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxFocus.FormattingEnabled = true;
            this.cmbBoxFocus.Items.AddRange(new object[] {
            "Current_Reading",
            "Amount_Paid"});
            this.cmbBoxFocus.Location = new System.Drawing.Point(851, 49);
            this.cmbBoxFocus.Name = "cmbBoxFocus";
            this.cmbBoxFocus.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxFocus.TabIndex = 12;
            this.cmbBoxFocus.TabStop = false;
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.lblFocus.Location = new System.Drawing.Point(848, 33);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(84, 13);
            this.lblFocus.TabIndex = 51;
            this.lblFocus.Text = "Choose to focus";
            // 
            // txtCurrentBillTotal
            // 
            this.txtCurrentBillTotal.BackColor = System.Drawing.Color.White;
            this.txtCurrentBillTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentBillTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBillTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentBillTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtCurrentBillTotal.HintText = "Current Bill Total";
            this.txtCurrentBillTotal.isPassword = false;
            this.txtCurrentBillTotal.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCurrentBillTotal.LineIdleColor = System.Drawing.Color.Black;
            this.txtCurrentBillTotal.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCurrentBillTotal.LineThickness = 1;
            this.txtCurrentBillTotal.Location = new System.Drawing.Point(446, 476);
            this.txtCurrentBillTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentBillTotal.Name = "txtCurrentBillTotal";
            this.txtCurrentBillTotal.Size = new System.Drawing.Size(111, 33);
            this.txtCurrentBillTotal.TabIndex = 21;
            this.txtCurrentBillTotal.TabStop = false;
            this.txtCurrentBillTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPrintOfficeFile
            // 
            this.btnPrintOfficeFile.BackColor = System.Drawing.Color.White;
            this.btnPrintOfficeFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintOfficeFile.FlatAppearance.BorderSize = 0;
            this.btnPrintOfficeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintOfficeFile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintOfficeFile.ForeColor = System.Drawing.Color.Black;
            this.btnPrintOfficeFile.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintOfficeFile.Image")));
            this.btnPrintOfficeFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintOfficeFile.Location = new System.Drawing.Point(851, 258);
            this.btnPrintOfficeFile.Name = "btnPrintOfficeFile";
            this.btnPrintOfficeFile.Size = new System.Drawing.Size(183, 50);
            this.btnPrintOfficeFile.TabIndex = 33;
            this.btnPrintOfficeFile.TabStop = false;
            this.btnPrintOfficeFile.Text = "Print Document for ALOWDA Office";
            this.btnPrintOfficeFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintOfficeFile.UseVisualStyleBackColor = false;
            this.btnPrintOfficeFile.Click += new System.EventHandler(this.btnPrintOfficeFile_Click);
            // 
            // btnPrintMonthlyReading
            // 
            this.btnPrintMonthlyReading.BackColor = System.Drawing.Color.White;
            this.btnPrintMonthlyReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintMonthlyReading.FlatAppearance.BorderSize = 0;
            this.btnPrintMonthlyReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintMonthlyReading.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintMonthlyReading.ForeColor = System.Drawing.Color.Black;
            this.btnPrintMonthlyReading.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMonthlyReading.Image")));
            this.btnPrintMonthlyReading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintMonthlyReading.Location = new System.Drawing.Point(851, 308);
            this.btnPrintMonthlyReading.Name = "btnPrintMonthlyReading";
            this.btnPrintMonthlyReading.Size = new System.Drawing.Size(146, 50);
            this.btnPrintMonthlyReading.TabIndex = 33;
            this.btnPrintMonthlyReading.TabStop = false;
            this.btnPrintMonthlyReading.Text = "Print Monthly Reading";
            this.btnPrintMonthlyReading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintMonthlyReading.UseVisualStyleBackColor = false;
            this.btnPrintMonthlyReading.Click += new System.EventHandler(this.btnPrintMonthlyReading_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.Black;
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.Location = new System.Drawing.Point(853, -5);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(144, 40);
            this.btnAddMember.TabIndex = 52;
            this.btnAddMember.TabStop = false;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // dgvAquapure
            // 
            this.dgvAquapure.AllowUserToAddRows = false;
            this.dgvAquapure.AllowUserToResizeColumns = false;
            this.dgvAquapure.AllowUserToResizeRows = false;
            this.dgvAquapure.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAquapure.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAquapure.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAquapure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAquapure.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAquapure.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAquapure.Location = new System.Drawing.Point(3, 76);
            this.dgvAquapure.Name = "dgvAquapure";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAquapure.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAquapure.Size = new System.Drawing.Size(842, 351);
            this.dgvAquapure.TabIndex = 53;
            this.dgvAquapure.TabStop = false;
            this.dgvAquapure.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAquapure_CellFormatting);
            this.dgvAquapure.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAquapure_RowHeaderMouseClick);
            this.dgvAquapure.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAquapure_RowsAdded);
            // 
            // btnMayorsAccount
            // 
            this.btnMayorsAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMayorsAccount.FlatAppearance.BorderSize = 0;
            this.btnMayorsAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMayorsAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayorsAccount.ForeColor = System.Drawing.Color.Black;
            this.btnMayorsAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnMayorsAccount.Image")));
            this.btnMayorsAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMayorsAccount.Location = new System.Drawing.Point(853, 353);
            this.btnMayorsAccount.Name = "btnMayorsAccount";
            this.btnMayorsAccount.Size = new System.Drawing.Size(144, 40);
            this.btnMayorsAccount.TabIndex = 54;
            this.btnMayorsAccount.TabStop = false;
            this.btnMayorsAccount.Text = "Mayor\'s Account";
            this.btnMayorsAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMayorsAccount.UseVisualStyleBackColor = true;
            this.btnMayorsAccount.Click += new System.EventHandler(this.btnMayorsAccount_Click);
            // 
            // checkBoxLastMonthPrintPayment
            // 
            this.checkBoxLastMonthPrintPayment.AutoSize = true;
            this.checkBoxLastMonthPrintPayment.Location = new System.Drawing.Point(644, 40);
            this.checkBoxLastMonthPrintPayment.Name = "checkBoxLastMonthPrintPayment";
            this.checkBoxLastMonthPrintPayment.Size = new System.Drawing.Size(162, 17);
            this.checkBoxLastMonthPrintPayment.TabIndex = 55;
            this.checkBoxLastMonthPrintPayment.Text = "Last Month for Print Payment";
            this.checkBoxLastMonthPrintPayment.UseVisualStyleBackColor = true;
            // 
            // checkBoxLastMonthPrintMonthlyReading
            // 
            this.checkBoxLastMonthPrintMonthlyReading.AutoSize = true;
            this.checkBoxLastMonthPrintMonthlyReading.Location = new System.Drawing.Point(644, 59);
            this.checkBoxLastMonthPrintMonthlyReading.Name = "checkBoxLastMonthPrintMonthlyReading";
            this.checkBoxLastMonthPrintMonthlyReading.Size = new System.Drawing.Size(201, 17);
            this.checkBoxLastMonthPrintMonthlyReading.TabIndex = 55;
            this.checkBoxLastMonthPrintMonthlyReading.Text = "Last Month for Print Monthly Reading";
            this.checkBoxLastMonthPrintMonthlyReading.UseVisualStyleBackColor = true;
            // 
            // AquapureCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBoxLastMonthPrintPayment);
            this.Controls.Add(this.dgvAquapure);
            this.Controls.Add(this.btnMayorsAccount);
            this.Controls.Add(this.btnPrintMonthlyReading);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrintOfficeFile);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.txtPriorityLessAmount);
            this.Controls.Add(this.txtForTheMonthOf);
            this.Controls.Add(this.txtOtherInformation);
            this.Controls.Add(this.txtPreviousBalancePillipinas);
            this.Controls.Add(this.txtTotalDue);
            this.Controls.Add(this.txtCreditBalance);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtPreviousBalance);
            this.Controls.Add(this.txtDatePaid);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.cmbBoxFocus);
            this.Controls.Add(this.cmbBoxStatus);
            this.Controls.Add(this.btnUserAgreement);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.txtPreviousReading);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtRateExcessCubicMeter);
            this.Controls.Add(this.txtCurrentBillTotal);
            this.Controls.Add(this.txtCurrentBill);
            this.Controls.Add(this.txtTotalMembers);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtAmountMinimumCubicMeter);
            this.Controls.Add(this.txtAmountExcessCubicMeter);
            this.Controls.Add(this.txtExcessCBM);
            this.Controls.Add(this.txtConsume);
            this.Controls.Add(this.txtMinimumCubicMeter);
            this.Controls.Add(this.txtRateMinimumCubicMeter);
            this.Controls.Add(this.txtMeterNumber);
            this.Controls.Add(this.txtCurrentReading);
            this.Controls.Add(this.lblALOWDA);
            this.Controls.Add(this.lblAquapure);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPrintWaterReading);
            this.Controls.Add(this.btnTransferThenUpdate);
            this.Controls.Add(this.btnPaymentForTreasurer);
            this.Controls.Add(this.checkBoxLastMonthPrintMonthlyReading);
            this.Name = "AquapureCustomControl";
            this.Size = new System.Drawing.Size(1312, 564);
            this.Load += new System.EventHandler(this.AquapureCustomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAquapure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAquapure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxStatus;
        private System.Windows.Forms.Button btnUserAgreement;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnPaymentForTreasurer;
        private System.Windows.Forms.Button btnPrintWaterReading;
        private System.Windows.Forms.Button btnTransferThenUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnForm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPreviousReading;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCustomerCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalAmount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRateExcessCubicMeter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCurrentBill;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalMembers;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVAT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAmountMinimumCubicMeter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAmountExcessCubicMeter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtExcessCBM;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConsume;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMinimumCubicMeter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRateMinimumCubicMeter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMeterNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCurrentReading;
        private System.Windows.Forms.Label lblALOWDA;
        private System.Windows.Forms.Label lblAquapure;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.ErrorProvider errorProviderAquapure;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDatePaid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAmountPaid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCreditBalance;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBalance;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalDue;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPreviousBalance;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPreviousBalancePillipinas;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPriorityLessAmount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOtherInformation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtForTheMonthOf;
        private System.Windows.Forms.ComboBox cmbBoxFocus;
        private System.Windows.Forms.Label lblFocus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCurrentBillTotal;
        private System.Windows.Forms.Button btnPrintMonthlyReading;
        private System.Windows.Forms.Button btnPrintOfficeFile;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.DataGridView dgvAquapure;
        private System.Windows.Forms.Button btnMayorsAccount;
        private System.Windows.Forms.CheckBox checkBoxLastMonthPrintPayment;
        private System.Windows.Forms.CheckBox checkBoxLastMonthPrintMonthlyReading;
    }
}
