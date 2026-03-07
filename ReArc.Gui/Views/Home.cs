using ReArc.ApiHandler;
using ReArc.ApiHandler.Controllers;
using ReArc.Shared;
using ReArc.Shared.Records.Responses.Admin;

namespace ReArc.Gui.Views
{
    public partial class Home : Page
    {
        private Statistics? _statistics;
        public Home()
        {
            InitializeComponent();
        }

        public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
        {
            var response = await AdminController.GetStatistics();
            if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);

            _statistics = response.Result!;
            return CommandResult<bool>.Ok(true);
        }

        public override void Render()
        {
            // statistics
            TokensLabel.Text = _statistics!.Counts.Tokens.ToString();
            UsersLabel.Text = _statistics!.Counts.Users.ToString();
            IndexesLabel.Text = _statistics!.Counts.Indexes.ToString();
            ApprovalsLabel.Text = _statistics!.Counts.Approvals.ToString();
            AccessorsLabel.Text = _statistics!.Counts.Accessors.ToString();
            BugReportsLabel.Text = _statistics!.Counts.Bugreps.ToString();
            AuditLogLabel.Text = _statistics!.Counts.Audits.ToString();
            ActivitiesLabel.Text = _statistics!.Counts.Activities.ToString();

            // greeting
            LoggedInAsLabel.Text = $"Logged in as {UserController.UserInfo!.Email} on {Client.Hostname}";
            GreetingBox.Text = GetGreeting(UserController.DisplayName!);
            ProfilePictureBox.Image = Image.FromFile(UserController.ProfilePicture!);
        }

        private static string GetGreeting(string displayName)
        {
            var hour = DateTime.Now.Hour;

            if (hour < 6) return $"Hi {displayName}, go to sleep";
            if (hour < 12) return $"Good morning, {displayName}!";
            if (hour < 18) return $"Good afternoon, {displayName}!";
            return $"Good evening, {displayName}!";
        }
    }
}
