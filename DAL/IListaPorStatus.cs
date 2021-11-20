using System.Data;

namespace DAL
{
    interface IListaPorStatus
    {
        DataTable ListarStatus(string status);
    }
}
