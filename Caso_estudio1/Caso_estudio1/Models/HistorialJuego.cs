using System;

public class HistorialJuego
{
    public int Id { get; set; } // Identificador único del historial de la partida

    public int UserId { get; set; } // Referencia al usuario que jugó

    public int Score { get; set; } // Puntuación del jugador

    public TimeSpan Duration { get; set; } // Duración de la partida

    public DateTime DatePlayed { get; set; } // Fecha y hora de la partida

    // Navegación a la entidad User
    public virtual User User { get; set; }
}
