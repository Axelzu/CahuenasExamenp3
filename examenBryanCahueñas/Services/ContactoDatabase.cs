using SQLite;
using examenBryanCahueñas.Models;

namespace examenBryanCahueñas.Services;

public class ContactoDatabase
{
    private readonly SQLiteAsyncConnection _database;

    public ContactoDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Contacto>().Wait();
    }

    public Task<int> AddContactoAsync(Contacto contacto) => _database.InsertAsync(contacto);

    public Task<List<Contacto>> GetContactosAsync() => _database.Table<Contacto>().ToListAsync();
}
