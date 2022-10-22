namespace UdemyMAUIMobile;

public partial class TestContent : ContentPage
{
	int count = 0;
	public TestContent()
	{
		InitializeComponent();
	}

	private void buttonCounter_Clicked(object sender, EventArgs e)
	{
        count++;
        labelCounter.Text = $"You clicked count: {count} times!";
        SemanticScreenReader.Announce(labelCounter.Text);
    }
}