namespace Tagger
{
    using System.Linq;

    public class Table : ContentTag<Table>
    {
        public Table() : base("table") { }

        /// <summary>
        /// Create a simple row of text
        /// </summary>
        /// <param name="data">The text to place in the cells</param>
        public Table AddRow(params string[] data)
        {
            return this.AddRow(data.Select(x => new TableCell().Text(x)).ToArray());
        }

        /// <summary>
        /// Add a row with the specified cells
        /// </summary>
        /// <param name="cells">The cells to add to the row</param>
        public Table AddRow(params TableCell[] cells)
        {
            return this.Add(new TableRow(cells));
        }
    }
}
