namespace ReArc.Gui.Common
{
    public partial class LoadingDialog : Form
    {
        private static LoadingDialog? _dialog;
        private bool _stop = false;

        public LoadingDialog(string caption)
        {
            InitializeComponent();

            StatusLabel.Text = caption;
        }

        public static LoadingDialog ShowLoading(Form invocator, string caption)
        {
            var dialog = new LoadingDialog(caption);
            invocator.BeginInvoke(() => dialog.ShowDialog(invocator));

            _dialog = dialog;

            return dialog;
        }

        public static void ChangeCaption(string caption)
        {
            if (_dialog == null) return;
            _dialog.StatusLabel.Text = caption;
        }

        private void LoadingDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_stop) e.Cancel = true;
        }

        public static async Task Stop()
        {
            if (_dialog == null) return;

            _dialog._stop = true;
            _dialog.Close();
            await Task.Delay(200);
            _dialog = null;
        }

        private void LoadingDialog_Load(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
