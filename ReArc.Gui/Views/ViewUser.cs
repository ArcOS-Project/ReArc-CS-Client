using ReArc.ApiHandler.Controllers;
using ReArc.Shared;
using ReArc.Shared.Records.Database;

namespace ReArc.Gui.Views
{
    public partial class ViewUser : Page
    {
        private List<ArcUser> _users = [];
        private ArcUser? _user;
        private string _profilePicture = string.Empty;
        public ViewUser()
        {
            InitializeComponent();
        }

        public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
        {
            if (props != null && props.TryGetValue("User", out var user) && user is ArcUser)
            {
                _user = user as ArcUser;

                var response = await AdminController.GetAllUsers();
                if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);

                var pfpResult = await UserController.DownloadProfilePicture(_user!._id);
                if (pfpResult.Success)
                {
                    _profilePicture = pfpResult.Result!;
                }

                _users = response.Result!;
                return CommandResult<bool>.Ok(true);
            }

            return CommandResult<bool>.Error("Invalid invocation");
        }

        public override void Render()
        {
            if (_profilePicture != string.Empty)
            {
                ProfilePictureBox.Image = Image.FromFile(_profilePicture);
            }

            UsernameLabel.Text = _user!.Username;
            EmailLabel.Text = _user!.Email;
        }
    }
}
