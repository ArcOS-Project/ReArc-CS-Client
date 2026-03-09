using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;
using System.Data;

namespace ReArc.Gui.Components
{
    public abstract partial class BaseList<T> : UserControl
    {
        protected readonly List<string> _filterOptions = ["All"];
        protected readonly List<DataGridViewColumn> _columns = [];
        public List<T> Items = [];
        protected List<T> _filteredItems = [];
        private string _filter { get => FilterBox.Text; }
        private string _query { get => SearchBox.Text; }
        public MainForm? MainForm;


        public BaseList()
        {
            _columns = Columns();
            _filterOptions = FilterOptions();
            InitializeComponent();

            FilterBox.SelectedIndex = 0;
        }

        public void FilterItems()
        {
            if (_filter == string.Empty && _query == string.Empty)
            {
                _filteredItems = Items;
                return;
            }

            _filteredItems = Items
                .Where((i) => QueryFilterCallback(_query, i))
                .Where((i) => FilterCallback(_filter, i))
                .ToList();
        }

        public void PopulateList()
        {
            GridView.Rows.Clear();

            foreach (var item in _filteredItems)
            {
                GridView.Rows.Add(GetGridRow(item));
            }

            GridView.AutoResizeColumns();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                FilterItems();
                PopulateList();
            }
        }

        private void FilterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterItems();
            PopulateList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FilterItems();
            PopulateList();
        }

        public abstract bool QueryFilterCallback(string query, T item);
        public abstract bool FilterCallback(string filter, T item);
        public abstract object[] GetGridRow(T item);
        public abstract void OnCellClicked(object sender, DataGridViewCellEventArgs e);
        protected abstract List<string> FilterOptions();
        protected abstract List<DataGridViewColumn> Columns();
    }
}
