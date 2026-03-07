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
            TokensLabel.Text = _statistics!.Counts.Tokens.ToString();
            UsersLabel.Text = _statistics!.Counts.Users.ToString();
            IndexesLabel.Text = _statistics!.Counts.Indexes.ToString();
        }
    }
}
