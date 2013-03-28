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
            return this.Add(new TableRow(data.Select(x => new TableCell().Text(x)).ToArray()));
        }
        
    }
}
