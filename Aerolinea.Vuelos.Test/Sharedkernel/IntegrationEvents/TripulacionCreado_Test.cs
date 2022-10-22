using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Vuelos.Domain.Entities;
using Sharedkernel.Entidades;
using Sharedkernel.IntegrationEvents;
using Xunit;

namespace Aerolinea.Vuelos.Test.Sharedkernel.IntegrationEvents {
    public class TripulacionCreado_Test {

        [Fact]
        public void IsRequest_Valid() {


            Guid vueloId = Guid.NewGuid();
            string codGrupo = Guid.NewGuid().ToString();
            var objVueloTest = new TripulacionVuelo();
            ICollection<TripulacionVuelo> listTripulantes = new Collection<TripulacionVuelo>();
            listTripulantes.Add(objVueloTest);

            var evento = new TripulacionCreado();
            evento.vueloId = vueloId;
            evento.IdGrupo = codGrupo;
            evento.tripulacionVuelos = new Collection<Tripulacion>();

            evento.Equals(objVueloTest);
            Assert.NotNull(evento);
            Assert.NotNull(evento.tripulacionVuelos);
            Assert.Equal(codGrupo, evento.IdGrupo);
            Assert.Equal(vueloId, evento.vueloId);
        }
    }
}
