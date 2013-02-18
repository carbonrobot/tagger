namespace Tagger
{
    /// <summary>
    /// Form element
    /// </summary>
    public abstract class FormElement<T> : TextTag<T> where T : FormElement<T>
    {
        /// <summary>
        /// Constructs a new form element
        /// </summary>
        /// <param name="name">The name of the element</param>
        protected FormElement(string name)
            : base(name)
        {

        }

        /// <summary>
        /// Set the name attribute of this tag
        /// </summary>
        /// <param name="value">The value of the name attribute</param>
        public T Name(string value)
        {
            return this.Attribute(Attributes.Name, value);
        }

        /// <summary>
        /// Adds the autofocus attribute to this tag
        /// </summary>
        public T Autofocus()
        {
            return this.Attribute(Attributes.Autofocus, "true");
        }

        /// <summary>
        /// Adds the disabled attribute to this tag
        /// </summary>
        public T Disabled()
        {
            return this.Attribute(Attributes.Disabled, "true");
        }
        
        /// <summary>
        /// Set the value attribute of this tag
        /// </summary>
        /// <param name="value">The value of this attribute</param>
        public T Value(string value)
        {
            if (value == null)
                return (T)this;

            return Attribute("value", value);
        }

    }
}
