using examenBryanCahueñas.Services;
using examenBryanCahueñas.ViewModels;
using examenBryanCahueñas.Views;

namespace examenBryanCahueñas;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "contactos.db");

        builder.Services.AddSingleton(new ContactoDatabase(dbPath));

        builder.Services.AddSingleton<CrearContactoViewModel>();
        builder.Services.AddSingleton<ListaContactosViewModel>();
        builder.Services.AddSingleton<LogsViewModel>();

        builder.Services.AddSingleton<CrearContactoPage>();
        builder.Services.AddSingleton<ListaContactosPage>();
        builder.Services.AddSingleton<LogsPage>();

        return builder.Build();
    }
}
