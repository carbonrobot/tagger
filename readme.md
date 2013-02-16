Tagger

A fluid html tag library built with C#

### Basic usages

	var div = new Div()
				.Class("input-wrap")
				.Add(new Label()
						.For("email_input")
						.Text("Email Address:")
				)
				.Add(new Input()
						.Id("email_input")
						.Name("email")
						.Class("required")
						.AddClass("email")
				);

#### Produces the following output when calling `div.ToString();`

	<div class="input-wrap">
		<label for="email_input">Email Address:</label>
		<input type="textbox" id="email_input" name="email"></input>
	</div>