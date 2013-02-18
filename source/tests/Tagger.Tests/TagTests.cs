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
            var tag = new HtmlTag("div");
            Assert.AreEqual("<div></div>", tag.ToString());
        }

        [TestMethod]
        public void CanCreateSelfClosingTag()
        {
            var tag = new HtmlTag("div").SelfClose();
            Assert.AreEqual("<div />", tag.ToString());
        }

        [TestMethod]
        public void CanCreateSelectLists()
        {
            var tag = new Select()
                .Add(new Optgroup()
                         .Label("Group 1")
                         .Add(
                             new Option().Text("Option 1"),
                             new Option().Text("Option 2")
                         )
                );

            Assert.AreEqual("<select><optgroup label=\"Group 1\"><option>Option 1</option><option>Option 2</option></optgroup></select>", tag.ToString());
        }

        [TestMethod]
        public void TestInheritanceChain()
        {
            // test that base classes have a correct return type to their children

            var tag = new Form()
                .Action("/post")                    // method from Form
                .Add(new Hidden().Name("test"))     // method from ContentTag<T>
                .Method("post");                    // method from Form

            Assert.IsNotNull(tag);
        }

    }
}
