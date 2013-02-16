namespace Tagger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Form element
    /// </summary>
    public abstract class FormElement : TextTag
    {
        /// <summary>
        /// Constructs a new form element
        /// </summary>
        /// <param name="name">The name of the element</param>
        public FormElement(string name)
            : base(name)
        {

        }

        /// <summary>
        /// Set the name attribute of this tag
        /// </summary>
        /// <param name="value">The value of the name attribute</param>
        public FormElement Name(string value)
        {
            return (FormElement) this.Attribute(Attributes.Name, value);
        }

        /// <summary>
        /// Adds the autofocus attribute to this tag
        /// </summary>
        public FormElement Autofocus()
        {
            return (FormElement)this.Attribute(Attributes.Autofocus, "true");
        }

        /// <summary>
        /// Adds the disabled attribute to this tag
        /// </summary>
        public FormElement Disabled()
        {
            return (FormElement)this.Attribute(Attributes.Disabled, "true");
        }

        /// <summary>
        /// Adds the required attribute to this tag
        /// </summary>
        public Select Required()
        {
            return (Select)this.Attribute(Attributes.Required, "true");
        }

        /// <summary>
        /// Set the value attribute of this tag
        /// </summary>
        /// <param name="value">The value of this attribute</param>
        public FormElement Value(string value)
        {
            if (value == null)
                return (FormElement)this;

            return (FormElement)Attribute("value", value);
        }

    }
}
