namespace Tagger
{
    public class Anchor : Tag<Anchor>
    {
        public Anchor()
            : base("a")
        {

        }

        public Anchor Href(string value)
        {
            return this.Attribute(Attributes.Href, value);
        }

        public Anchor Target(string target)
        {
            return this.Attribute(Attributes.Target, target);
        }
    }
}
