using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public ContentTag Text(string text)
        {
            _text = text;
            return (ContentTag)this;
        }

        // render text into output
        protected override string OnGetContent()
        {
            return _text + base.OnGetContent();
        }

        private string _text;
    }
}
