using SQLite;

namespace examenBryanCahueñas.Models;

public class Contacto
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Correo { get; set; }

    public string Telefono { get; set; }

    public bool Favorito { get; set; }
}

