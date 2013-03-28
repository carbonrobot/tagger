namespace Tagger.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The following tests are not all that thorough. 
    /// I am only using this as a sort fo smoke test for the fluid API at this point. 
    /// </summary>
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
        public void CanCreateSimpleDataTablesWithStrings()
        {
            var table = new Table()
                .AddRow("Apples", "Oranges", "Bananas");

            var expected = @"<table><tr><td>Apples</td><td>Oranges</td><td>Bananas</td></tr></table>";
            Assert.AreEqual(expected, table.ToString());
        }

        [TestMethod]
        public void CanCreateSimpleTablesWithTd()
        {
            var table = new Table()
                .Add(new TableRow(new TableCell("Apples"), new TableCell("Oranges"), new TableCell("Bananas")));

            var expected = @"<table><tr><td>Apples</td><td>Oranges</td><td>Bananas</td></tr></table>";
            Assert.AreEqual(expected, table.ToString());
        }

        [TestMethod]
        public void CanCreateComplexTables()
        {
            var table = new Table()
                .Add(new TableHeader()
                         .Add(new TableRow(new TableHeaderCell("Id"), new TableHeaderCell("Name"))
                         )
                ).Add(new TableBody()
                          .Add(new TableRow(new TableCell("1234"), new TableCell("Apples"))
                          )
                ).Add(new TableFooter()
                          .Add(new TableRow(new TableCell("Id"), new TableCell("Name"))
                          )
                );

            var expected = @"<table><thead><tr><th>Id</th><th>Name</th></tr></thead><tbody><tr><td>1234</td><td>Apples</td></tr></tbody><tfoot><tr><td>Id</td><td>Name</td></tr></tfoot></table>";
            Assert.AreEqual(expected, table.ToString());
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
