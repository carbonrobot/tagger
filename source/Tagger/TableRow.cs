namespace Tagger
{
    public class TableRow : ContentTag<TableRow>
    {
        public TableRow() : base("tr") { }

        public TableRow(params TableCell[] cells) : this()
        {
            this.Add(cells);
        }
        public TableRow(params TableHeaderCell[] cells)
            : this()
        {
            this.Add(cells);
        }
    }
}
