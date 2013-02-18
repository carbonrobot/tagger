namespace Tagger
{
    /// <summary>
    /// Option tag
    /// </summary>
    public class Option : TextTag<Option>
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
            return this.Attribute(Attributes.Disabled, "true");
        }

        /// <summary>
        /// Adds the required attribute to this tag
        /// </summary>
        public Option Selected()
        {
            return this.Attribute(Attributes.Selected, "true");
        }

        /// <summary>
        /// Set the value attribute of this tag
        /// </summary>
        /// <param name="value">The value of this attribute</param>
        public Option Value(string value)
        {
            if (value == null)
                return this;

            return Attribute("value", value);
        }
    }
}
