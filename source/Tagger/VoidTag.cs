namespace Tagger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// A tag that does not support content
    /// </summary>
    public abstract class VoidTag : Tag<VoidTag>
    {
        protected VoidTag(string name)
            : base(name)
        {
            this.SelfClose();
        }

    }
}
