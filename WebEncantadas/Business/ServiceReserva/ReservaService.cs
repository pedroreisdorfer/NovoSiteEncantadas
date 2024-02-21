using System.Collections.Generic;
using System.Threading.Tasks;
using WebEncantadas.Business.ServiceReserva.Abstracts;
using WebEncantadas.Data.ReservaIngresso.Abstractions;
using WebEncantadas.Helper;
using WebEncantadas.Models.Entities;

namespace WebEncantadas.Business.ServiceReserva
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;
        private readonly ISessao _sessao;
        //private readonly Contexto _context;
        //private readonly ISessao _sessao;
        //private readonly ConnectionManager _connection = new ConnectionManager();
        //private readonly IUsuarioService _usuarioService;

        public ReservaService(IReservaRepository reservaRepository, ISessao sessao)
        {
            _reservaRepository = reservaRepository;
            _sessao = sessao;
        }

        public async Task<Mesas> BuscarEconstruirMesas()
        {
            List<Reserva_ingressos> mesasDB = await _reservaRepository.BuscarMesas();

            Mesas mesas = new Mesas();

            for (int i = 0; i < mesasDB.Count; i++)
            {
                if (mesasDB[i].num_mesa == 1)
                {
                    mesas.Mesa1.Add(mesasDB[i]);
                }

                if (mesasDB[i].num_mesa == 2)
                {
                    mesas.Mesa2.Add(mesasDB[i]);
                }

                if (mesasDB[i].num_mesa == 2)
                {
                    mesas.Mesa3.Add(mesasDB[i]);
                }

                if (mesasDB[i].num_mesa == 4)
                {
                    mesas.Mesa4.Add(mesasDB[i]);
                }
            }

            return mesas;
        }
    }
}
