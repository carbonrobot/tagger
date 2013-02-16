namespace Tagger
{

    /// <summary>
    /// Basic Html Tag
    /// </summary>
    public class HtmlTag : Tag<HtmlTag>
    {
        /// <summary>
        /// Constructs a new instance of an <see cref="HtmlTag"/>
        /// </summary>
        /// <param name="name">The name of the html tag</param>
        public HtmlTag(string name)
            : base(name)
        {

        }
    }
}
