namespace Tagger
{
    public abstract class TextTag<T> : ContentTag<T> where T : TextTag<T>
    {
        protected TextTag(string name)
            : base(name)
        {

        }

        public T Text(string text)
        {
            _text = text;
            return (T)this;
        }
        
        // render text into output
        protected override string OnGetContent()
        {
            return _text + base.OnGetContent();
        }

        private string _text;
    }
}
