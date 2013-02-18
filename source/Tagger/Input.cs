namespace Tagger
{
    public class Input : FormElement
    {
        
        public Input(string type)
            : base("input")
        {
            this.Attribute(Attributes.Type, type);
        }

    }
}
