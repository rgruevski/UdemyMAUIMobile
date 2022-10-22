namespace UdemyMAUIMobile;

public partial class LayoutContent : ContentPage
{
    public const double FontSize = 22;
    public const string HorizontalOptions = "Center";
    public LayoutContent()
    {
        InitializeComponent();
        VStackLayout.Padding =
            DeviceInfo.Platform ==
                DevicePlatform.iOS ?
                    new Thickness(30, 10, 30, 10) :
                    new Thickness(25);
    }
}
public class GlobalFontSizeExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return LayoutContent.FontSize;
    }
}
public class GlobalHorizontalOptionsExtension : IMarkupExtension
{
    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return LayoutContent.HorizontalOptions;
    }
}
