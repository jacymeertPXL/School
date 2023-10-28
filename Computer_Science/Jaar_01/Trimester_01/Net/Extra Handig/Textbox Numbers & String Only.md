## XAML

```xml
<TextBox Name="NumberTextBox" PreviewTextInput="NumberValidationTextBox"/>
```

## XAML.CS FILE

```csharp
using System.Text.RegularExpressions;
private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
{
    Regex regex = new Regex("[^0-9]+"); // Numbers Only
    e.Handled = regex.IsMatch(e.Text);
}
```

```csharp
using System.Text.RegularExpressions;
private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
{
    Regex regex = new Regex("[^a-zA-Z]"); // String only
    e.Handled = regex.IsMatch(e.Text);
}
```