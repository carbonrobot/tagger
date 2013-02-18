namespace Tagger
{
    public class Input : FormElement<Input>
    {
        
        public Input(string type)
            : base("input")
        {
            this.Attribute(Attributes.Type, type);
        }

    }
}
