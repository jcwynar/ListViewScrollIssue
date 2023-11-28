using ListViewScrollIssue.ViewModels;

namespace ListViewScrollIssue;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
