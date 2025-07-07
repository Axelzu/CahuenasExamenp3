using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using examenBryanCahueñas.Models;
using examenBryanCahueñas.Services;

namespace examenBryanCahueñas.ViewModels;

public partial class CrearContactoViewModel : ObservableObject
{
    [ObservableProperty] string nombre;
    [ObservableProperty] string correo;
    [ObservableProperty] string telefono;
    [ObservableProperty] bool favorito;

    private readonly ContactoDatabase _database;

    public CrearContactoViewModel(ContactoDatabase database)
    {
        _database = database;
    }

    [RelayCommand]
    public async Task GuardarAsync()
    {
        if (!Telefono.StartsWith("+593"))
        {
            await Application.Current.MainPage.DisplayAlert("Error", "El teléfono debe iniciar con +593", "OK");
            return;
        }

        var contacto = new Contacto
        {
            Nombre = Nombre,
            Correo = Correo,
            Telefono = Telefono,
            Favorito = Favorito
        };

        await _database.AddContactoAsync(contacto);
        await LogService.EscribirLogAsync(Nombre);

        await Application.Current.MainPage.DisplayAlert("Guardado", "Contacto guardado exitosamente", "OK");

        Nombre = Correo = Telefono = string.Empty;
        Favorito = false;
    }
}
