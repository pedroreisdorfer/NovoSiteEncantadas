using System.Collections.Generic;
using System.Threading.Tasks;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Data.ReservaIngresso.Abstractions
{
    public interface IReservaRepository
    {
        Task<List<Reserva_ingressos>> BuscarMesas();
    }
}
