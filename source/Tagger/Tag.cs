namespace Tagger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Html Tag Builder
    /// </summary>
    /// <typeparam name="T">The type of tag. Supports a fluid interface.</typeparam>
    public abstract class Tag<T> : ICreateHtml where T : Tag<T>, ICreateHtml
    {
        /// <summary>
        /// Constructs a new instance of an html tag
        /// </summary>
        /// <param name="name">The name of the html tag</param>
        protected Tag(string name)
        {
            _name = name;
            _attributes = new Dictionary<string, string>();
        }

        /// <summary>
        /// Add css classes to the tag
        /// </summary>
        /// <param name="name">the names of the css classes</param>
        public T AddClass(params string[] name)
        {
            for (var i = 0; i < name.Length; i++)
            {
                if (i == 0 && !_attributes.ContainsKey(Attributes.Class))
                    _attributes.Add(Attributes.Class, name[i]);
                else
                    _attributes[Attributes.Class] += " " + name[i];
            }
            return (T)this;
        }

        /// <summary>
        /// Include a new tag after this one
        /// </summary>
        /// <param name="tag">The tag that should be placed after this one</param>
        public T Append<T2>(Tag<T2> tag) where T2 : Tag<T2>
        {
            _append = tag.ToString();
            return (T)this;
        }

        /// <summary>
        /// Include a new tag before this tag
        /// </summary>
        /// <param name="tag">The tag that should be placed before this one</param>
        public T Prepend<T2>(Tag<T2> tag) where T2 : Tag<T2>
        {
            _prepend = tag.ToString();
            return (T)this;
        }

        /// <summary>
        /// Set the class attribute of this tag
        /// </summary>
        /// <param name="value">The value of the class attribute</param>
        public T Class(string value)
        {
            return Attribute("class", value);
        }

        /// <summary>
        /// Get the id attribute of this tag
        /// </summary>
        public string Id()
        {
            return this.Attribute("id");
        }

        /// <summary>
        /// Set the id attribute of this tag
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Id(string id)
        {
            return Attribute("id", id);
        }
        
        /// <summary>
        /// Creates a self closing tag with no matching end tag and no content
        /// </summary>
        protected T SelfClose()
        {
            _selfClosing = true;
            return (T)this;
        }

        /// <summary>
        /// Produce the string representation of this tag
        /// </summary>
        public override string ToString()
        {
            return this.GetHtml();
        }

        /// <summary>
        /// Add a new attribute and value to a tag
        /// </summary>
        /// <param name="name">The name of the attribute</param>
        /// <param name="value">The value of the attribute</param>
        public virtual T Attribute(string name, string value)
        {
            if (_attributes.ContainsKey(name))
                _attributes[name] = value;
            else
                _attributes.Add(name, value);

            return (T)this;
        }

        /// <summary>
        /// Gets the value of a specified attribute
        /// </summary>
        /// <param name="name">The name of the attribute</param>
        public string Attribute(string name)
        {
            return _attributes[name];
        }

        /// <summary>
        /// Sets the style attribute of this tag
        /// </summary>
        /// <param name="value">The value of the style</param>
        public T Style(string value)
        {
            return (T) Attribute(Attributes.Style, value);
        }

        /// <summary>
        /// Sets the title attribute of this tag
        /// </summary>
        /// <param name="value">The value of the title</param>
        public T Title(string value)
        {
            return (T)Attribute(Attributes.Title, value);
        }

        /// <summary>
        /// Surround this tag with another
        /// </summary>
        /// <param name="parent">The tag that will become the parent</param>
        public T SurroundWith(ContentTag parent)
        {
            _parent = parent.Add(this);
            return (T)this;
        }

        /// <summary>
        /// Get the html string
        /// </summary>
        public string GetHtml()
        {
            // calling this on a child will call the parents
            if (_parent != null)
                return _parent.GetHtml();

            var tag = new StringBuilder();

            // preamble
            tag.AppendFormat("<{0}", _name);

            // attributes
            _attributes.ToList().ForEach(kvp => tag.AppendFormat(" {0}=\"{1}\"", kvp.Key, kvp.Value));

            // closing
            if (_selfClosing)
                tag.Append("/>");
            else
                tag.AppendFormat(">{0}</{1}>", OnGetContent(), _name);

            // handle any tags before and after
            return _prepend + tag + _append;
        }

        /// <summary>
        /// Overrideable method to add content
        /// </summary>
        protected virtual string OnGetContent()
        {
            return string.Empty;
        }

        private Dictionary<string, string> _attributes;
        private string _append = string.Empty;
        private string _prepend = string.Empty;
        private bool _selfClosing;
        private ContentTag _parent;
        private string _name;

        /*
         * accesskey
         * contenteditable t/f
         * contentmenu
         * data-*
         * dir ltr,rtl,auto
         * draggable t/f
         * dropzone copy,move,link
         * hidden t/f
         * lang
         * spellcheck t/f
         * tabindex
         */

    }
}
