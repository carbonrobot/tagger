namespace Tagger
{
    /// <summary>
    /// Option group
    /// </summary>
    public class Optgroup : ContentTag<Optgroup>
    {
        /// <summary>
        /// Constructs a new option group
        /// </summary>
        public Optgroup()
            : base("optgroup")
        {

        }
        
        /// <summary>
        /// Adds the disabled attribute to this tag
        /// </summary>
        public Optgroup Disabled()
        {
            return this.Attribute(Attributes.Disabled, "true");
        }

        /// <summary>
        /// Adds a label to this group
        /// </summary>
        /// <param name="value">The name of this group</param>
        public Optgroup Label(string value)
        {
            return this.Attribute(Attributes.Label, value);
        }

    }
}
