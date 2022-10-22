using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharedkernel.IntegrationEvents;
using Xunit;

namespace Aerolinea.Vuelos.Test.Sharedkernel.IntegrationEvents {
    public class VueloEliminado_Test {

        [Fact]
        public void IsRequest_Valid() {

            Guid codVuelo = Guid.NewGuid();
            string fech = DateTime.Now.ToString();


            VueloEliminado vueloEliminado = new VueloEliminado();
            vueloEliminado.vueloId = codVuelo;
            vueloEliminado.fecha = fech;

            Assert.Equal(vueloEliminado.fecha, fech);
            Assert.Equal(vueloEliminado.vueloId, codVuelo);

        }
    }
}
