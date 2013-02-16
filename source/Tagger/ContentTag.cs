namespace Tagger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Tag that supports content
    /// </summary>
    public abstract class ContentTag : Tag<ContentTag>
    {
        /// <summary>
        /// Constructs a new tag that supports children
        /// </summary>
        /// <param name="name"></param>
        public ContentTag(string name)
            : base(name)
        {
            _children = new List<ICreateHtml>();
        }

        /// <summary>
        /// Add a tag as a child
        /// </summary>
        /// <typeparam name="T">Type of child tag</typeparam>
        /// <param name="tag">The tag to add</param>
        public ContentTag Add<T>(params Tag<T>[] tag) where T : Tag<T>
        {
            for (var i = 0; i < tag.Length; i++)
                _children.Add(tag[i]);

            return (ContentTag)this;
        }

        // render child tags to the output
        protected override string OnGetContent()
        {
            return string.Join("", _children.Select(x => x.GetHtml()).ToArray());
        }

        private List<ICreateHtml> _children;
    }
}
