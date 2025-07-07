using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using examenBryanCahueñas.Services;

namespace examenBryanCahueñas.ViewModels;

public partial class LogsViewModel : ObservableObject
{
    public ObservableCollection<string> Logs { get; set; } = new();

    public LogsViewModel()
    {
        CargarLogs();
    }

    public async void CargarLogs()
    {
        Logs.Clear();
        var logs = await LogService.LeerLogsAsync();
        foreach (var log in logs)
            Logs.Add(log);
    }
}
