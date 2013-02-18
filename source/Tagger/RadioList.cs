namespace Tagger
{
    using System.Collections.Generic;
    using System.Linq;

    public class RadioList : Span
    {
        public RadioList()
        {
        }

        public RadioList AddOptions(string name, IEnumerable<KeyValuePair<string, string>> options, string selectedValue = "", string optionCssClass = "", string labelCssClass = "")
        {
            options.ToList().ForEach(kvp =>
            {
                var option = new Radio()
                    .Text(kvp.Value, labelCssClass)
                    .Name(name)
                    .Value(kvp.Key)
                    .Id(string.Format("{0}_{1}", name, kvp.Key))
                    .Class(optionCssClass);

                if (selectedValue == kvp.Key)
                    ((Radio)option).Checked();

                this.Add(option);
            });

            return this;
        }

    }
}
