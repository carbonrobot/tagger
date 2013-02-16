namespace Tagger
{

    /// <summary>
    /// List
    /// </summary>
    public class List : ContentTag
    {
        /// <summary>
        /// Constructs a new unordered list
        /// </summary>
        /// <param name="listType">One of the values of ListType</param>
        public List(string listType) 
            : base(listType)
        {
        }

    }
}
