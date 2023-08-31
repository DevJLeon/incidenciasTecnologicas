using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
public class Persona : BaseEntity
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public int IdGeneroFk { get; set; }
    public int IdCiudadFk { get; set; }
    public int IdTipoPersona { get; set; }
}
