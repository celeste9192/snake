using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; } // Identificador único del usuario

    [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre de usuario no puede exceder los 50 caracteres.")]
    public string Usuario { get; set; } // Nombre de usuario

    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [DataType(DataType.Password)]
    public string Password { get; set; } // Contraseña del usuario (asegúrate de usar hashing)

    public string ImagenPerfil { get; set; } // Ruta de la imagen de perfil o base64
}
