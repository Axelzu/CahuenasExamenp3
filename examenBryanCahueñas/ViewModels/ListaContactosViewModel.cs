using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using examenBryanCahueñas.Models;
using examenBryanCahueñas.Services;

namespace examenBryanCahueñas.ViewModels;

public partial class ListaContactosViewModel : ObservableObject
{
    public ObservableCollection<Contacto> Contactos { get; set; } = new();

    private readonly ContactoDatabase _database;

    public ListaContactosViewModel(ContactoDatabase database)
    {
        _database = database;
        CargarContactos();
    }

    public async void CargarContactos()
    {
        Contactos.Clear();
        var lista = await _database.GetContactosAsync();
        foreach (var c in lista)
            Contactos.Add(c);
    }
}
