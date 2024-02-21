using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEncantadas.Data.ReservaIngresso.Abstractions;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Data.ReservaIngresso
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly Contexto _context;

        public ReservaRepository(Contexto context)
        {
            _context = context;
        }

        //public async Task<Reserva_ingressos> BuscarMesas()
        //{
        //    List<Reserva_ingressos> cadeiras = _context.reserva_ingressos.ToList();

        //    Reserva_ingressos reservaIngresso = new Reserva_ingressos();
        //    foreach (Reserva_ingressos reserva in cadeiras)
        //    {
        //       reservaIngresso = reserva;
        //    }

        //    return reservaIngresso;
        //}

        public async Task<List<Reserva_ingressos>> BuscarMesas()
        {
            List<Reserva_ingressos> mesas =  _context.reserva_ingressos.ToList();

            return mesas;
        }
    }
}
