using ReArc.Gui.Common;
using ReArc.Shared;

namespace ReArc.Gui.Views
{
    public partial class Page : UserControl
    {
        public MainForm? MainForm;

        public Page()
        {
        
        }

        public async Task Setup(string name, Dictionary<string, object>? props = null)
        {
            MainForm!.BeginInvoke(() => LoadingDialog.ShowLoading(MainForm, $"Loading {name}..."));
            await Task.Delay(500);

            var result = await LoadData(props);

            LoadingDialog.ChangeCaption($"Done loading {name}");
            await LoadingDialog.Stop();

            if (!result.Success)
            {
                MessageBox.Show(MainForm, $"An error occurred while trying to load data for this page. {result.ErrorMessage}", name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            Render();
            Show();
        }

        public virtual async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
        {
            return CommandResult<bool>.Ok(true);
        }

        public virtual void Render()
        {

        }
    }
}
