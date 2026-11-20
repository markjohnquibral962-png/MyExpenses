![Banner](assets/banner.jpg)

# Personal Expense Tracker

A Windows Forms desktop app (C#, .NET 10, Visual Studio 2026) for recording daily expenses,
filtering them, comparing spending with a monthly budget, and saving everything to a JSON file.

Made for **Advance Programming - DICT 3-1** (Windows Desktop Programming with C# offline activity).

## Features

- **Main window**: menu bar (File / Expense / Help) and toolbar sharing the same handlers, shortcut keys Ctrl+N, Ctrl+O, Ctrl+S
- **Filters** (update the grid instantly): category, description search, optional date range
- **Grid**: read-only, full-row select, newest first, amounts with 2 decimals, double-click a row to edit
- **Summary**: number of shown records and their total, monthly budget, and a *Remaining* label that turns red when this month is over budget
- **Status bar**: status message, record count, live clock (Timer)
- **Add / Edit form** with `ErrorProvider` validation (date not in the future, description required and max 50 characters, amount greater than 0 and at most 1,000,000)
- **Unsaved-changes tracking**: `*` in the title bar, and a Yes / No / Cancel prompt on close, New, and Open
- **Delete confirmation**
- **JSON save/load** with `SaveFileDialog` / `OpenFileDialog`, all inside try-catch; new IDs are highest ID + 1

## Run it

1. Open `ExpenseTracker.slnx` in Visual Studio 2026 (needs the .NET 10 SDK and the *.NET desktop development* workload).
2. Press **F5**.
3. Try **File > Open...** and choose `sample-expenses.json` to load sample data.

## Project structure

| File | Purpose |
|------|---------|
| `Expense.cs` | The data class (provided in the activity) |
| `frmMain.cs` / `frmMain.Designer.cs` | Main window logic and layout |
| `frmExpense.cs` / `frmExpense.Designer.cs` | Add / Edit dialog |
| `Program.cs` | Entry point |
| `sample-expenses.json` | Sample data for testing |

## Developer

Mark John N. Quibral
