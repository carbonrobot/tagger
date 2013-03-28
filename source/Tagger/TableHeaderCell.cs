namespace Tagger
{
    public class TableHeaderCell : TextTag<TableHeaderCell>
    {
        public TableHeaderCell() : base("th") { }
        public TableHeaderCell(string text) : this()
        {
            this.Text(text);
        }
    }
}
