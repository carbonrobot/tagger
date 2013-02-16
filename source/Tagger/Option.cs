namespace Tagger
{
    /// <summary>
    /// Option tag
    /// </summary>
    public class Option : TextTag
    {
        /// <summary>
        /// Constructs a new option
        /// </summary>
        public Option()
            : base("option")
        {

        }

        /// <summary>
        /// Adds the disabled attribute to this tag
        /// </summary>
        public Option Disabled()
        {
            return (Option)this.Attribute(Attributes.Disabled, "true");
        }

        /// <summary>
        /// Adds a label to this tag
        /// </summary>
        /// <param name="value">The name of this label</param>
        public Optgroup Label(string value)
        {
            return (Optgroup)this.Attribute(Attributes.Label, value);
        }

        /// <summary>
        /// Adds the required attribute to this tag
        /// </summary>
        public Option Selected()
        {
            return (Option)this.Attribute(Attributes.Selected, "true");
        }

        /// <summary>
        /// Set the value attribute of this tag
        /// </summary>
        /// <param name="value">The value of this attribute</param>
        public Option Value(string value)
        {
            if (value == null)
                return (Option)this;

            return (Option)Attribute("value", value);
        }
    }
}
