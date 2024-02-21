using System.Collections.Generic;
using System.Threading.Tasks;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Business.ServiceReserva.Abstracts
{
    public interface IReservaService
    {
        Task<Mesas> BuscarEconstruirMesas();
    }
}
