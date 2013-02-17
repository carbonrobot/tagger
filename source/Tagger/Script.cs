namespace Tagger
{
    public class Script : Tag<Script>
    {
        public Script()
            : base("script")
        {
        }

        public Script Async()
        {
            return this.Attribute(Attributes.Async, "true");
        }

        public Script Type(string type)
        {
            return (Script) this.Attribute(Attributes.Type, type);
        }

        public Script Source(string source, bool async = false)
        {
            if (async)
                this.Async();

            return (Script) this.Attribute(Attributes.Source, source);
        }
    }
}
