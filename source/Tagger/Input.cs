namespace Tagger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    /// <summary>
    /// Input element
    /// </summary>
    public class Input : FormElement
    {
        /// <summary>
        /// Constructs a new input tag
        /// </summary>
        /// <param name="type">The type of input</param>
        public Input(string type)
            : base("input")
        {
            this.Attribute(Attributes.Type, type);
        }

    }
}
