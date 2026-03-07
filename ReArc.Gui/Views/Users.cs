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
            foreach (var user in _users)
            {
                var createdDate = DateTime.Parse(user.CreatedAt).ToString("dd-MM-yyyy, HH:mm:ss");

                UserListView.Rows.Add([Properties.Resources.user, user.Username, user.Email, createdDate, user.Approved, user.Admin]);
            }

            UserListView.AutoResizeColumns();
        }

        [STAThread]
        private void UserListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var columnIndex = e.ColumnIndex;
            var columnName = ((DataGridView)sender).Columns[columnIndex].Name;

            var user = _users[rowIndex];

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
    }
}
