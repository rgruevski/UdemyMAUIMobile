namespace UdemyMAUIMobile;

public class TestProgram : ContentPage
{
    int count = 0;
    Label labelCounter;
    public TestProgram()
    {
        var scrollView = new ScrollView();

        var stackLayout = new StackLayout();
        scrollView.Content = stackLayout;

        labelCounter = new Label
        {
            Text = "Count 0",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center
        };
        stackLayout.Children.Add(labelCounter);

        var buttonCounter = new Button                                              
        {
            Text = "Click to Count",
            HorizontalOptions = LayoutOptions.Center 
        };
        stackLayout.Children.Add(buttonCounter);
        buttonCounter.Clicked += OnClickedEvent;

        this.Content = scrollView;

    }
    private void OnClickedEvent(object sender, EventArgs e)
    {
        count++;
        labelCounter.Text = $"You clicked count: {count} times!";
        SemanticScreenReader.Announce(labelCounter.Text);
    }
}