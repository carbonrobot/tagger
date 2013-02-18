namespace Tagger
{
    public class Form : TextTag<Form>
    {
        public Form()
            : base("form")
        {
        }

        public Form Action(string action)
        {
            return this.Attribute(Attributes.Action, action);
        }

        public Form Method(string method)
        {
            return this.Attribute(Attributes.Method, method);
        }
    }
}
