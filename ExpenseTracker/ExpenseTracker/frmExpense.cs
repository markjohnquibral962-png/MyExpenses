namespace ExpenseTracker
{
    // Used for both Add and Edit.
    public partial class frmExpense : Form
    {
        public static readonly string[] Categories =
            { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" };

        private readonly Expense expense;

        // existing == null means "Add". Otherwise it means "Edit".
        public frmExpense(Expense? existing = null)
        {
            InitializeComponent();

            cboCategory.Items.AddRange(Categories);
            dtpDate.MaxDate = DateTime.Today; // no future dates

            if (existing == null)
            {
                expense = new Expense();
                this.Text = "Add Expense";
                dtpDate.Value = DateTime.Today;
                cboCategory.SelectedIndex = 0;
                rdoCash.Checked = true;
            }
            else
            {
                expense = existing;
                this.Text = "Edit Expense";

                DateTime date = existing.Date.Date;
                dtpDate.Value = date > DateTime.Today ? DateTime.Today : date;

                txtDescription.Text = existing.Description;

                int categoryIndex = cboCategory.Items.IndexOf(existing.Category);
                cboCategory.SelectedIndex = categoryIndex >= 0 ? categoryIndex : 0;

                nudAmount.Value = Math.Min(Math.Max(existing.Amount, nudAmount.Minimum), nudAmount.Maximum);

                rdoGCash.Checked = existing.PaymentMethod == "GCash";
                rdoCard.Checked = existing.PaymentMethod == "Card";
                rdoCash.Checked = !rdoGCash.Checked && !rdoCard.Checked;

                chkRecurring.Checked = existing.IsRecurring;
                txtNotes.Text = existing.Notes;
            }
        }

        // The main form calls this after ShowDialog() returns OK.
        public Expense GetExpense() => expense;

        private bool ValidateInputs()
        {
            bool isValid = true;
            errProvider.Clear();

            string description = txtDescription.Text.Trim();
            if (description.Length == 0)
            {
                errProvider.SetError(txtDescription, "Description is required.");
                isValid = false;
            }
            else if (description.Length > 50)
            {
                errProvider.SetError(txtDescription, "Description can have at most 50 characters.");
                isValid = false;
            }

            if (cboCategory.SelectedIndex < 0)
            {
                errProvider.SetError(cboCategory, "Choose a category.");
                isValid = false;
            }

            if (nudAmount.Value <= 0)
            {
                errProvider.SetError(nudAmount, "Amount must be greater than 0.");
                isValid = false;
            }
            else if (nudAmount.Value > 1000000)
            {
                errProvider.SetError(nudAmount, "Amount cannot be more than 1,000,000.");
                isValid = false;
            }

            return isValid;
        }

        private string GetPaymentMethod()
        {
            if (rdoGCash.Checked) return "GCash";
            if (rdoCard.Checked) return "Card";
            return "Cash";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            expense.Date = dtpDate.Value.Date;
            expense.Description = txtDescription.Text.Trim();
            expense.Category = cboCategory.Text;
            expense.Amount = nudAmount.Value;
            expense.PaymentMethod = GetPaymentMethod();
            expense.IsRecurring = chkRecurring.Checked;
            expense.Notes = txtNotes.Text.Trim();

            this.DialogResult = DialogResult.OK; // closes the form and returns OK
        }
    }
}
