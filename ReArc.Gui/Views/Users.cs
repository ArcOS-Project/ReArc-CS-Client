using ReArc.ApiHandler.Controllers;
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
                int idx = UserListView.Rows.Add([Properties.Resources.user, user.Username, user.Email, user.CreatedAt, user.Approved, user.Admin]);
            }

            UserListView.AutoResizeColumns();
        }

        private void UserListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var columnIndex = e.ColumnIndex;

            if (columnIndex == 6)
            {
                var user = _users[rowIndex];

                _ = MainForm!.SwitchView(new ViewUser(), $"View {user.Username}", new Dictionary<string, object>() {
                    { "User", user! }
                });
            }
        }
    }
}
