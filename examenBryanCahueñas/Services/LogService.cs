namespace examenBryanCahueñas.Services;

public static class LogService
{
    public static async Task EscribirLogAsync(string nombreContacto)
    {
        string fileName = "Logs_Cahueñas.txt"; // Usa tu apellido aquí
        string filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);

        string logLine = $"Se incluyó el registro [{nombreContacto}] el {DateTime.Now:dd/MM/yyyy HH:mm}";

        using StreamWriter writer = File.AppendText(filePath);
        await writer.WriteLineAsync(logLine);
    }

    public static async Task<List<string>> LeerLogsAsync()
    {
        string fileName = "Logs_Cahueñas.txt";
        string filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);

        if (!File.Exists(filePath))
            return new List<string>();

        return (await File.ReadAllLinesAsync(filePath)).ToList();
    }
}
