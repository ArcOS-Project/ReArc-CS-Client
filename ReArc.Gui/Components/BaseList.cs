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
        private bool _isReady = false;
        public MainForm? MainForm;

        public BaseList()
        {
            _columns = Columns();
            _filterOptions = FilterOptions();
            InitializeComponent();

            FilterBox.SelectedIndex = 0;
            _isReady = true;
        }

        private void FilterItems()
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

            if (_filteredItems.Count == 1 && _isReady)
            {
                HandleSingleItemResult(_filteredItems[0], _query, _filter);
            }
        }

        public void PopulateList()
        {
            FilterItems();

            if (GridView.Columns.Count > 0 && !GridView.IsDisposed)
            {
                GridView.Rows.Clear();

                foreach (var item in _filteredItems)
                {
                    GridView.Rows.Add(GetGridRow(item));
                }

                GridView.AutoResizeColumns();
            }
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                PopulateList();
            }
        }

        private void FilterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            PopulateList();
        }

        protected virtual bool QueryFilterCallback(string query, T item)
        {
            return true;
        }

        protected virtual bool FilterCallback(string filter, T item)
        {
            return true;
        }

        protected virtual object[] GetGridRow(T item)
        {
            return [];
        }

        private void Internal_OnCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var columnIndex = e.ColumnIndex;

            if (rowIndex < 0 || rowIndex > _filteredItems.Count || columnIndex < 0 || columnIndex > _columns.Count) return;

            var columnName = _columns[columnIndex].Name;
            var item = _filteredItems[rowIndex];

            OnCellClicked(columnName, item, rowIndex, columnIndex);
        }

        protected virtual void OnCellClicked(string columnName, T item, int row, int column)
        {
            return;
        }

        protected virtual List<string> FilterOptions()
        {
            return [];
        }

        protected virtual List<DataGridViewColumn> Columns()
        {
            return [];
        }

        protected virtual void HandleSingleItemResult(T item, string query, string filter)
        { }
    }
}
