namespace Tagger.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TagTests
    {
        [TestMethod]
        public void CanCreateBasicHtmlTag()
        {
            var html = new HtmlTag("html");
            Assert.IsNotNull(html.GetHtml());
        }
    }
}
