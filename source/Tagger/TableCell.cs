namespace Tagger
{
    public class TableCell : TextTag<TableCell>
    {
        public TableCell() : base("td") { }
        public TableCell(string text) : this()
        {
            this.Text(text);
        }
    }
}
