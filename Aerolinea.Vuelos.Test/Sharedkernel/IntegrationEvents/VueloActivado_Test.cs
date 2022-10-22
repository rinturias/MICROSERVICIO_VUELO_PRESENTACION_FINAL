using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharedkernel.IntegrationEvents;
using Xunit;

namespace Aerolinea.Vuelos.Test.Sharedkernel.IntegrationEvents {
    public class VueloActivado_Test {


        [Fact]
        public void IsRequest_Valid() {
            Guid vueloId = Guid.NewGuid();
            var fec = DateTime.Now.ToString();
            var evento = new VueloActivado();
            evento.fecha = fec;
            evento.vueloId = vueloId;

            Assert.Equal(evento.fecha, fec);
            Assert.Equal(evento.vueloId, vueloId);

        }
    }
}
