namespace WpfApp;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonMinutesToRead(object sender, RoutedEventArgs e)
    {
        tbResult.Text = StringUtils.StringUtils.MinutesToRead(textInput.Text, 200).ToString();
    }

    private void ButtonReadability(object sender, RoutedEventArgs e)
    {
        tbResult.Text = StringUtils.StringUtils.Readability(textInput.Text).ToString();
    }

    private void ButtonWords(object sender, RoutedEventArgs e)
    {
        tbResult.Text = StringUtils.StringUtils.Words(textInput.Text).ToString();
    }

    private void ButtonLetters(object sender, RoutedEventArgs e)
    {
        tbResult.Text = StringUtils.StringUtils.Letters(textInput.Text).ToString();
    }

    private void ButtonSentences(object sender, RoutedEventArgs e)
    {
        tbResult.Text = StringUtils.StringUtils.Sentences(textInput.Text).ToString();
    }
}