using System.Data;

namespace DAL
{
    interface IListaPelaReserva
    {
        DataTable ListarPorReserva(int reserva);
    }
}
