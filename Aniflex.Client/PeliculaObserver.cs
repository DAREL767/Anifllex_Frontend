using System;

namespace Aniflex.Client
{
    public static class PeliculaObserver
    {
        // Evento al que se suscribirá el formulario de listar
        public static event Action OnPeliculasCambiadas;

        // Método para notificar el cambio
        public static void NotificarCambio()
        {
            OnPeliculasCambiadas?.Invoke();
        }
    }
}
