using ReArc.Gui.Server;
using ReArc.Shared;

namespace ReArc.Gui
{
    internal static class Program
    {
        private static Form? _nextForm;

        [STAThread]
        static async Task Main()
        {
            await Configuration.ReadConfiguration();

            ApplicationConfiguration.Initialize();
            Application.Run(new SelectServerForm());

            while (_nextForm != null)
            {
                if (_nextForm.IsDisposed) break;
                Application.Run(_nextForm);
            }
        }

        public static void SetNextForm(Form form)
        {
            _nextForm = form;
        }
    }
}