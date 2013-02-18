namespace Tagger
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Select Element
    /// </summary>
    public class Select : FormElement
    {
        /// <summary>
        /// Constructs a new select element
        /// </summary>
        public Select()
            : base("select")
        {
        }

        public Select AddOptions(IEnumerable<KeyValuePair<string, string>> options, string selectedValue = "")
        {
            options.ToList().ForEach(kvp =>
            {
                var option = new Option()
                    .Value(kvp.Key)
                    .Text(kvp.Value);
                if (selectedValue == kvp.Key)
                    ((Option)option).Selected();

                this.Add(option);
            });
            return this;
        }

    }
}
