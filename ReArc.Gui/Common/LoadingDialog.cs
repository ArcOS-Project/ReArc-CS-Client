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
            if (_dialog != null)
            {
                ChangeCaption(caption);
                return _dialog;
            }

            var dialog = new LoadingDialog(caption);
            invocator.BeginInvoke(() => dialog.ShowDialog(invocator));

            _dialog = dialog;

            return dialog;
        }

        public static void SetProgress(int? value = null, int? max = null) {
            if (_dialog == null) return;

            if (value == null && max == null) {
                _dialog.ProgressBar.Style = ProgressBarStyle.Marquee;
                _dialog.ProgressBar.Maximum = 0;
                _dialog.ProgressBar.Value = 0;
                return;
            }

            _dialog.ProgressBar.Maximum = max ?? _dialog.ProgressBar.Maximum;
            _dialog.ProgressBar.Value = value ?? _dialog.ProgressBar.Value;
            _dialog.ProgressBar.Style = ProgressBarStyle.Continuous;
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
