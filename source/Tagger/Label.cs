﻿namespace Tagger
{
    /// <summary>
    /// Label
    /// </summary>
    public class Label : TextTag<Label>
    {
        /// <summary>
        /// Construct an html label
        /// </summary>
        public Label()
            : base("label")
        {
            
        }

        /// <summary>
        /// Set the value of the for attribute
        /// </summary>
        /// <param name="id">The id of the form element</param>
        public Label For(string id)
        {
            return this.Attribute(Attributes.For, id);
        }
    }
}
