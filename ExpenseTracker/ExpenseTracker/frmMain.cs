using System.Text.Json;

namespace ExpenseTracker
{
    public partial class frmMain : Form
    {
        private const string AppName = "Expense Tracker";
        private const string AppVersion = "1.0";
        private const string DeveloperName = "Mark John N. Quibral";
        private const string FileFilter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

        private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

        private readonly List<Expense> expenses = new();
        private string? currentFilePath;
        private bool isDirty;

        public frmMain()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------------
        //  Form events
        // ------------------------------------------------------------------

        private void frmMain_Load(object sender, EventArgs e)
        {
            cboFilterCategory.Items.Add("All");
            cboFilterCategory.Items.AddRange(frmExpense.Categories);
            cboFilterCategory.SelectedIndex = 0;

            DateTime today = DateTime.Today;
            dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpTo.Value = today;

            ShowClock();
            tmrClock.Start();

            RefreshView();
            SetStatus("Ready.");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmSaveChanges())
            {
                e.Cancel = true; // user chose Cancel: stay open
            }
        }

        // ------------------------------------------------------------------
        //  File menu
        // ------------------------------------------------------------------

        private void New_Click(object sender, EventArgs e)
        {
            if (!ConfirmSaveChanges()) return;

            expenses.Clear();
            currentFilePath = null;
            isDirty = false;
            RefreshView();
            SetStatus("New file started.");
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (!ConfirmSaveChanges()) return;

            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = FileFilter;
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                string json = File.ReadAllText(dialog.FileName);
                List<Expense>? loaded = JsonSerializer.Deserialize<List<Expense>>(json);

                expenses.Clear();
                if (loaded != null)
                {
                    foreach (Expense x in loaded)
                    {
                        // protect against missing values in a hand-edited file
                        x.Description ??= "";
                        x.Category ??= "";
                        x.PaymentMethod ??= "";
                        x.Notes ??= "";
                        expenses.Add(x);
                    }
                }

                currentFilePath = dialog.FileName;
                isDirty = false;
                RefreshView();
                SetStatus($"Opened {Path.GetFileName(dialog.FileName)}.");
            }
            catch (JsonException)
            {
                MessageBox.Show("That file is not a valid expense file.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // FormClosing asks about unsaved changes
        }

        // ------------------------------------------------------------------
        //  Expense menu / toolbar (shared handlers)
        // ------------------------------------------------------------------

        private void Add_Click(object sender, EventArgs e)
        {
            using (frmExpense form = new frmExpense())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Expense newExpense = form.GetExpense();
                    newExpense.Id = NextId();
                    expenses.Add(newExpense);

                    MarkDirty();
                    RefreshView();
                    SetStatus("Expense added.");
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Expense? selected = GetSelectedExpense();
            if (selected == null)
            {
                MessageBox.Show("Select an expense to edit.", AppName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (frmExpense form = new frmExpense(selected))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MarkDirty();
                    RefreshView();
                    SetStatus("Expense updated.");
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Expense? selected = GetSelectedExpense();
            if (selected == null)
            {
                MessageBox.Show("Select an expense to delete.", AppName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"Delete \"{selected.Description}\" (PHP {selected.Amount:N2})?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                expenses.Remove(selected);
                MarkDirty();
                RefreshView();
                SetStatus("Expense deleted.");
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"{AppName} v{AppVersion}\nDeveloper: {DeveloperName}\n\nTrack daily expenses, filter them, and compare your spending with a monthly budget.",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ------------------------------------------------------------------
        //  Grid, filters, budget, timer events
        // ------------------------------------------------------------------

        private void dgvExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Edit_Click(sender, e);
        }

        // Runs every time the grid is (re)bound: hide/format columns here.
        private void dgvExpenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvExpenses.Columns["Id"] is DataGridViewColumn idColumn)
                idColumn.Visible = false;

            if (dgvExpenses.Columns["Notes"] is DataGridViewColumn notesColumn)
                notesColumn.Visible = false;

            if (dgvExpenses.Columns["Date"] is DataGridViewColumn dateColumn)
                dateColumn.DefaultCellStyle.Format = "MM/dd/yyyy";

            if (dgvExpenses.Columns["Description"] is DataGridViewColumn descriptionColumn)
                descriptionColumn.FillWeight = 200;

            if (dgvExpenses.Columns["Amount"] is DataGridViewColumn amountColumn)
            {
                amountColumn.DefaultCellStyle.Format = "N2";
                amountColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void chkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = chkDateRange.Checked;
            dtpTo.Enabled = chkDateRange.Checked;
            RefreshView();
        }

        private void nudBudget_ValueChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            ShowClock();
        }

        // ------------------------------------------------------------------
        //  Helpers
        // ------------------------------------------------------------------

        // Applies the filters, sorts newest first, binds the grid, updates labels.
        private void RefreshView()
        {
            IEnumerable<Expense> query = expenses;

            if (cboFilterCategory.SelectedIndex > 0)
            {
                string category = cboFilterCategory.Text;
                query = query.Where(x => x.Category == category);
            }

            string keyword = txtSearch.Text.Trim();
            if (keyword.Length > 0)
            {
                query = query.Where(x => x.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            if (chkDateRange.Checked)
            {
                DateTime from = dtpFrom.Value.Date;
                DateTime to = dtpTo.Value.Date;
                if (from > to) (from, to) = (to, from); // tolerate reversed dates
                query = query.Where(x => x.Date.Date >= from && x.Date.Date <= to);
            }

            List<Expense> shown = query
                .OrderByDescending(x => x.Date)
                .ThenByDescending(x => x.Id)
                .ToList();

            dgvExpenses.DataSource = shown;

            UpdateSummary(shown);
            lblRecords.Text = $"{expenses.Count} records";
            UpdateTitle();
        }

        private void UpdateSummary(List<Expense> shown)
        {
            decimal shownTotal = shown.Sum(x => x.Amount);
            lblSummary.Text = $"Shown: {shown.Count}   Total: PHP {shownTotal:N2}";

            // The budget compares against ALL expenses of the current month,
            // no matter what filters are active.
            DateTime today = DateTime.Today;
            decimal spentThisMonth = expenses
                .Where(x => x.Date.Year == today.Year && x.Date.Month == today.Month)
                .Sum(x => x.Amount);

            decimal remaining = nudBudget.Value - spentThisMonth;
            lblRemaining.Text = $"Remaining this month: PHP {remaining:N2}";
            lblRemaining.ForeColor = remaining < 0 ? Color.Red : Color.ForestGreen;
        }

        private Expense? GetSelectedExpense()
        {
            if (dgvExpenses.SelectedRows.Count == 0) return null;
            return dgvExpenses.SelectedRows[0].DataBoundItem as Expense;
        }

        private int NextId()
        {
            return expenses.Count == 0 ? 1 : expenses.Max(x => x.Id) + 1;
        }

        private void MarkDirty()
        {
            isDirty = true;
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            string name = currentFilePath == null ? "Untitled" : Path.GetFileName(currentFilePath);
            this.Text = $"{AppName} - {name}{(isDirty ? "*" : "")}";
        }

        private void SetStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void ShowClock()
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        // Returns true if it is OK to continue (saved, discarded, or nothing to save).
        private bool ConfirmSaveChanges()
        {
            if (!isDirty) return true;

            string name = currentFilePath == null ? "Untitled" : Path.GetFileName(currentFilePath);
            DialogResult answer = MessageBox.Show(
                $"Save changes to {name}?",
                "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.Cancel) return false;
            if (answer == DialogResult.Yes) return SaveFile(); // false if the save was cancelled or failed
            return true; // No = discard
        }

        // Save writes to the current file; with no file yet it behaves like Save As.
        private bool SaveFile()
        {
            if (currentFilePath == null) return SaveFileAs();
            return WriteToFile(currentFilePath);
        }

        private bool SaveFileAs()
        {
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = FileFilter;
            dialog.FileName = currentFilePath == null ? "expenses.json" : Path.GetFileName(currentFilePath);

            if (dialog.ShowDialog(this) != DialogResult.OK) return false;
            return WriteToFile(dialog.FileName);
        }

        private bool WriteToFile(string path)
        {
            try
            {
                string json = JsonSerializer.Serialize(expenses, JsonOptions);
                File.WriteAllText(path, json);

                currentFilePath = path;
                isDirty = false;
                UpdateTitle();
                SetStatus($"Saved {expenses.Count} expense(s) to {Path.GetFileName(path)}.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
