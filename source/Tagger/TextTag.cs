namespace Tagger
{
    /// <summary>
    /// Tag that support text
    /// </summary>
    public class TextTag : ContentTag
    {
        /// <summary>
        /// Constructs a tag that supports text
        /// </summary>
        /// <param name="name"></param>
        public TextTag(string name)
            : base(name)
        {

        }

        /// <summary>
        /// Set the text content of the tag
        /// </summary>
        /// <param name="text">The text</param>
        public TextTag Text(string text)
        {
            _text = text;
            return this;
        }
        
        // render text into output
        protected override string OnGetContent()
        {
            return _text + base.OnGetContent();
        }

        private string _text;
    }
}
