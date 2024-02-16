namespace AbstractScanner.TestApp;

public sealed partial class MainPage : Page
{
    const string StartText = "SCAN";
    const string StopText = "STOP SCANNER";


    public MainPage()
    {
        this.InitializeComponent();

        AbstractScanner.Scanner.DataReceived += OnScannerDataReceived;
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
    }

    private void OnScannerDataReceived(object? sender, string e)
    {
        //_dataTextBlock.Text = "Data Received: [" + e + "] at " + DateTime.Now;
    }

    async void OnButtonClick(object sender, RoutedEventArgs e)
    {
        var data = await AbstractScanner.Scanner.Scan();
        _dataTextBlock.Text = $"[{data}]";
    }




}
