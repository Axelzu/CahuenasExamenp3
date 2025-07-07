using examenBryanCahueñas.ViewModels;

namespace examenBryanCahueñas.Views;

public partial class CrearContactoPage : ContentPage
{
    public CrearContactoPage(CrearContactoViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
