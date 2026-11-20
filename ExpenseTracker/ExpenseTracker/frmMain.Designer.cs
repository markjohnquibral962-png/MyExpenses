#nullable disable
namespace ExpenseTracker
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSave = new ToolStripMenuItem();
            mnuSaveAs = new ToolStripMenuItem();
            sepFile = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuExpense = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            sepTool = new ToolStripSeparator();
            tsbSave = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblRecords = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            pnlFilter = new Panel();
            lblCategory = new Label();
            cboFilterCategory = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            chkDateRange = new CheckBox();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            pnlSummary = new Panel();
            lblSummary = new Label();
            lblBudget = new Label();
            nudBudget = new NumericUpDown();
            lblRemaining = new Label();
            dgvExpenses = new DataGridView();
            tmrClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.RosyBrown;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuExpense, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(820, 24);
            menuStrip1.TabIndex = 0;
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, mnuSave, mnuSaveAs, sepFile, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuNew.Size = new Size(195, 22);
            mnuNew.Text = "&New";
            mnuNew.Click += New_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuOpen.Size = new Size(195, 22);
            mnuOpen.Text = "&Open...";
            mnuOpen.Click += Open_Click;
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuSave.Size = new Size(195, 22);
            mnuSave.Text = "&Save";
            mnuSave.Click += Save_Click;
            // 
            // mnuSaveAs
            // 
            mnuSaveAs.Name = "mnuSaveAs";
            mnuSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            mnuSaveAs.Size = new Size(195, 22);
            mnuSaveAs.Text = "Save &As...";
            mnuSaveAs.Click += SaveAs_Click;
            // 
            // sepFile
            // 
            sepFile.Name = "sepFile";
            sepFile.Size = new Size(192, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(195, 22);
            mnuExit.Text = "E&xit";
            mnuExit.Click += Exit_Click;
            // 
            // mnuExpense
            // 
            mnuExpense.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd, mnuEdit, mnuDelete });
            mnuExpense.Name = "mnuExpense";
            mnuExpense.Size = new Size(61, 20);
            mnuExpense.Text = "&Expense";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(107, 22);
            mnuAdd.Text = "&Add";
            mnuAdd.Click += Add_Click;
            // 
            // mnuEdit
            // 
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(107, 22);
            mnuEdit.Text = "&Edit";
            mnuEdit.Click += Edit_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(107, 22);
            mnuDelete.Text = "&Delete";
            mnuDelete.Click += Delete_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(44, 20);
            mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(107, 22);
            mnuAbout.Text = "&About";
            mnuAbout.Click += About_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbDelete, sepTool, tsbSave });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(820, 25);
            toolStrip1.TabIndex = 1;
            // 
            // tsbAdd
            // 
            tsbAdd.BackColor = Color.Red;
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(33, 22);
            tsbAdd.Text = "Add";
            tsbAdd.Click += Add_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.BackColor = Color.FromArgb(255, 255, 128);
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(31, 22);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += Edit_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(44, 22);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += Delete_Click;
            // 
            // sepTool
            // 
            sepTool.Name = "sepTool";
            sepTool.Size = new Size(6, 25);
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(35, 22);
            tsbSave.Text = "Save";
            tsbSave.Click += Save_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblRecords, lblClock });
            statusStrip1.Location = new Point(0, 518);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(820, 22);
            statusStrip1.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(679, 17);
            lblStatus.Spring = true;
            lblStatus.Text = "Ready.";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecords
            // 
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(55, 17);
            lblRecords.Text = "0 records";
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(71, 17);
            lblClock.Text = "00:00:00 AM";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = SystemColors.ButtonShadow;
            pnlFilter.Controls.Add(lblCategory);
            pnlFilter.Controls.Add(cboFilterCategory);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(chkDateRange);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(lblTo);
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 49);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(820, 75);
            pnlFilter.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 15);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category:";
            // 
            // cboFilterCategory
            // 
            cboFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterCategory.Location = new Point(80, 11);
            cboFilterCategory.Name = "cboFilterCategory";
            cboFilterCategory.Size = new Size(150, 23);
            cboFilterCategory.TabIndex = 0;
            cboFilterCategory.SelectedIndexChanged += Filter_Changed;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(250, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(305, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Description";
            txtSearch.Size = new Size(260, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += Filter_Changed;
            // 
            // chkDateRange
            // 
            chkDateRange.AutoSize = true;
            chkDateRange.Location = new Point(12, 43);
            chkDateRange.Name = "chkDateRange";
            chkDateRange.Size = new Size(86, 19);
            chkDateRange.TabIndex = 2;
            chkDateRange.Text = "Date range:";
            chkDateRange.CheckedChanged += chkDateRange_CheckedChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Enabled = false;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(110, 40);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(120, 23);
            dtpFrom.TabIndex = 3;
            dtpFrom.ValueChanged += Filter_Changed;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(240, 44);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(18, 15);
            lblTo.TabIndex = 4;
            lblTo.Text = "to";
            // 
            // dtpTo
            // 
            dtpTo.Enabled = false;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(265, 40);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(120, 23);
            dtpTo.TabIndex = 4;
            dtpTo.ValueChanged += Filter_Changed;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = SystemColors.ActiveCaption;
            pnlSummary.Controls.Add(lblSummary);
            pnlSummary.Controls.Add(lblBudget);
            pnlSummary.Controls.Add(nudBudget);
            pnlSummary.Controls.Add(lblRemaining);
            pnlSummary.Dock = DockStyle.Bottom;
            pnlSummary.Location = new Point(0, 438);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(820, 80);
            pnlSummary.TabIndex = 4;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSummary.Location = new Point(12, 12);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(150, 15);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Shown: 0   Total: PHP 0.00";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(12, 46);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(96, 15);
            lblBudget.TabIndex = 1;
            lblBudget.Text = "Monthly budget:";
            // 
            // nudBudget
            // 
            nudBudget.DecimalPlaces = 2;
            nudBudget.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudBudget.Location = new Point(115, 42);
            nudBudget.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudBudget.Name = "nudBudget";
            nudBudget.Size = new Size(100, 23);
            nudBudget.TabIndex = 0;
            nudBudget.TextAlign = HorizontalAlignment.Right;
            nudBudget.ThousandsSeparator = true;
            nudBudget.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            nudBudget.ValueChanged += nudBudget_ValueChanged;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRemaining.ForeColor = Color.ForestGreen;
            lblRemaining.Location = new Point(235, 46);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(185, 15);
            lblRemaining.TabIndex = 2;
            lblRemaining.Text = "Remaining this month: PHP 0.00";
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dgvExpenses.AllowUserToResizeRows = false;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Dock = DockStyle.Fill;
            dgvExpenses.Location = new Point(0, 124);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(820, 314);
            dgvExpenses.TabIndex = 5;
            dgvExpenses.CellDoubleClick += dgvExpenses_CellDoubleClick;
            dgvExpenses.DataBindingComplete += dgvExpenses_DataBindingComplete;
            // 
            // tmrClock
            // 
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 540);
            Controls.Add(dgvExpenses);
            Controls.Add(pnlSummary);
            Controls.Add(pnlFilter);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(760, 480);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuSaveAs;
        private ToolStripSeparator sepFile;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuExpense;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDelete;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator sepTool;
        private ToolStripButton tsbSave;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblRecords;
        private ToolStripStatusLabel lblClock;
        private Panel pnlFilter;
        private Label lblCategory;
        private ComboBox cboFilterCategory;
        private Label lblSearch;
        private TextBox txtSearch;
        private CheckBox chkDateRange;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Panel pnlSummary;
        private Label lblSummary;
        private Label lblBudget;
        private NumericUpDown nudBudget;
        private Label lblRemaining;
        private DataGridView dgvExpenses;
        private System.Windows.Forms.Timer tmrClock;
    }
}
