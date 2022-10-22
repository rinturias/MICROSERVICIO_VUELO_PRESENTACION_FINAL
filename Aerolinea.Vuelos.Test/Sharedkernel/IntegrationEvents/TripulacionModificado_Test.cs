using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharedkernel.Entidades;
using Sharedkernel.IntegrationEvents;
using Xunit;

namespace Aerolinea.Vuelos.Test.Sharedkernel.IntegrationEvents {
    public class TripulacionModificado_Test {

        [Fact]
        public void IsRequest_Valid() {


            Guid vueloId = Guid.NewGuid();
            string codGrupo = Guid.NewGuid().ToString();
            var evento = new TripulacionModificado();

            evento.vueloId = vueloId;
            evento.IdGrupo = codGrupo;
            evento.tripulacionVuelos = new Collection<Tripulacion>();
            Assert.NotNull(evento);
            Assert.NotNull(evento.tripulacionVuelos);
            Assert.Equal(codGrupo, evento.IdGrupo);
            Assert.Equal(vueloId, evento.vueloId);

        }
    }
}
