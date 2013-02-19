namespace Tagger
{
    public class TableRow : ContentTag<TableRow>
    {
        public TableRow() : base("tr") { }

        public TableRow(params TableCell[] cells) : this()
        {
            this.AddCells(cells);
        }

        public TableRow AddCells(params TableCell[] cells)
        {
            for (var i = 0;i < cells.Length;i++)
                this.Add(cells[i]);

            return this;
        }
    }
}
