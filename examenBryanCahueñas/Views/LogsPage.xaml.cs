using examenBryanCahueñas.ViewModels;

namespace examenBryanCahueñas.Views;

public partial class LogsPage : ContentPage
{
    public LogsPage(LogsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
