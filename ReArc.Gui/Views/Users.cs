using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Common;
using ReArc.Shared;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses.Admin;

namespace ReArc.Gui.Views
{
    public partial class Users : Page
    {
        private List<ArcUser> _users = [];
        private List<ArcUser> _filteredUsers = [];
        private string _filter { get => FilterDropdown.Text; }
        private string _query { get => SearchBox.Text; }

        public Users()
        {
            InitializeComponent();
        }

        public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
        {
            var response = await AdminController.GetAllUsers();
            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);

            _users = response.Result!;
            return CommandResult<bool>.Ok(true);
        }

        public override void Render()
        {
            FilterDropdown.SelectedIndex = 0;
            FilterUsers();
            PopulateList();
        }

        private void FilterUsers()
        {
            var comparison = StringComparison.InvariantCultureIgnoreCase;

            if (_filter == string.Empty && _query == string.Empty)
            {
                _filteredUsers = _users;
                return;
            }

            _filteredUsers = [.. _users.Where(
                (u) => _query == string.Empty ||
                       u.Username.Contains(_query, comparison) ||
                       u.Email.Contains(_query, comparison) ||
                       (u.Preferences?.Account.DisplayName?.Contains(_query, comparison) ?? false) ||
                       u._id == _query)];

            _filteredUsers = [.. _filteredUsers.Where(
                (u) => _filter switch {
                        "All" => true,
                        "Regular" => !u.Admin,
                        "Admins" => u.Admin,
                        "Approved" => u.Approved,
                        "Disapproved" => !u.Approved,
                        _ => true})];
        }

        private void PopulateList()
        {
            UserListView.Rows.Clear();


            foreach (var user in _filteredUsers)
            {
                var createdDate = DateTime.Parse(user.CreatedAt).ToString("dd-MM-yyyy, HH:mm:ss");

                UserListView.Rows.Add([Properties.Resources.user, user.Username, user.Email, createdDate, user.Approved, user.Admin]);
            }

            UserListView.AutoResizeColumns();
        }

        private void UserListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var columnIndex = e.ColumnIndex;
            var columnName = ((DataGridView)sender).Columns[columnIndex].Name;

            var user = _filteredUsers[rowIndex];

            switch (columnName)
            {
                case "View":
                    _ = MainForm!.SwitchView(new ViewUser(), $"View {user.Username}", new Dictionary<string, object>() {
                        { "User", user! }
                    });
                    break;

                case "Copy":
                    CopyDialog.ShowCopyDialog(MainForm!, user._id);
                    break;
            }
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                FilterUsers();
                PopulateList();
            }
        }

        private void FilterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterUsers();
            PopulateList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FilterUsers();
            PopulateList();
        }
    }
}
