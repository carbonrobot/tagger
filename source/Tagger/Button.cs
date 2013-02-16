namespace Tagger
{
    /// <summary>
    /// Button
    /// </summary>
    public class Button : FormElement
    {
        /// <summary>
        /// Constructs an html button
        /// </summary>
        /// <param name="type">The button type</param>
        public Button(string type)
            : base("button")
        {
            this.Attribute(Attributes.Type, type);
        }
    }
}
