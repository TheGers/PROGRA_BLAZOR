using System.ComponentModel.DataAnnotations;

namespace MODELOS
{
    public class Producto
    {
        [Required(ErrorMessage = "Error de datos")]
        public string Codigo{get; set; }
        [Required(ErrorMessage = "Error de datos")]
        public string Descripcion{get; set; }

public decimal Precio { get; set; }

public int Existencia { get; set; }

public byte[] Imagen {get; set; }




    }
}
