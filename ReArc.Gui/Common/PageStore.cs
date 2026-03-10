using ReArc.Gui.Views;

namespace ReArc.Gui.Common
{
    public static class PageStore
    {
        public record ToolboxPage
        {
            public required string Name { get; set; }
            public required Func<Page> Page { get; set; }
            public required Image? Image { get; set; }
            public bool? Separator;
        }

        public readonly static List<ToolboxPage> Pages =
        [
            new()
            {
                Name = "Dashboard",
                Image = Properties.Resources.dashboard16,
                Page = () => new Home()
            },
            new()
            {
                Name = "Bug Reports",
                Image = Properties.Resources.crash16,
                Page = () => new BugReports(),
                Separator = true
            },
            new()
            {
                Name = "Users",
                Image = Properties.Resources.users16,
                Page = () => new Users(),
                Separator = true
            },
            new()
            {
                Name = "Shares",
                Image = Properties.Resources.share16,
                Page = () => new Shares()
            },
            new()
            {
                Name = "Filesystems",
                Image = Properties.Resources.keyfs16,
                Page = () => new Users()
            },
            new()
            {
                Name = "App Store",
                Image = Properties.Resources.installer16,
                Page = () => new Users(),
                Separator = true
            },
            new()
            {
                Name = "Tokens",
                Image = Properties.Resources.keys16,
                Page = () => new Users()
            },
            new()
            {
                Name = "Activities",
                Image = Properties.Resources.lock16,
                Page = () => new Users()
            },
            new()
            {
                Name = "Scopes",
                Image = Properties.Resources.elevate16,
                Page = () => new Users(),
                Separator = true
            },
            new()
            {
                Name = "Audit Log",
                Image = Properties.Resources.cabinet16,
                Page = () => new Users()
            },
            new()
            {
                Name = "Logs",
                Image = Properties.Resources.event16,
                Page = () => new Users()
            }
        ];
    }
}
