namespace Tagger
{
    public class Image : Tag<Image>
    {
        public Image() : base("img")
        {
        }

        public Image Src(string value)
        {
            return this.Attribute(Attributes.Source, value);
        }
    }
}
