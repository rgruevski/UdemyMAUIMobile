namespace UdemyMAUIMobile;

public partial class LayoutContent : ContentPage
{
    public const double FontSize = 22;
    public const string HorizontalOptions = "Center";
    public LayoutContent()
    {
        InitializeComponent();
    }
}
public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return LayoutContent.FontSize;
    }
}