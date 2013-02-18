namespace Tagger
{
    using System;

    public class Radio : Input
    {
        public Radio()
            : base("radio")
        {
            
        }

        public Radio Checked()
        {
            return (Radio)this.Attribute(Attributes.Checked, "checked");
        }

        public new Radio Text(string text)
        {
            return Text(text, string.Empty);
        }

        public Radio Text(string text, string cssClass)
        {
            return (Radio)this.Append(new Label()
                                   .For(this.Id())
                                   .Text(text)
                                   .Class(cssClass)
                );
        }
    }
}
