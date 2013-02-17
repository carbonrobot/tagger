Tagger
===============================================================

A fluid html tag library built with C#

### Basic usages

	var div = new Div()
				.Class("input-wrap")
				.Add(new Label()
						.For("email")
						.Text("Email Address:")
				)
				.Add(new Input()
						.Id("email")
						.Name("email")
						.Class("required")
						.AddClass("email")
				);

#### Call `div.GetHtml()` or `div.ToString()` to get the html output

	<div class="input-wrap">
		<label for="email">Email Address:</label>
		<input type="textbox" id="email" name="email"></input>
	</div>

#### Adding multiple tags using parameters

	var div = new Div()
				.Add(
					new Span().Text("Option 1"),
					new Span().Text("Option 2"),
					new Span().Text("Option 3")
				);
	<div>
		<span>Option 1</span>
		<span>Option 2</span>
		<span>Option 3</span>
	</div>

#### Surrounding tags

	var button = new Button().SurroundWith(new Form());
					
#### Void tags

	var tag = new HtmlTag("hr").SelfClose();

	<hr />

### Form elements

Some form elements have special usage

#### Select lists

	var tag = new Select()
				.Add(
					new Option().Text("Option 1").Value("1"),
					new Option().Text("Option 2").Value("2"),
					new Option().Text("Option 3").Value("3")
				);
	<select>
		<option value="1">Option 1</option>
		<option value="2">Option 2</option>
		<option value="3">Option 3</option>
	</select>

#### Select lists using `KeyValuePair<string, string>`

	var options = new Dictionary<string, string>();
	options.Add("1", "Option 1");
	options.Add("2", "Option 2");
	options.Add("3", "Option 3");

	var tag = new Select().Add(options);

	<select>
		<option value="1">Option 1</option>
		<option value="2">Option 2</option>
		<option value="3">Option 3</option>
	</select>

### Tables

Coming Soon!
