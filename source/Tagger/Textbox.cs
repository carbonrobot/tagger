namespace Tagger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Textbox
    /// </summary>
    public class Textbox : Input
    {
        public Textbox()
            : base("text")
        {
        }

        public Textbox Placeholder(string text)
        {
            return (Textbox)Attribute("placeholder", text);
        }
    }

}
