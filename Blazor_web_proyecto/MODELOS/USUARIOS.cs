using System.ComponentModel.DataAnnotations;

namespace MODELOS;

public class USUARIOS
    {
    [Required(ErrorMessage = "Error de datos")]
    public string Codigo { get; set; }
    [Required(ErrorMessage = "Error de datos")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "Error de datos")]
    public string Rol { get; set; }
    public string Clave { get; set; }
    public bool EstaActivo { get; set; }






}

