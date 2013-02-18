namespace Tagger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Tag that supports content
    /// </summary>
    public abstract class ContentTag<T> : Tag<T> where T: ContentTag<T>
    {
        /// <summary>
        /// Constructs a new tag that supports children
        /// </summary>
        /// <param name="name"></param>
        protected ContentTag(string name)
            : base(name)
        {
            _children = new List<ICreateHtml>();
        }

        /// <summary>
        /// Add a tag as a child
        /// </summary>
        /// <typeparam name="TTag">Type of child tag</typeparam>
        /// <param name="tag">The tag to add</param>
        public T Add<TTag>(params Tag<TTag>[] tag) where TTag : Tag<TTag>
        {
            for (var i = 0; i < tag.Length; i++)
                _children.Add(tag[i]);

            return (T)this;
        }

        // render child tags to the output
        protected override string OnGetContent()
        {
            return string.Join("", _children.Select(x => x.GetHtml()).ToArray());
        }

        private List<ICreateHtml> _children;
    }
}
