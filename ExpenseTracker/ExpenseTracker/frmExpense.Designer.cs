#nullable disable
namespace ExpenseTracker
{
    partial class frmExpense
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAmount = new Label();
            nudAmount = new NumericUpDown();
            grpPayment = new GroupBox();
            rdoCash = new RadioButton();
            rdoGCash = new RadioButton();
            rdoCard = new RadioButton();
            chkRecurring = new CheckBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            grpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 24);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(120, 20);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(130, 23);
            dtpDate.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 59);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 55);
            txtDescription.MaxLength = 50;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 23);
            txtDescription.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 94);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(120, 90);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(160, 23);
            cboCategory.TabIndex = 2;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 129);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount:";
            // 
            // nudAmount
            // 
            nudAmount.DecimalPlaces = 2;
            nudAmount.Location = new Point(120, 125);
            nudAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(110, 23);
            nudAmount.TabIndex = 3;
            nudAmount.TextAlign = HorizontalAlignment.Right;
            nudAmount.ThousandsSeparator = true;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(rdoCash);
            grpPayment.Controls.Add(rdoGCash);
            grpPayment.Controls.Add(rdoCard);
            grpPayment.Location = new Point(20, 160);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(350, 60);
            grpPayment.TabIndex = 4;
            grpPayment.TabStop = false;
            grpPayment.Text = "Payment";
            // 
            // rdoCash
            // 
            rdoCash.AutoSize = true;
            rdoCash.Checked = true;
            rdoCash.Location = new Point(15, 25);
            rdoCash.Name = "rdoCash";
            rdoCash.Size = new Size(51, 19);
            rdoCash.TabIndex = 0;
            rdoCash.TabStop = true;
            rdoCash.Text = "Cash";
            // 
            // rdoGCash
            // 
            rdoGCash.AutoSize = true;
            rdoGCash.Location = new Point(110, 25);
            rdoGCash.Name = "rdoGCash";
            rdoGCash.Size = new Size(59, 19);
            rdoGCash.TabIndex = 1;
            rdoGCash.Text = "GCash";
            // 
            // rdoCard
            // 
            rdoCard.AutoSize = true;
            rdoCard.Location = new Point(205, 25);
            rdoCard.Name = "rdoCard";
            rdoCard.Size = new Size(50, 19);
            rdoCard.TabIndex = 2;
            rdoCard.Text = "Card";
            // 
            // chkRecurring
            // 
            chkRecurring.AutoSize = true;
            chkRecurring.Location = new Point(20, 232);
            chkRecurring.Name = "chkRecurring";
            chkRecurring.Size = new Size(125, 19);
            chkRecurring.TabIndex = 5;
            chkRecurring.Text = "Recurring monthly";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(20, 267);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(41, 15);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(120, 264);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(250, 70);
            txtNotes.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(195, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 30);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(285, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 30);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // frmExpense
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            CancelButton = btnCancel;
            ClientSize = new Size(410, 400);
            Controls.Add(lblDate);
            Controls.Add(dtpDate);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblAmount);
            Controls.Add(nudAmount);
            Controls.Add(grpPayment);
            Controls.Add(chkRecurring);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmExpense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Expense";
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblAmount;
        private NumericUpDown nudAmount;
        private GroupBox grpPayment;
        private RadioButton rdoCash;
        private RadioButton rdoGCash;
        private RadioButton rdoCard;
        private CheckBox chkRecurring;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errProvider;
    }
}
