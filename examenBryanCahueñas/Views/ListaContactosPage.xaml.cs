using examenBryanCahueñas.ViewModels;

namespace examenBryanCahueñas.Views;

public partial class ListaContactosPage : ContentPage
{
    public ListaContactosPage(ListaContactosViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
