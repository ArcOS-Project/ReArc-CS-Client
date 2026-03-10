namespace ReArc.Gui.Helpers
{
    public static class TableHelpers
    {
        public static DataGridViewImageColumn ImageColumn(Image source, string name, string? tooltipText = null)
        {
            return new DataGridViewImageColumn
            {
                HeaderText = "",
                Image = source,
                ImageLayout = DataGridViewImageCellLayout.NotSet,
                MinimumWidth = 16,
                Name = name,
                ReadOnly = true,
                Resizable = DataGridViewTriState.False,
                ToolTipText = tooltipText,
                Width = 24
            };
        }

        public static DataGridViewTextBoxColumn TextColumn(string name, string headerText, DataGridViewAutoSizeColumnMode autoSizeMode = DataGridViewAutoSizeColumnMode.AllCells)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = headerText,
                AutoSizeMode = autoSizeMode,
                ReadOnly = true,
                Resizable = DataGridViewTriState.True
            };
        }

        public static DataGridViewCheckBoxColumn CheckboxColumn(string name, string headerText)
        {
            return new DataGridViewCheckBoxColumn
            {
                ReadOnly = true,
                Name = name,
                HeaderText = headerText,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                SortMode = DataGridViewColumnSortMode.Automatic,
                Resizable = DataGridViewTriState.False
            };
        }
    }
}
