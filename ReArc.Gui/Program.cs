using ReArc.Shared;

namespace ReArc.Gui
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            await Configuration.ReadConfiguration();

            ApplicationConfiguration.Initialize();
            Application.Run(new SelectServerForm());
        }
    }
}