namespace ReArc.Gui.Common
{
    public partial class LoadingDialog : Form
    {
        private bool _stop = false;

        public LoadingDialog(string caption)
        {
            InitializeComponent();

            StatusLabel.Text = caption;
        }

        public static LoadingDialog ShowLoading(Form invocator, string caption)
        {
            var dialog = new LoadingDialog(caption);
            dialog.ShowDialog(invocator);

            return dialog;
        }

        private void LoadingDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_stop) e.Cancel = true;
        }

        public async Task Stop()
        {
            _stop = true;
            Close();
            await Task.Delay(100);
        }
    }
}
