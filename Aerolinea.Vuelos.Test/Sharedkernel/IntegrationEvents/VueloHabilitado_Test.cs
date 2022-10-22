using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharedkernel.IntegrationEvents;
using Xunit;

namespace Aerolinea.Vuelos.Test.Sharedkernel.IntegrationEvents {
    public class VueloHabilitado_Test {

        [Fact]
        public void IsRequest_Valid() {
            DateTime v_horaSalida = DateTime.Now;
            DateTime v_horallegada = DateTime.Now;
            string v_estado = "A";
            int precio = 50;
            Guid codRuta = Guid.NewGuid();
            Guid idVuelo = Guid.NewGuid();
            Guid codAeronave = Guid.NewGuid();
            DateTime fecha = DateTime.Now;
            int activo = 0;
            int stockAsientos = 100;
            VueloHabilitado OBJ = new VueloHabilitado();
            OBJ.activo = activo;
            OBJ.horaSalida = v_horaSalida;
            OBJ.estado = v_estado;
            OBJ.codRuta = codRuta;
            OBJ.horaLLegada = v_horallegada;
            OBJ.stockAsientos = stockAsientos;
            OBJ.precio = precio;
            OBJ.vueloId = idVuelo;
            OBJ.fecha = fecha;
            OBJ.precio = precio;
            Assert.Equal(OBJ.fecha, fecha);
            Assert.Equal(OBJ.vueloId, idVuelo);

        }

    }
}
